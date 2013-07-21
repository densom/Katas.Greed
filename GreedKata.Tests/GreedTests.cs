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
        public void CalculateScore_AllOnes()
        {
            TestRoll(new[] {1, 1, 1, 1, 1}, 500);
        }
        
        
    }
}
