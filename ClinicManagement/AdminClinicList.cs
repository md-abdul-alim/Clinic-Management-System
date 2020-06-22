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
    public partial class AdminClinicList : MetroForm
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        Admin ad = new Admin();
        public AdminClinicList(Admin ad)
        {
            InitializeComponent();
            this.ad = ad;
            string sql = "select * from clinic";
            this.PopulateGridView(sql);
            this.GrdClinicList.DataSource = this.Ds.Tables[0];
           
        }
        void PopulateGridView(string sql)
        {
            this.GrdClinicList.AutoGenerateColumns = false;  //Optional false
            this.Ds = DataAccess.GetDataSet(sql);
        }

        private void GridPatientList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

            string userid = this.GrdClinicList.CurrentRow.Cells["userid"].Value.ToString();
            string username = this.GrdClinicList.CurrentRow.Cells["username"].Value.ToString();
            string sql = "delete from clinic where userid='" + userid + "';";
            string sqll = "delete from login where userid='" + userid + "';";
            DataAccess.ExecuteQuery(sql);
            DataAccess.ExecuteQuery(sqll);
            MessageBox.Show(username + " has been deleted.");
            string sql1 = "select * from clinic";
            this.PopulateGridView(sql1);
            this.GrdClinicList.DataSource = this.Ds.Tables[0];
            Count();

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
           

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //update query
           
        }

        private void BtnFromDoctorsList_Click(object sender, EventArgs e)
        {

        }

        private void BtnBackAdminPage_Click(object sender, EventArgs e)
        {
            AdminProfile ap = new AdminProfile(ad);
            this.Visible = false;
            ap.Visible = true;
        }

        private void AdminClinicList_Load(object sender, EventArgs e)
        {
            Count();
        }
        public void Count()
        {
            this.txtCcount.Text = Ds.Tables[0].Rows.Count.ToString();
            //SELECT COUNT(userid)
            //  FROM patient;
        }
    }
}
