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
        public CourseDetails(CourseInfo course)
        {
            InitializeComponent();
            Course = course;
            SetInfoRight();
        }

        public CourseDetails()
        {
            InitializeComponent();
            Course = new CourseInfo();
        }

        private void SetInfoRight()
        {
            using (AttendanceListDbEntities context = new AttendanceListDbEntities())
            {
                /*var innerJoinQuery = from participant in context.Participants
                                     join participantCourse in context.Participants_Courses on participant.ID equals participantCourse.CourseID
                                     join course in context.CourseInfoes on participantCourse.CourseID equals course.ID
                                     select new { ProductName = product.Name, Category = category.Name };
                
                foreach (var item in context.Teachers.Where())
                {
                    LstTeachers.Items.Add(item);
                }

                txtName.Text = Course.Course;
                txtLocation.Text = Course.Location;
                TxtContactPerson.Text = Course.ContactPerson;
                TxtCourseCode.Text = Course.CourseCode.ToString();
                TxtOeNumber.Text = Course.OeNumber.ToString();
                txtInstitution.Text = Course.CourseInstitution;
                */
            }
        }

        

        private void BtnAddParticipant_Click(object sender, EventArgs e)
        {

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
    }
}
