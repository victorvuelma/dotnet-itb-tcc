using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using vitorrdgs.SqlMaster.Helper;

namespace vitorrdgs.SqlMaster.Command
{
    public class sqlInsert : sqlCommand
    {

        private sqlHelperValue _value;
        private bool _output = false;

        public sqlInsert table(String table)
        {
            Table = table;
            return this;
        }

        public sqlHelperValue Value
        {
            get
            {
                if (_value == null)
                    return _value = new sqlHelperValue();
                return _value;
            }
        }

        protected override String generateCommand()
        {
            StringBuilder commandBuilder = new StringBuilder();
            commandBuilder.Append("INSERT INTO ").Append(Table);
            if (_value != null)
                _value.generateInsert(commandBuilder, _output);

            return commandBuilder.ToString();
        }

        private int insert(sqlDatabase db, bool output)
        {
            _output = output;

            SqlCommand cmd = db.getCommand(generateCommand());
            if (_value != null)
                _value.prepare(cmd);

            if (output)
            {
                return Convert.ToInt32(db.executeScalar(cmd));
            }
            else
            {
                return db.execute(cmd);
            }
        }

        public int executeWithOutput(sqlDatabase db) => insert(db, true);

        public int execute(sqlDatabase db) => insert(db, false);

    }
}
