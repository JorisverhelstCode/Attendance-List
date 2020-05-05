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
                foreach (var item in context.Participants.Where())
                {
                    LstParticipants.Items.Add(item);
                }

                foreach (var item in context.Teachers.Where())
                {
                    LstTeachers.Items.Add(item);
                }

                txtName.Text = Course.Name;
                txtLocation.Text = Course.Location;
                TxtContactPerson.Text = Course.ContactPerson;
                TxtCourseCode.Text = Course.CourseCode;
                TxtOeNumber.Text = Course.OeNumber;
                txtInstitution.Text = Course.Institution;
            }
        }

        

        private void BtnAdd_Click(object sender, EventArgs e)
        {

        }

        private void BtnRemove_Click(object sender, EventArgs e)
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
