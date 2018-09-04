﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class AddressRepository
    {
        #region Methods

        /// <sumarry>
        /// Retrieve one address.
        /// </sumarry>
        public Address Retrieve(int addressId)
        {
            //Create the instance of the Address class
            //Pass in the requested Id
            Address address = new Address(addressId);

            //Code that retrieves the defined address

            //Temporary hard coded valules to return a populated address
            if (addressId == 1)
            {
                address.StreetLine1 = "Bag End";
                address.StreetLine2 = "Bagshot row";
                address.City = "Hobbiton";
                address.State = "Shrire";
                address.Country = "Middle Earth";
                address.PostalCode = "144";
            }
            return address;
        }

        /// <summary>
        /// Retrieve all addresses for one Customer
        /// </summary>
        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            //Code that retrieves the defined addresses for the customer

            //Temporary hard coded values to return a set of addresses for a customer
            var addressList = new List<Address>()
            {
                new Address(1)
                {
                    AddressType = 1,
                    StreetLine1 = "Bag End",
                    StreetLine2 = "Bagshot row",
                    City = "Hobbiton",
                    State = "Shire",
                    Country = "Middle Earth",
                    PostalCode = "144"
                },
                new Address(2)
                {
                    AddressType = 2,
                    StreetLine1 = "Green Dragon",
                    City = "Bywater",
                    State = "Shire",
                    Country = "Middle Earth",
                    PostalCode = "146"
                }
            };

            return addressList;

        }

        /// <summary>
        /// Saves the current address.
        /// </summary>
        public bool Save(Address address)
        {
            var success = true;

            if (address.HasChanges && address.IsValid)
            {
                if (address.IsNew)
                {
                    //Call an Insert Stored Procedure
                }
                else
                {
                    //Call an Update Stored Procedure
                }
            }

            return success;
        }


        #endregion


    }
}
