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
using MetroFramework.Forms;
using ClinicManagement.Data;

namespace ClinicManagement
{
    public partial class DoctorProfile : MetroForm
    {
        DataSet ds = new DataSet();
        private Doctor dr;
        public DoctorProfile(Doctor dr)
        {
            InitializeComponent();
            this.dr = dr;
        }

        private void DoctorProfile_Load(object sender, EventArgs e)
        {

        }

        private void BtnSetSchedule_Click(object sender, EventArgs e)
        {
            DoctorSetSchedule dss = new DoctorSetSchedule(dr);
            this.Visible = false;
            dss.Visible = true;
        }

        private void BtnRequAppo_Click(object sender, EventArgs e)
        {
            RequestedAppointment rp = new RequestedAppointment(dr);
            this.Visible = false;
            rp.Visible = true;
        }

        private void BtnPaWaitingList_Click(object sender, EventArgs e)
        {
            PatientWatingList pwl= new PatientWatingList(dr);
            this.Visible = false;
            pwl.Visible = true;
        }

        private void BtnPatientsRecords_Click(object sender, EventArgs e)
        {
            PatientsRecords pr = new PatientsRecords(dr);
            this.Visible = false;
            pr.Visible = true;
        }

        private void BtnProfile_Click(object sender, EventArgs e)
        {
            DoctorEditProfile de = new DoctorEditProfile(dr);
            this.Visible = false;
            de.Visible = true;
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            HomePage hp = new HomePage();
            this.Visible = false;
            hp.Visible = true;
        }
    }
}
