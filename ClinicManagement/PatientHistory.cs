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
    public partial class PatientHistory : MetroForm
    {
        Patient pa = new Patient();
        Clinic cl = new Clinic();
        Doctor dr = new Doctor();
        PrescriptionClass pp = new PrescriptionClass();
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        public PatientHistory(Patient pa)
        {
            InitializeComponent();
            this.pa = pa;
            string sql = "select * from patienthistory where patientid='"+pa.Userid+"';";
            this.PopulateGridView(sql);
            this.GridPatientHistory.DataSource = this.Ds.Tables[0];
        }
        void PopulateGridView(string sql)
        {
            this.GridPatientHistory.AutoGenerateColumns = false;
            this.Ds = DataAccess.GetDataSet(sql);
        }
        private void BtnBack_Click(object sender, EventArgs e)
        {
            PatientProfile pp = new PatientProfile(pa);
            this.Visible = false;
            pp.Visible = true;
        }

        private void GridPatientHistory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cl.Userid = this.GridPatientHistory.CurrentRow.Cells["testclinicid"].Value.ToString();
            pp.Test = this.GridPatientHistory.CurrentRow.Cells["test"].Value.ToString();
            pp.Testclinicname = this.GridPatientHistory.CurrentRow.Cells["testclinicname"].Value.ToString();
            dr.Userid = this.GridPatientHistory.CurrentRow.Cells["doctorid"].Value.ToString();
            if (/*cl.Userid.Equals("none") || pp.Test.Equals("none") ||*/ pp.Testclinicname.Equals("none"))
            {
                MessageBox.Show("You Have no report to Test");
            }
            else
            {
                if (string.IsNullOrEmpty(this.GridPatientHistory.CurrentRow.Cells["report"].Value.ToString()))
                {
                    DialogResult dialogResult = MessageBox.Show("To Clinic", "Want to sent Request?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //Application.Exit();
                    }
                    else { }
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("To Doctor", "Want to sent Request?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //Application.Exit();
                    }
                    else { }
                }
            }
        }
    }
}
