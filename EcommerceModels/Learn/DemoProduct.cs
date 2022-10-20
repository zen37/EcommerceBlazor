using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceModels.Learn
{
    public class DemoProduct
    {

        public int ID { get; set; }
        public string Name { get; set; }

        public double Price { get; set; }
 
        public Boolean IsAvailable { get; set; }

        public IEnumerable<DemoProductProp>ProductProperties { get; set; }
    }
}
