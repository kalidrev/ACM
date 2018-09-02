using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order
    {

        #region Fields & Properties

        public DateTimeOffset? orderDate { get; set; }
        public int OrderId { get; private set; }


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

        /// <summary>
        /// Retrieve one order.
        /// </summary>
        public Order Retrieve(int orderId)
        {
            //code that retrieves the defined order
            return new Order();
        }

        /// <summary>
        /// Saves the current order.
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            //Code that saves the order
            return true;
        }

        /// <summary>
        /// Validates the order
        /// </summary>
        public bool Validate()
        {
            return orderDate.HasValue;
        }

        #endregion


    }
}
