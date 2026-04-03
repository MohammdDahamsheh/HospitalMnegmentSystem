using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class BillsItems
    {
        public BillsItems() { }
        [Key]
        public int billItemId { get; private set; }
        public string itemName { get; private set; }
        public double amount { get; private set; }
        public int quantity { get; private set; }
        public int billId { get; private set; }
        public Bills bill { get; private set; }
    }
}
