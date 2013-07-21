using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace GreedKata.Tests
{
    [TestFixture]
    public class GreedTests
    {
        private static void TestRoll(int[] roll, int expectedScore)
        {
            var score = Greed.CalculateScore(roll);

            Assert.That(score, Is.EqualTo(expectedScore));
        }

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
        public void CalculateScore_AllTwos()
        {
            TestRoll(2.CreateArrayOf(5), 0);
        }
    }
}
