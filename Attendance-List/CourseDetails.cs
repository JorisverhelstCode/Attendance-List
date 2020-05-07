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
        public CourseInfo Course { get; set; }
        private bool NewEntry;
        private ErrorProvider EmptyError;
        public CourseDetails(CourseInfo course)
        {
            InitializeComponent();
            NewEntry = false;
            Course = course;
            EmptyError = new ErrorProvider();
            SetInfoRight();
        }

        public CourseDetails()
        {
            InitializeComponent();
            Course = new CourseInfo();
            NewEntry = true;
            EmptyError = new ErrorProvider();
        }

        private void SetInfoRight()
        {
            TxtContactPerson.Text = Course.ContactPerson;
            TxtCourseCode.Text = Course.CourseCode + "";
            TxtOeNumber.Text = Course.OeNumber + "";
            txtInstitution.Text = Course.CourseInstitution;
            txtLocation.Text = Course.Location;
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

        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {

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
                EmptyError.SetError(TxtCourseCode, "You must give the participant a badge number!");
                Allgood = false;
            }
            if (DTPDayOfBirth.Value.Year > DateTime.Today.Year || DTPDayOfBirth.Value.Year < 1920)
            {
                EmptyError.SetError(DTPDayOfBirth, "Please select a valid date!");
                Allgood = false;
            }
            return Allgood;
        }
    }
}
