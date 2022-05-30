using Innovation_test.Models;

namespace Innovation_test.Processors
{
    public interface IOrderProcesor
    {
        OrderStatus RushOrder(bool isLargeOrder);

        OrderStatus ProcessOrder(bool isLargeOrder);
    }
}
