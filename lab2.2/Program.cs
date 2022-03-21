using System;

namespace lab2._2
{
    class Program
    {

        static void Main(string[] args)
        {
            int x, y;
            int N = 1;
            while (N == 1)
            {
                Console.WriteLine("Please enter x:");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter y:");
                y = Convert.ToInt32(Console.ReadLine());

                int res = Check.checkPresence(x, y);

                switch (res) {
                    case 2:
                        Console.WriteLine("Yes");
                        break;
                    case 1:
                        Console.WriteLine("On border");
                        break;
                    case 0:
                        Console.WriteLine("No");
                        break;
                }

                Console.WriteLine("Please enter 0 to end or 1 to continue:");
                N = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
