using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DataClasses;
using WindowsFormsApp1.Interfaces;

//created by Bhagya G
namespace WindowsFormsApp1.IntermediaryClasses
{
   
    internal class CoursesIntermediary:ICourseIntermediary
    {
        public string LastError { get; set; }
        public DataTable ListCourses()
        {
            try
            {
                ExamScheduleDataClass db = new ExamScheduleDataClass();
                string query = "SELECT CourseID, CourseName,CourseNumber FROM Courses;";// where Available=True
                return db.GetTable(query, CommandType.Text);
            }
            catch (Exception ex)
            {
                LastError = ex.Message;
                return null;
            }
        }
    }
}
