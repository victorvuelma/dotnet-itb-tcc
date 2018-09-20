using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vitorrdgs.SqlMaster
{
    public class sqlCredential
    {

        private string _user;
        private string _pass;

        private string _source;
        private string _database;

        public string User { get => _user; set => _user = value; }
        public string Pass { get => _pass; set => _pass = value; }
        public string Source { get => _source; set => _source = value; }
        public string Database { get => _database; set => _database = value; }

    }
}
