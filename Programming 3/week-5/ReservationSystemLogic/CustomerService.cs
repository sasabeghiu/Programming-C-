using System;
using System.Collections.Generic;
using DAL;
using Model;

namespace ReservationSystemLogic
{
    public class CustomerService
    {
        CustomerDAO customerDAO;
        public CustomerService()
        {
            customerDAO = new CustomerDAO();
        }

        public List<Customer> GetAll()
        {
            List<Customer> customers = customerDAO.GetAll();
            return customers;
        }

        public Customer GetById(int customerId)
        {
            Customer customer = customerDAO.GetById(customerId);
            return customer;
        }
    }
}
