using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{   
    public class Patients
    {
        public Patients() { }
        [Key]
        public int patientId {   set; get; }
        public string patientCode { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string addres { get; set; }
        public string gender {get;  set;}
        public DateOnly dateOfBirth { get; set; }
        public string bloodType { get; set; }
        public string allergies { get; set; }
        public string emergencyContact { get; set; }
        public DateTime createdAt { get; set; }
        
        public IEnumerable<Bills> bills { get; private set; }
        public IEnumerable <Admissions> admissions { get; private set; }
        public IEnumerable<Appointments> appointments { get; private set; }
        public IEnumerable<MedicalRecords> medicalRecords { get; private set; }
        public IEnumerable<LabTests> labTests { get; private set; }

    }
}
