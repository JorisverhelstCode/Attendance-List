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
    public partial class TeacherDetails : Form
    {
        public Teacher ThisTeacher { get; set; } = new Teacher();
        private ErrorProvider EmptyError;
        private bool NewEntry = true;
        public event EventHandler<OnClosingEventArgs> OnClosingEvent;
        private List<Form> Children;
        public TeacherDetails()
        {
            InitializeComponent();
            EmptyError = new ErrorProvider();
            Children = new List<Form>();
        }

        public TeacherDetails(Teacher teacher) : this()
        {
            NewEntry = false;
            ThisTeacher = teacher;
            TxtCompany.Text = ThisTeacher.Company;
            TxtName.Text = ThisTeacher.Name;
            using (AttendanceListDbEntities context = new AttendanceListDbEntities())
            {
                foreach (var item in context.Teachers_Courses.Where(x => x.TeacherID == ThisTeacher.ID))
                {
                    var course = context.CourseInfoes.Where(x => x.ID == item.CourseID);
                    LstCourses.Items.Add(course);
                }
            }
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (CustomValidtion())
            {
                RestoreEmptyError();
                ThisTeacher.Name = TxtName.Text;
                ThisTeacher.Company = TxtCompany.Text;
                using (AttendanceListDbEntities context = new AttendanceListDbEntities())
                {
                    if (NewEntry)
                    {
                        context.Teachers.Add(ThisTeacher);
                    }
                    else
                    {
                        context.Teachers.Where(x => x.ID == ThisTeacher.ID).ToList()[0] = ThisTeacher;
                    }
                    context.SaveChanges();
                }
                this.Close();
            }
        }

        private bool CustomValidtion()
        {
            bool Allgood = true;
            if (String.IsNullOrEmpty(TxtName.Text))
            {
                EmptyError.SetError(TxtName, "You must give the participant a name!");
                Allgood = false;
            }
            return Allgood;
        }

        private void RestoreEmptyError()
        {
            EmptyError.SetError(TxtName, "");
        }

        private void TeacherDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Children.Count() != 0)
            {
                MessageBox.Show("You still have connected windows open, close them first!", "Unable to close the window", MessageBoxButtons.OK);
                e.Cancel = true;
            } else 
            if (TxtName.Text == "" && !NewEntry)
            {
                EmptyError.SetError(TxtName, "You can't just steal this man's name!");
                e.Cancel = true;
            }
            else
            if (TxtName.Text != ThisTeacher.Name || TxtCompany.Text != ThisTeacher.Company)
            {
                string errorMessage;
                if (NewEntry)
                {
                    errorMessage = "Quiting new teacher";
                }
                else
                {
                    errorMessage = $"Quiting Participant {ThisTeacher.Name}";
                }
                var SureYouWantToQuit = MessageBox.Show("Are you sure you want to quit without saving?",
                    errorMessage, MessageBoxButtons.YesNo);
                if (SureYouWantToQuit == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void TeacherDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            OnClosingEvent?.Invoke(this, new OnClosingEventArgs());
        }
    }
}
