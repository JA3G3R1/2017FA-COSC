using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Data.Sql;

namespace ClassLibrary
{
    public class EventInfo : Event
    {
        public string Description
        {
            get => default(int);
            set
            {
            }
        }

        public string Location
        {
            get => default(int);
            set
            {
            }
        }

        public string Title
        {
            get => default(int);
            set
            {
            }
        }
    }
}