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

        public Customer Index(int i)
        {
            return customers[i];
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
