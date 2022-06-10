using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballScheduleManagement.DB.AdapterPattern
{
    //Adapter pattern
    class MySqlAdapter : IDBHandler
    {
        private MySqlServer mySql;

        public MySqlAdapter(MySqlServer mySql)
        {
            this.mySql = mySql;
        }
        public int ExcecuteDataNonQuery(DbCommand sqlCommand)
        {
            return mySql.ExcecuteDataNonQuery(sqlCommand);
        }

        public DataSet ExcecuteDataQuery(DbCommand sqlCommand)
        {
            return mySql.ExcecuteDataQuery(sqlCommand);
        }
    }
}
