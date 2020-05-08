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
    public partial class SelectParticipant : Form
    {
        CourseInfo Course;
        public event EventHandler<OnClosingEventArgs> OnClosingEvent;
        public event EventHandler<OnAddedEventArgs> OnAddedEvent;
        private List<Form> Children;
        public SelectParticipant(CourseInfo course)
        {
            InitializeComponent();
            Course = course;
            Children = new List<Form>();
            if (Course.Course == String.Empty)
            {
                LblCourseName.Text = "Unnamed Course";
            } else
            {
                LblCourseName.Text = Course.Course;
            }
            RefreshList();
        }

        private void BtnCreateNewParticipant_Click(object sender, EventArgs e)
        {
            var participant = new ParticipantDetails();
            Children.Add(participant);
            participant.OnClosingEvent += ParticipantForm_OnClosingEvent;
            participant.Show();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (LstParticipants.SelectedItem != null)
            {
                var tempPart = (Participant)LstParticipants.SelectedItem;
                var relation = new Participants_Courses();
                relation.ParticipantID = tempPart.ID;
                relation.CourseID = Course.ID;
                using (AttendanceListDbEntities context = new AttendanceListDbEntities())
                {
                    context.Participants_Courses.Add(relation);
                    context.SaveChanges();
                }
                OnAddedEvent?.Invoke(this, new OnAddedEventArgs());
                RefreshList();
            }
        }

        private void LstParticipants_DoubleClick(object sender, EventArgs e)
        {
            if (LstParticipants.SelectedItem != null)
            {
                var participant = new ParticipantDetails((Participant)LstParticipants.SelectedItem);
                Children.Add(participant);
                participant.OnClosingEvent += ParticipantForm_OnClosingEvent;
                participant.Show();
            }
        }

        private void SelectParticipant_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Children.Count != 0)
            {
                MessageBox.Show("You still have connected windows open, close them first!", "Unable to close the window", MessageBoxButtons.OK);
                e.Cancel = true;
            }
        }

        private void SelectParticipant_FormClosed(object sender, FormClosedEventArgs e)
        {
            OnClosingEvent?.Invoke(this, new OnClosingEventArgs());
        }

        private void TxtFilter_TextChanged(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void ParticipantForm_OnClosingEvent(object sender, OnClosingEventArgs e)
        {
            var temp = (ParticipantDetails)sender;
            temp.OnClosingEvent -= ParticipantForm_OnClosingEvent;
            Children.Remove(temp);
            RefreshList();        
        }

        private void RefreshList()
        {
            LstParticipants.Items.Clear();
            using (AttendanceListDbEntities context = new AttendanceListDbEntities())
            {
                foreach (var item in context.Participants)
                {
                    bool addable = true;
                    foreach (var courseSet in context.Participants_Courses.Where(x => x.CourseID == Course.ID))
                    {
                        if (item.ID == courseSet.ParticipantID)
                        {
                            addable = false;
                        }
                    }
                    if (item.Name.Contains(TxtFilter.Text) && addable)
                    {
                        LstParticipants.Items.Add(item);
                    }
                }
            }
        }
    }
}
