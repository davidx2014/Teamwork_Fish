using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Configuration;

namespace FishMD.DAL
{
    struct DBHelper
    {
        // 数据库连接字符串
        private string connString;

        // 数据库连接 Connection 对象
        private SqlConnection connection;

        /// <summary>
        /// Connection对象
        /// </summary>
        public SqlConnection Connection
        {
            get
            {
                if (connection == null)
                {
                    connString = ConfigurationManager.ConnectionStrings["DBConnectionStr"].ToString();
                    connection = new SqlConnection(connString);
                }
                return connection;
            }
        }

        /// <summary>
        /// 打开数据库连接
        /// </summary>
        public void OpenConnection()
        {
            if (Connection.State == ConnectionState.Closed)
            {
                Connection.Open();
            }
            else if (Connection.State == ConnectionState.Broken)
            {
                Connection.Close();
                Connection.Open();
            }
        }
    }
}
