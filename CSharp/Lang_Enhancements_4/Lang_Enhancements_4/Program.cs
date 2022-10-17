using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lang_Enhancements_4
{
    class Program
    {
        static int [] numbers = new int[] { 1, 2, 3, 4, 5 };
        public static void Simple_Aggregates()
        {
            var result = numbers.Aggregate((a, b) => a * b);
            Console.WriteLine("Aggregated Product is :{0}", result);
            foreach(int n in numbers)
            {
                Console.WriteLine(n);
            }    
        }

       public static void  Aggregates_WithSeed()
        {
            var sum = numbers.Sum(); // 15
            Console.WriteLine(sum);
            var res = numbers.Aggregate(10.5, (a, b) => a + b);
            Console.WriteLine("Aggregated Sum with a seed value :{0}",res);

        }

        public static void FirstEg()
        {
            string[] colors = { "Red", "Blue", "Green","Yellow","Black","White" };
            Console.WriteLine(colors.First());
            Console.WriteLine(colors.Last());
            string[] c1 = { };
            Console.WriteLine(c1.FirstOrDefault()); //does not throw exception
            Console.WriteLine(c1.LastOrDefault()); //""
        }

        public static void SingleEg()
        {
            string[] names1 = { "Amitabh Bacchan" };
            string[] names2 = { "JoeBiden", "Donald", "Trump", "Obama" };
            string[] empty = { };
            Console.WriteLine(names1.Single());
          //  Console.WriteLine(names2.SingleOrDefault()); //throws exception
            Console.WriteLine(empty.SingleOrDefault());
        }
        static void Main(string[] args)
        {
            // Simple_Aggregates();
            //Aggregates_WithSeed();
            // FirstEg();
            SingleEg();
            Console.Read();
        }  
    }
}
