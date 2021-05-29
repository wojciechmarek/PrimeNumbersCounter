using NUnit.Framework;
using PrimeNumbers;

namespace PrimeNumberCounter.Tests
{
    public class Tests
    {
        [Test]
        public void PrimeNumbersCounter_CountrsNumbersInTheRange_CorrectAmountOfThePrimeNumbers()
        {
            // arrange
            var primeNumbersCounter = new PrimeNumbers.PrimeNumberCounter();

            // act
            var amount = primeNumbersCounter.CountPrimeNumbers(1, 10);
            
            //assert
            Assert.AreEqual(amount, 4);

        }
    }
}