using MPDSDF1.Task1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPDSDF1.Task3
{
    internal interface IExamSubmission
    {
        void SubmitExam (ExamStudent student);
        void GradeExam (ExamStudent student);
    }
}
