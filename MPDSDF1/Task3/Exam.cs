using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPDSDF1.Task3
{
    internal abstract class Exam
    {
        public int ExamId {  get; set; }
        public DateTime ExamDate { get; set; }

        public abstract int CalculateScore();
        public abstract void DisplayExam();
    }
}
