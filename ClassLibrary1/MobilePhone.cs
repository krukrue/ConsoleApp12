using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class MobilePhone : IPsysicalProcuct
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }
        public MobilePhone(string NAME, double PRICE, double LENGTH, double HEIGHT, double WIDTH)
        {
            Name = NAME;
            Price = PRICE;
            Length= LENGTH;
            Height = HEIGHT;
            Width = WIDTH;
        }
    }
}
