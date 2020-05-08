using AttendencieLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_List
{
    public partial class Manage : Form
    {
        private List<Form> Children;
        public Manage()
        {
            InitializeComponent();
            Children = new List<Form>();
            RefreshCourses();
            RefreshParticipants();
            RefreshTeachers();
        }

        private void BtnDeleteCourse_Click(object sender, EventArgs e)
        {
            var toBeDeleted = (CourseInfo)LstParticipants.SelectedItem;
            if (toBeDeleted != null)
            {
                var ConfirmationBoxAnswer = MessageBox.Show($"Deleting {toBeDeleted}", $"Are you sure you want to delete {toBeDeleted}", MessageBoxButtons.YesNo);
                if (ConfirmationBoxAnswer == DialogResult.Yes)
                {
                    using (AttendanceListDbEntities context = new AttendanceListDbEntities())
                    {
                        bool oldValidateOnSaveEnabled = context.Configuration.ValidateOnSaveEnabled;

                        try
                        {
                            context.Configuration.ValidateOnSaveEnabled = false;

                            var course = new CourseInfo { ID = toBeDeleted.ID };

                            context.CourseInfoes.Attach(course);
                            context.Entry(course).State = EntityState.Deleted;
                            context.SaveChanges();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("This participant still has open connections!", $"Unable to delete {toBeDeleted.Course}", MessageBoxButtons.OK);
                        }
                        finally
                        {
                            context.Configuration.ValidateOnSaveEnabled = oldValidateOnSaveEnabled;
                        }
                    }
                    RefreshCourses();
                }
            }
        }

        private void BtnCreateCourse_Click(object sender, EventArgs e)
        {
            CourseDetails details = new CourseDetails();
            Children.Add(details);
            details.Show();
            details.OnClosingEvent += CourseCreated_OnClosingEvent;
        }

        private void Manage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Children.Count != 0)
            {
                MessageBox.Show("You still have connected forms open, close them first!", "Unable to close aplication", MessageBoxButtons.OK);
                e.Cancel = true;
            }
        }

        private void CourseCreated_OnClosingEvent(object sender, OnClosingEventArgs e)
        {
            CourseDetails temp = (CourseDetails)sender;
            temp.OnClosingEvent -= CourseCreated_OnClosingEvent;
            Children.Remove(temp);
            RefreshCourses();
        }

        private void LstBoxCourses_DoubleClick(object sender, EventArgs e)
        {
            if (LstBoxCourses.SelectedItem != null)
            {
                CourseDetails details = new CourseDetails((CourseInfo)LstBoxCourses.SelectedItem);
                details.Show();
                Children.Add(details);
                details.OnClosingEvent += CourseCreated_OnClosingEvent;
            }
        }

        private void RefreshCourses()
        {
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

        private void RefreshParticipants()
        {
            LstParticipants.Items.Clear();
            using (AttendanceListDbEntities context = new AttendanceListDbEntities())
            {
                var Participants = context.Participants.ToList();
                if (Participants.Count() != 0)
                {
                    foreach (var item in Participants)
                    {
                        LstParticipants.Items.Add(item);
                    }
                }
            }
        }

        private void RefreshTeachers()
        {
            LstTeachers.Items.Clear();
            using (AttendanceListDbEntities context = new AttendanceListDbEntities())
            {
                var Teachers = context.Teachers.ToList();
                if (Teachers.Count() != 0)
                {
                    foreach (var item in Teachers)
                    {
                        LstTeachers.Items.Add(item);
                    }
                }
            }
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCreateNewParticipant_Click(object sender, EventArgs e)
        {
            ParticipantDetails details = new ParticipantDetails();
            Children.Add(details);
            details.Show();
            details.OnClosingEvent += ParticipantDetails_OnCLosingEvent;
        }

        private void BtnDeleteTeacher_Click(object sender, EventArgs e)
        {
            var toBeDeleted = (Teacher)LstTeachers.SelectedItem;
            if (toBeDeleted != null)
            {
                var ConfirmationBoxAnswer = MessageBox.Show($"Deleting {toBeDeleted}", $"Are you sure you want to delete {toBeDeleted}", MessageBoxButtons.YesNo);
                if (ConfirmationBoxAnswer == DialogResult.Yes)
                {
                    using (AttendanceListDbEntities context = new AttendanceListDbEntities())
                    {
                        bool oldValidateOnSaveEnabled = context.Configuration.ValidateOnSaveEnabled;

                        try
                        {
                            context.Configuration.ValidateOnSaveEnabled = false;

                            var teacher = new Teacher { ID = toBeDeleted.ID };

                            context.Teachers.Attach(teacher);
                            context.Entry(teacher).State = EntityState.Deleted;
                            context.SaveChanges();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("This teacher still has open connections!", $"Unable to delete {toBeDeleted.Name}", MessageBoxButtons.OK);
                        }
                        finally
                        {
                            context.Configuration.ValidateOnSaveEnabled = oldValidateOnSaveEnabled;
                        }
                    }
                    RefreshTeachers();
                }
            }
        }

        private void BtnDeleteParticipant_Click(object sender, EventArgs e)
        {
            var toBeDeleted = (Participant)LstParticipants.SelectedItem;
            if (toBeDeleted != null)
            {
                var ConfirmationBoxAnswer = MessageBox.Show($"Deleting {toBeDeleted}", $"Are you sure you want to delete {toBeDeleted}", MessageBoxButtons.YesNo);
                if (ConfirmationBoxAnswer == DialogResult.Yes)
                {
                    using (AttendanceListDbEntities context = new AttendanceListDbEntities())
                    {
                        bool oldValidateOnSaveEnabled = context.Configuration.ValidateOnSaveEnabled;

                        try
                        {
                            context.Configuration.ValidateOnSaveEnabled = false;

                            var part = new Participant { ID = toBeDeleted.ID };

                            context.Participants.Attach(part);
                            context.Entry(part).State = EntityState.Deleted;
                            context.SaveChanges();
                        } catch (Exception)
                        {
                            MessageBox.Show("This participant still has open connections!", $"Unable to delete {toBeDeleted.Name}", MessageBoxButtons.OK);
                        }
                        finally
                        {
                            context.Configuration.ValidateOnSaveEnabled = oldValidateOnSaveEnabled;
                        }
                    }
                    RefreshParticipants();
                }
            }
        }

        private void BtnCreateNewTeacher_Click(object sender, EventArgs e)
        {
            TeacherDetails details = new TeacherDetails();
            Children.Add(details);
            details.Show();
            details.OnClosingEvent += TeacherDetails_OnCLosingEvent;
        }

        private void LstParticipants_DoubleClick(object sender, EventArgs e)
        {
            if (LstParticipants.SelectedItem != null)
            {
                ParticipantDetails details = new ParticipantDetails((Participant)LstParticipants.SelectedItem);
                details.Show();
                Children.Add(details);
                details.OnClosingEvent += ParticipantDetails_OnCLosingEvent;
            }
        }

        private void LstTeachers_DoubleClick(object sender, EventArgs e)
        {
            if (LstTeachers.SelectedItem != null)
            {
                TeacherDetails details = new TeacherDetails((Teacher)LstParticipants.SelectedItem);
                details.Show();
                Children.Add(details);
                details.OnClosingEvent += TeacherDetails_OnCLosingEvent;
            }
        }

        private void ParticipantDetails_OnCLosingEvent(object sender, OnClosingEventArgs e)
        {
            ParticipantDetails temp = (ParticipantDetails)sender;
            temp.OnClosingEvent -= ParticipantDetails_OnCLosingEvent;
            Children.Remove(temp);
            RefreshParticipants();
        }

        private void TeacherDetails_OnCLosingEvent(object sender, OnClosingEventArgs e)
        {
            TeacherDetails temp = (TeacherDetails)sender;
            temp.OnClosingEvent -= TeacherDetails_OnCLosingEvent;
            Children.Remove(temp);
            RefreshTeachers();
        }
    }
}
