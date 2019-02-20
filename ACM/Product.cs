using ACM.Common;
using System;

namespace ACM.BL
{
    public class Product : EntityBase, ILoggable
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            this.ProductId = productId;
        }

        public Decimal? CurrentPrice { get; set; }
        public int ProductId { get; set; }
        public string ProductDescription { get; set; }
        //public string ProductName { get; set; }
        private string _productName;

        public string ProductName
        {
            get {
                //we need to create instance of non-static class
                //can access specific state from the instance
                //var stringHandler = new StringHandler();
                //return stringHandler.InsertSpaces(_productName);

                //return StringHandler.InsertSpaces(_productName);
                return _productName.InsertSpaces();
            }
            set { _productName = value; }
        }


        public Product Retrieve(int productId)
        {
            return new Product();
        }

        public bool Save() => true;

        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }

        public override string ToString()
        {
            return ProductName;
        }

        public string Log()
        {
            var logging = this.ProductDescription + ": " + this.ProductName;

            return logging;
        }
    }
}
