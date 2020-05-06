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
        public ParticipantDetails(Participant part)
        {
            InitializeComponent();
            ThisParticipant = part;
        }

        private void LstBoxCourses_DoubleClick(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (TxtName.Text != ThisParticipant.Name)
            {
                using (AttendanceListDbEntities context = new AttendanceListDbEntities())
                {
                    var current = context.Participants.Where(x => x.ID == ThisParticipant.ID);
                    
                }
            }
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {

        }
    }
}
