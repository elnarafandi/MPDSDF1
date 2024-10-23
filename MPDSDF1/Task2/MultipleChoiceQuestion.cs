using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPDSDF1.Task2
{
    internal class MultipleChoiceQuestion:ExamQuestion
    {
        public string[] Options { get; set; }
        public int CorrectOption { get; set; }
        public override void DisplayQuestion()
        {
            Console.WriteLine(QuestionText+" "+string.Join(" ", Options));
        }

        public override int TotalMark(string answer)
        {
            int sum = 0;
            int index = answer.ToUpper()[0] - 'A';
            
            if (index == CorrectOption)
            {
                    sum += Marks;
            }
            

            return sum;
        }
    }
}
