using AttendencieLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
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
            this.Text = Course.Course;
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
            DTPEndDate.Value = Course.EndDate;
            DTPStartDate.Value = Course.StartDate;
            RefreshParticipants();
            RefreshTeachers();
        }

        private void BtnAddParticipant_Click(object sender, EventArgs e)
        {
            var participantList = new SelectParticipant(Course);
            Children.Add(participantList);
            participantList.OnClosingEvent += ParticipantList_OnClosingEvent;
            participantList.OnAddedEvent += ParticipantList_OnAddedEvent;
            participantList.Show();
        }

        private void BtnRemoveParticipant_Click(object sender, EventArgs e)
        {
            if (LstParticipants.SelectedItem != null)
            {
                var tempParticipant = (Participant)LstParticipants.SelectedItem;
                var sure = MessageBox.Show($"Are you sure you want to remove {tempParticipant.Name} from {Course.Course}?", $"Removing {tempParticipant.Name}", MessageBoxButtons.YesNo);
                if (sure == DialogResult.Yes)
                {
                    using (AttendanceListDbEntities context = new AttendanceListDbEntities())
                    {
                        var tobeRemoved = (Participants_Courses)context.Participants_Courses.Where(x => x.CourseID == Course.ID && x.ParticipantID == tempParticipant.ID).FirstOrDefault();
                        context.Participants_Courses.Remove(tobeRemoved);
                        context.SaveChanges();
                    }
                    RefreshParticipants();
                }
            }
        }

        private void BtnAddTeacher_Click(object sender, EventArgs e)
        {
            var teacherList = new SelectTeacher(Course);
            Children.Add(teacherList);
            teacherList.OnClosingEvent += TeacherList_OnClosingEvent;
            teacherList.OnAddedEvent += TeacherList_OnAddedEvent;
            teacherList.Show();
        }

        private void BtnRemoveTeacher_Click(object sender, EventArgs e)
        {
            if (LstTeachers.SelectedItem != null)
            {
                var tempTeacher = (Teacher)LstTeachers.SelectedItem;
                var sure = MessageBox.Show($"Are you sure you want to remove {tempTeacher.Name} from {Course.Course}?", $"Removing {tempTeacher.Name}", MessageBoxButtons.YesNo);
                if (sure == DialogResult.Yes)
                {
                    using (AttendanceListDbEntities context = new AttendanceListDbEntities())
                    {
                        var tobeRemoved = (Teachers_Courses)context.Teachers_Courses.Where(x => x.CourseID == Course.ID && x.TeacherID == tempTeacher.ID).FirstOrDefault();
                        context.Teachers_Courses.Remove(tobeRemoved);
                        context.SaveChanges();
                    }
                    RefreshTeachers();
                }
            }
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
                Course.CourseCode = Convert.ToInt32(TxtCourseCode.Text);
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
                if (TxtName.Text != Course.Course || TxtContactPerson.Text != Course.ContactPerson || Convert.ToInt32(TxtCourseCode.Text) != Course.CourseCode
                || Convert.ToInt32(TxtOeNumber.Text) != Course.OeNumber || TxtInstitution.Text != Course.CourseInstitution || TxtLocation.Text != Course.Location)
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
            OnClosingEvent?.Invoke(this, new OnClosingEventArgs());
        }

        private void LstParticipants_DoubleClick(object sender, EventArgs e)
        {
            if (LstParticipants.SelectedItem != null)
            {
                var participant = new ParticipantDetails((Participant)LstParticipants.SelectedItem);
                Children.Add(participant);
                participant.Show();
            }
        }

        private void LstTeachers_DoubleClick(object sender, EventArgs e)
        {
            if (LstTeachers.SelectedItem != null)
            {
                var teacher = new TeacherDetails((Teacher)LstTeachers.SelectedItem);
                Children.Add(teacher);
                teacher.Show();
            }
        }

        private void ParticipantForm_OnClosingEvent(object sender, OnClosingEventArgs e)
        {
            var temp = (ParticipantDetails)sender;
            temp.OnClosingEvent -= ParticipantForm_OnClosingEvent;
            Children.Remove(temp);
            RefreshParticipants();
        }

        private void ParticipantList_OnClosingEvent(object sender, OnClosingEventArgs e)
        {
            var temp = (SelectParticipant)sender;
            temp.OnClosingEvent -= ParticipantList_OnClosingEvent;
            temp.OnAddedEvent -= ParticipantList_OnAddedEvent;
            Children.Remove(temp);
            RefreshParticipants();
        }

        private void ParticipantList_OnAddedEvent(object sender, OnAddedEventArgs e)
        {
            RefreshParticipants();
        }

        private void TeacherForm_OnClosingEvent(object sender, OnClosingEventArgs e)
        {
            var temp = (TeacherDetails)sender;
            temp.OnClosingEvent -= TeacherForm_OnClosingEvent;
            Children.Remove(temp);
            RefreshTeachers();
        }

        private void TeacherList_OnClosingEvent(object sender, OnClosingEventArgs e)
        {
            var temp = (SelectTeacher)sender;
            temp.OnClosingEvent -= TeacherList_OnClosingEvent;
            temp.OnAddedEvent -= TeacherList_OnAddedEvent;
            Children.Remove(temp);
            RefreshTeachers();
        }

        private void TeacherList_OnAddedEvent(object sender, OnAddedEventArgs e)
        {
            RefreshTeachers();
        }

        private void RefreshParticipants()
        {
            LstParticipants.Items.Clear();
            using (AttendanceListDbEntities context = new AttendanceListDbEntities())
            {
                foreach (var item in context.Participants_Courses.Where(x => x.CourseID == Course.ID))
                {
                    var participant = context.Participants.Where(x => x.ID == item.ParticipantID).FirstOrDefault();
                    LstParticipants.Items.Add(participant);
                }
            }
        }

        private void RefreshTeachers()
        {
            LstTeachers.Items.Clear();
            using (AttendanceListDbEntities context = new AttendanceListDbEntities())
            {
                foreach (var item in context.Teachers_Courses.Where(x => x.CourseID == Course.ID))
                {
                    var teacher = context.Teachers.Where(x => x.ID == item.TeacherID).FirstOrDefault();
                    LstTeachers.Items.Add(teacher);
                }
            }
        }
    }
}
