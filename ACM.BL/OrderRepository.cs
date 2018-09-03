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

        public OrderDisplay RetrieveOrderDisplay(int orderId)
        {
            OrderDisplay orderDisplay = new OrderDisplay();

            //code that retrieves the defined order fields

            // Temporary Hard-coded data
            if(orderId == 10)
            {
                orderDisplay.FirstName = "Bilbo";
                orderDisplay.LastName = "Baggins";
                orderDisplay.OrderDate = new DateTimeOffset(2018, 09, 02, 23, 52, 00, new TimeSpan(-6, 0, 0));
                orderDisplay.ShippingAddress = new Address()
                {
                    AddressType = 1,
                    StreetLine1 = "Bag End",
                    StreetLine2 = "Bagshot row",
                    City = "Hobbiton",
                    State = "Shire",
                    Country = "Middle Earth",
                    PostalCode = "144"
                };
            }

            orderDisplay.OrderDisplayItemList = new List<OrderDisplayItem>();

            //code that retrieves the order items

            //temporary hard-coded data
            if(orderId == 10)
            {
                orderDisplay.OrderDisplayItemList = new List<OrderDisplayItem>()
                {
                    new OrderDisplayItem()
                    {
                        ProductName = "Sunflowers",
                        PurchasePrice = 15.96M,
                        OrderQuantity = 2
                    },
                    new OrderDisplayItem()
                    {
                        ProductName = "Rake",
                        PurchasePrice = 6M,
                        OrderQuantity = 1
                    }
                };

            }

            return orderDisplay;
        }


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
