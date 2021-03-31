using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class MyException : Exception
    {
        public MyException(string message) : base(message)
        { }
    }
}
