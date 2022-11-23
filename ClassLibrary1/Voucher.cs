using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Voucher : IProduct
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Voucher(string NAME, double PRICE)
        {
            Name = NAME;
            Price = PRICE;
        }

    }
}
