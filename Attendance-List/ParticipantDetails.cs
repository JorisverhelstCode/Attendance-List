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
    public partial class ParticipantDetails : Form
    {
        public Participant ThisParticipant { get; set; }
        private ErrorProvider EmptyError;

        public ParticipantDetails()
        {
            InitializeComponent();
        }

        public ParticipantDetails(Participant part) : this()
        {
            ThisParticipant = part;
        }

        private void LstBoxCourses_DoubleClick(object sender, EventArgs e)
        {
            if (LstBoxCourses.SelectedItem != null)
            {
                var course = new CourseDetails((CourseInfo)LstBoxCourses.SelectedItem);
                course.Show();
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (TxtName.Text != ThisParticipant.Name)
            {
                using (AttendanceListDbEntities context = new AttendanceListDbEntities())
                {
                    context.Participants.Where(x => x.ID == ThisParticipant.ID).ToList()[0].Name = TxtName.Text;
                    context.SaveChanges();
                }
            }
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ParticipantDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (TxtName.Text == "")
            {
                EmptyError.SetError(TxtName, "You must give the participant a name!");
                e.Cancel = true;
            }
        }
    }
}