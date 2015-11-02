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
            DBH.OpenConnection();
            SqlCommand cmd = new SqlCommand(cmdStr.ToString(), DBH.Connection);
            try
            {
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
            DBH.OpenConnection();
            SqlCommand cmd = new SqlCommand(cmdStr.ToString(), DBH.Connection);
            try { return (int)cmd.ExecuteNonQuery(); }
            catch (Exception ex)
            {
                ErrMsg = ex.Message;
                return -1;
            }
            finally { DBH.Connection.Close(); }
        }

        public object ExecSC(StringBuilder cmdStr, ref string ErrMsg)
        {
            DBH.OpenConnection();
            SqlCommand cmd = new SqlCommand(cmdStr.ToString(), DBH.Connection);
            try { return cmd.ExecuteScalar(); }
            catch (Exception ex)
            {
                ErrMsg = ex.Message;
                return -1;
            }
            finally { DBH.Connection.Close(); }
        }

        private static SqlDataAdapter adapter = new SqlDataAdapter();
        private SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

        public DataSet FillDs(DataSet DS, StringBuilder sqlCommTxt, string TableName, ref string ErrMsg)
        {
            DBH.OpenConnection();
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
            finally { DBH.Connection.Close(); }
        }

        public bool UpdateDBWithDs(ref DataSet DS, ref string ErrMsg, string TableName)
        {
            DBH.OpenConnection();
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
            finally { DBH.Connection.Close(); }
        }
    }
}
