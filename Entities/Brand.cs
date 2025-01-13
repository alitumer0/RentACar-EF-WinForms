using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_AracKiralama_WF.Entities
{
    internal class Brand
    {
        public int BrandID { get; set; }
        public string BrandName { get; set; }

        //Navigation Property

        public List<Model> models { get; set; }

    }
}
