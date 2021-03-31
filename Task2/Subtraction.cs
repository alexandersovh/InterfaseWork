using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Subtraction : IOperation
    {
        public Logger Logger { get; set; }
        double IOperation.Operation(double numOne, double numTwo)
        {
            Logger = new Logger();
            Logger.Evetnt("Вычетание чисел");
            return numOne - numTwo;
        }
    }
}
