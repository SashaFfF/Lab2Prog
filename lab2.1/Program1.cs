using System;

namespace lab2._1
{
    class Program1
    {
        static void Main(string[] args)
        {
            int a;
            int N = 1;
            while (N == 1)
            {
                Console.WriteLine("Please enter a two-digit number:");
                a = Convert.ToInt32(Console.ReadLine());
                int sum = Calc.SumOfDigits(a);
                int result = sum % 2;
                switch (result)
                {
                    case 0:
                        Console.WriteLine("The sum of the digits of a two-digit number is even");
                        break;
                    case 1:
                        Console.WriteLine("The sum of the digits of a two-digit number is odd");
                        break;
                }
                Console.WriteLine("Please enter 0 to end or 1 to continue:");
                N = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
