using System;

namespace Codility.Solutions.PrimeAndCompositeNumbers
{

    // https://app.codility.com/programmers/lessons/10-prime_and_composite_numbers/count_factors/
    public class CountFactors
    {
        public int Solution(int N)
        {
            int total = 1;
            double sqrt = Math.Sqrt(N);
            for (int i = 2; i <= sqrt; i++)
            {
                if (N % i == 0)
                    total++;
            }
            
            total *= 2;
            if (((int)sqrt) == sqrt)
                total -= 1;

            return total;
        }
    }
}