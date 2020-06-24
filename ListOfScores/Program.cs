using System;
using System.Collections.Generic;

namespace ListOfScores
{
    class Program
    {
        static void Main(string[] args)
        {
            var scores = new List<int>();
            scores.Add(42);
            scores.Add(98);
            scores.Add(66);
            scores.Add(5);
            scores.Add(100);

            var fixedScores = scores.ToArray();
            var genericFixedScore = new List<int>(fixedScores);

            var total = 0;
            foreach(var item in scores)
            {
                total += item;
            }
        }
    }
}
