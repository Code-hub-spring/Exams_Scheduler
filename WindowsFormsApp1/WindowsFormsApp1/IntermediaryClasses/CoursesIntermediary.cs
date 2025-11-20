using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DataClasses;

//created by Bhagya G
namespace WindowsFormsApp1.IntermediaryClasses
{
   
    internal class CoursesIntermediary
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

        // Add Room
        public int AddRoom(int roomNumber, string roomName, int roomCapacity)
        {
            ExamScheduleDataClass db = new ExamScheduleDataClass();

            string sqlQuery =
                "INSERT INTO Rooms (RoomNumber, RoomName, Capacity) " +
                "VALUES (@roomNumber, @roomName, @roomCapacity);";

            SqlParameter p1 = new SqlParameter("@roomNumber", SqlDbType.Int);
            SqlParameter p2 = new SqlParameter("@roomName", SqlDbType.VarChar);
            SqlParameter p3 = new SqlParameter("@roomCapacity", SqlDbType.Int);

            p1.Value = roomNumber;
            p2.Value = roomName;
            p3.Value = roomCapacity;

            try
            {
                return db.ExecNonQuery(sqlQuery, CommandType.Text, p1, p2, p3);
            }
            catch (Exception ex)
            {
                LastError = ex.Message;
                return -1;
            }
        }//end AddRoom()

        //get room capacity
        public int GetRoomCapacity(int roomId)
        {
            ExamScheduleDataClass db = new ExamScheduleDataClass();
            string q = "SELECT Capacity FROM Rooms WHERE RoomID = @RoomID";

            SqlParameter p = new SqlParameter("@RoomID", SqlDbType.Int) { Value = roomId };

            object result = db.ExecScalarQuery(q, CommandType.Text, p);
            return result == null ? 0 : Convert.ToInt32(result);
        }

        // Mark room availability (requires Rooms.Available BIT column)
        public int UpdateRoomAvailability(int roomId, bool available)
        {
            ExamScheduleDataClass db = new ExamScheduleDataClass();
            string q = "UPDATE Rooms SET Available = @Available WHERE RoomID = @RoomID";

            SqlParameter p1 = new SqlParameter("@Available", SqlDbType.Bit) { Value = available };
            SqlParameter p2 = new SqlParameter("@RoomID", SqlDbType.Int) { Value = roomId };

            return db.ExecNonQuery(q, CommandType.Text, p1, p2);
        }
    }
}
