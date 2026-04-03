using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Users
    {
        public Users() { }

        [Key]
        public int userId { private set; get; }
        public string userName { get; private set; }
        public string password { get; private set; }
        public string role { get; private set; }
        public string email { get; private set; }
        public string phone { get; private set; }
        public bool status { get; private set; }




    }
}
