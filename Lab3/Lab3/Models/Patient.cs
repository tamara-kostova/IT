using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Lab3.Models
{
    public class Patient
    {
        [Key]
        public int PatientId { get; set; }
        [Required]
        public string Name { get; set; }
        [Range(10000, 99999)]
        [Display(Name = "Kod na pacientot")]
        public int PatientCode { get; set; }
        [Display(Name = "Gender")]
        public Gender SelectedGender { get; set; }
        public virtual ICollection<Doctor> Doctors { get; set; }
        public Patient()
        {
            Doctors = new List<Doctor>();
        }
    }
    public enum Gender
    {
        Male,
        Female
    }
}