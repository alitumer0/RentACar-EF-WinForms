using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _10_AracKiralama_WF.Enums;

namespace _10_AracKiralama_WF.Entities
{
    internal class CustomerProfile
    {
        [Key]
        [ForeignKey("Customer")]
        public int Id { get; set; }
        public string Name { get; set; }

        public string RelativeName { get; set; }

        public string RelativeType { get; set; }

        public string RelativePhoneNumber { get; set; }

        public BloodType BloodType { get; set; }

        //Navigation Property

        public Customer Customer { get; set; }
    }
}
