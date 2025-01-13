using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_AracKiralama_WF.Entities
{
    internal class Rent
    {      

        public int RentID { get; set; }
        public int CustomerID { get; set; }
        public int CarID { get; set; }

        public DateTime StartRentDate { get; set; }
        public DateTime EndRentDate { get; set; }

        //Navigation Property

        public Customer Customer { get; set; }

        public Car Car { get; set; }

    }
}
