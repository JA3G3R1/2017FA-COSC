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

        // use a method to add the information from the database.
        public void ReadData()
        {
            // Create a working connection to the database.
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password = db20;";
            connection.Open();

            // Create a sql command
            SqlCommand readPaticipants = new SqlCommand("select * from Participants");
            SqlDataReader reader = readPaticipants.ExecuteReader(); 

            // Create a list object to hold the data
            List<Participant> participants = new List<Participant>();

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