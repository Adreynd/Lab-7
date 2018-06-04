using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMaintenanceClasses
{
    public class Customer
    {
        private const int MAXLENGTH = 30;

        private string firstName;
        private string lastName;
        private string email;

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

        public string GetDisplayText()
        {
            return firstName + " " + lastName + ", " + email + ".";
        }

        public override string ToString()
        {
            return firstName + " " + lastName + " " + email;
        }
    }
}
