using System;

namespace ConsoleApp3
{
    class Program
    {
        static uint FactorialRecursive(uint number)
        {
            if(number == 0)
            {
                return 1;
            }
            if (number == 1)
            {
                return 1;
            }
            uint result = number*FactorialRecursive(number - 1);
            return result;
        }
        static void Main(string[] args)
        {
            uint count = FactorialRecursive(10);
            Console.Write($"{count}결과는 다음과 같다.");
        }
    }
}
