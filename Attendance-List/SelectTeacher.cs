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
    public partial class SelectTeacher : Form
    {
        CourseInfo Course;
        public event EventHandler<OnClosingEventArgs> OnClosingEvent;
        private List<Form> Children;
        public SelectTeacher(CourseInfo course)
        {
            InitializeComponent();
            Course = course;
            Children = new List<Form>();
            if (Course.Course == "")
            {
                LblCourseName.Text = "Unnamed Course";
            }
            else
            {
                LblCourseName.Text = Course.Course;
            }
            RefreshList();
        }


        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (LstTeachers.SelectedItem != null)
            {
                var tempPart = (Teacher)LstTeachers.SelectedItem;
                var relation = new Teachers_Courses();
                relation.TeacherID = tempPart.ID;
                relation.CourseID = Course.ID;
                using (AttendanceListDbEntities context = new AttendanceListDbEntities())
                {
                    context.Teachers_Courses.Add(relation);
                    context.SaveChanges();
                }
            }
        }

        private void BtnCreateNewTeacher_Click(object sender, EventArgs e)
        {
            var teacher = new TeacherDetails();
            Children.Add(teacher);
            teacher.OnClosingEvent += TeacherForm_OnClosingEvent;
            teacher.Show();
        }

        private void LstTeachers_DoubleClick(object sender, EventArgs e)
        {
            if (LstTeachers.SelectedItem != null)
            {
                var teacher = new TeacherDetails((Teacher)LstTeachers.SelectedItem);
                Children.Add(teacher);
                teacher.OnClosingEvent += TeacherForm_OnClosingEvent;
                teacher.Show();
            }
        }

        private void TxtFilter_TextChanged(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void TeacherForm_OnClosingEvent(object sender, OnClosingEventArgs e)
        {
            var temp = (TeacherDetails)sender;
            temp.OnClosingEvent -= TeacherForm_OnClosingEvent;
            Children.Remove(temp);
            RefreshList();
        }

        private void RefreshList()
        {
            LstTeachers.Items.Clear();
            using (AttendanceListDbEntities context = new AttendanceListDbEntities())
            {
                foreach (var item in context.Teachers_Courses.Where(x => x.CourseID == Course.ID))
                {
                    var teacher = context.Teachers.Where(x => x.ID == item.TeacherID && x.Name.Contains(TxtFilter.Text));
                    LstTeachers.Items.Add(teacher);
                }
            }
        }

        private void SelectTeacher_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Children.Count != 0)
            {
                MessageBox.Show("You still have connected windows open, close them first!", "Unable to close the window", MessageBoxButtons.OK);
                e.Cancel = true;
            }
        }

        private void SelectTeacher_FormClosed(object sender, FormClosedEventArgs e)
        {
            OnClosingEvent?.Invoke(this, new OnClosingEventArgs());
        }
    }
}
