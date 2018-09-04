using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        #region Fields & Properties



        #endregion

        #region Constructors & Destructors



        #endregion

        #region Methods

        /// <summary>
        /// Retrieve one product.
        /// </summary>
        public Product Retrieve(int productId)
        {
            //Create the instance of the product class
            //Pass in the requested Id
            Product product = new Product(productId);

            //Code that retrieves the defined product

            //Temporary hard coded values to return
            //a populated product
            if(productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Assorted Sizes";
                product.CurrentPrice = 15.96M;
            }
            return product;
        }

        /// <summary>
        /// Saves the current product.
        /// </summary>
        /// <returns></returns>
        public bool Save(Product product)
        {
            var success = true;

            if (product.HasChanges && product.IsValid)
            {
                if (product.IsNew)
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
