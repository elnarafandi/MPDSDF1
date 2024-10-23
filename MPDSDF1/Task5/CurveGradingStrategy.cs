using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPDSDF1.Task5
{
    internal class CurveGradingStrategy : GradingStrategy
    {
        private int[] _classScores;

        public CurveGradingStrategy(int[] classScores)
        {
            _classScores = classScores;
        }
        public override double CalculateFinalScore(int[] answers)
        {
            if (answers == null || answers.Length == 0)
                throw new ArgumentException("Answers cannot be null or empty.");
            int correctAnswers = 0;
            foreach (var answer in answers)
            {
                if (answer < 0 || answer > MaxScore)
                    throw new ArgumentOutOfRangeException("Answer scores must be between 0 and MaxScore");

                if (answer > 0) correctAnswers++;
            }
            double rawScore = (double)correctAnswers / answers.Length * MaxScore;
            double highestScore = GetHighestScore();
            return rawScore + (highestScore - rawScore) * 0.1;
        }
        private double GetHighestScore()
        {
            if (_classScores.Length == 0) return 0;

            double highestScore = _classScores[0];

            for (int i = 1; i < _classScores.Length; i++)
            {
                if (_classScores[i] > highestScore)
                {
                    highestScore = _classScores[i];
                }
            }

            return highestScore;
        }
    }
}
