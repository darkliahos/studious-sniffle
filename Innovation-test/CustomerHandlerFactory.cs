using Innovation_test.Handlers;
using Innovation_test.Models;

namespace Innovation_test
{
    public class CustomerHandlerFactory : ICustomerHandlerFactory
    {
        public ICustomerHandler CreateCustomer(OrderType type, bool isNewCustomer)
        {
            if(type == OrderType.Hire)
            {
                return isNewCustomer ? new NewHireCustomerHandler() : new HireCustomerHandler();
            }

            if(type == OrderType.Repair)
            {
                return isNewCustomer ? new NewRepairCustomerHandler() : new RepairCustomerHandler();
            }

            throw new NotImplementedException();
        }
    }
}
