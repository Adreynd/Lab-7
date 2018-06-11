using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomerMaintenanceClasses
{
    public class CustomerList2 : List<Customer>
    {
        public CustomerList2() : base()
        {
        }

        public Customer this[string e]
        {
            get
            {
                Customer c = new Customer();
                c.Email = e;
                if (this.IndexOf(c) >= 0)
                    return this[this.IndexOf(c)];
                else
                    return new Customer("InvalidCustomer", "", "invalid@customer.com");
            }
        }

        public void Fill()
        {
            this.Clear();
            List<Customer> customers = CustomerDB.GetCustomers();
            foreach (Customer c in customers)
                Add(c);
        }

        public void Save()
        {
            CustomerDB.SaveCustomers(this);
        }

        /*public override string ToString()
        {
            string output = "";
            for (int i = 0; i < this.Count; i++)
            {
                output += this[i].FirstName + " ";
                output += this[i].LastName + " ";
                output += this[i].Email + "\n";
            }
            return output;
        }*/

        static public CustomerList2 operator+(CustomerList2 cl, Customer c)
        {
            cl.Add(c);
            return cl;
        }

        static public CustomerList2 operator-(CustomerList2 cl, Customer c)
        {
            cl.Remove(c);
            return cl;
        }
    }
}
