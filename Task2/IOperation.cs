using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    interface IOperation
    {
        Logger Logger { get; set; }
        double Operation(double numOne, double numTwo);
    }
}
