using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Admissions
    {
        public Admissions() { }


        [Key]
        public int admissionId { get; private set; }
        public DateTime admissionDate { get; private set; }
        public DateTime? dischargeDate { get; private set; }
        public bool status { get; private set; }
        public int patientId { get; private set; }
        public Patients patient { get; private set; }
        public int doctorId { get; private set; }
        public Doctors doctor { get; private set; }
        public int roomId { get; private set; }
        public Rooms room { get; private set; }
        public int bedId { get; private set; }
        public Beds bed { get; private set; }
    }
}
