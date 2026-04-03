using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Departments
    {
        public Departments() { }
        [Key]
        public int departmentId { private set; get; }
        public string name { get; private set; }
        public string description { get; private set; }

        public IEnumerable<Appointments> appointments { get; private set; }

    }
}
