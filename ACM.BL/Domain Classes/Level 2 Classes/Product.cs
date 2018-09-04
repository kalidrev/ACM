using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product : EntityBase
    {
        private string _productName;

        #region Fields & Properties

        public Decimal? CurrentPrice { get; set; }
        public int ProductId { get; private set; }
        public string ProductDescription { get; set; }
        public string ProductName { get => _productName; set => _productName = value; }

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

        

        #endregion
    }
}
