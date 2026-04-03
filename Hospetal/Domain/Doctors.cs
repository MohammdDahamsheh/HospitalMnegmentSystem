using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Doctors
    {
        public Doctors() { }
        [Key]
        public int doctorId { private set; get; }
        public string specialization { get; private set; }
        public double fees { get; private set; }
        public  string schedule{ get; private set; }
        public bool status { get; private set; }
        public int userId { get; private set; }
        public Users user { get; private set; }
        public int departmentId { get; private set; }
        public Departments department { get; private set; }

        public IEnumerable<Appointments> appointments { get; private set; }
        
        public IEnumerable<Admissions> admissions { get; private set; }
    }
}
