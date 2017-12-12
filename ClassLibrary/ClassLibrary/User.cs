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
        // CW: I plan on using an array to take the data from the Psrticipants table and store it into the 
        // user Age,ID,LastName,Firstname
        public int Age { get; set; }
        public int ID { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }
        
    }
}