using MySchoolDAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FishBLL
{
    public class ServiceProvider
    {
        private static DBOperator DBOP = new DBOperator();

        public class FishService
        {
            public List<Fish> GetAllFish()
            {
                string ErrMsg = string.Empty;
                StringBuilder sql = new StringBuilder("Select * from Fish");
                SqlDataReader reader = DBOP.ReadDB(sql, ref ErrMsg);
                if (ErrMsg.Equals(string.Empty))
                {
                    List<Fish> tmp = new List<Fish>();
                    while (reader.Read())
                    {
                        Fish f0 = new Fish();
                        f0.FishID = Convert.ToInt32(reader["FishID"]);
                        f0.FishName = reader["FishName"].ToString();
                        f0.FishType = reader["FishType"].ToString();
                        f0.FishInfoRoot = reader["FishInfoRoot"].ToString();
                        f0.InfoPicture = reader["InfoPicture"].ToString();
                        f0.InfoIntroduction = reader["InfoIntroduction"].ToString();
                        f0.InfoDisease = reader["InfoDisease"].ToString();
                        f0.InfoRaise = reader["InfoRaise"].ToString();
                        f0.InfoAllInfo = reader["InfoAllInfo"].ToString();
                        tmp.Add(f0);
                    }
                    return tmp;
                }
                else
                {
                    reader.Close();
                    DBOP.CloseConn();
                    MessageBox.Show("Error GetAllFish()", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }
    }
}
