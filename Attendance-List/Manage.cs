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
        private List<CourseDetails> FormsOpen;
        public Manage()
        {
            InitializeComponent();
            FormsOpen = new List<CourseDetails>();
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
                FormsOpen.Add(details);
                details.OnClosingEvent += CourseCreated_OnClosingEvent;
            }
        }

        private void BtnDeleteCourse_Click(object sender, EventArgs e)
        {
            var toBeDeleted = LstBoxCourses.SelectedItem;
            if (toBeDeleted != null )
            {
                var ConfirmationBoxAnswer = MessageBox.Show($"Deleting {toBeDeleted}", $"Are you sure you want to delete {toBeDeleted}", MessageBoxButtons.YesNo);
                if (ConfirmationBoxAnswer == DialogResult.Yes)
                {
                    using (AttendanceListDbEntities context = new AttendanceListDbEntities())
                    {
                        context.CourseInfoes.Remove((CourseInfo)LstBoxCourses.SelectedItem);
                    }
                }
            }
        }

        private void BtnCreateCourse_Click(object sender, EventArgs e)
        {
            CourseDetails details = new CourseDetails();
            FormsOpen.Add(details);
            details.Show();
            details.OnClosingEvent += CourseCreated_OnClosingEvent;
        }

        private void Manage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FormsOpen.Count != 0)
            {
                MessageBox.Show("You still have connected forms open, close them first!", "Unable to close aplication", MessageBoxButtons.OK);
                e.Cancel = true;
            }
        }

        private void CourseCreated_OnClosingEvent(object sender, OnClosingEventArgs e)
        {
            CourseDetails temp = (CourseDetails)sender;
            temp.OnClosingEvent -= CourseCreated_OnClosingEvent;
            FormsOpen.Remove(temp);
            LstBoxCourses.Items.Clear();
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

        private void LstBoxCourses_DoubleClick(object sender, EventArgs e)
        {
            if (LstBoxCourses.SelectedItem != null)
            {
                CourseDetails details = new CourseDetails((CourseInfo)LstBoxCourses.SelectedItem);
                details.Show();
                FormsOpen.Add(details);
                details.OnClosingEvent += CourseCreated_OnClosingEvent;
            }
        }
    }
}
