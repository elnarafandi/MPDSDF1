using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPDSDF1.Task5
{
    internal class StandardGradingStrategy : GradingStrategy
    {
        public override double CalculateFinalScore(int[] answers)
        {
            if (answers == null || answers.Length == 0)
                throw new ArgumentException("Answers cannot be null or empty.");
            int correctAnswers = 0;
            foreach (var answer in answers)
            {
                if (answer > 0) correctAnswers++;
            }

            return (double)correctAnswers / answers.Length * MaxScore;

        }
    }
}
