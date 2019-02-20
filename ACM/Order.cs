using ACM.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Order: ILoggable
    {
        public Order()
        {

        }

        public Order(int orderId)
        {
            this.OrderId = orderId;
        }

        //composition with Ids
        public int CustomerId { get; set; } //can have or not - problem on display information of Customer
        public int ShippingAddressId { get; set; } //can have or not - problem on display information of Address

        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; set; }

        public List<OrderItem> orderItems { get; set; }

        public Order Retrieve(int orderId)
        {
            return new Order();
        }

        public bool Save() => true;

        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }

        public override string ToString()
        {
            return OrderDate.Value.Date + " (" + OrderId + ")";
        }

        public string Log()
        {
            throw new NotImplementedException();
        }
    }
}
