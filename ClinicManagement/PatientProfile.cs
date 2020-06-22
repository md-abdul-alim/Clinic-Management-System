using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicManagement.Entities;
using ClinicManagement.Repository;
using MetroFramework.Forms;

namespace ClinicManagement
{
    public partial class PatientProfile : MetroForm
    {
        DataSet ds = new DataSet();
        private Patient pa;
        public PatientProfile(Patient pa)
        {
            InitializeComponent();
            this.pa = pa;
        }

        private void PatientProfile_Load(object sender, EventArgs e)
        {

        }

        private void BtnTakeAppointment_Click(object sender, EventArgs e)
        {
            TakeAppointment ta = new TakeAppointment(pa);
            this.Visible = false;
            ta.Visible = true;
        }

        private void BtnHistory_Click(object sender, EventArgs e)
        {
            PatientHistory ph = new PatientHistory(pa);
            this.Visible = false;
            ph.Visible = true;
        }

        private void BtnProfile_Click(object sender, EventArgs e)
        {
            PatientEditProfile pe = new PatientEditProfile(pa);
            this.Visible = false;
            pe.Visible = true;
        }

        private void BtnNotification_Click(object sender, EventArgs e)
        {
            PatientNotification pn = new PatientNotification(pa);
            //this.Visible = false;
            pn.Visible = true;
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            HomePage hp = new HomePage();
            this.Visible = false;
            hp.Visible = true;
        }
    }
}
