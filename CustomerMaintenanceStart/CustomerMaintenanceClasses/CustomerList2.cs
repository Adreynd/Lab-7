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

        public void Fill()                          // Note for teacher (Ron Little): We talked about this method, I didn't know how to implement it without skipping over the creation of a new list of customers...
        {                                           // ... and you gave me the go ahead to ignore it, so I haven't fixed this so I can skip ths step.
            this.Clear();
            List<Customer> customers = CustomerDB.GetCustomers();
            foreach (Customer c in customers)
                Add(c);
        }

        public void Save()
        {
            CustomerDB.SaveCustomers(this);
        }

        public override string ToString()
        {
            string output = "";
            for (int i = 0; i < this.Count; i++)
            {
                output += this[i].ToString() + "\n";
            }
            return output;
        }

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
