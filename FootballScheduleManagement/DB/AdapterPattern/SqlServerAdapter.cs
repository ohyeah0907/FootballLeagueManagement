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
    class SqlServerAdapter : IDBHandler
    {
        public SqlServer sqlServer;

        public SqlServerAdapter(SqlServer sqlServer)
        {
            this.sqlServer = sqlServer;
        }
        public int ExcecuteDataNonQuery(DbCommand sqlCommand)
        {
            return sqlServer.ExcecuteDataNonQuery(sqlCommand);
        }

        public DataSet ExcecuteDataQuery(DbCommand sqlCommand)
        {
            return sqlServer.ExcecuteDataQuery(sqlCommand);
        }
    }
}
