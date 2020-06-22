using ClinicManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagement.Repository
{
    interface IDoctorRepo
    {
        void AddDoctorScheduleInfromation(Doctor dr, Clinic cl);
        void AddPatientWatingListInfromation(Patient pa, Doctor dr, Clinic cl);
    }
}
