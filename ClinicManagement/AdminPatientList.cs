using ClinicManagement.Data;
using MetroFramework.Forms;
using ClinicManagement.Entities;
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
    public partial class AdminPatientList : MetroForm
    {
        Admin ad = new Admin();
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        public AdminPatientList(Admin ad)
        {
            InitializeComponent();
            this.ad = ad;
            string sql = "select * from patient";
            this.PopulateGridView(sql);
            this.GridPatientList.DataSource = this.Ds.Tables[0];
        }
        void PopulateGridView(string sql)
        {
            this.GridPatientList.AutoGenerateColumns = false;  //Optional false 
            this.Ds = DataAccess.GetDataSet(sql);
        }

        private void MetroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GridPatientList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string userid = this.GridPatientList.CurrentRow.Cells["userid"].Value.ToString();
            string username = this.GridPatientList.CurrentRow.Cells["username"].Value.ToString();
            string sql = "delete from patient where userid='" + userid + "';";
            string sqll = "delete from login where userid='" + userid + "';";
            DataAccess.ExecuteQuery(sql);
            DataAccess.ExecuteQuery(sqll);
            MessageBox.Show(username + " has been deleted.");
            string sql1 = "select * from patient";
            this.PopulateGridView(sql1);
            this.GridPatientList.DataSource = this.Ds.Tables[0];
            Count();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnBackAdmin_Click(object sender, EventArgs e)
        {
            AdminProfile ap = new AdminProfile(ad);
            this.Visible = false;
            ap.Visible = true;
        }

        private void AdminPatientList_Load(object sender, EventArgs e)
        {
            Count();
        }
        public void Count()
        {
            txtPcount.Text = Ds.Tables[0].Rows.Count.ToString();
            //SELECT COUNT(userid)
            //  FROM patient;
        }
    }
}
