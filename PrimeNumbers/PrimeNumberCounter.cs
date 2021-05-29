using System;

namespace PrimeNumbers
{
    public class PrimeNumberCounter
    {
        public int CountPrimeNumbers(int rangeMin, int rangeMax)
        {
            if (rangeMin > rangeMax)
            {
                throw new InvalidOperationException("Min value cannot ve greather than max value");
            }

            if (rangeMax < 0 || rangeMin < 0)
            {
                throw new InvalidOperationException("Values cannot be lower than 0");
            }

            int foundPrimeNumbers = 0;

            for (int i = rangeMin; i < rangeMax; i++)
            {
                if (IsPrime(i))
                {
                    foundPrimeNumbers++;
                }
            }

            return foundPrimeNumbers;
            

            bool IsPrime(int number)
            {
                if (number == 1) return false;

                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0) return false;
                }
                    
                return true;
            }

        }
    }
}