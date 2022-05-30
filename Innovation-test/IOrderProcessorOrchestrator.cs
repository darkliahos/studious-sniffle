using Innovation_test.Models;

namespace Innovation_test
{
    public interface IOrderProcessorOrchestrator
    {
        OrderStatus ProcessOrder(bool isRushOrder, bool isLargeOrder);
    }
}