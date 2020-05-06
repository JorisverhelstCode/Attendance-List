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
    public partial class Manage : Form
    {
        public Manage()
        {
            InitializeComponent();
            using (AttendanceListDbEntities context = new AttendanceListDbEntities())
            {
                var Courses = context.CourseInfoes.ToList();
                if (Courses.Count() != 0)
                {
                    foreach (var item in Courses)
                    {
                        LstBoxCourses.Items.Add(item);
                    }
                }
            }
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            if (LstBoxCourses.SelectedItem != null)
            {
                CourseDetails details = new CourseDetails((CourseInfo)LstBoxCourses.SelectedItem);
                details.Show();
            }
        }

        private void BtnDeleteCourse_Click(object sender, EventArgs e)
        {
            var toBeDeleted = LstBoxCourses.SelectedItem;
            var ConfirmationBoxAnswer = MessageBox.Show($"Deleting {toBeDeleted}", $"Are you sure you want to delete {toBeDeleted}", MessageBoxButtons.YesNo);
            if (toBeDeleted != null && ConfirmationBoxAnswer == DialogResult.Yes)
            {
                using (AttendanceListDbEntities context = new AttendanceListDbEntities())
                {
                    context.CourseInfoes.Remove((CourseInfo)LstBoxCourses.SelectedItem);
                }
            }
        }

        private void BtnCreateCourse_Click(object sender, EventArgs e)
        {
            CourseDetails details = new CourseDetails();
            details.Show();
        }


    }
}
