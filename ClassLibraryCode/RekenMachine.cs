using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCode
{
    public class RekenMachine
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }

        public int Mult(int a, int b)
        {
            return a * b;
        }

        public int Div(int a, int b)
        {
            return a / b;
        }

        public bool IsInRange(int number)
        {
            return number >= 1 && number <= 100;
        }
    }
}
