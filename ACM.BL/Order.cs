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

        public DateTimeOffset? OrderDate { get; set; }
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
        /// Validates the order
        /// </summary>
        public bool Validate()
        {
            return OrderDate.HasValue;
        }

        #endregion


    }
}
