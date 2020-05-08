using AttendencieLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_List
{
    public partial class ParticipantDetails : Form
    {
        public Participant ThisParticipant { get; set; } = new Participant();
        private ErrorProvider EmptyError;
        private bool NewEntry = true;
        public event EventHandler<OnClosingEventArgs> OnClosingEvent;
        private List<Form> Children;

        public ParticipantDetails()
        {
            InitializeComponent();
            ThisParticipant.DateOfBirth = DTPDayOfBirth.Value;
            EmptyError = new ErrorProvider();
            Children = new List<Form>();
        }

        public ParticipantDetails(Participant part) : this()
        {
            ThisParticipant = part;
            this.Text = part.Name;
            NewEntry = false;
            TxtName.Text = ThisParticipant.Name;
            TxtBadge.Text = ThisParticipant.BadgeNumber + "";
            TxtAdress.Text = ThisParticipant.Adress;
            DTPDayOfBirth.Value = ThisParticipant.DateOfBirth != null ? (DateTime)ThisParticipant.DateOfBirth : new DateTime();
            RefreshCourses();
            RefreshTimeRegistrations();
        }

        private void LstBoxCourses_DoubleClick(object sender, EventArgs e)
        {
            if (LstBoxCourses.SelectedItem != null)
            {
                var course = new CourseDetails((CourseInfo)LstBoxCourses.SelectedItem);
                course.OnClosingEvent += CourseInfo_OnClosingEvent;
                Children.Add(course);
                course.Show();
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (CustomValidation())
            {
                RestoreEmptyError();
                ThisParticipant.Name = TxtName.Text;
                ThisParticipant.BadgeNumber = Convert.ToInt32(TxtBadge.Text);
                ThisParticipant.Adress = TxtAdress.Text;
                ThisParticipant.DateOfBirth = DTPDayOfBirth.Value;
                using (AttendanceListDbEntities context = new AttendanceListDbEntities())
                {
                    if (NewEntry)
                    {
                        context.Participants.Add(ThisParticipant);
                    }
                    else
                    {
                        context.Participants.Where(x => x.ID == ThisParticipant.ID).ToList()[0] = ThisParticipant;
                    }
                    context.SaveChanges();
                }
                this.Close();
            }
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ParticipantDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (TxtName.Text == "" && !NewEntry)
            {
                EmptyError.SetError(TxtName, "You can't just steal this man's name!");
                e.Cancel = true;
            } else 
            if (TxtName.Text != ThisParticipant.Name || TxtAdress.Text != ThisParticipant.Adress
                || Convert.ToInt32(TxtBadge.Text) != ThisParticipant.BadgeNumber)
            {
                string errorMessage;
                if (NewEntry)
                {
                    errorMessage = "Quiting new participant";
                }
                else
                {
                    errorMessage = $"Quiting Participant {ThisParticipant.Name}";
                }
                var SureYouWantToQuit = MessageBox.Show("Are you sure you want to quit without saving?",
                    errorMessage, MessageBoxButtons.YesNo);
                if (SureYouWantToQuit == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private bool CustomValidation()
        {
            bool Allgood = true;
            if (String.IsNullOrEmpty(TxtName.Text))
            {
                EmptyError.SetError(TxtName, "You must give the participant a name!");
                Allgood = false;
            }
            if (String.IsNullOrEmpty(TxtBadge.Text))
            {
                EmptyError.SetError(TxtBadge, "You must give the participant a badge number!");
                Allgood = false;
            }
            if (DTPDayOfBirth.Value.Year > DateTime.Today.Year || DTPDayOfBirth.Value.Year < 1920)
            {
                EmptyError.SetError(DTPDayOfBirth, "Please select a valid date!");
                Allgood = false;
            }
            return Allgood;
        }

        private void RestoreEmptyError()
        {
            EmptyError.SetError(TxtName, "");
            EmptyError.SetError(TxtBadge, "");
            EmptyError.SetError(DTPDayOfBirth, "");
        }

        private void ParticipantDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            OnClosingEvent?.Invoke(this, new OnClosingEventArgs());
        }

        private void CourseInfo_OnClosingEvent(object sender, OnClosingEventArgs e)
        {
            CourseDetails temp = (CourseDetails)sender;
            temp.OnClosingEvent -= CourseInfo_OnClosingEvent;
            Children.Remove(temp);
            RefreshCourses();
        }

        private void RefreshCourses()
        {
            LstBoxCourses.Items.Clear();
            using (AttendanceListDbEntities context = new AttendanceListDbEntities())
            {
                var Courses = context.Participants_Courses.Where(x => x.ParticipantID == ThisParticipant.ID);
                if (Courses.Count() != 0)
                {
                    foreach (var item in Courses)
                    {
                        LstBoxCourses.Items.Add(context.CourseInfoes.Where(x => x.ID == item.CourseID).FirstOrDefault());
                    }
                }
            }
        }

        private void RefreshTimeRegistrations()
        {
            if (LstBoxCourses.SelectedItem != null)
            {
                LstTimeRegistrations.Items.Clear();
                using (AttendanceListDbEntities context = new AttendanceListDbEntities())
                {
                    var TimeRegistartions = context.TimeRegistrations.Where(x => x.ParticipantID == ThisParticipant.ID);
                    if (TimeRegistartions.Count() != 0)
                    {
                        var temp = (CourseInfo)LstBoxCourses.SelectedItem;
                        foreach (var item in TimeRegistartions)
                        {
                            if (item.CourseID == temp.ID)
                                LstBoxCourses.Items.Add(item);
                        }
                    }
                }
            }
        }

        private void LstBoxCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTimeRegistrations();
        }

        private void LstTimeRegistrations_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}