using System;
using MetroFramework.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicManagement.Entities;

namespace ClinicManagement
{
    public partial class AdminProfile : MetroForm
    {
        DataSet ds = new DataSet();
        private Admin ad;
        public AdminProfile() { }
        public AdminProfile(Admin ad)
        {
            InitializeComponent();
            this.ad = ad;
        }

        private void AdminProfile_Load(object sender, EventArgs e)
        {

        }

        private void BtnDoctorList_Click(object sender, EventArgs e)
        {
            AdminDoctorsList1 adl = new AdminDoctorsList1(ad);
            this.Visible = false;
            adl.Visible = true;
        }

        private void BtnClinicList_Click(object sender, EventArgs e)
        {
            AdminClinicList adl = new AdminClinicList(ad);
            this.Visible = false;
            adl.Visible = true;
        }

        private void BtnPatientList_Click(object sender, EventArgs e)
        {
            AdminPatientList ap = new AdminPatientList(ad);
            this.Visible = false;
            ap.Visible = true;
        }

        private void BtnRegistrationClinic_Click(object sender, EventArgs e)
        {
            ClinicRegistration cr=new ClinicRegistration(ad);
            this.Visible = false;
            cr.Visible = true;
        }

        private void BtnDoctorsRequest_Click(object sender, EventArgs e)
        {
            DoctorRegReqToAdmin drra = new DoctorRegReqToAdmin(ad);
            this.Visible = false;
            drra.Visible = true;
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            HomePage hp = new HomePage();
            this.Visible = false;
            hp.Visible = true;
        }
    }
}
