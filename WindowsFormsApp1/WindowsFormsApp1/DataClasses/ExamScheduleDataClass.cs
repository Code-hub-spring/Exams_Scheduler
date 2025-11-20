using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Created by Bhagya G
namespace WindowsFormsApp1.DataClasses
{
    internal class ExamScheduleDataClass
    {
        //conn object
        private SqlConnection ESConnection;
        //conn string
        String ESConnectionString = ConfigurationManager.ConnectionStrings["WindowsFormsApp1.Properties.Settings.ExamScheduleDB"].ConnectionString;
        
        private SqlConnection GetConnection()
        {
            //instantiate if null, return connection
            if (ESConnection == null)
            {
                ESConnection = new SqlConnection(ESConnectionString);
            }
            return ESConnection;
        }// GetConnection()

        private void OpenConnection()
        {
            if (ESConnection.State == ConnectionState.Closed)
            {
                ESConnection.Open();
            }
        }

        private void CloseConnection()
        {
            ESConnection.Close();
        }
        private SqlDataReader GetReader (string procNameOrQuery, CommandType cmdType,SqlParameter param1 =null,SqlParameter param2 = null, SqlParameter param3 = null, SqlParameter param4 = null, SqlParameter param5 = null, SqlParameter param6 = null, SqlParameter param7 = null, SqlParameter param8 = null, SqlParameter param9=null, SqlParameter param10=null, SqlParameter param11 = null, SqlParameter param12 = null, SqlParameter param13 = null)
        {
            SqlCommand esSqlCommand =new SqlCommand(procNameOrQuery, this.GetConnection());
            esSqlCommand.CommandType = cmdType; //set the cmd type as incoming cmdtype

            if (param1 != null)
            {
                esSqlCommand.Parameters.Add(param1);
            }
            if (param2 != null)
            {
                esSqlCommand.Parameters.Add(param2);
            }
            if (param3 != null)
            {
                esSqlCommand.Parameters.Add(param3);
            }
            if(param4 != null)
            {  esSqlCommand.Parameters.Add(param4);
            }
            if (param5 != null)
            {
                esSqlCommand.Parameters.Add(param5);
            }
            if( param6 != null)
            { esSqlCommand.Parameters.Add(param6);
            }
            if(param7 != null)
            { esSqlCommand.Parameters.Add(param7);
            }
            if(param8 != null)
            {
                esSqlCommand.Parameters.Add(param8);
            }
            if(param9 != null)
            { esSqlCommand.Parameters.Add(param9);
            }
            if(param10!=null)
            {  esSqlCommand.Parameters.Add(param10);
            }
            if (param11 != null)
            {
                esSqlCommand.Parameters.Add(param11);
            }
            if (param12 != null)
            {
                esSqlCommand.Parameters.Add(param12);
            }
            if (param13 != null)
            {
                esSqlCommand.Parameters.Add(param13);
            }

            try
            {
                this.OpenConnection();//open connection
                return esSqlCommand.ExecuteReader();
            }
            catch (Exception ex) 
                {
                throw ex;
                }
            finally
            {
                esSqlCommand.Dispose();
            }

        }// GetReader()

        public DataTable GetTable(string procNameOrQuery,CommandType cmdType, SqlParameter param1 = null, SqlParameter param2 = null, SqlParameter param3 = null, SqlParameter param4 = null, SqlParameter param5 = null, SqlParameter param6 = null, SqlParameter param7 = null, SqlParameter param8 = null, SqlParameter param9 = null, SqlParameter param10 = null, SqlParameter param11 = null, SqlParameter param12 = null, SqlParameter param13 = null)
        {
            //load the data table
            DataTable datatable = new DataTable();
            SqlDataReader datareader = null;

            try
            {
                //instatiate reader using GetReader Method
                datareader = GetReader(procNameOrQuery, cmdType, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10,param11,param12, param13);
                //load the table with data
                datatable.Load(datareader);
                datareader.Close();
                return datatable;

            }catch(Exception ex) { throw ex; }
       
        }//GetTable()

        public int ExecNonQuery(string procNameOrQuery, CommandType cmdType, SqlParameter param1 = null, SqlParameter param2 = null, SqlParameter param3 = null, SqlParameter param4 = null, SqlParameter param5 = null, SqlParameter param6 = null, SqlParameter param7 = null, SqlParameter param8 = null, SqlParameter param9 = null, SqlParameter param10 = null, SqlParameter param11 = null, SqlParameter param12 = null, SqlParameter param13 = null)
        {

            SqlCommand sqlCommand = new SqlCommand(procNameOrQuery, this.GetConnection());
            sqlCommand.CommandType = cmdType;

            if(param1 != null) sqlCommand.Parameters.Add(param1);
            if(param2!=null) sqlCommand.Parameters.Add(param2);
            if(param3!= null) sqlCommand.Parameters.Add(param3);
            if(param4!=null) sqlCommand.Parameters.Add(param4);
            if(param5!=null) sqlCommand.Parameters.Add(param5);
            if (param6 != null) sqlCommand.Parameters.Add(param6);
            if (param7 != null) sqlCommand.Parameters.Add(param7);
            if (param8 != null) sqlCommand.Parameters.Add(param8);
            if (param9 != null) sqlCommand.Parameters.Add(param9);
            if (param10 != null) sqlCommand.Parameters.Add(param10);
            if (param11 != null) sqlCommand.Parameters.Add(param11);
            if (param12 != null) sqlCommand.Parameters.Add(param12);
            if (param13 != null) sqlCommand.Parameters.Add(param13);

            try
            {
                this.OpenConnection();
                return sqlCommand.ExecuteNonQuery();
            }catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CloseConnection();
                sqlCommand.Dispose();
            }
        }

        public Object ExecScalarQuery(string procNameOrQuery, CommandType commandType, SqlParameter param1 = null, SqlParameter param2 = null, SqlParameter param3 = null, SqlParameter param4 = null, SqlParameter param5 = null, SqlParameter param6 = null, SqlParameter param7 = null, SqlParameter param8 = null, SqlParameter param9 = null, SqlParameter param10 = null, SqlParameter param11 = null, SqlParameter param12 = null, SqlParameter param13 = null)
        {
            SqlCommand sqlCommand = new SqlCommand(procNameOrQuery, this.GetConnection());
            sqlCommand.CommandType = commandType;
            //set params
            if (param1 != null) sqlCommand.Parameters.Add(param1);
            if (param2 != null) sqlCommand.Parameters.Add(param2);
            if (param3 != null) sqlCommand.Parameters.Add(param3);
            if (param4 != null) sqlCommand.Parameters.Add(param4);
            if (param5 != null) sqlCommand.Parameters.Add(param5);
            if (param6 != null) sqlCommand.Parameters.Add(param6);
            if (param7 != null) sqlCommand.Parameters.Add(param7);
            if (param8 != null) sqlCommand.Parameters.Add(param8);
            if (param9 != null) sqlCommand.Parameters.Add(param9);
            if (param10 != null) sqlCommand.Parameters.Add(param10);
            if (param11 != null) sqlCommand.Parameters.Add(param11);
            if (param12 != null) sqlCommand.Parameters.Add(param12);
            if (param13 != null) sqlCommand.Parameters.Add(param13);


            try
            {
                this.OpenConnection();
                return sqlCommand.ExecuteScalar();//executeNonQuery and returns integer


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CloseConnection();
                sqlCommand.Dispose();
            }

        }//ExecScalar Query()

    }
}
