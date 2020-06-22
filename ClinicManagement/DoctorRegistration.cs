using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicManagement.Data;
using ClinicManagement.Repository;
using ClinicManagement.Entities;
using System.Text.RegularExpressions;

namespace ClinicManagement
{
    public partial class DoctorRegistration : MetroForm
    {
        Doctor dc = new Doctor();
        User u = new User();

        RegistrationRepo drepo = new RegistrationRepo();
        UserRepository urepo = new UserRepository();

        List<Panel> listPanel = new List<Panel>();
        int index;
        private DataTable Dt { get; set; }
        private DataSet Ds { get; set; }
        private DataSet Dss { get; set; }
        public DoctorRegistration()
        {
            InitializeComponent();
            string query = "select * from ClinicManagementDB.dbo.divission";
            Dt = DataAccess.GetDataTable(query);
            comDivission.ValueMember = "divissionid";
            comDivission.DisplayMember = "divissionname";
            comDivission.DataSource = Dt;
            comDistrict.Enabled = false;
            comThana.Enabled = false;

            string query1 = "select * from ClinicManagementDB.dbo.specialty";
            Dt = DataAccess.GetDataTable(query1);
            comSpecialty.ValueMember = "sid";
            comSpecialty.DisplayMember = "sname";
            comSpecialty.DataSource = Dt;
            BtnSignUp.Enabled = false;


        }

        private void Btn_next_Click(object sender, EventArgs e)
        {
            if (index < listPanel.Count - 1)
            {
                listPanel[++index].BringToFront();
                BtnSignUp.Enabled = true;
                BtnNext.Enabled = false;
            }
        }

        private void Btn_previous_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                listPanel[--index].BringToFront();
                BtnSignUp.Enabled = false;
                BtnNext.Enabled = true;
            }
        }

        private void DoctorRegistration_Load(object sender, EventArgs e)
        {
            listPanel.Add(panel1);
            listPanel.Add(panel2);
            listPanel[index].BringToFront();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Cbox_district_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comDistrict.SelectedValue.ToString() != null)
            {
                string query = "select * from ClinicManagementDB.dbo.thana where districtid='" + comDistrict.SelectedValue.ToString() + "' ;";

                Dt = DataAccess.GetDataTable(query);
                comThana.DataSource = Dt;
                comThana.ValueMember = "thanaid";
                comThana.DisplayMember = "thananame";
                comThana.Enabled = true;

            }
        }

        private void Cbox_divission_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comDivission.SelectedValue.ToString() != null)
            {
                string query = "select * from ClinicManagementDB.dbo.district where divissionid='" + comDivission.SelectedValue.ToString() + "' ;";
                Dt = DataAccess.GetDataTable(query);
                comDistrict.ValueMember = "districtid";
                comDistrict.DisplayMember = "districtname";
                comDistrict.DataSource = Dt;
                comDistrict.Enabled = true;
                comThana.Enabled = false;
            }
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            if (this.cbxAgreement.Checked)
            {
                if (string.IsNullOrEmpty(this.txtUserid.Text) || string.IsNullOrEmpty(this.txtName.Text) || string.IsNullOrEmpty(this.txtPassword.Text) || string.IsNullOrEmpty(this.txtConPassword.Text) || string.IsNullOrEmpty(this.txtPhone.Text) || string.IsNullOrEmpty(this.txtEmail.Text) || string.IsNullOrEmpty(this.txtDegree.Text) || string.IsNullOrEmpty(this.txtBmdcRegno.Text) || string.IsNullOrEmpty(this.txtDiscription.Text))
                {
                    MessageBox.Show(this, "Please fill up all fields");
                }
                else
                {
                    //user id validation
                    Regex ree = new Regex("^[a-zA-Z0-9]{2,15}$");
                    bool isValiduserid = ree.IsMatch(this.txtUserid.Text);
                    if ((!isValiduserid))
                    {
                        MessageBox.Show("User Id format is not correct.try ^[a-zA-Z0-9]{2,15}$", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUserid.Focus();
                    }
                    else
                    {
                        //user name validation
                        Regex uname = new Regex("^[a-zA-Z .]{2,30}$");
                        bool isValidusername = uname.IsMatch(this.txtName.Text);
                        if ((!isValidusername))
                        {
                            MessageBox.Show("User name format is not correct.try a-zA-Z . 2 to 30", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                                //degree validation
                                Regex degree = new Regex("^[a-zA-Z]{1,300}$");
                                bool isValiddegree = degree.IsMatch(this.txtDegree.Text);
                                if ((!isValiddegree))
                                {
                                    MessageBox.Show("Degree Char try up to 300 charter", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    //BMDCR validation
                                    Regex bmdcr = new Regex("^[0-9]{10}$");
                                    bool isValidbmdcr = bmdcr.IsMatch(this.txtBmdcRegno.Text);
                                    if ((!isValidbmdcr))
                                    {
                                        MessageBox.Show("BMDCR format is not correct.try 0-9 fill 10", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        txtBmdcRegno.Focus();
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
                                                bool isValid = re.IsMatch(txtPhone.Text);
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
                                                        u.Userid = this.txtUserid.Text;
                                                        u.Password = this.txtPassword.Text;
                                                        u.Status = "doctor";
                                                        urepo.AddUserInfromationToTemploginTable(u);

                                                        dc.Userid = this.txtUserid.Text;
                                                        dc.Username = this.txtName.Text;
                                                        dc.Gender = radio;
                                                        dc.Phone = this.txtPhone.Text;
                                                        dc.Email = this.txtEmail.Text;
                                                        dc.DateOfBirth = this.txtDateOfBirth.Text;
                                                        dc.Specialty = this.comSpecialty.Text;
                                                        dc.Degree = this.txtDegree.Text;
                                                        dc.BMDCRegno = this.txtBmdcRegno.Text;
                                                        dc.Description = this.txtDiscription.Text;
                                                        dc.Divission = this.comDivission.Text;
                                                        dc.District = this.comDistrict.Text;
                                                        dc.Thana = this.comThana.Text;


                                                        drepo.AddDoctorInfromationToAdminTempTable(dc);
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
