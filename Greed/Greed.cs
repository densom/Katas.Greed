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
            


            return roll.Sum(number => CalculateScoreSingleNumber(number));
        }

        internal static int CalculateScoreSingleNumber(int number)
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

        internal static IEnumerable<IGrouping<int, int>> GetRepeatedNumbers(this int[] numbers)
        {
            var triples = numbers.GroupBy(x => x).OrderByDescending(x => x.Count());

            return triples;
        }
    }
}
