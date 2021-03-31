using System;

namespace Task2
{
    class Program
    {
        static Logger Logger { get; set; }
        static void Main(string[] args)
        {
            Console.WriteLine("*** Начало работы ***");

            while (true)
            {
                double result = default;
                IOperation oper;
                Logger = new Logger();
                try
                {
                    Console.Write("введите число: ");
                    double numOne = Convert.ToDouble(Console.ReadLine());

                    Console.Write("введите число: ");
                    double numTwo = Convert.ToDouble(Console.ReadLine());

                    Console.Write("введите операцию('+', '-', '*', '/'): ");
                    string operation = Console.ReadLine();


                    Logger.Evetnt("начнем считать");

                    switch (operation)
                    {
                        case "+":
                            oper = new Sum();
                            result = oper.Operation(numOne, numTwo);
                            break;

                        case "-":
                            oper = new Subtraction();
                            result = oper.Operation(numOne, numTwo);
                            break;
                        case "*":
                            oper = new Multiplication();
                            result = oper.Operation(numOne, numTwo);
                            break;
                        case "/":
                            if (numTwo == 0)
                            {
                                throw new DivideByZeroException();
                            }
                            else
                            {
                                oper = new Division();
                                result = oper.Operation(numOne, numTwo);
                            }
                            break;

                    }
                    string a = Convert.ToString(result);
                    Logger.Evetnt(a);
                }
                catch (FormatException fe)
                {
                    Logger.Error("возникли неполадка . . . ");
                    Logger.Error("некорректное число!!");
                    Logger.Error(fe.Message);
                }
                catch (OverflowException oe)
                {
                    Logger.Error("возникли неполадка . . . ");
                    Logger.Error("Слишком большое число!!");
                    Logger.Error(oe.Message);
                }

                catch (DivideByZeroException dbze)
                {
                    Logger.Error("возникли неполадка . . . ");
                    Logger.Error("На ноль делить нельзя!!");
                    Logger.Error(dbze.Message);
                }
                catch (Exception e)
                {
                    Logger.Error(e.Message);
                }
                finally
                {
                    Console.WriteLine("Хотите выйти из программы Да/Нет (Y/N)");
                    if (Console.ReadKey(true).Key == ConsoleKey.Y)
                    {
                        Environment.Exit(0);
                    }
                }
            }
        }
    }
}
