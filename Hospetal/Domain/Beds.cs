using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Beds
    {
        public Beds() { }
        [Key]
        public int bedId { get; private set; }
        public string bedNumber { get; private set; }
        public bool status { get; private set; }
        public int roomId { get; private set; }
        public Rooms room { get; private set; }
        public IEnumerable<Admissions> admissions { get; private set; }
    }
}
