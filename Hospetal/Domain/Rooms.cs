using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Rooms
    {
        public Rooms() { }
        [Key]
        public int roomId { get; private set; }
        public string roomNumber { get; private set; }
        public string roomType { get; private set; }
        public bool status { get; private set; }
        public double chargePerDay { get; private set; }
        public IEnumerable<Admissions> admissions { get; private set; }
        public IEnumerable<Beds> beds { get; private set; }
    }
}
