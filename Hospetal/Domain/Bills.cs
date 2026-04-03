using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Bills
    {
        public Bills() { }
        [Key]
        public int billId { get; private set; }
        public double totalAmount { get; private set; }
        public bool paymentStatus { get; private set; }

        public DateTime createdDate { get; private set; }
        public int patientId { get; private set; }
        public Patients patient { get; private set; }
        public IEnumerable<BillsItems> billItems { get; private set; }
    }
}
