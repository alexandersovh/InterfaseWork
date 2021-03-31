using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("введите число для первре сложения: ");
                int nunOne = Convert.ToInt32(Console.ReadLine());
                Console.Write("введите число для второе сложения: ");
                int nunTwo = Convert.ToInt32(Console.ReadLine());
                

                Sumator sumTwoNum = new Sumator();
                Console.WriteLine("Сумма чисел: " + sumTwoNum.Sum( nunOne, nunTwo));

            }
            catch(Exception e)
            {
                Console.WriteLine("Ошибка: {0}",e.Message);
            }
            Console.ReadKey();
        }
    }
}
