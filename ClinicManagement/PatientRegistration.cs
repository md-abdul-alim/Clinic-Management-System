using MetroFramework.Forms;
using ClinicManagement.Data;
using ClinicManagement.Entities;
using ClinicManagement.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ClinicManagement
{
    public partial class PatientRegistration : MetroForm
    {
        Patient pa = new Patient();
        User u = new User();

        RegistrationRepo prepo = new RegistrationRepo();
        UserRepository urepo = new UserRepository();
		
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private DataSet Dss { get; set; }
        DataTable dt = new DataTable();

        public PatientRegistration()
        {
            InitializeComponent();
            string sql = "select * from ClinicManagementDB.dbo.divission";
            dt = DataAccess.GetDataTable(sql);
            ComDivission.ValueMember = "divissionid";
            ComDivission.DisplayMember = "divissionname";
            ComDivission.DataSource = dt;
            ComDistrict.Enabled = false;
            ComThana.Enabled = false;
        }

        private void PatientRegistration_Load(object sender, EventArgs e)
        {

        }

        private void MetroLabel6_Click(object sender, EventArgs e)
        {

        }
        private void ComDivission_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComDivission.SelectedValue.ToString() != null)
            {
                string query = "select * from ClinicManagementDB.dbo.district where divissionid='" + ComDivission.SelectedValue.ToString() + "' ;";
                dt = DataAccess.GetDataTable(query);
                ComDistrict.ValueMember = "districtid";
                ComDistrict.DisplayMember = "districtname";
                ComDistrict.DataSource = dt;
                ComDistrict.Enabled = true;
                ComThana.Enabled = false;
            }
        }
        private void MetroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComDistrict.SelectedValue.ToString() != null)
            {
                string query = "select * from ClinicManagementDB.dbo.thana where districtid='" + ComDistrict.SelectedValue.ToString() + "' ;";

                dt = DataAccess.GetDataTable(query);
                ComThana.DataSource = dt;
                ComThana.ValueMember = "thanaid";
                ComThana.DisplayMember = "thananame";
                ComThana.Enabled = true;

            }
        }

        private void ComThana_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            //try
            //{
            if (this.cbxAgreement.Checked)
            {
                if (string.IsNullOrEmpty(this.txtUserid.Text) || string.IsNullOrEmpty(this.txtUserName.Text) || string.IsNullOrEmpty(this.txtPassword.Text) || string.IsNullOrEmpty(this.txtConPassword.Text) || string.IsNullOrEmpty(this.txtPhoneNumber.Text) || string.IsNullOrEmpty(this.txtEmail.Text))
                {
                    MessageBox.Show(this, "Please fill up all fields");
                }
                else
                {
                    //password validation
                    Regex pass = new Regex("^[-~!@#$%^&*()_=a-zA-Z0-9]{2,25}$");
                    bool isValidpass = pass.IsMatch(this.txtPassword.Text);
                    if ((!isValidpass))
                    {
                        MessageBox.Show("Password format is not correct.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        //user name validation
                        Regex uname = new Regex("^[a-zA-Z .]{2,30}$");
                        bool isValidusername = uname.IsMatch(this.txtUserName.Text);
                        if ((!isValidusername))
                        {
                            MessageBox.Show("User name format is not correct.try a-zA-Z . 2 to 30", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            //user id validation
                            Regex ree = new Regex("^[a-zA-Z0-9]{2,15}$");
                            bool isValiduserid = ree.IsMatch(this.txtUserid.Text);
                            if ((!isValiduserid))
                            {
                                MessageBox.Show("User Id format is not correct.try ^[a-zA-Z0-9]{2,15}$", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                if (this.txtPassword.Text.Equals(this.txtConPassword.Text))
                                {
                                    //email validation
                                    Regex emailch;
                                    emailch = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

                                    if (!emailch.IsMatch(txtEmail.Text.Trim()))

                                    {

                                        MessageBox.Show("E-mail address format is not correct.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                        txtEmail.Focus();
                                    }
                                    else
                                    {
                                        //phone number validation
                                        Regex re = new Regex("^[0-9]{11}$");
                                        bool isValid = re.IsMatch(txtPhoneNumber.Text);
                                        if ((!isValid))
                                        {
                                            MessageBox.Show("Phone number format is not correct.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                        else
                                        {
                                            string sql = "select userid from login where userid='" + this.txtUserid.Text + "';";
                                            string sqll = "select userid from temploginReg where userid='" + this.txtUserid.Text + "';";
                                            this.Ds = DataAccess.GetDataSet(sql);
                                            this.Dss = DataAccess.GetDataSet(sqll);
                                            if (this.Ds.Tables[0].Rows.Count == 1 || this.Dss.Tables[0].Rows.Count == 1)
                                            {
                                                MessageBox.Show(this, "Your given user id already exist!");
                                            }
                                            else
                                            {
                                                string radio = null;
                                                if (RadioMale.Checked)
                                                {
                                                    radio = RadioMale.Text;
                                                }
                                                if (RadioFemale.Checked)
                                                {
                                                    radio = RadioFemale.Text;
                                                }
                                                //Data Insert Part
                                                pa.Userid = this.txtUserid.Text;
                                                u.Userid = this.txtUserid.Text;
                                                pa.Username = this.txtUserName.Text;
                                                pa.Gender = radio;
                                                u.Password = this.txtPassword.Text;
                                                pa.Phone = this.txtPhoneNumber.Text;
                                                pa.Email = this.txtEmail.Text;
                                                pa.DateOfBirth = this.DateOfBirth.Text;
                                                pa.Divission = this.ComDivission.Text;
                                                pa.District = this.ComDistrict.Text;
                                                pa.Thana = this.ComThana.Text;
                                                u.Status = "patient";
                                                prepo.AddUserInfromation(u);
                                                prepo.AddPatientInfromation(pa);
                                                Login l = new Login();
                                                this.Visible = false;
                                                l.Visible = true;
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show(this, "Password & Con. Password Doesn't Match.");
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show(this, "Please check the agreement box to continue!");
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            HomePage hp = new HomePage();
            this.Visible = false;
            hp.Visible = true;
        }
    }
}
