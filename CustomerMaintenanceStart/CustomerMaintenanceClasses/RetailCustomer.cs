﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomerMaintenanceClasses
{
    public class RetailCustomer : Customer
    {
        protected const int PHONE_DIGITS = 10;
        protected string homePhone;

        public RetailCustomer() : base()
        {
            homePhone = "5416669876";
        }

        public RetailCustomer(string fn, string ln, string e, string hp) : base(fn, ln, e)
        {
            this.HomePhone = hp;
        }

        public string HomePhone
        {
            get { return homePhone; }
            set { if (value.Length != PHONE_DIGITS) throw new ArgumentOutOfRangeException("Phone number", value, "Your phone number must consist of 10 digits."); homePhone = value; }
        }

        public override string GetDisplayText()
        {
            return base.GetDisplayText() + " ph: (" + homePhone[0] + homePhone[1] + homePhone[2] + ")" + homePhone[3] + homePhone[4] + homePhone[5] + "-" + homePhone[6] + homePhone[7] + homePhone[8] + homePhone[9];
        }

        public override string ToString()
        {
            return base.ToString() + " (" + homePhone[0] + homePhone[1] + homePhone[2] + ")" + homePhone[3] + homePhone[4] + homePhone[5] + "-" + homePhone[6] + homePhone[7] + homePhone[8] + homePhone[9];
        }
    }
}
