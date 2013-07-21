using NUnit.Framework;

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
            var score = Greed.CalculateScoreSingleNumber(numberToTest);
            Assert.That(score, Is.EqualTo(expectedScore));
        }

        [Test]
        [TestCase(1, 500)]
        [TestCase(5, 250)]
        public void CalculateScore_AllSameNumber(int numberToTest, int exptectedScore)
        {
            TestRoll(numberToTest.CreateArrayOf(5), exptectedScore);
        }

        [Test]
        [TestCase(new[] { 1, 1, 1, 5, 1 }, 1150, Ignore = true)]
        [TestCase(new[] { 2, 3, 4, 6, 2 }, 0)]
        [TestCase(new[] { 3, 4, 5, 3, 3 }, 350, Ignore = true)]
        [TestCase(new[] { 1, 5, 1, 2, 4 }, 250)]
        [TestCase(new[] { 5, 5, 5, 5, 5 }, 600, Ignore = true)]
        public void CalculateScore_ExamplesFromInstructions(int[] numbersToTest, int expectedScore)
        {
            TestRoll(numbersToTest, expectedScore);
        }
    }


}
