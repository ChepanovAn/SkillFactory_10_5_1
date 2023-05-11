using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory_10_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите первое число");

                    int numberOne = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите второе число");

                    int numberTwo = int.Parse(Console.ReadLine());

                    ConsoleProcessor consoleProcessor = new ConsoleProcessor();

                    ((ISum)consoleProcessor).Sum(numberOne, numberTwo);
                }
                catch
                {
                    Console.WriteLine("Возникло исключение");
                }
                Console.ReadKey();
            }

        }
    }
}
