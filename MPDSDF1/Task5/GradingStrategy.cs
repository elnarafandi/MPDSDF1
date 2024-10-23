using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPDSDF1.Task5
{
    internal abstract class GradingStrategy
    {
        public int MaxScore { get; set; } = 100;
        public abstract double CalculateFinalScore(int[] answers);
        
    }
}
