using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class RegistrationModel
    {


        public int RegId { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public Nullable<System.DateTime> DoB { get; set; }
        public string Cno { get; set; }
    }
}
