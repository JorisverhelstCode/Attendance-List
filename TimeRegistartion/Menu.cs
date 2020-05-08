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
        private List<Form> Children;
        public Menu()
        {
            InitializeComponent();
            LoadList();
            Children = new List<Form>();
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            BadgeIn details = new BadgeIn(LstCourses.SelectedItem);
            Children.Add(details);
            details.Show();
            details.OnClosingEvent += BadgeIn_OnClosingEvent;
        }

        private void BadgeIn_OnClosingEvent(object sender, OnClosingEventArgs e)
        {
            BadgeIn temp = (BadgeIn)sender;
            temp.OnClosingEvent -= BadgeIn_OnClosingEvent;
            Children.Remove(temp);
        }

        private void LstCourses_DoubleClick(object sender, EventArgs e)
        {
            BadgeIn details = new BadgeIn(LstCourses.SelectedItem);
            Children.Add(details);
            details.Show();
            details.OnClosingEvent += BadgeIn_OnClosingEvent;
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
