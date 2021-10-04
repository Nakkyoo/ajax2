using System;

namespace ConsoleApp1
{
    class Program
    {
        static uint FibonacciRecursive (uint num) // 어차피 uint라서 음수못들어감
        {
            if(num == 0)
            {
                return 0;
            }
            else if (num == 1) // 이렇게 else 쓰면 호온난다 아주. 논리적으로 0은 이제 될 수 없는 상황이면 if로써야지
            {
                return 1;
            }
                return FibonacciRecursive(num - 2) + FibonacciRecursive(num - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(FibonacciRecursive(10));
        }
    }
}
