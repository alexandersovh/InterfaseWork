using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceTask1
{
    class Sumator : ISumator
    {
        public int Sum(int numOne, int numTwo)
        {

            return numOne + numTwo;
        }

        public int Sum(int numOne, int numTwo, int numthree)
        {

            return numOne + numTwo + numthree;
        }
    }
}
