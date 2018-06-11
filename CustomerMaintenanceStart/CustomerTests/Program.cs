using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerMaintenanceClasses;

namespace CustomerTests
{
    class Program
    {
        static void Main(string[] args)
        {
            TestCustomerConstructors();
            TestCustomerGetters();
            TestCustomerSetters();
            TestCustomerToString();
            TestCustomerExceptions();

            TestCustomerListAddRemove();
            TestCustomerListOverrideAddRemove();
            TestCustomerListCount();
            TestCustomerListIndex();
            TestCustomerListFind();
            TestCustomerEquals();
            TestCustomerListSave();
            TestCustomerListFill();

            TestCustomerList2AddRemove();
            TestCustomerList2OverrideAddRemove();
            TestCustomerList2Count();
            TestCustomerList2Index();
            TestCustomerList2Find();
            TestCustomerList2Save();
            TestCustomerList2Fill();
            TestCustomerList2Poly();
            TestCustomerList2Foreach();

            Console.WriteLine();
            Console.ReadLine();
        }

        static void TestCustomerConstructors()
        {
            Customer c1 = new Customer();
            WholesaleCustomer ws = new WholesaleCustomer();
            RetailCustomer rs = new RetailCustomer();
            Customer c2 = new Customer("Nohm", "Chomskey", "nohm@chomskey.com");
            WholesaleCustomer ws2 = new WholesaleCustomer("Nohm", "Chomskey", "nohm@chomskey.com", "Ben's Boxing");
            RetailCustomer rs2 = new RetailCustomer("Nohm", "Chomskey", "nohm@chomskey.com", "5415555555");

            Console.WriteLine("Testing both constructors");
            Console.WriteLine("Default constructor.  Expecting default values. " + c1.GetDisplayText());
            Console.WriteLine("Overloaded constructor.  Expecting Nohm Chomskey, nohmchomskey.com. ");
            Console.WriteLine("Getting " + c2.GetDisplayText());
            Console.WriteLine("Testing WholesaleCustomer's constructors and RetailCustomer's constructors.");
            Console.WriteLine("Expecting default values.");
            Console.WriteLine("WholesaleCustomer: " + ws.GetDisplayText() + " RetailCustomer: " + rs.GetDisplayText());
            Console.WriteLine("Expecting Nohm, Chomskey, nohm@chomskey.com, Ben's boxing and Nohm, Chomskey, nohm@chomskey.com, 5415555555");
            Console.WriteLine("Overloaded WholesaleCustomer: " + ws2.GetDisplayText() + " Overloaded RetailCustomer: " + rs2.GetDisplayText());
            Console.WriteLine();
        }

        static void TestCustomerGetters()
        {
            Customer c1 = new Customer("Nohm", "Chomskey", "nohm@chomskey.com");
            WholesaleCustomer ws = new WholesaleCustomer();
            RetailCustomer rs = new RetailCustomer();

            Console.WriteLine("Testing getters");
            Console.WriteLine("First name.  Expecting Nohm. " + c1.FirstName);
            Console.WriteLine("Last name.  Expecting Chomskey. " + c1.LastName);
            Console.WriteLine("Email.  Expecting nohm@chomskey.com. " + c1.Email);
            Console.WriteLine("Company name. Expecting Frank's Haircutting. " + ws.Company);
            Console.WriteLine("Home phone number. Expecting 5416669876. " +rs.HomePhone);
            Console.WriteLine();
        }

        static void TestCustomerSetters()
        {
            Customer c1 = new Customer("Nohm", "Chomskey", "nohm@chomskey.com");
            WholesaleCustomer ws = new WholesaleCustomer();
            RetailCustomer rs = new RetailCustomer();

            Console.WriteLine("Testing setters");
            c1.FirstName = "Kyle";
            c1.LastName = "Normand";
            c1.Email = "kyle@normand.com";
            ws.Company = "Noble Barns Emporium";
            rs.HomePhone = "5419999999";
            Console.WriteLine("Expecting Kyle, Normand, kyle@normand.com.");
            Console.WriteLine("Getting " + c1.GetDisplayText());
            Console.WriteLine("Expecting Noble Barns Emporium and 5419999999");
            Console.WriteLine("Getting " + ws.Company + " and " + rs.HomePhone);
            Console.WriteLine();
        }

        static void TestCustomerToString()
        {
            Customer c1 = new Customer("Nohm", "Chomskey", "nohm@chomskey.com");
            WholesaleCustomer ws = new WholesaleCustomer();
            RetailCustomer rs = new RetailCustomer();

            Console.WriteLine("Testing ToString");
            Console.WriteLine("Expecting Nohm, Chomskey, nohm@chomskey.com. " + c1.GetDisplayText());
            Console.WriteLine("Getting Nohm, Chomskey, nohm@chomskey.com. " + c1.ToString());
            Console.WriteLine("Testing WholesaleCustomer ToString and RetailCustomer ToString.");
            Console.WriteLine("Expecting default values.");
            Console.WriteLine(ws.ToString() + " " + rs.ToString());
            Console.WriteLine();
        }

        static void TestCustomerExceptions()
        {
            Customer c1 = new Customer("Nohm", "Chomskey", "nohm@chomskey.com");
            WholesaleCustomer c2 = new WholesaleCustomer();
            RetailCustomer c3 = new RetailCustomer();

            Console.WriteLine("Testing customer set exceptions");
            Console.WriteLine("Attempting to set first name, last name, and email to more than 30 characters, expecting an exception from each.");

            try
            {
                c1.FirstName = "11111111111111111111111111111111111111111111111111111111111111111111";
                Console.WriteLine("Exception not caught.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught with message " + e);
            }
            Console.WriteLine();

            try
            {
                c1.LastName = "11111111111111111111111111111111111111111111111111111111111111111111";
                Console.WriteLine("Exception not caught.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught with message " + e);
            }
            Console.WriteLine();

            try
            {
                c1.Email = "11111111111111111111111111111111111111111111111111111111111111111111@.";
                Console.WriteLine("Exception not caught.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught with message " + e);
            }

            Console.WriteLine("Attempting to set Company name to more than 30 characters, and an invalid phone number expecting an exception from each.");

            try
            {
                c2.Company = "11111111111111111111111111111111111111111111111111111111111111111111";
                Console.WriteLine("Exception not caught.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught with message " + e);
            }

            try
            {
                c3.HomePhone = "David66666666.";
                Console.WriteLine("Exception not caught.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught with message " + e);
            }

            Console.WriteLine();
        }

        static void TestCustomerListAddRemove()
        {
            CustomerList cl = new CustomerList();
            Customer c = new Customer("Nohm", "Chomskey", "nohm@chomskey.com");

            cl.Add(c);

            Console.WriteLine("Testing add customer.");
            Console.WriteLine("Expecting Nohm, Chomskey, nohm@chomskey.com, with one item in the list.");
            Console.WriteLine("Getting " + cl[0].GetDisplayText() + " with a total of " + cl.Count + " items.");
            Console.WriteLine();

            cl.Remove(c);

            Console.WriteLine("Testing remove customer.");
            Console.WriteLine("Removing Nohm Chomskey. Expecting empty list.");
            Console.WriteLine("Getting " + cl.Count + " customers.");
            Console.WriteLine();
        }

        static void TestCustomerListOverrideAddRemove()
        {
            CustomerList cl = new CustomerList();
            Customer c = new Customer("Nohm", "Chomskey", "nohm@chomskey.com");

            cl += c;

            Console.WriteLine("Testing overloaded + operator.");
            Console.WriteLine("Expecting Nohm, Chomskey, nohm@chomskey.com. with one item in the list.");
            Console.WriteLine("Getting " + cl[0].GetDisplayText() + " with a total of " + cl.Count + " items.");
            Console.WriteLine();

            cl -= c;

            Console.WriteLine("Testing overloaded - operator.");
            Console.WriteLine("Removing Nohm Chomskey. Expecting empty list.");
            Console.WriteLine("Getting " + cl.Count + " customers.");
            Console.WriteLine();
        }

        static void TestCustomerListCount()
        {
            CustomerList cl = new CustomerList();
            Customer c = new Customer();

            for (int i = 0; i < 15; i++)
                cl += c;

            Console.WriteLine("Testing counter variable.");
            Console.WriteLine("Expecting 15 items in the list.");
            Console.WriteLine("Getting a total of " + cl.Count + " customers.");
            Console.WriteLine();

            for (int i = 0; i < 7; i++)
                cl -= c;

            Console.WriteLine("Removing 7 items. Expecing 8 items to be left in the list.");
            Console.WriteLine("Getting " + cl.Count + " customers.");
            Console.WriteLine();
        }

        static void TestCustomerListIndex()
        {
            CustomerList cl = new CustomerList();
            Customer c = new Customer();
            Customer c2 = new Customer("Nohm", "Chomskey", "nohm@chomskey.com");

            for (int i = 0; i < 4; i++)
                cl.Add(c);
            cl.Add(c2);
            for (int i = 0; i < 10; i++)
                cl.Add(c);

            Console.WriteLine("Testing indexer getter. Placing 15 items in the list.");
            Console.WriteLine("Expecting the customer at index 4 to be Nohm Chomskey.");
            Console.WriteLine("The customer at index 4 is " + cl[4].FirstName + " " + cl[4].LastName);
            Console.WriteLine("Testing indexer setter.");
            cl[5] = c2;
            Console.WriteLine("Expecting the customer at index 4 to be Nohm Chomskey.");
            Console.WriteLine("The customer at index 4 is " + cl[5].FirstName + " " + cl[5].LastName);
            Console.WriteLine();
        }

        static void TestCustomerListFind()
        {
            CustomerList cl = new CustomerList();
            Customer c = new Customer();
            Customer c2 = new Customer("Nohm", "Chomskey", "nohm@chomskey.com");
            Customer c3;

            for (int i = 0; i < 4; i++)
                cl.Add(c);
            cl.Add(c2);
            for (int i = 0; i < 10; i++)
                cl.Add(c);

            Console.WriteLine("Testing email indexer.");
            Console.WriteLine("Expecting to find the customer with the email nohm@chomskey and not the email edward@adams.com.");
            if (cl["nohm@chomskey.com"].Email == "nohm@chomskey.com")
            {
                c3 = cl["nohm@chomskey.com"];
                Console.WriteLine("Found " + c3.FirstName + " " + c3.LastName + " with the email " + c3.Email);
            }
            else
                Console.WriteLine("Customer with email nohm@chomskey.com not found.");;
            if (cl["edward@adams.com"].Email == "edward@adams.com")
            {
                c3 = cl["edward@adams.com"];
                Console.WriteLine("Found " + c3.FirstName + " " + c3.LastName + " with the email " + c3.Email);
            }
            else
                Console.WriteLine("Customer with email edward@adams.com not found.");
            Console.WriteLine();
        }

        static void TestCustomerEquals()
        {
            Customer c1 = new Customer("Nohm", "Chomskey", "nohm@chomskey.com");
            Customer c2 = new Customer("Nohm", "Chomskey", "nohm@chomskey.com");

            Console.WriteLine("Testing overloaded equals operator.");
            Console.WriteLine("Expecting customer 1 to be equal to customer 2.");
            if (c1 == c2)
                Console.WriteLine("Customer 1 is equal to customer 2");
            else
                Console.WriteLine("Customer 1 is not equal to customer 2");
            Console.WriteLine();

            Console.WriteLine("Testing equals method.");
            Console.WriteLine("Expecting customer 1 to be equal to customer 2.");
            if (c1.Equals(c2))
                Console.WriteLine("Customer 1 is equal to customer 2");
            else
                Console.WriteLine("Customer 1 is not equal to customer 2");
            Console.WriteLine();
        }

        static void TestCustomerListSave()
        {
            CustomerList cl = new CustomerList();
            Customer c = new Customer("Henry", "Davenport", "henrydaven@gmail.com");
            List<Customer> customers;

            Console.WriteLine("Testing CustomerList save.");
            Console.Write("Expecting ");
            customers = CustomerDB.GetCustomers();
            customers.Add(c);

            for (int i = 0; i < customers.Count; i++)
                Console.WriteLine(customers[i].GetDisplayText());

            for (int i = 0; i < customers.Count; i++)
                cl.Add(customers[i]);

            Console.Write("Getting ");
            cl.Save();
            customers = CustomerDB.GetCustomers();
            for (int i = 0; i < customers.Count; i++)
                Console.WriteLine(customers[i].GetDisplayText());
            Console.WriteLine();

            customers.RemoveAt(customers.IndexOf(c));
            CustomerList cl2 = new CustomerList();
            for (int i = 0; i < customers.Count; i++)
                cl2.Add(customers[i]);
            cl2.Save();
        }

        static void TestCustomerListFill()
        {
            CustomerList cl = new CustomerList();
            List<Customer> customers;
            customers = CustomerDB.GetCustomers();

            Console.WriteLine("Testing CustomerList fill.");
            Console.Write("Expecting ");
            for (int i = 0; i < customers.Count; i++)
                Console.WriteLine(customers[i]);
            cl.Fill();

            Console.Write("Getting ");
            for (int i = 0; i < cl.Count; i++)
                Console.WriteLine(cl[i].GetDisplayText());
            Console.WriteLine();
        }

        /// <summary>
        ///                                         CUSTOMER LIST 2 TESTING STARTS HERE
        /// </summary>


        static void TestCustomerList2AddRemove()
        {
            CustomerList2 cl = new CustomerList2();
            Customer c = new Customer("Nohm", "Chomskey", "nohm@chomskey.com");

            cl.Add(c);

            Console.WriteLine("Testing add customer for CustomerList2.");
            Console.WriteLine("Expecting Nohm, Chomskey, nohm@chomskey.com, with one item in the list.");
            Console.WriteLine("Getting " + cl[0].GetDisplayText() + " with a total of " + cl.Count + " items.");
            Console.WriteLine();

            cl.Remove(c);

            Console.WriteLine("Testing remove customer for CustomerList2.");
            Console.WriteLine("Removing Nohm Chomskey. Expecting empty list.");
            Console.WriteLine("Getting " + cl.Count + " customers.");
            Console.WriteLine();
        }

        static void TestCustomerList2OverrideAddRemove()
        {
            CustomerList2 cl = new CustomerList2();
            Customer c = new Customer("Nohm", "Chomskey", "nohm@chomskey.com");

            cl += c;

            Console.WriteLine("Testing overloaded + operator for CustomerList2.");
            Console.WriteLine("Expecting Nohm, Chomskey, nohm@chomskey.com. with one item in the list.");
            Console.WriteLine("Getting " + cl[0].GetDisplayText() + " with a total of " + cl.Count + " items.");
            Console.WriteLine();

            cl -= c;

            Console.WriteLine("Testing overloaded - operator for CustomerList2.");
            Console.WriteLine("Removing Nohm Chomskey. Expecting empty list.");
            Console.WriteLine("Getting " + cl.Count + " customers.");
            Console.WriteLine();
        }

        static void TestCustomerList2Count()
        {
            CustomerList2 cl = new CustomerList2();
            Customer c = new Customer();

            for (int i = 0; i < 15; i++)
                cl += c;

            Console.WriteLine("Testing counter variable for CustomerList2.");
            Console.WriteLine("Expecting 15 items in the list.");
            Console.WriteLine("Getting a total of " + cl.Count + " customers.");
            Console.WriteLine();

            for (int i = 0; i < 7; i++)
                cl -= c;

            Console.WriteLine("Removing 7 items. Expecing 8 items to be left in the list.");
            Console.WriteLine("Getting " + cl.Count + " customers.");
            Console.WriteLine();
        }

        static void TestCustomerList2Index()
        {
            CustomerList2 cl = new CustomerList2();
            Customer c = new Customer();
            Customer c2 = new Customer("Nohm", "Chomskey", "nohm@chomskey.com");

            for (int i = 0; i < 4; i++)
                cl.Add(c);
            cl.Add(c2);
            for (int i = 0; i < 10; i++)
                cl.Add(c);

            Console.WriteLine("Testing indexer getter for CustomerList2. Placing 15 items in the list.");
            Console.WriteLine("Expecting 15 customers to be in the list.");
            Console.WriteLine("Getting " + cl.Count + " customers");
            Console.WriteLine("Testing indexer setter for CustomerList2.");
            cl[5] = c2;
            Console.WriteLine("Expecting the customer at index 4 to be Nohm Chomskey.");
            Console.WriteLine("The customer at index 4 is " + cl[5].FirstName + " " + cl[5].LastName);
            Console.WriteLine();
        }

        static void TestCustomerList2Find()
        {
            CustomerList2 cl = new CustomerList2();
            Customer c = new Customer();
            Customer c2 = new Customer("Nohm", "Chomskey", "nohm@chomskey.com");
            Customer c3;

            for (int i = 0; i < 4; i++)
                cl.Add(c);
            cl.Add(c2);
            for (int i = 0; i < 10; i++)
                cl.Add(c);

            Console.WriteLine("Testing email indexer for CustomerList2.");
            Console.WriteLine("Expecting to find the customer with the email nohm@chomskey and not the email edward@adams.com.");
            if (cl["nohm@chomskey.com"].Email == "nohm@chomskey.com")
            {
                c3 = cl["nohm@chomskey.com"];
                Console.WriteLine("Found " + c3.FirstName + " " + c3.LastName + " with the email " + c3.Email);
            }
            else
                Console.WriteLine("Customer with email nohm@chomskey.com not found."); ;
            if (cl["edward@adams.com"].Email == "edward@adams.com")
            {
                c3 = cl["edward@adams.com"];
                Console.WriteLine("Found " + c3.FirstName + " " + c3.LastName + " with the email " + c3.Email);
            }
            else
                Console.WriteLine("Customer with email edward@adams.com not found.");
            Console.WriteLine();
        }

        static void TestCustomerList2Save()
        {
            CustomerList2 cl = new CustomerList2();
            Customer c = new Customer("Henry", "Davenport", "henrydaven@gmail.com");
            List<Customer> customers;

            Console.WriteLine("Testing CustomerList2 save.");
            Console.Write("Expecting ");
            customers = CustomerDB.GetCustomers();
            customers.Add(c);

            for (int i = 0; i < customers.Count; i++)
                Console.WriteLine(customers[i].GetDisplayText());

            for (int i = 0; i < customers.Count; i++)
                cl.Add(customers[i]);

            Console.Write("Getting ");
            cl.Save();
            customers = CustomerDB.GetCustomers();
            for (int i = 0; i < customers.Count; i++)
                Console.WriteLine(customers[i].GetDisplayText());
            Console.WriteLine();

            customers.RemoveAt(customers.IndexOf(c));
            CustomerList2 cl2 = new CustomerList2();
            for (int i = 0; i < customers.Count; i++)
                cl2.Add(customers[i]);
            cl2.Save();
        }

        static void TestCustomerList2Fill()
        {
            CustomerList2 cl = new CustomerList2();
            List<Customer> customers;
            customers = CustomerDB.GetCustomers();

            Console.WriteLine("Testing CustomerList2 fill.");
            Console.Write("Expecting ");
            for (int i = 0; i < customers.Count; i++)
                Console.WriteLine(customers[i]);
            cl.Fill();

            Console.Write("Getting ");
            for (int i = 0; i < cl.Count; i++)
                Console.WriteLine(cl[i].GetDisplayText());
            Console.WriteLine();
        }

        static void TestCustomerList2Poly()
        {
            CustomerList2 cl = new CustomerList2();
            Customer c = new Customer();
            Customer c2 = new Customer("Jack", "Daniels", "jack@daniels.com");
        }

        static void TestCustomerList2Foreach()
        {
            CustomerList2 cl = new CustomerList2();
            List<Customer> customers;
            customers = CustomerDB.GetCustomers();

            Console.WriteLine("Testing CustomerList2.");
            Console.Write("Expecting ");
            cl.Fill();

            Console.Write("Getting ");
            foreach(Customer c in cl)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine();
        }
    }
}
