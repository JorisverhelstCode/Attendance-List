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

namespace TimeRegistartion
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            LoadList();
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            BadgeIn details = new BadgeIn((CourseInfo)LstCourses.SelectedItem);
            details.Show();
        }

        private void LstCourses_DoubleClick(object sender, EventArgs e)
        {
            BadgeIn details = new BadgeIn((CourseInfo)LstCourses.SelectedItem);
            details.Show();
        }

        private void LoadList()
        {
            LstCourses.Items.Clear();
            using (AttendanceListDbEntities context = new AttendanceListDbEntities())
            {
                var Courses = context.CourseInfoes.ToList();
                if (Courses.Count() != 0)
                {
                    foreach (var item in Courses)
                    {
                        LstCourses.Items.Add(item);
                    }
                }
            }
        }
    }
}
