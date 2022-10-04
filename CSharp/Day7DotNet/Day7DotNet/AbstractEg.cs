using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7DotNet
{
   abstract class Shapeclass
    {
        //declaring abstract method with asbtract modifier, without definition
          abstract public int Area();

        //non abstract method with definition
        public void Display()
        {
            Console.WriteLine("Hi I am Abstract class");
        }
    }

    class SquareClass : Shapeclass
    {
        int side;
        public SquareClass(int n)
        {
            side = n;
        }
        public override int Area()
        {
            return side * side;
        }
    }
    class AbstractEg 
    {
        static void Main()
        {
            Shapeclass sc = new SquareClass(4);
            Console.WriteLine(sc.Area());
            sc.Display();
            Console.Read();
        }
    }
}
