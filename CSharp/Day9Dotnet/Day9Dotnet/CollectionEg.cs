using System;
using System.Collections;

namespace Day9Dotnet
{
    class CollectionEg
    {
        public void ArrayListEg()
        {
            //ArrayList Collection can take different data types
            ArrayList arrlist = new ArrayList();
            arrlist.Add("Sampreeth");
            arrlist.Add(10);
            arrlist.Add(true);
            arrlist.Add(35.45f);
            arrlist.Add('S');
            arrlist.Add(55.50);

            foreach(var val in arrlist)
            {
                Console.WriteLine(val);
            }

            //insert a value at an index
            arrlist.Insert(2, "Rama");
           // arrlist.Remove(10); //or
            arrlist.RemoveAt(1);
            Console.WriteLine("--------------");
            foreach (var val in arrlist)
            {
                Console.WriteLine(val);
            }
            Console.WriteLine("----------");
            Console.WriteLine(arrlist.Capacity);
            //another arraylist object
            ArrayList newlist = new ArrayList();
            newlist.Add(1);
            newlist.Add(8);
            newlist.Add(19);
            newlist.Add(6);
            newlist.Add(4);

            arrlist.InsertRange(0,newlist);
            Console.WriteLine("----after adding a range of values----");
            Console.WriteLine(arrlist.Count);
            Console.WriteLine(arrlist.Capacity);
            
            foreach (var val in arrlist)
            {
                Console.WriteLine(val);
            }
            Console.WriteLine("************");
            foreach (int i in newlist)
            {
                Console.WriteLine(i);
            }
            newlist.Sort();
            foreach(int i in newlist)
            {
                Console.WriteLine(i);
            }
        }

        public static void Main()
        {
            CollectionEg ceg = new CollectionEg();
            ceg.ArrayListEg();
            Console.Read();
        }
    }
}
