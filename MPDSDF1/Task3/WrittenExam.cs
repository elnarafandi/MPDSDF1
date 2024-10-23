using MPDSDF1.Task1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPDSDF1.Task3
{
    internal class WrittenExam:Exam,IExamSubmission
    {
        public string AnswerSheet { get; set; }

        public override int CalculateScore()
        {
            Console.WriteLine("Please enter written exam scor");
            int score=int.Parse(Console.ReadLine());
            return score;
        }

        public override void DisplayExam()
        {
            Console.WriteLine("Exam id: " + ExamId + " " + "Exam date: " + ExamDate);
        }

        public void GradeExam(ExamStudent student)
        {
            int grade = CalculateScore();
            Console.WriteLine("Name: " + student.Name + " " + "Grade: " + grade);
        }

        public void SubmitExam(ExamStudent student)
        {
            Console.WriteLine("Online Exam submitted for " + student.Name);
        }
    }
}
