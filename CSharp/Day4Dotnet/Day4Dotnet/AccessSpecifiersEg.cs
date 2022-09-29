using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Dotnet
{
    public class AccessSpecifiersEg
    {
        public int publicmember;
        int privatemember;
        internal int internalmember;

        public void checkAccess()
        {
            publicmember = 1;
            privatemember = 2;
            internalmember = 3;
            Console.WriteLine(" Project 1 Assembly function.. ");
        }
    }

    class TestAccess
    {
        public void TestingAccess()
        {
            AccessSpecifiersEg aeg = new AccessSpecifiersEg();
            aeg.publicmember = 10;
            aeg.internalmember = 20;
        }
    }
}
