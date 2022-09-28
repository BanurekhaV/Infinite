using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3DotNet
{
    class MethodsnParameters
    {
        //value type 
        public void SimpleMethod(int x)
        {
            Console.WriteLine("the value of the variable passed ");
            Console.WriteLine(x);
            x = 500;
            Console.WriteLine(x);
        }

        //reference type
        public void ReferenceMethod(ref int j)
        {
            Console.WriteLine("the value of the variable passed ");
            Console.WriteLine(j);
            j = 500;
            Console.WriteLine(j);
        }

        //out parameters
        public int Calculator(int num1, int num2, out int sum, out int prod, out int sub)
        {
            prod = num1 * num2; // ""
            sum = num1 + num2; //addition result is sent as an output value
            sub = num1 - num2; // "  "" 
            return num1 / num2;  // division result is being returned
           // Console.WriteLine(sum+ " " +prod);
        }
       static void Main()
        {
            int a = 10;
            MethodsnParameters mp = new MethodsnParameters();
            
            int division;
            int total,product,difference;
            division=mp.Calculator(20, 10, out total, out product, out difference);
            Console.WriteLine($"Sum is {total}, product is {product}, difference is {difference} and division is {division}");
            //Console.WriteLine(total +" "+ product +" " +difference );
            
            Console.Read();

        }
    }
}
