using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagement.Entities
{
    //public struct CustomDate
    //{
    //    internal byte day;
    //    internal byte month;
    //    internal ushort year;
    //    public CustomDate(byte day, byte month, ushort year)
    //    {
    //        this.day = day;
    //        this.month = month;
    //        this.year = year;
    //    }
    //}
    public abstract class Common
    {
    //    private string userid;
    //    private string name;
    //    private string gender;
    //    private string phone;
    //    private string email;
    //    //private CustomDate dateOfBirth;
    //    private string dateOfBirth;
    //    private string divission;
    //    private string district;
    //    private string thana;

        
        //admin
        public Common(string userid,string username)
        {
            this.Userid = userid;
            this.Username = username;
        }
        //Clinic
        public Common(string userid,string username, string divission, string district, string thana,string phone)
        {
            this.Userid = userid;
            this.Username = username;
            this.Divission = divission;
            this.District = district;
            this.Thana = thana;
			this.Phone=phone;
        }
        public Common() { }
        //patient
        public Common(string userid,string username, string gender, string phone, string email, string dateOfBirth, string divission, string district, string thana)
        {
            this.Userid = userid;
            this.Username = username;
            this.Gender = gender;
            this.Phone = phone;
            this.Email = email;
            this.DateOfBirth = dateOfBirth;
            this.Divission = divission;
            this.District = district;
            this.Thana = thana;
        }

        public string Password { get; set; }
        public string Status { get; set; }
        public string DateOfBirth { get; set; }
        public string Nmessage { get; set; }
        public string Userid { get; set; }
        
        public string Gender { get; set; }
        public string Username { get; set; }
        public string Phone { get; set; }
        
        public string Email { get; set; }
       
        public string Divission { get; set; }
        public string District { get; set; }
        public string Thana { get; set; }
    }
}
