using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DataClasses;

namespace WindowsFormsApp1.IntermediaryClasses
{
    internal class InvigilatorIntermediary
    {
        public string LastError {  get; set; }

        public DataTable GetAllInvigilators()
        {
            ExamScheduleDataClass examScheduleDataClass = new ExamScheduleDataClass();
            string sqlString = "Select * from Invigilators ";//where Available=True;
            try
            {
                return examScheduleDataClass.GetTable(sqlString, CommandType.Text);
            }
            catch (Exception ex) 
                {
                    LastError = ex.Message;
                return null;
                }
        }

        //insert invigilator data
        public int InsertInvigilator(string name, bool available,string empId)
        {
            ExamScheduleDataClass examScheduleDataClass = new ExamScheduleDataClass();
            string query = "insert into Invigilators (Name, Available,InvigilatorEmpId) values(@name, @available,@empId);";

            SqlParameter param1 = new SqlParameter("@name", SqlDbType.VarChar, 100);
            SqlParameter param2 = new SqlParameter("@available", SqlDbType.Bit);
            SqlParameter param3 = new SqlParameter("@empId", SqlDbType.VarChar, 55);

            param1.Value = name;
            param2.Value = available;
            param3.Value = empId;

            try
            {
                return examScheduleDataClass.ExecNonQuery(query, CommandType.Text, param1, param2,param3);

            }
            catch (Exception ex)
            {
                LastError = ex.Message;
                return -1;
            }
        }// InsertInvigilator()
        public int UpdateInvigilatorAvailability(int invigilatorId, bool available)
        {
            ExamScheduleDataClass db = new ExamScheduleDataClass();
            string q = "UPDATE Invigilators SET Available = @Available WHERE InvigilatorID = @InvigilatorID";

            SqlParameter p1 = new SqlParameter("@Available", SqlDbType.Bit) { Value = available };
            SqlParameter p2 = new SqlParameter("@InvigilatorID", SqlDbType.Int) { Value = invigilatorId };

            return db.ExecNonQuery(q, CommandType.Text, p1, p2);
        }

    }
}
