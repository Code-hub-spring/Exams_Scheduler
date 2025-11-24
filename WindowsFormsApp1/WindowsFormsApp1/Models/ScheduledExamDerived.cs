using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    internal class ScheduledExamDerived: ExamBase
    {
        public string CourseName { get; set; }
        public int RoomID { get; set; }
        public string RoomName { get; set; }
        public int InvigilatorID { get; set; }
        public string InvigilatorName { get; set; }

      
        public override string ToString()
        {
            return $"{CourseName} - {ExamTitle} on {ExamDateTime.ToShortDateString()} from {ExamStartTime.ToShortTimeString()} to {ExamEndTime.ToShortTimeString()} in Room: {RoomName} (ID: {RoomID}), Invigilator: {InvigilatorName} (ID: {InvigilatorID})";
        }

        //call the overload method to calculate duration with extra hr
        public TimeSpan CalculateDuration(DateTime startTime, DateTime endTime,double ExtraHours)
        {
           TimeSpan baseDuration = base.CalculateDuration(startTime, endTime);
           TimeSpan extra = TimeSpan.FromHours(ExtraHours);
            //  TimeSpan duration = TimeSpan.FromMinutes(totalMinutes);
            return baseDuration + extra;
        }
    
    }
}
