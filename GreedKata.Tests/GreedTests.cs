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
        [TestCase(1,500)]
        [TestCase(5,250)]
        public void CalculateScore_AllSameNumber(int numberToTest, int exptectedScore)
        {
            TestRoll(numberToTest.CreateArrayOf(5), exptectedScore);
        }
    }
}
