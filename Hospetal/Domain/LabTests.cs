using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class LabTests
    {
        public LabTests() { }
        [Key]
        public int labTestId { get; private set; }
        public string testName { get; private set; }
        public bool status { get; private set; }
        public string result { get; private set; }
        public DateTime date { get; private set; }
        public int patientId { get; private set; }
        public Patients patient { get; private set; }
        public int doctorId { get; private set; }
        public Doctors doctor { get; private set; }
    }
}
