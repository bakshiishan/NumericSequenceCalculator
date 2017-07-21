using NumericSequenceCalculator.Helpers;
using NUnit.Framework;
using System.Web.WebPages;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace NumericSequenceCalculator.Tests.Helpers
{
    [TestFixture]
    class SequenceCalculatorTest
    {

        [TestCase(10, "11, 12")]
        public void GetSequence_Incorrect(int inputValue, string expectedOutput)
        {
            var sequence = SequenceCalculator.GetSequence(inputValue);
            Assert.IsFalse(sequence.Contains(expectedOutput));
        }

        [TestCase(1,"1")]
        [TestCase(10,"1, 2, 3")]
        [TestCase(50,"48, 49, 50")]
        [TestCase(10000,"5555, 5556, 5557")]
        public void GetSequence_Correct(int inputValue, string expectedOutput)
        {
            var sequence = SequenceCalculator.GetSequence(inputValue);
            Assert.IsTrue(sequence.Contains(expectedOutput));
        }

        [TestCase(10, "2, 4", "1, 3")]
        [TestCase(50, "48, 50", "47, 49")]
        [TestCase(10000, "5556, 5558", "5555, 5557")]
        public void GetOddEvenSequence_InCorrect(int inputValue, string expectedOddOutput, string expectedEvenOutput)
        {
            var evenSequence = string.Empty;
            var oddSequence = SequenceCalculator.GetOddEvenSequence(inputValue, out evenSequence);
            Assert.IsFalse(oddSequence.Contains(expectedOddOutput));

            Assert.IsFalse(evenSequence.IsEmpty());

            Assert.IsFalse(evenSequence.Contains(expectedEvenOutput));
        }

        [TestCase(10, "1, 3","2, 4")]
        [TestCase(50, "47, 49", "48, 50")]
        [TestCase(10000, "5555, 5557", "5556, 5558")]
        public void GetOddEvenSequence_Correct(int inputValue, string expectedOddOutput,string expectedEvenOutput)
        {
            var evenSequence = string.Empty;
            var oddSequence = SequenceCalculator.GetOddEvenSequence(inputValue,out evenSequence);
            Assert.IsTrue(oddSequence.Contains(expectedOddOutput));

            Assert.IsFalse(evenSequence.IsEmpty());

            Assert.IsTrue(evenSequence.Contains(expectedEvenOutput));
        }

        [TestCase(10, "2, 3")]
        [TestCase(50, "15, 16")]
        [TestCase(10000, "5556, 5557")]
        public void GetCEZSequence_InCorrect(int inputValue, string expectedCEZOutput)
        {
            var cezSequence = SequenceCalculator.GetCEZSequence(inputValue);
            Assert.IsFalse(cezSequence.Contains(expectedCEZOutput));
        }

        [TestCase(10, "2, C, 4, E")]
        [TestCase(50, "14, Z, 16")]
        [TestCase(10000, "E, C, 5557")]
        public void GetCEZSequence_Correct(int inputValue, string expectedCEZOutput)
        {
            var cezSequence = SequenceCalculator.GetCEZSequence(inputValue);
            Assert.IsTrue(cezSequence.Contains(expectedCEZOutput));
        }

        [TestCase(10, "2, 3, 4, 5")]
        [TestCase(50, "14, 15, 16")]
        [TestCase(10000, "5555, 5556, 5557")]
        public void GetFibonacciSequence_InCorrect(int inputValue, string expectedFibonnaciOutput)
        {
            var fibonnaciSequence = SequenceCalculator.GetFibonaciSeries(inputValue);
            Assert.IsFalse(fibonnaciSequence.Contains(expectedFibonnaciOutput));
        }

        [TestCase(10, "0, 1, 1, 2")]
        [TestCase(10, "3, 5, 8")]
        [TestCase(50, "13, 21, 34")]
        [TestCase(10000, "2584, 4181, 6765")]
        public void GetFibonacciSequence_Correct(int inputValue, string expectedFibonnaciOutput)
        {
            var fibonnaciSequence = SequenceCalculator.GetFibonaciSeries(inputValue);
            Assert.IsTrue(fibonnaciSequence.Contains(expectedFibonnaciOutput));
        }



    }
}
