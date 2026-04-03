using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class MedicalRecords
    {
        public MedicalRecords() { }
        [Key]
        public int medicalRecordId { get; private set; }
        public string diagnosis { get; private set; }
        public string treatment { get; private set; }
        public string symptoms { get; private set; }
        public DateTime visitDate { get; private set; }
        public string notes { get; private set; }

        public int patientId { get; private set; }
        public Patients patient { get; private set; }
        public int doctorId { get; private set; }
        public Doctors doctor { get; private set; }
        public IEnumerable<Prescriptions> prescriptions { get; private set; }
    }
}
