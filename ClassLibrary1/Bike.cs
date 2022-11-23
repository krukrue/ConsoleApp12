using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Bike : IPsysicalProcuct, IWheeledVehicle
    {
        public int WhellCount { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Bike(string NAME, double PRICE, double LENGTH, double HEIGHT, double WIDTH, int WHELLCOUNT)
        {
            WhellCount = WHELLCOUNT;
            Height = HEIGHT;
            Width = WIDTH;
            Length = LENGTH;
            Name = NAME;
            Price = PRICE;
        }
    }
}
