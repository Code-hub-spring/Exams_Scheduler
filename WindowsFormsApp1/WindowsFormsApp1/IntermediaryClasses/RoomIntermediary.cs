using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using WindowsFormsApp1.DataClasses;
using WindowsFormsApp1.Interfaces;

namespace WindowsFormsApp1.IntermediaryClasses
{
    public class RoomIntermediary : IRoomIntermediary
    {
        public string LastError { get; set; }
        ExamScheduleDataClass db = new ExamScheduleDataClass();
        // Get Total Rooms
        public int GetCount()
        {
            string queryStr = "SELECT COUNT(*) FROM Rooms;";
            try
            {
                ExamScheduleDataClass db = new ExamScheduleDataClass();
                return Convert.ToInt32(db.ExecScalarQuery(queryStr, CommandType.Text));
            }
            catch (Exception ex)
            {
                LastError = ex.Message;
                return -1;
            }
        }

        // List all rooms
        public DataTable ListRooms()
        {
            try
            {
               
                string query = "SELECT RoomID, RoomNumber, RoomName, Capacity, Available FROM Rooms;"; // where Available=1
                return db.GetTable(query, CommandType.Text);
            }
            catch (Exception ex)
            {
                LastError = ex.Message;
                return null;
            }
        }
        //method overload to get room by availability
        public DataTable ListRooms(bool onlyAvailable)
        {
            string query = "SELECT RoomID, RoomNumber, RoomName, Capacity,Available FROM Rooms";
            if (onlyAvailable)
                query += " WHERE Available = 1";

            return db.GetTable(query, CommandType.Text);
        }

        // Add Room
        public int AddRoom(int roomNumber, string roomName, int roomCapacity)
        {
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
            string q = "SELECT Capacity FROM Rooms WHERE RoomID = @RoomID";
            SqlParameter p = new SqlParameter("@RoomID", SqlDbType.Int) { Value = roomId };
            object result = db.ExecScalarQuery(q, CommandType.Text, p);
            return result == null ? 0 : Convert.ToInt32(result);
        }
        // Mark room availability (requires Rooms.Available BIT column)
        public bool UpdateRoomAvailability(int roomId, bool available)
        {
            string q = "UPDATE Rooms SET Available = @Available WHERE RoomID = @RoomID";
            SqlParameter p1 = new SqlParameter("@Available", available?1:0);
            SqlParameter p2 = new SqlParameter("@RoomID", roomId);

         // return db.ExecNonQuery(q, CommandType.Text, p1, p2); //if return type is int
            return db.ExecNonQuery(q, CommandType.Text, p1, p2) > 0;//if return type is bool
        }
        public int RemoveRoom(int roomNumber)
        {
            throw new NotImplementedException();
        }
    }
}
