using Innovation_test.Models;

namespace Innovation_test.Handlers
{
    public class HireCustomerHandler : ICustomerHandler
    {
        public virtual OrderStatus LargeOrder()
        {
            return OrderStatus.Confirmed;
        }

        public virtual OrderStatus LargeRushOrder()
        {
            return OrderStatus.Closed;
        }

        public virtual OrderStatus Order()
        {
            return OrderStatus.Confirmed;
        }

        public virtual OrderStatus RushOrder()
        {
            return OrderStatus.Confirmed;
        }
    }
}