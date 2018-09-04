using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {

        #region Fields & Properties

        private AddressRepository addressRepository { get; set; }

        #endregion

        #region Constructors & Destructors

        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Saves the current customer.
        /// </summary>
        /// <returns></returns>
        public bool Save(Customer customer)
        {
            var success = true;

            if (customer.HasChanges && customer.IsValid)
            {
                if (customer.IsNew)
                {
                    //Call an Insert Sproc
                }
                else
                {
                    //call an update sproc
                }
            }

            return success;
        }

        /// <summary>
        /// Retrieve one customer.
        /// </summary>
        /// <returns></returns>
        public Customer Retrieve(int customerId)
        {
            //Create the nistance of the Customer class
            Customer customer = new Customer(customerId);
            customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
            
            // Code that retrieves the defined customer

            // Temporary hard coded values to return a populated customer
            if (customerId == 1)
            {
                customer.EmailAddress = "fbaggins@hobbiton.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
            }

            return customer;
        }

        /// <summary>
        /// Retrieve all customers
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Customer> Retrieve()
        {
            return new List<Customer>();
        }

        #endregion
    }
}
