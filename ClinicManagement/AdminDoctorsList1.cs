using ClinicManagement.Data;
using ClinicManagement.Entities;
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

namespace ClinicManagement
{
    public partial class AdminDoctorsList1 : MetroForm
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        Admin ad = new Admin();
        string sql;
        public AdminDoctorsList1(Admin ad)
        {
            InitializeComponent();
            this.ad = ad;
            sql = "select * from doctor";
            this.PopulateGridView(sql);
            this.GridDoctorsList.DataSource = this.Ds.Tables[0];
        }
        void PopulateGridView(string sql)
        {
            this.GridDoctorsList.AutoGenerateColumns = false;
            this.Ds = DataAccess.GetDataSet(sql);
        }
        private void GrdDoctor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void BtnFromDoctorsList_Click(object sender, EventArgs e)
        {
            AdminProfile ap = new AdminProfile(ad);
            this.Visible = false;
            ap.Visible = true;
        }
        private void GridDoctorsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GridDoctorsList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string userid = this.GridDoctorsList.CurrentRow.Cells["userid"].Value.ToString();
            string username = this.GridDoctorsList.CurrentRow.Cells["username"].Value.ToString();
            string sql = "delete from doctor where userid='" + userid + "';";
            string sqll = "delete from login where userid='" + userid + "';";
            DataAccess.ExecuteQuery(sql);
            DataAccess.ExecuteQuery(sqll);
            MessageBox.Show(username + " has been deleted.");
            string sql1 = "select * from doctor";
            this.PopulateGridView(sql1);
            this.GridDoctorsList.DataSource = this.Ds.Tables[0];
            Count();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        { }

        private void AdminDoctorsList1_Load(object sender, EventArgs e)
        {
            Count();
        }
        public void Count()
        {
            txtDcount.Text = Ds.Tables[0].Rows.Count.ToString();
            //SELECT COUNT(userid)
            //  FROM patient;
        }
    }
}
