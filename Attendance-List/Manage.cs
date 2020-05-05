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
                foreach (var item in context.CourseInfoes)
                {
                    LstBoxCourses.Items.Add(item);
                } 
            }
        }

        private void Manage_Load(object sender, EventArgs e)
        {

        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            if (LstBoxCourses.SelectedItem != null)
            {
                CourseDetails details = new CourseDetails(LstBoxCourses.SelectedItem);
                details.Show();
            }
        }

        private void BtnDeleteCourse_Click(object sender, EventArgs e)
        {
            using (AttendanceListDbEntities context = new AttendanceListDbEntities())
            {
                context.CourseInfoes.Remove(LstBoxCourses.SelectedItem);
            }
        }

        private void BtnCreateCourse_Click(object sender, EventArgs e)
        {
            CourseDetails details = new CourseDetails();
            details.Show();
        }
    }
}
