using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Enums;
using static WindowsFormsApp1.Enums.EnumData;

//created By Bhagya G
namespace WindowsFormsApp1.Models
{
       public class Exam
        {
        public int CourseID { get; set; }
        public String ExamTitle {  get; set; }
        public String CourseName {  get; set; }
        public int RoomID { get; set; }
            public int InvigilatorID { get; set; }
            public string InvigilatorName { get; set; }
            public DateTime ExamDateTime { get; set; }
            public DateTime ExamStartTime { get; set; }
            public DateTime ExamEndTime { get; set; }
            public int DurationMinutes { get; set; }
            public bool SpecialPermission { get; set; }
            public string SpecialStudentName {  get; set; }
            public decimal ExtraHours {  get; set; }

        }
    }
