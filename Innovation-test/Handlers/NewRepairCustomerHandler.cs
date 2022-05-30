using Innovation_test.Models;

namespace Innovation_test.Handlers
{
    public class NewRepairCustomerHandler : RepairCustomerHandler
    {
        public override OrderStatus LargeOrder()
        {
            return OrderStatus.Closed;
        }

        public override OrderStatus RushOrder()
        {
            return OrderStatus.AuthorisationRequired;
        }

        public override OrderStatus LargeRushOrder()
        {
            return OrderStatus.AuthorisationRequired;
        }
    }
}