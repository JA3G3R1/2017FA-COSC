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

        public string Date { get; set; }


        public void ReadEventData()
        {
            // Create a working connection to the database.
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password = db20;";
            connection.Open();

            // Create a sql command
            SqlCommand readEventData = connection.CreateCommand();
            readEventData.CommandText = "select * from Event";
            SqlDataReader reader = readEventData.ExecuteReader();

            // execute the reader
            while (reader.Read())
            {
                Capacity = (Int32)reader["Capacity"];
                Status = (Boolean)reader["Status"];
                Type = (string)reader["Category"];
                Date = (string)reader["Date"];           

            }
        }


        //CW: this will pull all dates for use in UI
        public List<string> ReadEventDate()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password = db20;";
            connection.Open();

            SqlCommand readEventDate = connection.CreateCommand();
            readEventDate.CommandText = "select Date from Event";
            SqlDataReader reader = readEventDate.ExecuteReader();
            List<string> Result = new List<string>();
            while (reader.Read())
            {
                Result.Add((string)reader["Date"]);
            }
            return Result;
        }

        //CW: The goal of this method is to convert the input to a string
    }
}