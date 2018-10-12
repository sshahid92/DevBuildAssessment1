using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_ShahShahid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eneter a number to see its multiplication table up to 12.");
            double input = Convert.ToDouble(Console.ReadLine());
            for (int i = 0; i <= 12; i++)
            {
                Console.WriteLine(input + " * " + i + " = " + input * i);

            }
            Console.ReadLine();
        }
    }

}
