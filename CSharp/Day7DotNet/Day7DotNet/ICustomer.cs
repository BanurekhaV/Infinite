using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7DotNet
{
    interface ICustomer   //prefix I for interface
    {
        void Print();  //only decl.
        int EvenNo(int x);
    }

    interface ICustomer1
    {
        void Show();
    }
   
    class Customer : ICustomer,ICustomer1
    {
        public void Print()
        {
            Console.WriteLine("ICustomer Interface Method..");
        }
        public int EvenNo(int a)
        {
            if (a % 2 == 0)
                return a;
            else
                return 0;
        }

        public void Show()
        {
            Console.WriteLine("ICustomer Show Implementation");
        }
    }
    class Tester
    {
        static void Main()
        {
            Customer c = new Customer();
            c.Print();
            Console.Read();
           // ICustomer ic=new Customer();
        }
    }
}
