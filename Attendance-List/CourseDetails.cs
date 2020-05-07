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
    public partial class CourseDetails : Form
    {
        public CourseInfo Course { get; set; } = new CourseInfo();
        private bool NewEntry = true;
        private ErrorProvider EmptyError;
        private List<Form> Children;
        public event EventHandler<OnClosingEventArgs> OnClosingEvent;
        

        public CourseDetails()
        {
            InitializeComponent();
            EmptyError = new ErrorProvider();
            Children = new List<Form>();
        }

        public CourseDetails(CourseInfo course) : this()
        {
            NewEntry = false;
            Course = course;
            SetInfoRight();
        }

        private void SetInfoRight()
        {
            TxtContactPerson.Text = Course.ContactPerson;
            TxtCourseCode.Text = Course.CourseCode + "";
            TxtOeNumber.Text = Course.OeNumber + "";
            TxtInstitution.Text = Course.CourseInstitution;
            TxtLocation.Text = Course.Location;
            TxtName.Text = Course.Course;
            using (AttendanceListDbEntities context = new AttendanceListDbEntities())
            {
                foreach (var item in context.Participants_Courses.Where(x => x.CourseID == Course.ID))
                {
                    var participant = context.Participants.Where(x => x.ID == item.ParticipantID);
                    LstParticipants.Items.Add(participant);
                }
                foreach (var item in context.Teachers_Courses.Where(x => x.CourseID == Course.ID))
                {
                    var teacher = context.Teachers.Where(x => x.ID == item.TeacherID);
                    LstParticipants.Items.Add(teacher);
                }
            }
        }

        private void BtnAddParticipant_Click(object sender, EventArgs e)
        {
            var Participant = new ParticipantDetails();
            Participant.Show();
        }

        private void BtnRemoveParticipant_Click(object sender, EventArgs e)
        {

        }

        private void BtnAddTeacher_Click(object sender, EventArgs e)
        {

        }

        private void BtnRemoveTeacher_Click(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (CustomValidation())
            {
                ValidatedSuccesFully();
                Course.Course = TxtName.Text;
                Course.ContactPerson = TxtContactPerson.Text;
                Course.CourseInstitution = TxtInstitution.Text;
                Course.OeNumber = Convert.ToInt32(TxtOeNumber.Text);
                Course.CourseCode = Convert.ToInt32(TxtCourseCode);
                Course.EndDate = DTPEndDate.Value;
                Course.StartDate = DTPStartDate.Value;
                Course.Location = TxtLocation.Text;
                using (AttendanceListDbEntities context = new AttendanceListDbEntities())
                {
                    if (NewEntry)
                    {
                        context.CourseInfoes.Add(Course);
                    }
                    else
                    {
                        context.CourseInfoes.Where(x => x.ID == Course.ID).ToList()[0] = Course;
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

        private bool CustomValidation()
        {
            bool Allgood = true;
            if (String.IsNullOrEmpty(TxtName.Text))
            {
                EmptyError.SetError(TxtName, "You must give the course a name!");
                Allgood = false;
            }
            if (String.IsNullOrEmpty(TxtCourseCode.Text))
            {
                EmptyError.SetError(TxtCourseCode, "You must give the course a code number!");
                Allgood = false;
            }
            if (DTPStartDate.Value.Year > DateTime.Today.Year + 10 || DTPStartDate.Value.Year < 2000)
            {
                EmptyError.SetError(DTPStartDate, "Please select a valid date!");
                Allgood = false;
            }
            if (DTPEndDate.Value.Year > DateTime.Today.Year + 10 || DTPEndDate.Value < DTPStartDate.Value)
            {
                EmptyError.SetError(DTPEndDate, "Please select a valid date!");
                Allgood = false;
            }
            try
            {
                int oe = Convert.ToInt32(TxtOeNumber.Text);
            }
            catch (Exception)
            {
                EmptyError.SetError(TxtOeNumber, "This must be a number!");
                Allgood = false;
            }
            try
            {
                int code = Convert.ToInt32(TxtCourseCode.Text);
            }
            catch (Exception)
            {
                EmptyError.SetError(TxtCourseCode, "This must be a number!");
                Allgood = false;
            }
            return Allgood;
        }

        private void ValidatedSuccesFully()
        {
            EmptyError.SetError(TxtName, "");
            EmptyError.SetError(TxtCourseCode, "");
            EmptyError.SetError(DTPStartDate, "");
            EmptyError.SetError(DTPEndDate, "");
            EmptyError.SetError(TxtOeNumber, "");
        }

        private void CourseDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Children.Count() != 0)
            {
                MessageBox.Show("You still have connected windows open, close them first!", "Unable to close the window", MessageBoxButtons.OK);
                e.Cancel = true;
            }
            else
            {
                if (TxtName.Text != Course.Course || TxtContactPerson.Text != Course.ContactPerson || Convert.ToInt32(TxtCourseCode) != Course.CourseCode
                || Convert.ToInt32(TxtOeNumber.Text) != Course.OeNumber || TxtInstitution.Text != Course.CourseInstitution || TxtLocation.Text != Course.Location
                || DTPStartDate.Value != Course.StartDate || DTPEndDate.Value != Course.EndDate)
                {
                    string errorMessage;
                    if (NewEntry)
                    {
                        errorMessage = "Quiting new course";
                    }
                    else
                    {
                        errorMessage = $"Quiting course {Course.Course}";
                    }
                    var SureYouWantToQuit = MessageBox.Show("Are you sure you want to quit without saving?",
                        errorMessage, MessageBoxButtons.YesNo);
                    if (SureYouWantToQuit == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                }
            }
        }

        private void CourseDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            RaiseClosingevent();
        }

        public void RaiseClosingevent()
        {
            OnClosingEvent?.Invoke(this, new OnClosingEventArgs());
        }
    }
}
