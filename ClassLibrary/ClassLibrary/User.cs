﻿using System;
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

        // use a method to add the information from the database.
        // This method will pull all last names and store them in a list object
        public List<string> ReadAllFirstNames()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password = db20;";
            connection.Open();

            SqlCommand readUserFirst = connection.CreateCommand();
            readUserFirst.CommandText = "select FirstName from Participant";
            SqlDataReader reader = readUserFirst.ExecuteReader();
            List<string> Result = new List<string>();
            while (reader.Read())
            {
                Result.Add((string)reader["FirstName"]);            
            }
            return Result;
        }
        // This method will pull all last names and store them in a list object
        public List<string> ReadAllLastNames()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password = db20;";
            connection.Open();

            SqlCommand readUserLast = connection.CreateCommand();
            readUserLast.CommandText = "select LastName from Participant";
            SqlDataReader reader = readUserLast.ExecuteReader();
            List<string> Result = new List<string>();
            while (reader.Read())
            {
                Result.Add((string)reader["LastName"]);
            }
            return Result;
        }

        // Im going to try and create an item that will produce "Firstname, Lastname" for UI
        public List<string> ReadAllFirstLastNames()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password = db20;";
            connection.Open();

            SqlCommand readUserName = connection.CreateCommand();
            readUserName.CommandText = "select * from Participant";
            SqlDataReader reader = readUserName.ExecuteReader();
            List<string> Result = new List<string>();
            while (reader.Read())
            {
                Result.Add((string)reader["FirstName"] + ", " + (string)reader["LastName"]);
            }
            return Result;
        }
        public void ReadData()
        {
            // Create a working connection to the database.
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password = db20;";
            connection.Open();

            // Create a sql command
            // SqlCommand readParticipants = new SqlCommand("select * from Participants");

            SqlCommand readParticipant = connection.CreateCommand();
            readParticipant.CommandText = "select * from Participant where UserID = 1001";
            SqlDataReader reader = readParticipant.ExecuteReader(); 


            // Create a list object to hold the data
            // List<Participant> participants = new List<Participant>();

            while (reader.Read())
            {
               // We can instantiate a Participant object in the participants class
               // Participant p = new Participant();
                ID = (Int32) reader["UserID"];
                FirstName = (string) reader["FirstName"];
                LastName = (string)reader["LastName"];
                Age = (Int32)reader["Age"]; 
            }

        }
    }
}