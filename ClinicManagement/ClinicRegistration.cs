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
using ClinicManagement.Entities;
using ClinicManagement.Repository;
using System.Text.RegularExpressions;

namespace ClinicManagement
{
    public partial class ClinicRegistration : MetroForm
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private DataSet Dss { get; set; }
        private DataTable Dt { get; set; }

        Clinic ci = new Clinic();
        User u = new User();
        Admin ad = new Admin();

        RegistrationRepo crepo = new RegistrationRepo();
        UserRepository urepo = new UserRepository();
        AdminRepo arepo = new AdminRepo();
        
        public ClinicRegistration(Admin ad)
        {
            InitializeComponent();
            this.ad = ad;
            string query = "select * from ClinicManagementDB.dbo.divission";
            Dt = DataAccess.GetDataTable(query);
            comDivission.ValueMember = "divissionid";
            comDivission.DisplayMember = "divissionname";
            comDivission.DataSource = Dt;
            comDistrict.Enabled = false;
            comThana.Enabled = false;
        }

        private void ComDivission_SelectedIndexChanged(object sender, EventArgs e)
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

        private void ComDistrict_SelectedIndexChanged(object sender, EventArgs e)
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

        private void BtnAddclinic_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtUserId.Text) || string.IsNullOrEmpty(this.txtName.Text) || string.IsNullOrEmpty(this.txtPassword.Text) || string.IsNullOrEmpty(this.txtconPassword.Text) || string.IsNullOrEmpty(txtPhone.Text))
            {
                MessageBox.Show("Please fill up all fields.");
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
                    //clinic name validation
                    Regex uname = new Regex("^[a-zA-Z .]{2,30}$");
                    bool isValidusername = uname.IsMatch(this.txtName.Text);
                    if ((!isValidusername))
                    {
                        MessageBox.Show("clinic name format is not correct.try a-zA-Z . 2 to 30", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        //user id validation
                        Regex ree = new Regex("^[a-zA-Z0-9]{2,15}$");
                        bool isValiduserid = ree.IsMatch(this.txtUserId.Text);
                        if ((!isValiduserid))
                        {
                            MessageBox.Show("User Id format is not correct.try a-zA-Z0-9 2 to 15", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (this.txtPassword.Text.Equals(this.txtconPassword.Text))
                            {
                                //phone number validation
                                Regex re = new Regex("^[0-9]{11}$");
                                bool isValid = re.IsMatch(this.txtPhone.Text);
                                if ((!isValid))
                                {
                                    MessageBox.Show("Phone number format is not correct.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    string sql = "select userid from login where userid='" + this.txtUserId.Text + "';";
                                    string sqll = "select userid from temploginReg where userid='" + this.txtUserId.Text + "';";
                                    this.Ds = DataAccess.GetDataSet(sql);
                                    this.Dss = DataAccess.GetDataSet(sqll);
                                    if (this.Ds.Tables[0].Rows.Count == 1 || this.Dss.Tables[0].Rows.Count == 1)
                                    {
                                        MessageBox.Show(this, "Your given user id already exist!");
                                    }
                                    else
                                    {
                                        u.Userid = this.txtUserId.Text;
                                        u.Password = this.txtPassword.Text;
                                        u.Status = "clinic";
                                        arepo.AddUserInfromation(u);

                                        ci.Userid = this.txtUserId.Text;
                                        ci.Username = this.txtName.Text;
                                        ci.Phone = this.txtPhone.Text;
                                        ci.Divission = this.comDivission.Text;
                                        ci.District = this.comDistrict.Text;
                                        ci.Thana = this.comThana.Text;
                                        crepo.AddClinicInfromation(ci);
                                        MessageBox.Show(this, "Clinic Registraion Complete.");
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

        private void BtnAdminPage_Click(object sender, EventArgs e)
        {
            AdminProfile ap = new AdminProfile(ad);
            this.Visible = false;
            ap.Visible = true;
        }
    }
}
