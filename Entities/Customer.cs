using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_AracKiralama_WF.Entities
{
    internal class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime LicenceYear { get; set; }

        public string CitizenID { get; set; } 

        public DateTime BirthDate { get; set; }

        public string PhoneNumber { get; set; }

        public string LisanceType { get; set; }

        public int UserID { get; set; } //foreign key

        //navigation property

        public User User { get; set; }
        public CustomerProfile CustomerProfile { get; set; }
        public ICollection<Rent> Rents { get; set; } // Add this line




    }
}
