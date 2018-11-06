using System;
using vitorrdgs.SqlMaster;

namespace BurgerShack.Common
{
    public class App
    {

        private static string _name = "BurgerShack";

        private static sqlCredential _databaseSqlCredential = new sqlCredential
        {
            Database = AppLocal.DATABASE,
            User = AppLocal.USER,
            Pass = AppLocal.PASS,
            Source = AppLocal.SOURCE,
        };
        private static sqlDatabase _databaseSql = new sqlDatabase
        {
            ExceptionCall = (Exception ex, string error) => { throw ex; },
            Credential = DatabaseSqlCredential
        };

        public static string Name { get => _name; set => _name = value; }

        public static sqlCredential DatabaseSqlCredential { get => _databaseSqlCredential; set => _databaseSqlCredential = value; }
        public static sqlDatabase DatabaseSql { get => _databaseSql; set => _databaseSql = value; }
    }
}
