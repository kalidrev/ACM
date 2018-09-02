using System;
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

        /// <summary>
        /// Saves the current customer.
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            //Code that saves the defined customer
            return true;
        }

        /// <summary>
        /// Retrieve one customer.
        /// </summary>
        /// <returns></returns>
        public Customer Retrieve(int customerId)
        {
            // Code that retrieves the defined customer
            return new Customer();
        }

        /// <summary>
        /// Retrieve all customers
        /// </summary>
        /// <returns></returns>
        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

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
