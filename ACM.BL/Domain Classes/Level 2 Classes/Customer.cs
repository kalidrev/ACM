﻿using Acme.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer : EntityBase, ILoggable
    {
        #region Fields & Properties

        public int CustomerType { get; set; }

        public List<Address> AddressList { get; set; }

        public static int InstanceCount { get; set; }

        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string FirstName { get; set; }

        public string EmailAddress { get; set; }

        public int CustomerId { get; private set; }

        public string FullName
        {
            get
            {
                //string fullName = LastName;
                //if (!string.IsNullOrWhiteSpace(FirstName))
                //{
                //    if (!string.IsNullOrWhiteSpace(fullName))
                //    {
                //        fullName += ", ";
                //    }
                //    fullName += FirstName;
                //}
                //return fullName;

                if (string.IsNullOrWhiteSpace(FirstName))
                    return LastName;
                else if (string.IsNullOrWhiteSpace(LastName))
                    return FirstName;
                else
                    return LastName + ", " + FirstName;
            }
        }
        #endregion

        #region Constructors & Destructors

        public Customer(): this(0)
        {

        }

        public Customer(int customerId)
        {
            this.CustomerId = customerId;
            AddressList = new List<Address>();
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            return FullName;
        }

        public override bool Validate()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }

        public string Log()
        {
            var logString = this.CustomerId + ": " +
                            this.FullName + " " +
                            "Email: " + this.EmailAddress + " " +
                            "Status: " + this.EntityState.ToString();

            return logString;
        }

        

        #endregion



    }
}
