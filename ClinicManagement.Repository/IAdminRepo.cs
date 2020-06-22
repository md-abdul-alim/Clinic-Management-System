using ClinicManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagement.Repository
{
    interface IAdminRepo
    {
        void AddDoctorInfromation(Doctor dc);
        void AddUserInfromation(User u);
    }
}
