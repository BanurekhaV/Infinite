using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2DotNet
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int x = 10;

            //the below is to understand the primitive data type being represented as class type
            //  Console.WriteLine("Minimum Value of an Integer is {0}",int.MinValue);
            // Console.WriteLine("Maximum Value :{0}",int.MaxValue);
            //  float f = x; //implicit conversion
            //  Console.WriteLine(f);
            //  Console.WriteLine("---------");
            //  f = 1234534755657876.45f;
            //// x =(int) f;   //explicit conversion using typecast
            ////  x = Convert.ToInt32(f); // explicit conversion using conversion functions

            //  Console.WriteLine(x);

            //example for tryparse
            Console.WriteLine("Enter a Number :");
            string str = Console.ReadLine();
            // x = Convert.ToInt32(str); throws exception
            // x = int.Parse(str); //throws exception
            int res;
            bool status = int.TryParse(str, out res);
            if(status==true)  //if success is true
            {
                Console.WriteLine("The parsed/converted data is {0}",res);
            }
            else
                Console.WriteLine("Invalid Data.. could not convert");
            //Console.WriteLine(x);
            Console.Read();
        }
    }
}
