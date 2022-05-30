using Innovation_test.Handlers;
using Innovation_test.Models;

namespace Innovation_test
{
    public interface ICustomerHandlerFactory
    {
        ICustomerHandler CreateCustomer(OrderType type, bool isNewCustomer); 
    }
}
