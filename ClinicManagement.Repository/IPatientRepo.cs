using ClinicManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagement.Repository
{
    interface IPatientRepo
    {
        void AddtempReqAppoDocInfromation(Patient pa, Doctor dr, Clinic cl);
        void AddPatientHistoryInfromation(Patient pa, Doctor dr, Clinic cl, PrescriptionClass pr);
        void AddPatientNotification(Patient pa,Doctor dr);
    }
}
