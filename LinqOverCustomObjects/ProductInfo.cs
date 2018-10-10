using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqOverCustomObjects
{
    class ProductInfo
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int NumberInstock { get; set; }

        public override string ToString()
        {
            return string.Format("Name={0}, Description={1}, NumberInstock={2}", Name, Description, NumberInstock);
        }
    }
}
