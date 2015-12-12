using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace MySchoolDAL
{
    public interface IDBOperator
    {
         SqlDataReader ReadDB(StringBuilder cmdStr, ref string ErrMsg);
         int UpdateDBNQ(StringBuilder cmdStr, ref string ErrMsg);
         object ExecSC(StringBuilder cmdStr, ref string ErrMsg);
         DataSet FillDs(DataSet DS, StringBuilder sqlCommTxt, string TableName, ref string ErrMsg);
         DataTable FillDT(DataTable DS, StringBuilder sqlCommTxt, ref string ErrMsg);
         bool UpdateDBWithDs(ref DataSet DS, ref string ErrMsg, string TableName);
         void CloseConn();
    }
}
