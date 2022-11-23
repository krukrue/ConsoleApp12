using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class WhellCountFilter : IFilter 
    {
        public WhellCountFilter(int NUM) {
            num = NUM;
        }
        public int num { get; set; }
        public bool isMatch(IProduct item)
        {
            var temp = (IWheeledVehicle)item;
            if (temp.WhellCount == num) return true;
            return false;
        }
    }
}
