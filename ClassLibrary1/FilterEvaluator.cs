using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class FilterEvaluator
    {
        List<IFilter> list = new List<IFilter>();


        public void Add(IFilter filter)
        {
            list.Add(filter);
        }
        public bool IsMatch(IProduct item)
        {
            foreach(IFilter filter in list)
            {
                if (!filter.isMatch(item)) return false;
            }
            return true;
        }
    }
}
