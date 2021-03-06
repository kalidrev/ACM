﻿using Acme.Common;
using Acme.Common.Interfaces;
using System;

namespace ACM.BL
{
    public class Product : EntityBase, ILoggable
    {
        private string _productName;

        #region Fields & Properties

        public Decimal? CurrentPrice { get; set; }
        public int ProductId { get; private set; }
        public string ProductDescription { get; set; }

        public string ProductName
        {
            get
            {
                return _productName.InsertSpaces();
            }
            set { _productName = value; }
        }


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

        public override string ToString()
        {
            return ProductName;
        }

        /// <summary>
        /// Validates the product data.
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            isValid = CurrentPrice.HasValue;

            return isValid;
        }

        public string Log()
        {
            var logString = this.ProductId + ": " +
                            this.ProductName + " " +
                            "Detail: " + this.ProductDescription + " " +
                            "Status: " + this.EntityState.ToString();

            return logString;
        }

        

        #endregion
    }
}
