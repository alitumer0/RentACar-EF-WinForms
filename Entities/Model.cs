using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_AracKiralama_WF.Entities
{
    internal class Model
    {
        public int ModelID { get; set; }
        public string ModelName { get; set; }
        public int BrandID { get; set; }

        //Navigation Property

        public Brand Brand { get; set; }
        public List<Car> Cars { get; set; }
    }
}
