using GunnarsAutoV2.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace GunnarsAuto
{
    public class Repository
    {
        public static List<Car> cars = new List<Car>();
        public static List<SalesPerson> salesPersons = new List<SalesPerson>();
        private const string connectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=GunnarsAutoDB;Integrated Security=True";


        public static List<Car> GetAllVehicles()
        {
            cars = new List<Car>();
            string sql = "SELECT * FROM Cars";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                int carID = (int)reader["ID"];
                string make = (string)reader["Make"];
                string model = (string)reader["Model"];
                string vin = (string)reader["VIN"];
                string registration = (string)reader["NumberPlate"];
                string isUsed = (string)reader["IsUsed"];

                Car car = new Car(carID, make, model, vin, registration, isUsed);
                cars.Add(car);
            }

            connection.Close();
            return cars;
        }

        public static List<SalesPerson> GetAllSalesPersons()
        {
            string sql = "SELECT * FROM SalesPersons";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                int id = (int)reader["ID"];
                string firstName = (string)reader["FirstName"];
                string lastName = (string)reader["LastName"];
                string initials = (string)reader["Initials"];

                SalesPerson salesPerson = new SalesPerson(id, firstName, lastName, initials);
                salesPersons.Add(salesPerson);
            }
            connection.Close();
            return salesPersons;
        }

    }
}