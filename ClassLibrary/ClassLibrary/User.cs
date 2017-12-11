using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Data.Sql;

namespace ClassLibrary
{
    public class User
    {
        public int Age { get; set; }
        public int ID { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }
    }
}