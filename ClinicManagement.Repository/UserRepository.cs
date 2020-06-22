using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicManagement.Entities;
using ClinicManagement.Data;
using System.Windows.Forms;

namespace ClinicManagement.Repository
{
    public class UserRepository
    {
        User u = new User();
        public void AddUserInfromationToTemploginTable(User u)
        {
            this.u = u;
            try
            {
                string sql = @"Insert into temploginReg (userid,password,status) values ('" + u.Userid + "','" + u.Password + "','" + u.Status + "');";
                DataAccess.ExecuteQuery(sql);
            }
            catch (Exception exc)
            {

                MessageBox.Show("Error: " + exc.Message);
                //return 0;
            }
        }
    }
}
