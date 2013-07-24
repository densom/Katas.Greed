using NUnit.Framework;
using System.Linq;

namespace GreedKata.Tests
{
    [TestFixture]
    public class GreedTests
    {
        #region Helper Methods
        private static void TestRoll(int[] roll, int expectedScore)
        {
            var score = Greed.CalculateScore(roll);

            Assert.That(score, Is.EqualTo(expectedScore));
        }
        #endregion


        [Test]
        [TestCase(1, 100)]
        [TestCase(2, 0)]
        [TestCase(3, 0)]
        [TestCase(4, 0)]
        [TestCase(5, 50)]
        [TestCase(6, 0)]
        public void CalculateSingleNumber(int numberToTest, int expectedScore)
        {
            var score = Greed.CalculateScoreSingleNumbers(numberToTest);
            Assert.That(score, Is.EqualTo(expectedScore));
        }

        [Test]
        [TestCase(1, 1200)]
        [TestCase(5, 600)]
        public void CalculateScore_AllSameNumber(int numberToTest, int exptectedScore)
        {
            TestRoll(numberToTest.CreateArrayOf(5), exptectedScore);
        }

        [Test]
        public void CalculateScore_AllOnes()
        {
            var score = Greed.CalculateScore(new[] {1, 1, 1, 1, 1,});
            Assert.That(score, Is.EqualTo(1200));
        }

        [Test]
        public void CalculateScore_Triples()
        {
            var score = Greed.CalculateScore(new[] { 1, 1, 1, 2, 2 });

            Assert.That(score, Is.EqualTo(1000));
        }

        [Test]
        [TestCase(new[] { 1, 1, 1, 5, 1 }, 1150)]
        [TestCase(new[] { 2, 3, 4, 6, 2 }, 0)]
        [TestCase(new[] { 3, 4, 5, 3, 3 }, 350)]
        [TestCase(new[] { 1, 5, 1, 2, 4 }, 250)]
        [TestCase(new[] { 5, 5, 5, 5, 5 }, 600)]
        public void CalculateScore_ExamplesFromInstructions(int[] numbersToTest, int expectedScore)
        {
            TestRoll(numbersToTest, expectedScore);
        }

        [Test]
        [TestCase(new[] { 1, 1, 1 }, 1, 1)]
        [TestCase(new[] { 2, 2, 2 }, 1, 2)]
        [TestCase(new[] { 2, 2, 2, 1, 1 }, 2, 2)]
        public void GetRepeatedNumbers(int[] set, int numberOfGroups, int largestGroup)
        {
            var results = Greed.GetRepeatedNumbers(set);

            Assert.That(results.Count(), Is.EqualTo(numberOfGroups));
            Assert.That(results.ToList()[0].Key, Is.EqualTo(largestGroup));
        }

    }


}
