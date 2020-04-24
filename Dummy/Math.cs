using System;

namespace Dummy
{
    public static class Math
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Factorial(int n)
        {
            if (n < 1) throw new ArgumentOutOfRangeException(nameof(n));

            if (n == 1)
                return n;
            else
                return n * Factorial(n - 1);
        }
    }
}
