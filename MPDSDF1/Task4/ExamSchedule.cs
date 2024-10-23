using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPDSDF1.Task4
{
    internal abstract class ExamSchedule
    {
        public int ExamId {  get; set; }
        public DateTime ScheduledDate {  get; set; }
        public abstract void ScheduleExam();
    }
}
