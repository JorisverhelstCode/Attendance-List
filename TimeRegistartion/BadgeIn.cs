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
        private CourseInfo Course;
        private List<Participant> Participants;
        public BadgeIn(CourseInfo course)
        {
            InitializeComponent();
            Course = course;
            LblCourseName.Text = Course.Course;
            Participants = new List<Participant>();
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
            RefreshTimeregistrations();
        }

        private void LoadParticipants()
        {
            LstParticipants.Items.Clear();
            using (AttendanceListDbEntities context = new AttendanceListDbEntities())
            {
                foreach (var item in context.Participants_Courses.Where(x => x.CourseID == Course.ID))
                {
                    var participant = context.Participants.Where(x => x.ID == item.ParticipantID).FirstOrDefault();
                    Participants.Add(participant);
                    LstParticipants.Items.Add(participant);
                }
            }
        }

        private void RefreshTimeregistrations()
        {
            LstTimeRegistrations.Items.Clear();
            using (AttendanceListDbEntities context = new AttendanceListDbEntities())
            {
                var timeStamps = from part in Participants
                                 join timeStamp in context.TimeRegistrations on part.ID equals timeStamp.ParticipantID
                                 where timeStamp.DateTime.Day == DateTime.Now.Day && timeStamp.DateTime.Month == DateTime.Now.Month && timeStamp.DateTime.Year == DateTime.Now.Year
                                 select new { ParticipantName = part.Name };
                if (timeStamps.Count() != 0)
                {
                    foreach (var item in Participants)
                    {
                        int counter = 0;
                        foreach (var name in timeStamps)
                        {
                            if (name.ParticipantName == item.Name)
                            {
                                counter++;
                            }
                        }
                        if (counter % 2 == 1)
                        {
                            LstTimeRegistrations.Items.Add("Badged in");
                        } else
                        {
                            LstTimeRegistrations.Items.Add("Badged out");
                        }
                    }
                }
            }
        }
    }
}
