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
        public void SingleNumberScore_CalculatesIndividualNumberScoreAmountsCorrectly(int numberToTest, int expectedScore)
        {
            var score = Greed.SingleNumberScore(numberToTest);
            Assert.That(score, Is.EqualTo(expectedScore));
        }

        [Test]
        [TestCase(1, 4000)]
        [TestCase(2, 800)]
        [TestCase(3, 1200)]
        [TestCase(4, 1600)]
        [TestCase(5, 2000)]
        public void CalculateScore_AllSameNumber(int numberToTest, int exptectedScore)
        {
            TestRoll(numberToTest.CreateArrayOf(5), exptectedScore);
        }

        [Test]
        [TestCase(new[] { 1, 1, 1, 2, 2 }, 1000)]
        [TestCase(new[] { 2, 2, 2, 3, 3 }, 200)]
        [TestCase(new[] { 3, 3, 3, 2, 2 }, 300)]
        [TestCase(new[] { 4, 4, 4, 2, 2 }, 400)]
        [TestCase(new[] { 5, 5, 5, 2, 2 }, 500)]
        public void CalculateScore_Triples(int[] roll, int expectedScore)
        {
            var score = Greed.CalculateScore(roll);

            Assert.That(score, Is.EqualTo(expectedScore));
        }

        [Test]
        [TestCase(new[] { 1, 1, 1, 5, 1 }, 2050)]
        [TestCase(new[] { 2, 3, 4, 6, 2 }, 0)]
        [TestCase(new[] { 3, 4, 5, 3, 3 }, 350)]
        [TestCase(new[] { 1, 5, 1, 2, 4 }, 250)]
        [TestCase(new[] { 5, 5, 5, 5, 5 }, 2000)]
        public void CalculateScore_ExamplesFromInstructions(int[] numbersToTest, int expectedScore)
        {
            TestRoll(numbersToTest, expectedScore);
        }

        [Test]
        [TestCase(new[] { 1, 1, 1 }, 1, 1)]
        [TestCase(new[] { 2, 2, 2 }, 1, 2)]
        [TestCase(new[] { 2, 2, 2, 1, 1 }, 2, 2)]
        public void GetNumberGroups_ReturnsCorrectNumberOfGroupsWithLargestGroupOnTop(int[] set, int numberOfGroups, int largestGroup)
        {
            var results = Greed.GetNumberGroups(set);

            Assert.That(results.Count(), Is.EqualTo(numberOfGroups));
            Assert.That(results.ToList()[0].Key, Is.EqualTo(largestGroup));
        }

        /* Extra Credit */

        [Test]
        public void CalculateScore_SixDice_FourOfAKind()
        {
            var score = Greed.CalculateScore(new[] {1, 1, 1, 1, 2, 3});

            Assert.That(score, Is.EqualTo(2000));
        }

        [Test]
        public void CalculateScore_SixDice_FiveOfAKind()
        {
            var score = Greed.CalculateScore(new[] { 1, 1, 1, 1, 1, 3 });

            Assert.That(score, Is.EqualTo(4000));
        }

        [Test]
        public void CalculateScore_SixDice_SixOfAKind()
        {
            var score = Greed.CalculateScore(new[] { 1, 1, 1, 1, 1, 1 });

            Assert.That(score, Is.EqualTo(8000));
        }

        [Test]
        public void CalculateScore_SixDice_Straight()
        {
            var score = Greed.CalculateScore(new[] {1, 2, 3, 4, 5, 6});

            Assert.That(score, Is.EqualTo(1200));
        }

    }


}
