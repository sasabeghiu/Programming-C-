using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using Model;

namespace DAL
{/*
    public class ReservationDAO
    {
        private SqlConnection dbConnection;
        public ReservationDAO()
        {
            string connString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
            dbConnection = new SqlConnection(connString);
        }
        public List<Reservation> GetAll()
        {
            dbConnection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Customers", dbConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Reservation> reservations = new List<Reservation>();
            while (reader.Read())
            {
                Reservation reservation = ReadCustomer(reader);
                reservations.Add(reservation);
            }
            reader.Close();
            dbConnection.Close();

            return reservations;
        }
        public List<Customer> getAllForBook(Book book)
        {
            
        }
        public List<Book> getAllForCustomer(Customer customer)
        {

        }
    }*/
}
    