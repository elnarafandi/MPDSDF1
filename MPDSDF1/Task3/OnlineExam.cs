using MPDSDF1.Task1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPDSDF1.Task3
{
    internal class OnlineExam:Exam,IExamSubmission
    {
        public string[] Answers { get; set; }
        public readonly string[] CorrectAnswers = { "B", "A", "C" };

        public override int CalculateScore()
        {
            if(Answers.Length > CorrectAnswers.Length)
            {
                throw new IndexOutOfRangeException("Invalid answer range");
            }
            int sum = 0;
            for(int i = 0; i < Answers.Length; i++)
            {
                if (Answers[i] == CorrectAnswers[i])
                {
                    sum += 5;
                }
            }
            return sum;
        }

        public override void DisplayExam()
        {
            Console.WriteLine("Exam id: "+ExamId+" "+"Exam date: "+ExamDate);
        }

        public void GradeExam(ExamStudent student)
        {
            int grade = CalculateScore();
            Console.WriteLine("Name: "+student.Name+" "+"Grade: "+grade);
        }

        public void SubmitExam(ExamStudent student)
        {
            Console.WriteLine("Online Exam submitted for " +student.Name);
        }
    }
}
