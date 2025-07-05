using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_system
{
    internal class db
    {
        string connectionString = "Data Source=ADEEL;Initial Catalog=school_mgmt_sytem;Integrated Security=True";

        public string get_db()
        {
            return connectionString;
        }
    }
}
