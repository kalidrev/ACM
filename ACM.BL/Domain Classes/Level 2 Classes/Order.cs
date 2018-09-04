using Acme.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order : EntityBase, ILoggable
    {

        #region Fields & Properties

        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }
        public IEnumerable<OrderItem> orderItems { get; set; }
        public int CustomerId { get; set; }
        public int ShippingAddressId { get; set; }



        #endregion

        #region Constructors & Destructors

        public Order()
        {

        }

        public Order(int orderId)
        {
            this.OrderId = orderId;
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            return OrderDate.Value.Date + " (" + OrderId + ")";
        }

        /// <summary>
        /// Validates the order
        /// </summary>
        public override bool Validate()
        {
            return OrderDate.HasValue;
        }

        public string Log()
        {
            var logString = this.OrderId + ": " +
                            "Date: " + this.OrderDate.Value.Date + " " +
                            "Status: " + this.EntityState.ToString();

            return logString;
        }

        #endregion


    }
}
