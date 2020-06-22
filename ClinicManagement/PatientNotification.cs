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
    public partial class PatientNotification : MetroForm
    {
        Patient pa = new Patient();
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        public PatientNotification(Patient pa)
        {
            InitializeComponent();
            this.pa = pa;
            string sql = "select * from notification where pid='"+pa.Userid+"'";
            this.PopulateGridView(sql);
            this.GridNotification.DataSource = this.Ds.Tables[0];
        }
        void PopulateGridView(string sql)
        {
            this.GridNotification.AutoGenerateColumns = false;
            this.Ds = DataAccess.GetDataSet(sql);
        }
        private void BtnBack_Click(object sender, EventArgs e)
        {
             this.Visible = false;
        }

        private void PatientNotification_Load(object sender, EventArgs e)
        {

        }
    }
}
