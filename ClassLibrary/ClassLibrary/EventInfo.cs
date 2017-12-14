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

        public int EventID { get; set; }

        // CW: Set all data from the Event database into the properties
        public void ReadEvenInfotData()
        {
            // Create a working connection to the database.
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password = db20;";
            connection.Open();

            // Create a sql command
            SqlCommand readEventInfo = connection.CreateCommand();
            readEventInfo.CommandText = "select * from Event";
            SqlDataReader reader = readEventInfo.ExecuteReader();

            // execute the reader
            while (reader.Read())
            {
                EventID = (Int32)reader["EventID"];
                Title = (string)reader["EventName"];
                Location = (string)reader["Location"];
                Description = (string)reader["Description"];
            }
        }

        // CW: This method will pull all the event titles for use in the UI
        public List<string> ReadAllEventTitle()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password = db20;";
            connection.Open();

            SqlCommand readEventTitle = connection.CreateCommand();
            readEventTitle.CommandText = "select EventName from Event";
            SqlDataReader reader = readEventTitle.ExecuteReader();
            List<string> Result = new List<string>();
            while (reader.Read())
            {
                Result.Add((string)reader["EventName"]);
            }
            return Result;
        }

        //CW: This method will pull all the event locations for use in UI
        public List<string> ReadAllEventLocation()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password = db20;";
            connection.Open();

            SqlCommand readEventLocation = connection.CreateCommand();
            readEventLocation.CommandText = "select Location from Event";
            SqlDataReader reader = readEventLocation.ExecuteReader();
            List<string> Result = new List<string>();
            while (reader.Read())
            {
                Result.Add((string)reader["Location"]);
            }
            return Result;
        }

        //CW: This method should insert new information into the database for event title,location, and description
        public void AddEventData()
        {
            // Create a working connection to the database.
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password = db20;";
            connection.Open();

            // Create a sql command
            SqlCommand addEventInfo = connection.CreateCommand();
            addEventInfo.CommandText = "insert into Event(EventName, Location, Description) values ('" + Title + "', '" + Location + "', '" + Description + "')";
            //INSERT INTO table_name(column1, column2, column3, ...)
            //VALUES(value1, value2, value3, ...);
            //addEventInfo.Parameters.AddWithValue("EventName", Title);
            //addEventInfo.Parameters.AddWithValue("Location", Location);
            //addEventInfo.Parameters.AddWithValue("Description", Description);

            addEventInfo.ExecuteNonQuery();
        }

        //CW: This method should remove information in the database
        public void DeleteEventData()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password = db20;";
            connection.Open();

            // Create a sql command
            SqlCommand addEventInfo = connection.CreateCommand();
            addEventInfo.CommandText = "delete from Event where EventID = '" + EventID + "';";

            addEventInfo.ExecuteNonQuery();
        }
        //CW: this will ovveride the tostring method for entering in properties
        public EventInfo(string evDescription, string evLocation, string evTitle)
        {
            Description = evDescription;
            Location = evLocation;
            Title = evTitle;
        }

    }
}
       