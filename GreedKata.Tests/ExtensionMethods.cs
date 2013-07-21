using System.Collections.Generic;

namespace GreedKata.Tests
{
    public static class ExtensionMethods
    {
        public static int[] CreateArrayOf(this int numberToRepeat, int repeatTimes)
        {
            var ints = new List<int>(repeatTimes);

            for (int i = 0; i < repeatTimes; i++)
            {
                ints.Add(numberToRepeat);
            }

            return ints.ToArray();
        }
         
    }
}