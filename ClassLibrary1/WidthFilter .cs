using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class WidthFilter : IFilter
    {
        double max = 0;
        double min = 0;

        public WidthFilter()
        {
        }

        public WidthFilter(double max, double min)
        {
            this.max = max;
            this.min = min;
        }

        public bool isMatch(IProduct item)
        {
            try
            {
                if (max == 0 && min == 0)
                {
                    throw new InvalidFilterArgumentsException();
                }
            } catch (InvalidFilterArgumentsException)
            {
               
            }
            if (item.Price < min || item.Price > max) return false;
            return true;
        }

    }
}
