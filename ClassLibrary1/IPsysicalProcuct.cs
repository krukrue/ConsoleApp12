using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface IPsysicalProcuct : IProduct
    {
        double Height { get; }
        double Width { get; }
        double Length { get; }
    }
}
