using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreedKata
{
    public class Greed
    {
        public static int CalculateScore(int[] roll)
        {
            return roll.Sum(number => CalculateScoreSingleNumber(number));
        }

        private static int CalculateScoreSingleNumber(int number)
        {
            
            switch (number)
            {
                case 1:
                    return 100;

                default:
                    return 0;
            }
        }
    }
}
