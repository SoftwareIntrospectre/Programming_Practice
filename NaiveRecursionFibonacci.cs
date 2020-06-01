using System;
using System.Linq;

namespace ExampleCodePlayground
{
    class Program
    {
        static void Main(string[] args)
        {
            fibonacci(5);
        }

        static int fibonacci(int n)
        {
            if(n == 1)
            {
                Console.WriteLine("n: " + fibonacci(n));
                return 1;
            }

            else if(n == 2)
            {
                Console.WriteLine("n: " + fibonacci(n));
                return 1;
            }

            else if (n > 2)
            {
                Console.WriteLine("n: " + fibonacci(n));
                return fibonacci(n-1) + fibonacci(n-2);
            }

            return 0;
        }
    }
}
