using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Appointments
    {
        public Appointments() { }
        [Key]
        public int appointmentId { private set; get; }
        public DateTime appointmentDate { get; private set; }
        public bool status { get; private set; }
        public string notes { get; private set; }
        public int patientId { get; private set; }
        public Patients patient { get; private set; }
        public int doctorId { get; private set; }
        public Doctors doctor { get; private set; }
        public int departmentId { get; private set; }
        public Departments department { get; private set; }

    }
}
