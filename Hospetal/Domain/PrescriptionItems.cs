using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class PrescriptionItems
    {
        public PrescriptionItems() { }
        [Key]
        public int prescriptionItemId { get; private set; }
        public string dosage { get; private set; }
        public string frequency { get; private set; }
        public string duration { get; private set; }

        public int prescriptionId { get; private set; }
        public Prescriptions prescription { get; private set; }
        public int medicineId { get; private set; }
        public Medicines medicine { get; private set; }
    }
}
