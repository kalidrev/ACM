﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        #region Fields & Methods
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

        public Customer()
        {

        }

        public Customer(int customerId)
        {
            this.CustomerId = customerId;
        }

        #endregion

        #region Methods

        public bool Validate()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }

        #endregion



    }
}
