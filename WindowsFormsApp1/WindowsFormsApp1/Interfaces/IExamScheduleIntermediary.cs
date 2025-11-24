using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Interfaces
{
    internal interface IExamScheduleIntermediary
    {
        DataTable SelectExams();
        DataRow GetExamById(int examId);
        string LastError { get; set; }
    }
}
