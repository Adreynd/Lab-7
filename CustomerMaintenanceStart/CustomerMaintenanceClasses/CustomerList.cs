using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomerMaintenanceClasses
{
    public class CustomerList
    {
        private List<Customer> customers;
        private int count;

        public CustomerList()
        {
            customers = new List<Customer>();
            count = 0;
        }

        public int Count
        {
            get { return count; }
        }

        public Customer this[int i]
        {
            get { return customers[i]; }
            set { customers[i] = value; }
        }

        public Customer this[string e]
        {
            get
            {
                Customer c = new Customer();
                c.Email = e;
                if (customers.IndexOf(c) >= 0)
                    return this[customers.IndexOf(c)];
                else
                    return new Customer("InvalidCustomer", "", "invalid@customer.com");
            }
        }

        public void Add(Customer c)
        {
            customers.Add(c);
            count++;
        }

        public void Remove(Customer c)
        {
            customers.Remove(c);
            count--;
        }

        public void Fill()
        {
            customers.Clear();
            customers = CustomerDB.GetCustomers();
            count = customers.Count();
        }

        public void Save()
        {
            CustomerDB.SaveCustomers(customers);
        }

        static public CustomerList operator+(CustomerList cl, Customer c)
        {
            cl.Add(c);
            return cl;
        }

        static public CustomerList operator-(CustomerList cl, Customer c)
        {
            cl.Remove(c);
            return cl;
        }
    }
}
