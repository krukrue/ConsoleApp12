using System.Collections.Generic;

namespace ClassLibrary1
{
    public class Stock<T> 
    {
        List <T> products= new List <T> ();

        public void Add(T item)
        {
            if (products.Any(o => o.Equals(item)))
            {
                throw new DuplicitProductException();
            }

            products.Add(item);
            
        }
        public List<T> Filter (FilterEvaluator filterev)
        {
            List <T> temp = new List <T> ();
            foreach(T item in products)
            {
                if (filterev.IsMatch((IProduct)item) == true)
                {
                    temp.Add (item);
                }
            }
            return temp;
        } 
    }
}