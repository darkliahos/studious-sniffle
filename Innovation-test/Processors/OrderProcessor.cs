using Innovation_test.Handlers;
using Innovation_test.Models;

namespace Innovation_test.Processors
{
    public class OrderProcessor : IOrderProcesor
    {
        private readonly ICustomerHandler customer;

        public OrderProcessor(ICustomerHandler customer)
        {
            this.customer = customer;
        }

        public OrderStatus ProcessOrder(bool isLargeOrder)
        {
            if (isLargeOrder)
            {
                return customer.LargeOrder();
            }
            return customer.Order();
        }

        public OrderStatus RushOrder(bool isLargeOrder)
        {
            if (isLargeOrder)
            {
                return customer.LargeRushOrder();
            }
            return customer.RushOrder();
        }
    }
}
