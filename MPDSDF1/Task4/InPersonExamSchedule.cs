using MPDSDF1.Task1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPDSDF1.Task4
{
    internal class InPersonExamSchedule : ExamSchedule
    {
        public int RoomNumber {  get; set; }
        public override void ScheduleExam()
        {
            if (RoomNumber < 0)
            {
                throw new ArgumentException("Room number can not be negative");
            }
            Console.WriteLine($"In-person exam scheduled in room {RoomNumber} on {ScheduledDate}");
        }

    }
}
