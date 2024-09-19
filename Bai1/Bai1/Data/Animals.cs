﻿using Bai1.Business;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1.Data
{
    public class Animals
    {
        private string connectionString = "Data Source=HP/HPCENTER;Initial Catalog=Farm;Integrated Security=True;";

        public void Add(Animal animal)
        {
            string query = "INSERT INTO Animals (Name, Quantity, TotalMilk) " +
                           "VALUES (@Name, @Quantity, @TotalMilk)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open(); 
                command.ExecuteNonQuery();
            }
        }

        public List<Animal> GetAllAnimals()
        {
            List<Animal> animals = new List<Animal>();
            string query = "SELECT * FROM Animals";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Animal animal = new Animal();
                    animals.Add(animal);
                }
            }
            return animals;
        }
    }

}
