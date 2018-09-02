using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {

        #region Fields & Properties



        #endregion

        #region Constructors & Destructors



        #endregion

        #region Methods

        /// <summary>
        /// Retrieve one order.
        /// </summary>
        public Order Retrieve(int orderId)
        {
            //Create the instance of the Order class
            //Pass in the requested Id
            Order order = new Order(orderId);

            //code that retrieves the defined order

            //Temporary hard coded values to return a populated order
            if (orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(2018, 09, 02, 02, 07, 00, new TimeSpan(-6, 0, 0) );
            }

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


        #endregion

    }
}
