using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPDSDF1.Task4
{
    internal class OnlineExamSchedule:ExamSchedule
    {
        public string PlatformLink {  get; set; }

        public override void ScheduleExam()
        {
            if(string.IsNullOrWhiteSpace(PlatformLink) || !Uri.IsWellFormedUriString(PlatformLink, UriKind.Absolute))
            {
                throw new ArgumentException("Invalid platform link");
            }
            Console.WriteLine($"Online exam scheduled at {PlatformLink} on {ScheduledDate}");
        }
    }
}
