using System;
using System.Collections.Generic;
using System.Text;

namespace ACM
{
    public class OrderRepository
    {
        //could create an OrderDisplayRepository
        public OrderDisplay RetrieveOrderDisplay(int orderId)
        {
            var orderDisplay = new OrderDisplay();
            orderDisplay.orderDisplayItemList = new List<OrderDisplayItem>();
            return orderDisplay;
        }
    }
}
