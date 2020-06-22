using ClinicManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagement.Repository
{
    interface IRegistrationRepo
    {
        void AddPatientInfromation(Patient pa);
        void AddClinicInfromation(Clinic ci);
        void AddDoctorInfromationToAdminTempTable(Doctor dc);
        void AddUserInfromation(User u);
    }
}
