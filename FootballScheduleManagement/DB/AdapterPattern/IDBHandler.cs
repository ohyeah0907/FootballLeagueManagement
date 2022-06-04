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
    public interface IDBHandler
    {
        DataSet ExcecuteDataQuery(DbCommand sqlCommand);
        int ExcecuteDataNonQuery(DbCommand sqlCommand);
    }
}
