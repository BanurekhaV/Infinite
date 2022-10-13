using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lang_Enhancements2
{
    class Employee
    {
        public int ID { get; } = 1010;
        public string Ename { get; set; } = "Janice";
        public float ESal { get; private set; } = 35000;
        public string City { get; protected set; } = "Delhi";

        //public Employee()
        //{
        //    Ename = "janice";
        //    ESal = 35000;
        //}

        //setting property values thru a public function
        public void propertySetters()
        {
            ESal = 50000;
            City = "Pune";
        }

    }
    class Program :Employee
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            Console.WriteLine(e.Ename + e.ESal+e.City);
            e.Ename = "Bennett";
            e.propertySetters();
            //e.City = "Pune"; //not possible
            
            Program p = new Program();
            p.City = "Mumbai";
            Console.WriteLine(e.Ename + e.ESal+e.City);
            Console.Read();
        }
    }

    
}
