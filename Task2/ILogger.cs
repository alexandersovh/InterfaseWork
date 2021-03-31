using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    interface ILogger
    {
        void Error(string massag);
        void Evetnt(string massag);
    }
}
