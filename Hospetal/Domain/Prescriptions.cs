using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Prescriptions
    {
        public Prescriptions() { }
        [Key]
        public int prescriptionId { get; private set; }
        public DateTime date { get; private set; }
        public int medicalRecordId { get; private set; }
        public MedicalRecords medicalRecord { get; private set; }

        public IEnumerable<PrescriptionItems> prescriptionItems { get; private set; }
    }
}
