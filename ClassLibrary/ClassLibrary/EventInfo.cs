﻿using System;
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

        // CW: Set all data from the Event database into the properties
        public void ReadEvenInfotData()
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

        // CW: This method will pull all the event titles for use in the UI
        public List<string> ReadAllEventTitle()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password = db20;";
            connection.Open();

            SqlCommand readParticipant = connection.CreateCommand();
            readParticipant.CommandText = "select EventName from Event";
            SqlDataReader reader = readParticipant.ExecuteReader();
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

            SqlCommand readParticipant = connection.CreateCommand();
            readParticipant.CommandText = "select Location from Event";
            SqlDataReader reader = readParticipant.ExecuteReader();
            List<string> Result = new List<string>();
            while (reader.Read())
            {
                Result.Add((string)reader["Location"]);
            }
            return Result;
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