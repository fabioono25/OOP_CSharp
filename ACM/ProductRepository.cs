using ACM.BL;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACM
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            var product = new Product(productId);

            return product;
        }

        public bool Save(Product product)
        {
            var success = true;

            if (product.HasChanged && product.IsValid)
            {
                if (product.IsNew)
                {
                    //insert
                }
                else
                {
                    //update
                }
            }
            return success;
        }
    }
}
