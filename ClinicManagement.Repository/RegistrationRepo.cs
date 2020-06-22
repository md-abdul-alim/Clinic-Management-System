using System;
using ClinicManagement.Entities;
using ClinicManagement.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagement.Repository
{
    public class RegistrationRepo: IRegistrationRepo
    {

        //Patient Data Insert From Patient Registration From
        Patient pa = new Patient();
        public void AddPatientInfromation(Patient pa)
        {
            this.pa = pa;
            try
            {
                string sql = @"Insert into patient (userid,username,gender,phone,email,dateOfBirth,divission,district,thana) values ('" + pa.Userid + "','" + pa.Username + "','" + pa.Gender + "','" + pa.Phone + "','" + pa.Email + "','" + pa.DateOfBirth + "','" + pa.Divission + "','" + pa.District + "','" + pa.Thana + "');";
                
                DataAccess.ExecuteQuery(sql);
            }
            catch (Exception exc)
            {   
                MessageBox.Show("Error: " + exc.Message);
                //return 0;
            }
        }
        public void AddClinicInfromation(Clinic ci)
        {
            try
            {
                string sql = @"insert into clinic (userid,username,divission,district,thana,phone) values ('" + ci.Userid + "','" + ci.Username + "','" + ci.Divission + "','" + ci.District + "','" + ci.Thana + "','" + ci.Phone + "');";
                DataAccess.ExecuteQuery(sql);
            }
            catch (Exception exc)
            {

                MessageBox.Show("Error: " + exc.Message);

            }
        }
        public void AddDoctorInfromationToAdminTempTable(Doctor dc)
        {
            try
            {
                string sql = @"insert into tempDoctorReg (userid,username,gender,phone,email,dateOfBirth,specialty,degree,bmdcregno,description,divission,district,thana) 
values ('" + dc.Userid + "','" + dc.Username + "','" + dc.Gender + "','" + dc.Phone + "','" + dc.Email + "','" + dc.DateOfBirth + "','" + dc.Specialty + "','" + dc.Degree + "','" + dc.BMDCRegno + "','" + dc.Description + "','" + dc.Divission + "','" + dc.District + "','" + dc.Thana + "');";
                DataAccess.ExecuteQuery(sql);
            }
            catch (Exception exc)
            {

                MessageBox.Show("Error: " + exc.Message);

            }
        }
        public void AddUserInfromation(User u)
        {
            try
            {
                string sql = @"Insert into login (userid,password,status) values ('" + u.Userid + "','" + u.Password + "','" + u.Status + "');";
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
