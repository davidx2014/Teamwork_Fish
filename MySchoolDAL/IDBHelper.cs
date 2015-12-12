using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace MySchoolDAL
{
    public interface IDBHelper
    {
        SqlConnection Connection { get; }
        void OpenConnection();
        void CloseConnection();
    }
}
