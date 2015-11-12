using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace FishMD.DAL
{
    public class DBOperator
    {
        private DBHelper DBH = new DBHelper();

        public SqlDataReader ReadDB(StringBuilder cmdStr, ref string ErrMsg)
        {
            SqlCommand cmd = new SqlCommand(cmdStr.ToString(), DBH.Connection);
            try
            {
                DBH.OpenConnection();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader != null) { return reader; }
                else
                {
                    ErrMsg = "No data found";
                    return null;
                }
            }
            catch (Exception ex)
            {
                ErrMsg = ex.Message;
                return null;
            }
        }

        public int UpdateDBNQ(StringBuilder cmdStr, ref string ErrMsg)
        {
            SqlCommand cmd = new SqlCommand(cmdStr.ToString(), DBH.Connection);
            try
            {
                DBH.OpenConnection();
                return (int)cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                ErrMsg = ex.Message;
                return -1;
            }
            finally { CloseConn(); }
        }

        public object ExecSC(StringBuilder cmdStr, ref string ErrMsg)
        {
            SqlCommand cmd = new SqlCommand(cmdStr.ToString(), DBH.Connection);
            try
            {
                DBH.OpenConnection();
                return cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                ErrMsg = ex.Message;
                return -1;
            }
            finally { CloseConn(); }
        }

        private static SqlDataAdapter adapter = new SqlDataAdapter();
        private SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

        public DataSet FillDs(DataSet DS, StringBuilder sqlCommTxt, string TableName, ref string ErrMsg)
        {
            adapter.SelectCommand = new SqlCommand(sqlCommTxt.ToString(), DBH.Connection);
            try
            {
                adapter.Fill(DS, TableName);
                return DS;
            }
            catch (Exception ex)
            {
                ErrMsg = ex.Message;
                return null;
            }
            finally { CloseConn(); }
        }

        public DataTable FillDT(DataTable DS, StringBuilder sqlCommTxt, ref string ErrMsg)
        {
            adapter.SelectCommand = new SqlCommand(sqlCommTxt.ToString(), DBH.Connection);
            try
            {
                adapter.Fill(DS);
                return DS;
            }
            catch (Exception ex)
            {
                ErrMsg = ex.Message;
                return null;
            }
            finally { CloseConn(); }
        }

        public bool UpdateDBWithDs(ref DataSet DS, ref string ErrMsg, string TableName)
        {
            try
            {
                builder.GetUpdateCommand();
                adapter.Update(DS, TableName);
                return true;
            }
            catch (Exception ex)
            {
                ErrMsg = ex.Message;
                return false;
            }
            finally { CloseConn(); }
        }

        public void CloseConn() { DBH.Connection.Close(); }
    }
}
