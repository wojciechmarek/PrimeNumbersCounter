using System;
using NUnit.Framework;
using PrimeNumbers;

namespace PrimeNumberCounter.Tests
{
    public class Tests
    {
        [TestCase(1, 10, 4)]
        [TestCase(1, 11, 5)]
        [TestCase(0, 11, 5)]
        [TestCase(2, 2, 1)]
        [TestCase(8, 10, 0)]
        public void PrimeNumbersCounter_CountrsNumbersInTheRange_CorrectAmountOfThePrimeNumbers(int min, int max, int result)
        {
            // arrange
            var primeNumbersCounter = new PrimeNumbers.PrimeNumberCounter();

            // act
            var amount = primeNumbersCounter.CountPrimeNumbers(min, max);
            
            //assert
            Assert.AreEqual(amount, result);
        }
        
        [TestCase(20, 5)]
        [TestCase(-2, 10)]
        [TestCase(2, -10)]
        public void PrimeNumbersCounter_ThrowAnException_ExceptionWhenWrongParameters(int min, int max)
        {
            // arrange
            var primeNumbersCounter = new PrimeNumbers.PrimeNumberCounter();

            // act & assert
            Assert.Throws<InvalidOperationException>(() => primeNumbersCounter.CountPrimeNumbers(min, max));
        }
    }
}