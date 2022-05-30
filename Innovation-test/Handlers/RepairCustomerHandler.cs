using Innovation_test.Models;

namespace Innovation_test.Handlers
{
    public class RepairCustomerHandler : ICustomerHandler
    {
        public virtual OrderStatus LargeOrder()
        {
            return OrderStatus.AuthorisationRequired;
        }

        public virtual OrderStatus LargeRushOrder()
        {
            return OrderStatus.AuthorisationRequired;
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