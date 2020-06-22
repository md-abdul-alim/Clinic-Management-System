using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Web.UI.WebControls;
using System.Windows.Forms;
//using System.Web.UI.WebControls;

namespace ClinicManagement.Entities
{
    public class User : Common
    {
        //public  Login LG { get; set; }
        
        //public string Password { get; set; }
        //public string Status { get; set; }
        public User() { }

        public User(DataSet login)
        {
            try
            {
                base.Userid = login.Tables[0].Rows[0][1].ToString();
                base.Password = login.Tables[0].Rows[0][2].ToString();
                base.Status = login.Tables[0].Rows[0][3].ToString();

                //this.LG = lg;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Coudn't get User Information");
                MessageBox.Show(ex.Message);
            }
        }
    }
}

