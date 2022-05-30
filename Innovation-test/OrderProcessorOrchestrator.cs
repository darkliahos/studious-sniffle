using Innovation_test.Models;
using Innovation_test.Processors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innovation_test
{
    public class OrderProcessorOrchestrator : IOrderProcessorOrchestrator
    {
        private readonly IOrderProcesor orderProcessor;

        public OrderProcessorOrchestrator(IOrderProcesor orderProcessor)
        {
            this.orderProcessor = orderProcessor;
        }

        public OrderStatus ProcessOrder(bool isRushOrder, bool isLargeOrder)
        {
            if (isRushOrder)
            {
                return this.orderProcessor.RushOrder(isLargeOrder);
            }
            else
            {
                return this.orderProcessor.ProcessOrder(isLargeOrder);
            }
        }
    }
}
