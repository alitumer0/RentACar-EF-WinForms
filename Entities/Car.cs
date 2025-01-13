using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _10_AracKiralama_WF.Enums;

namespace _10_AracKiralama_WF.Entities
{
    internal class Car
    {
        public int Id { get; set; }

        public int ModelID { get; set; }

        public int Year { get; set; }

        public double Price { get; set; }
        public int Kilometer { get; set; }
        public string LicansePlate { get; set; }
        public Enums.Color Color { get; set; }

        public string Chassis { get; set; }
        public bool IsRented { get; set; }

        public bool HasInsurance { get; set; }

        public DateTime InsuranceLastDate { get; set; }

        public DateTime ExaminationLastDate { get; set; }

        public int SeatCount { get; set; } 
        
        public FuelType FuelType { get; set; }

        public GearBox GearBox { get; set; }

        //Navigation Property

        public Model Model { get; set; }

        
        public ICollection<Rent> Rents { get; set; } // Add this line




    }
}
