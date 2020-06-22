using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicManagement.Data;

namespace ClinicManagement.Entities
{
    sealed public class Admin:Common
    {
        public Admin() { }
        public Admin(string userid,string name):base(userid,name)
        {

        }
        public Admin(DataSet admin)
        {
            try
            {
                base.Userid = admin.Tables[0].Rows[0][1].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Coudn't get User Information");
                MessageBox.Show(ex.Message);
            }
        }
    }
}
