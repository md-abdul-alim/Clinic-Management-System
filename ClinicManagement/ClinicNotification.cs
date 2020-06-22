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
    public partial class ClinicNotification : MetroForm
    {
        Clinic ci = new Clinic();
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        public ClinicNotification(Clinic ci)
        {
            InitializeComponent();
            this.ci = ci;
            //string sql = "select * from notification where cid='" + ci.Userid + "'";
            //this.PopulateGridView(sql);
            //this.GridClinicNotification.DataSource = this.Ds.Tables[0];milon1
        }
        void PopulateGridView(string sql)
        {
            this.GridClinicNotification.AutoGenerateColumns = false;
            this.Ds = DataAccess.GetDataSet(sql);
        }
        private void BtnBack_Click(object sender, EventArgs e)
        {
            //ClinicProfile cp = new ClinicProfile(ci);
            this.Visible = false ;
            ///cp.Visible = true;
        }
    }
}
