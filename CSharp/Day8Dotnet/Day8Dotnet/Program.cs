using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8Dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            try
            {
                Console.WriteLine("Enter 2 nos :");
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                c = a / b;
                Console.WriteLine(c);
                Console.Read();
            }
            catch(FormatException fe)
            {
                Console.WriteLine(fe.Message);
                Console.WriteLine("Please enter only numbers");
                Console.Read();
            }          

        }
    }
}
