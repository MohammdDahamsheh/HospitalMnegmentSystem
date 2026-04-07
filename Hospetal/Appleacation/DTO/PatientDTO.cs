using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appleacation.DTO
{
    public class PatientDTO
    {
        public PatientDTO() { }

        public string name { get;  set; }
        public string phone { get;  set; }
        public string addres { get;  set; }
        public string gender { get; set; }
        public DateOnly dateOfBirth { get; set; }
        public string bloodType { get; set; }
        public string allergies { get; set; }
        public string emergencyContact { get; set; }

    }
}
