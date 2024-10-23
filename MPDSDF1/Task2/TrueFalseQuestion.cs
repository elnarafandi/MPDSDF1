using MPDSDF1.Task1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPDSDF1.Task2
{
    internal class TrueFalseQuestion : ExamQuestion
    {
        public bool CorrectAnswer { get; set; }
        public override void DisplayQuestion()
        {
            Console.WriteLine(QuestionText+"True/False");
        }

        public override int TotalMark(string answer)
        {
            int sum = 0;
            bool check;
            if (!bool.TryParse(answer, out check))
            {
                throw new WrongFormatException("Answer format is wrong.");
            }
            if (check==CorrectAnswer)
            {
                sum += Marks;
            }
            
            return sum;
        }
    }
}
