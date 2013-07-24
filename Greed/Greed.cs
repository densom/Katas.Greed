using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreedKata
{
    public static class Greed
    {
        public static int CalculateScore(int[] roll)
        {
            var sum = 0;

            foreach (var item in roll.GetNumberGroups())
            {
                switch (item.Count())
                {
                    case 6:
                    case 5:
                        sum += ScoreSetOfFive(item.ToArray());
                        break;
                    case 4:
                        sum += ScoreSetOfFour(item.ToArray());
                        break;
                    case 3:
                        sum += ScoreSetOfTriples(item.ToArray());
                        break;
                    default:
                        sum+= item.Sum(number => SingleNumberScore(number));
                        break;
                }
            }

            return sum;
        }

        private static int ScoreSetOfFive(int[] roll)
        {
            var score = 0;
            var setOf = roll[0];

            score += 4 * ScoreSetOfTriples(roll.Take(3).ToArray());

            var numberOfExtras = roll.Count() - 5;

            var extrasList = new List<int>(numberOfExtras);

            for (var i = 0; i < numberOfExtras; i++)
            {
                extrasList.Add(setOf);
            }

            score += CalculateScore(extrasList.ToArray());

            return score;
        }

        private static int ScoreSetOfFour(int[] roll)
        {
            var score = 0;
            var setOf = roll[0];

            score += 2 * ScoreSetOfTriples(roll.Take(3).ToArray());

            var numberOfExtras = roll.Count() - 4;

            var extrasList = new List<int>(numberOfExtras);

            for (var i = 0; i < numberOfExtras; i++)
            {
                extrasList.Add(setOf);
            }

            score += CalculateScore(extrasList.ToArray());

            return score;
        }

        private static int ScoreSetOfTriples(int[] roll)
        {
            var score = 0;
            var setOf = roll[0];

            switch (setOf)
            {
                case 1:
                    score += 1000;
                    break;
                case 2:
                    score += 200;
                    break;
                case 3:
                    score += 300;
                    break;
                case 4:
                    score += 400;
                    break;
                case 5:
                    score += 500;
                    break;
                case 6:
                    score += 600;
                    break;
            }

            var numberOfExtras = roll.Count() - 3;

            var extrasList = new List<int>(numberOfExtras);

            for (var i = 0; i < numberOfExtras; i++)
            {
                extrasList.Add(setOf);
            }

            score += CalculateScore(extrasList.ToArray());

            return score;
        }

        internal static int SingleNumberScore(int number)
        {
            
            switch (number)
            {
                case 1:
                    return 100;
                case 5:
                    return 50;
                default:
                    return 0;
            }
        }

        internal static IEnumerable<IGrouping<int, int>> GetNumberGroups(this int[] numbers)
        {
            return numbers.GroupBy(x => x).OrderByDescending(x => x.Count());
        }
    }
}
