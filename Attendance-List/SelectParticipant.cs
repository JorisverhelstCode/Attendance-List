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
        private List<Form> Children;
        public SelectParticipant(CourseInfo course)
        {
            InitializeComponent();
            Course = course;
            Children = new List<Form>();
            if (Course.Course == "")
            {
                LblCourseName.Text = "Unnamed Course";
            } else
            {
                LblCourseName.Text = Course.Course;
            }
            using (AttendanceListDbEntities context = new AttendanceListDbEntities())
            {
                foreach (var item in context.Participants_Courses.Where(x => x.CourseID == Course.ID))
                {
                    var participant = context.Participants.Where(x => x.ID == item.ParticipantID);
                    LstParticipants.Items.Add(participant);
                }
            }
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

        }

        private void LstParticipants_DoubleClick(object sender, EventArgs e)
        {

        }

        private void SelectParticipant_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void SelectParticipant_FormClosed(object sender, FormClosedEventArgs e)
        {

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
                foreach (var item in context.Participants_Courses.Where(x => x.CourseID == Course.ID))
                {
                    var participant = context.Participants.Where(x => x.ID == item.ParticipantID && x.Name.Contains(TxtFilter.Text));
                    LstParticipants.Items.Add(participant);
                }
            }
        }
    }
}
