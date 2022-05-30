using Innovation_test.Models;

namespace Innovation_test.Handlers
{
    public class NewHireCustomerHandler : HireCustomerHandler
    {

        public override OrderStatus RushOrder()
        {
            return OrderStatus.AuthorisationRequired;
        }
    }
}