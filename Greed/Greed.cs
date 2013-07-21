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
            int score = 0;

            foreach (var num in roll)
            {
                switch (num)
                {
                    case 1:
                        score += 100;
                        break;
                }
            }
            
            return score;
        }
    }
}
