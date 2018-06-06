using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomerMaintenanceClasses
{
    class WholesaleCustomer : Customer
    {
        protected string company;

        public WholesaleCustomer() : base()
        {
            company = "Frank's Haircutting";
        }

        public WholesaleCustomer(string fn, string ln, string e, string c) : base(fn, ln, e)
        {
            this.Company = c;
        }

        public string Company
        {
            get { return company; }
            set { company = value; }
        }

        public override string GetDisplayText()
        {
            return base.GetDisplayText() + " (" + company + ")";
        }
    }
}
