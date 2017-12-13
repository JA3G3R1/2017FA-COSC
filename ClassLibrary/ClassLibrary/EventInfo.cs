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
        public string Description { get; set; }

        public string Location { get; set; }

        public string Title { get; set; }

        // Set all data from the Event database into the properties

        public void ReadEventData()
        {
            // Create a working connection to the database.
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password = db20;";
            connection.Open();

            // Create a sql command
            SqlCommand readParticipant = connection.CreateCommand();
            readParticipant.CommandText = "select * from Event";
            SqlDataReader reader = readParticipant.ExecuteReader();

            // execute the reader
            while (reader.Read())
            {
                Title = (string)reader["EventName"];
                Location = (string)reader["Location"];
                Description = (string)reader["Description"];
            }
        }
    }
}