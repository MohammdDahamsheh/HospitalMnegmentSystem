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
        public int patientId { private set; get; }
        public string patientCode { get; private set; }
        public string name { get; private set; }
        public string phone { get; private set; }
        public string addres { get; private set; }
        public string gender {get; private set;}
        public DateOnly dateOfBirth { get; private set; }
        public string bloodType { get; private set; }
        public string allergies { get; private set; }
        public string emergencyContact { get; private set; }
        public DateTime createdAt { get; private set; }
        
        public IEnumerable<Bills> bills { get; private set; }
        public IEnumerable <Admissions> admissions { get; private set; }
        public IEnumerable<Appointments> appointments { get; private set; }
        public IEnumerable<MedicalRecords> medicalRecords { get; private set; }
        public IEnumerable<LabTests> labTests { get; private set; }

    }
}
