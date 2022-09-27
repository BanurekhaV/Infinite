using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2DotNet
{
    class ArraysEg
    {
        public void ArrayFunctions()
        {
            int[] arr = new int[5] { 6, 23, 1, 45, 12 };
            Console.WriteLine(arr.Length);
            System.Array.Sort(arr); 
            for(int i=0; i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }
            
            Console.WriteLine((arr.Rank));
        }

        public void TwoDimensionalArray()
        {
            //declare a 2 dimension array
            int[,] myarray = new int[2, 3]{
                {1,2,3 },
                {4,5,6 } 
            }; //2 rows and 3 columns
            Console.WriteLine(myarray[0,1]); //returns 2 
            myarray[1, 0] = 14;
            Console.WriteLine(myarray[1,0]);
            //loop for tracking rows
            for(int i=0;i<2;i++)
            {
                Console.Write("Elements at Row " + i + ":");
                //inner loop for columns
                for(int j=0;j<3;j++)
                {
                    Console.Write(myarray[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
