using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMaintenanceClasses
{
    public class Customer
    {
        protected const int MAXLENGTH = 30;

        protected string firstName;
        protected string lastName;
        protected string email;

        public Customer()
        {
            firstName = "John";
            lastName = "Doe";
            email = "john@doe.com";
        }

        public Customer(string fn, string ln, string e)
        {
            this.FirstName = fn;
            this.LastName = ln;
            this.Email = e;
        }

        public string FirstName
        {
            get { return firstName; }
            set { if (value.Length > MAXLENGTH) throw new ArgumentOutOfRangeException("FirstName", value, "You must enter in a first name with a length of 30 characters or less."); firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { if (value.Length > MAXLENGTH) throw new ArgumentOutOfRangeException("LastName", value, "You must enter in a last name with a length of 30 characters or less."); lastName = value; }
        }

        public string Email
        {
            get { return email; }
            set { if (value.Length > MAXLENGTH) throw new ArgumentOutOfRangeException("Email", value, "Your email must be 30 characters or less."); email = value; }
        }

        public virtual string GetDisplayText()
        {
            return firstName + " " + lastName + ", " + email + ".";
        }

        public override string ToString()
        {
            return firstName + " " + lastName + " " + email;
        }

        static public bool operator ==(Customer c1, Customer c2)
        {
            if (c1.Equals(null))
                return c2.Equals(null);
            else
                return c1.Email == c2.Email;
        }

        static public bool operator !=(Customer c1, Customer c2)
        {
            return !Equals(c1, c2);
        }

        public override bool Equals(object o)
        {
            if ((o == null) || !this.GetType().Equals(o.GetType()))
            {
                return false;
            }
            else
            {
                Customer c = (Customer) o;
                return this == c;
            }
        }

        public override int GetHashCode()
        {
            return (firstName + " " + lastName + " " + email).GetHashCode();
        }
    }
}
