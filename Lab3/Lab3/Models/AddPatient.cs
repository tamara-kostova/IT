using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab3.Models
{
    public class AddPatient
    {
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
        public List<Patient> Patients { get; set; }
        public AddPatient()
        {
            Patients = new List<Patient>();
        }
    }
}