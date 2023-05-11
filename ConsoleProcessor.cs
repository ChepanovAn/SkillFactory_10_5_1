using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory_10_5_1
{
    class ConsoleProcessor : ISum
    {
        public void Sum(int numberOne, int numberTwo)
        {
            int result = numberOne + numberTwo;
            Console.WriteLine($"Результат: {result}");
        }
    }
}
