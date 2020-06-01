using System;

namespace ExampleCodePlayground
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine(fibonacci(10));
        }

        static int fibonacci(int x)
        {

            if(x == 1)
            {
                return 1; //no need for recursive call here, just return it (because recursion needs a base-case to finish)
            }

            else
            {
                int result = x * fibonacci(x - 1); //more efficient way than "fibonacci(x - 1) + fibonacci(x - 2)" 
                return result;
            }
        }
    }
}
