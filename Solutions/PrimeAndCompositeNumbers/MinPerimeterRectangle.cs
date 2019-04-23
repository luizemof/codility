using System;

namespace Codility.Solutions.PrimeAndCompositeNumbers
{
    // https://app.codility.com/programmers/lessons/10-prime_and_composite_numbers/min_perimeter_rectangle/
    public class MinPerimeterRectangle
    {
        public int Solution(int N)
        {
            double sqrt = Math.Sqrt(N);
            int minPermeter = int.MaxValue;
            for (int i = 1; i <= sqrt; i++)
            {
                if (N % i == 0)
                    minPermeter = Math.Min(minPermeter, 2 * (i + (N / i)));
            }

            return minPermeter;
        }
    }
}