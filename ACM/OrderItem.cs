using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class OrderItem
    {
        public OrderItem()
        {

        }

        public OrderItem(int orderItemId)
        {
            this.OrderItemId = orderItemId;
        }

        public int OrderItemId { get; set; }
        public int OrderQuantity { get; set; }
        public int ProductId { get; set; }
        public decimal? PurshasePrice { get; set; }

        public OrderItem Retrieve(int orderItemId)
        {
            return new OrderItem();
        }

        public bool Save() => true;

        public bool Validate()
        {

            var isValid = true;

            if (OrderQuantity <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (PurshasePrice == null) isValid = false;

            return isValid;
        }
    }
}
