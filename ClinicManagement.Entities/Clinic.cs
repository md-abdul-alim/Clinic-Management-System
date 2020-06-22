using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagement.Entities
{
    sealed public class Clinic : Common
    {
        public Clinic() { }
        public int Testcost { get; set; }
        public int Medicinescost { get; set; }

        public Clinic(string userid, string name, string divission, string district, string thana,string phone) : base(userid,name, divission, district, thana,phone)
        {

        }
        public Clinic(DataSet clinic)
        {
            try
            {
                base.Userid = clinic.Tables[0].Rows[0][1].ToString();
                base.Username = clinic.Tables[0].Rows[0][2].ToString();
                base.Divission = clinic.Tables[0].Rows[0][3].ToString();
                base.District = clinic.Tables[0].Rows[0][4].ToString();
                base.Thana = clinic.Tables[0].Rows[0][5].ToString();
                base.Phone = clinic.Tables[0].Rows[0][6].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Coudn't get Information");
                MessageBox.Show(ex.Message);
            }
        }
    }
}
