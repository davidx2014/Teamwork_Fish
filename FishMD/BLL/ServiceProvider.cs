using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FishMD.DAL;

namespace FishMD.BLL
{
    public class ServiceProvider
    {
        private static DBOperator DBOP = new DBOperator();

        public class FishService
        {
            public List<Fish> GetAllFish()
            {

            }
        }
    }
}
