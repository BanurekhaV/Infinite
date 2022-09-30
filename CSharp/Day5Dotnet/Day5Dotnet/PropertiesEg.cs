using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Dotnet
{
    class Student
    {
        private string RollNo = "N.A.";
        private string Name = "Dont Know";
        private int age = 0;

        //declare property for RollNo
        public string Code
        {
            get { return RollNo; }
            set { if(String.IsNullOrEmpty(value))
                    RollNo = "Invaliddata"; }
        }

        //declare property for Name
        public string _Name
        {
            get { return Name; }
            set { Name = value; }
        }

        //declare property for Age
        public int Age
        {
            get { return age; }  //to read
            set { age = value; } // to write
        }
    }
    class PropertiesEg
    {
        static void Main()
        {
            Student student = new Student();
            Console.WriteLine(student.Code + " " +student._Name + " " + student.Age);
            student.Code = null;
            student._Name = "JamesBond";
            student.Age =65;
            Console.WriteLine(student.Code + " " + student._Name + " " + student.Age);
          //  Console.WriteLine("Enter Code, Name and Age :");
          ////  student.Code = Console.ReadLine();
          //  student._Name = Console.ReadLine();
          //  student.Age = Convert.ToInt32(Console.ReadLine());
          //  Console.WriteLine(student.Code + " " + student._Name + " " + student.Age);
            Console.Read();
        }
    }
}
