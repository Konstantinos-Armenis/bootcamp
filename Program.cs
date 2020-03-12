using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASKHSH_ME_TERNARY_OPERATOR_TETRADIO_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 23;
            int b = 31;
            
           var max = (a > b) ? a : b;
            Console.WriteLine(max);
        }
    }
}
