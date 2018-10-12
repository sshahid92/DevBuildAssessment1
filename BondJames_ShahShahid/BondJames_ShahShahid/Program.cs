using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BondJames_ShahShahid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome secret agent. Please enter your first and last name.");
            string name = Console.ReadLine();
            
            string[] nameArray = name.Split(' ');
            Console.WriteLine($"Welcome Agent {nameArray[1]}, {nameArray[0]}!");
            Console.ReadLine();
        }
    }
}
