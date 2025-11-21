using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DataClasses;
using WindowsFormsApp1.Models;

//Created by Bhagya G
namespace WindowsFormsApp1.IntermediaryClasses
{
    internal class ExamScheduleInterMediarycs
    {
            public string LastError { get; set; }

           //  SELECT ALL EXAMS
            public DataTable SelectExams()
            {
                try
                {
                    ExamScheduleDataClass db = new ExamScheduleDataClass();
                    string query = @"
     SELECT 
                E.ExamID,
                E.CourseName,
                E.CourseID,
               C.CourseNumber, 
                R.RoomName,
                I.Name AS InvigilatorName,
                I.InvigilatorEmpID AS InvigilatorEmpID,
                E.ExamDate,
                E.ExamStartTime,
                E.ExamEndTime,
                E.DurationMinutes,
                E.SpecialNeeds,
                E.SpecialStudentName,
                E.ExtraHours,
                E.ExamTitle
            FROM Exams E
             LEFT JOIN Courses C
                ON  E.CourseID =C.CourseID
            LEFT JOIN Rooms R 
                ON E.RoomID = R.RoomID
            LEFT JOIN Invigilators I
                ON E.InvigilatorID = I.InvigilatorID
           
            ORDER BY E.ExamDate DESC;
            ";
                return db.GetTable(query, CommandType.Text);
                }
                catch (Exception ex)
                {
                    LastError = ex.Message;
                    return null;
                }
            }

            // ==========================================
            //  INSERT EXAM
            // ==========================================
            public int InsertExam(Exam exam)
            {
                ExamScheduleDataClass db = new ExamScheduleDataClass();

                string query = @"INSERT INTO Exams
                             (CourseID, RoomID, InvigilatorID, ExamDate, ExamStartTime, ExamEndTime, DurationMinutes, SpecialNeeds,SpecialStudentName,ExtraHours,CourseName,ExamTitle)
                             VALUES
                             (@CourseID, @RoomID, @InvigilatorID, @ExamDate, @ExamStartTime,@ExamEndTime, @DurationMinutes, @SpecialNeeds, @SpecialStudentName, @ExtraHours,@CourseName,@ExamTitle)";

                try
                {
                    return db.ExecNonQuery(query, CommandType.Text,
                    new SqlParameter("@CourseID", exam.CourseID),
                    new SqlParameter("@RoomID", exam.RoomID),
                    new SqlParameter("@InvigilatorID", exam.InvigilatorID),
                    new SqlParameter("@ExamDate", exam.ExamDateTime.Date),
                    new SqlParameter("@ExamStartTime", exam.ExamStartTime.TimeOfDay),
                    new SqlParameter("@ExamEndTime", exam.ExamEndTime.TimeOfDay),
                    new SqlParameter("@DurationMinutes", exam.DurationMinutes),
                    new SqlParameter("@SpecialNeeds", exam.SpecialPermission),
                    new SqlParameter("@SpecialStudentName", exam.SpecialStudentName ?? (object)DBNull.Value),
                    new SqlParameter("@ExtraHours", exam.ExtraHours),
                    new SqlParameter("@CourseName", exam.CourseName),
                    new SqlParameter("@ExamTitle", exam.ExamTitle));
            }
                catch (Exception ex)
                {
                    LastError = ex.Message;
                    return -1;
                }
            }

        // ==========================================
        //  UPDATE EXAM
        // ==========================================
        public int UpdateExam(Exam exam, int examID)
        {
            ExamScheduleDataClass db = new ExamScheduleDataClass();

            string query = @"UPDATE Exams SET
                     CourseID = @CourseID,
                     RoomID = @RoomID,
                     InvigilatorID = @InvigilatorID,
                     ExamDate = @ExamDate,
                     ExamStartTime = @ExamStartTime,
                     ExamEndTime = @ExamEndTime,
                     SpecialStudentName= @SpecialStudentName,
                        ExtraHours = @ExtraHours,
                     DurationMinutes = @DurationMinutes,
                     SpecialNeeds = @SpecialNeeds
                     WHERE ExamID = @ExamID";

            // Use individual parameters (NOT array)
            SqlParameter p1 = new SqlParameter("@CourseID", exam.CourseID);
            SqlParameter p2 = new SqlParameter("@RoomID", exam.RoomID);
            SqlParameter p3 = new SqlParameter("@InvigilatorID", exam.InvigilatorID);
            SqlParameter p4 = new SqlParameter("@ExamDate", exam.ExamDateTime.Date);
            SqlParameter p5 = new SqlParameter("@ExamStartTime", exam.ExamStartTime.TimeOfDay);
            SqlParameter p6 = new SqlParameter("@DurationMinutes", exam.DurationMinutes);
            SqlParameter p7 = new SqlParameter("@SpecialNeeds", exam.SpecialPermission);
            SqlParameter p8 = new SqlParameter("@ExamID", examID);
            SqlParameter p9 =new SqlParameter("@ExamEndTime", exam.ExamEndTime.TimeOfDay);
            SqlParameter p10 = new SqlParameter("@SpecialStudentName", exam.SpecialStudentName ?? (object)DBNull.Value);
            SqlParameter p11 = new SqlParameter("@ExtraHours", exam.ExtraHours);    


            try
            {
                // FIX → pass parameters individually
                return db.ExecNonQuery(query, CommandType.Text, p1, p2, p3, p4, p5, p6, p7, p8,p9,p10,p11);
            }
            catch (Exception ex)
            {
                LastError = ex.Message;
                return -1;
            }
        }

     // Delete exam
        public int DeleteExam(int examID)
            {
                ExamScheduleDataClass db = new ExamScheduleDataClass();

                string query = "DELETE FROM Exams WHERE ExamID = @ExamID";

                SqlParameter p1 = new SqlParameter("@ExamID", SqlDbType.Int);
                p1.Value = examID;

                try
                {
                    return db.ExecNonQuery(query, CommandType.Text, p1);
                }
                catch (Exception ex)
                {
                    LastError = ex.Message;
                    return -1;
                }
            }

        //get Exam by Id
        public DataRow GetExamById(int examId)
        {
            ExamScheduleDataClass db = new ExamScheduleDataClass();
            string q = @"
         SELECT e.ExamID, e.RoomID, e.InvigilatorID,
               e.CourseID,
               r.RoomName,
               c.CourseName,
               c.CourseNumber, 
               i.Name,
               e.ExamDate,
               e.SpecialNeeds,
               e.SpecialStudentName,
               e.ExtraHours,
               e.ExamStartTime,
               e.ExamEndTime
        FROM Exams e
        JOIN Rooms r ON e.RoomID = r.RoomID
        JOIN Courses c ON e.CourseID = c.CourseID
        JOIN Invigilators i ON e.InvigilatorID = i.InvigilatorID
        WHERE e.ExamID = @ExamID;";

            SqlParameter p = new SqlParameter("@ExamID", examId);
            DataTable dt = db.GetTable(q, CommandType.Text, p);

            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
           
        }
        
        public DataTable SelectExamIDs()
        {
            ExamScheduleDataClass db = new ExamScheduleDataClass();
            string q = "SELECT ExamID,ExamTitle FROM Exams ORDER BY ExamID DESC";
            return db.GetTable(q, CommandType.Text);
        }
    }
    }
