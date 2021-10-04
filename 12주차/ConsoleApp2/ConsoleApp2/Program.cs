using System;

namespace ConsoleApp2
{
    class Program
    {
        static uint FactiorialUnRecursive(uint number)
        {
            if(number == 0)
            {
                return 1;
            }
            if(number == 1)
            {
                return 0;
            }
            uint result = 1;
            for(uint i =2;i<= number ; i++)
            {
                result *= i; 
            }
            return result;
        }
        static void Main(string[] args)
        {
            uint count = FactiorialUnRecursive(10);
            Console.Write($"{count}");
        }
    }
}
