using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Logger : ILogger
    {
        public void Error(string massag)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(massag);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void Evetnt(string massag)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(massag);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
