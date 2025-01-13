using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _10_AracKiralama_WF.Enums;

namespace _10_AracKiralama_WF.Entities
{
    internal class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNum { get; set; } 
        public Role Role { get; set; }

        public string Password { get; set; }


        //navigation property

        public Customer? Customer { get; set; }



    }
}
