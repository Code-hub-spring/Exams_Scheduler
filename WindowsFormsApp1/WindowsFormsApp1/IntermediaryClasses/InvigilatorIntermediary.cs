using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DataClasses;
using WindowsFormsApp1.Interfaces;

namespace WindowsFormsApp1.IntermediaryClasses
{
    internal class InvigilatorIntermediary : IInvigilatorIntermediary
    {
        public string LastError {  get; set; }
        ExamScheduleDataClass db = new ExamScheduleDataClass();

        public DataTable GetAllInvigilators()
        {
            string sqlString = "Select * from Invigilators;"; 
            try
            {
                return db.GetTable(sqlString, CommandType.Text);
            }
            catch (Exception ex) 
                {
                    LastError = ex.Message;
                return null;
                }
        }// end GetAllInvigilators()
        //method overload to get invigilators by availability
        public DataTable GetAllInvigilators(bool onlyAvailable)
        {
            string query = "SELECT * FROM Invigilators";
            if (onlyAvailable)
                query += " WHERE Available = 1";
            return db.GetTable(query, CommandType.Text);
        }
        // end GetAllInvigilators()

            //insert invigilator data
        public int InsertInvigilator(string name, bool available,string empId)
        {
            string query = "insert into Invigilators (Name, Available,InvigilatorEmpId) values(@name, @available,@empId);";

            SqlParameter param1 = new SqlParameter("@name", SqlDbType.VarChar, 100);
            SqlParameter param2 = new SqlParameter("@available", SqlDbType.Bit);
            SqlParameter param3 = new SqlParameter("@empId", SqlDbType.VarChar, 55);
            param1.Value = name;
            param2.Value = available;
            param3.Value = empId;
            try
            {
                return db.ExecNonQuery(query, CommandType.Text, param1, param2,param3);

            }
            catch (Exception ex)
            {
                LastError = ex.Message;
                return -1;
            }
        }// InsertInvigilator()
        public bool UpdateInvigilatorAvailability(int invigilatorId, bool available)
        {
         
            string q = "UPDATE Invigilators SET Available = @Available WHERE InvigilatorID = @InvigilatorID";
            SqlParameter p1 = new SqlParameter("@Available", available?1:0) ;
            SqlParameter p2 = new SqlParameter("@InvigilatorID", invigilatorId);

            return db.ExecNonQuery(q, CommandType.Text, p1, p2)>0;
        }// end UpdateInvigilatorAvailability
    }
}
