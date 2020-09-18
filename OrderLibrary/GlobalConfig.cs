using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using Dapper;
using OrderLibrary.DataAccess;

namespace OrderLibrary
{
    public enum DatabaseType
    {
        Sql,
        TextFile
    }
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }
        public static void InitializeConnections(DatabaseType db)
        {
            switch (db)
            {

                case DatabaseType.Sql:
                    var sql = new SqlConnector();
                    Connection = sql;
                    break;

                default:
                    break;
            }

        }
        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
