﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product
    {

        #region Fields & Properties

        public Decimal? CurrentPrice { get; set; }
        public int ProductId { get; private set; }
        public string ProductDescription { get; set; }
        public string ProductName { get; set; }

        #endregion

        #region Constructors & Destructors

        public Product()
        {

        }

        public Product(int productId)
        {
            this.ProductId = productId;
        }

        #endregion


        #region Methods

        /// <summary>
        /// Validates the product data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            isValid = CurrentPrice.HasValue;

            return isValid;
        }

        #endregion
    }
}
