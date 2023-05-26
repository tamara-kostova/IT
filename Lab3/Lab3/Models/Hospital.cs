using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab3.Models
{
    public class Hospital
    {
        [Key]
        public int HospitalId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        [Display(Name = "Image")]
        public string ImageUrl { get; set; }
        public virtual ICollection<Doctor> Doctors { get; set; }
        public Hospital() { 
            Doctors = new List<Doctor>();
        }
    }
}