using System;
using System.Linq;

namespace factorial
{
    class Program
    {
        static int Factorial_recursive(int n)
        {
            // Base Case, n = 1
            if (n == 1) return 1;

            // Otherwise
            return n * Factorial_recursive(n-1);
        }

        static int Factorial_tailRecursive(int n, int accumulator = 1)
        {
            // Base case, n == 1
            if (n == 1) return accumulator;

             // Otherwise
            return n * Factorial_tailRecursive(n-1, accumulator * n);
        }        
        static int Factorial_for(int n)
        {
            var accum = 1;

            for (int i = 1; i <= n; ++i)
            {
                accum *= i;                
            }
            return accum;
        }
        static int Factorial_LinqAggregate(int n) => Enumerable.Range(1, n-1).Aggregate((x,y) => x*y);
        
        static int Fib(int n, int x = 0, int y = 1)
        {
            if (n == 0) return x;

            return Fib(n - 1, y, x + y);
        }

        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                System.Console.WriteLine("You must pass exactly one argument");
                Environment.Exit(-1);
            }

            var n = int.Parse(args[0]);

            System.Console.WriteLine($"Factorial of {n} is {Factorial_recursive(n)}");
            System.Console.WriteLine($"Factorial of {n} is {Factorial_tailRecursive(n)}");
            System.Console.WriteLine($"Factorial of {n} is {Factorial_for(n)}");
            System.Console.WriteLine($"Factorial of {n} is {Factorial_LinqAggregate(n)}");
            System.Console.WriteLine($"Fib {n} : {Fib(8)}");
        }
    }
}
