using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPDSDF1.Task2
{
    internal abstract class ExamQuestion
    {
        public int QuestionId {  get; set; }
        public string QuestionText {  get; set; }
        public int Marks { get; set; }
        public abstract void DisplayQuestion();
        public abstract int TotalMark(string answer);
        
    }
}
