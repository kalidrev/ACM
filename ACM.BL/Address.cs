using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Address
    {

        #region Fields & Properties

        public int AddressId { get; set; }
        public int AddressType { get; set; }
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        
        #endregion

        #region Constructors & Destructors

        public Address()
        {

        }

        public Address(int addressId)
        {
            this.AddressId = addressId;
        }

        #endregion

        #region Methods



        #endregion


    }
}
