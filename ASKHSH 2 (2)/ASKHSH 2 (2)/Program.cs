using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASKHSH_2__2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Give me a number");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num%2 == 0)
            {
                Console.WriteLine(num + 2);
            }
            else
            {
                Console.WriteLine(" Einai arritos");
            }
        }
    }
}
