using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Medicines
    {
        public Medicines() { }
        [Key]
        public int medicineId { get; private set; }
        public string name { get; private set; }
        public string category { get; private set; }
        public double price { get; private set; }
        public int stock { get; private set; }
        public DateOnly expirationDate { get; private set; }
            
       public int supplierId { get; private set; }
       public Suppliers supplier { get; private set; }
    }
}
