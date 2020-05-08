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
    public partial class BadgeIn : Form
    {
        public event EventHandler<OnClosingEventArgs> OnClosingEvent;
        private CourseInfo Course;
        public BadgeIn(CourseInfo course)
        {
            InitializeComponent();
            Course = course;
            LoadParticipants();
            RefreshTimeregistrations();
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnBadgeIn_Click(object sender, EventArgs e)
        {
            var temp = (Participant)LstParticipants.SelectedItem;
            var toBeAdded = new TimeRegistration()
            {
                ParticipantID = temp.ID,
                CourseID = Course.ID,
                DateTime = DateTime.Now
            };
            using (AttendanceListDbEntities context = new AttendanceListDbEntities())
            {
                context.TimeRegistrations.Add(toBeAdded);
                context.SaveChanges();
            }
        }

        private void LstTimeRegistrations_DoubleClick(object sender, EventArgs e)
        {

        }

        private void LoadParticipants()
        {
            LstParticipants.Items.Clear();
            using (AttendanceListDbEntities context = new AttendanceListDbEntities())
            {
                foreach (var item in context.Participants_Courses.Where(x => x.CourseID == Course.ID))
                {
                    var participant = context.Participants.Where(x => x.ID == item.ParticipantID).FirstOrDefault();
                    LstParticipants.Items.Add(participant);
                }
            }
        }

        private void RefreshTimeregistrations()
        {
            LstTimeRegistrations.Items.Clear();
            using (AttendanceListDbEntities context = new AttendanceListDbEntities())
            {
                var timeStamps = context.TimeRegistrations.Where(x => x.DateTime.Day == DateTime.Now.Day 
                && x.DateTime.Month == DateTime.Now.Month && x.DateTime.Year == DateTime.Now.Year).ToList();
                if (timeStamps.Count() != 0)
                {
                    foreach (var item in timeStamps)
                    {
                        LstTimeRegistrations.Items.Add(item);
                    }
                }
            }
        }

        private void BadgeIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            OnClosingEvent?.Invoke(this, new OnClosingEventArgs());
        }
    }
}
