using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab3.Models
{
    public class DoctorDTO
    {
        public int DoctorId { get; set; }
        public string Name { get; set; }
        public int HospitalId { get; set; }
        public List <Hospital> Hospitals { get; set; }
        public DoctorDTO() { 
            Hospitals = new List<Hospital>(); 
        }
    }
}