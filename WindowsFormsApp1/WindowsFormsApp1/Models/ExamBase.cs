using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Enums;

//created By Bhagya G
namespace WindowsFormsApp1.Models
{
    public class ExamBase
    {
        public int CourseID { get; set; }
        public string ExamTitle { get; set; }
        public string ExamType { get; set; }
        public DateTime ExamDateTime { get; set; }
        public DateTime ExamStartTime { get; set; }
        public DateTime ExamEndTime { get; set; }
        public int DurationMinutes { get; set; }
        public bool SpecialPermission { get; set; }
        public string SpecialStudentName { get; set; }
        public decimal ExtraHours { get; set; }

        //declare the override function


        public TimeSpan CalculateDuration(DateTime startTime, DateTime endTime)
        {
            return endTime - startTime;
          
        }

    }
}
