using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Data.Sql;

namespace ClassLibrary
{
    public class Event
    {
        public int Capacity { get; set; }

        public bool Status { get; set; }

        public string Type { get; set; }

        public int Date { get; set; }
    }
}