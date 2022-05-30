using Innovation_test;
using Innovation_test.Handlers;
using Innovation_test.Models;
using Innovation_test.Processors;
using Xunit;

namespace innovation_test_integration
{
    public class IntegrationRun
    {
        [Fact]
        public void AllLargeRepairOrdersForNewCustomers_ShouldBeClosed()
        {
            var repairCustomer = new NewRepairCustomerHandler();
            var repairOrderProcessor = new OrderProcessor(repairCustomer);

            var repairOrchestrator = new OrderProcessorOrchestrator(repairOrderProcessor);

            Assert.Equal(OrderStatus.Closed, repairOrchestrator.ProcessOrder(false, true));
        }

        [Fact]
        public void AllLargeRushHireOrders_ShouldBeClosed()
        {
            var newHirecustomer = new NewHireCustomerHandler();
            var newHireOrderProcessor = new OrderProcessor(newHirecustomer);

            var newHireOrchestror = new OrderProcessorOrchestrator(newHireOrderProcessor);

            var hirecustomer = new HireCustomerHandler();
            var hireOrderProcessor = new OrderProcessor(hirecustomer);

            var hireOrchestror = new OrderProcessorOrchestrator(hireOrderProcessor);

            Assert.Equal(OrderStatus.Closed, hireOrchestror.ProcessOrder(true, true));
            Assert.Equal(OrderStatus.Closed, newHireOrchestror.ProcessOrder(true, true));
        }

        [Fact]
        public void LargeRepairOrders_ShouldBeRequireAuthorisation()
        {
            var repairCustomer = new RepairCustomerHandler();
            var repairOrderProcessor = new OrderProcessor(repairCustomer);
            var repairOrchestror = new OrderProcessorOrchestrator(repairOrderProcessor);


            Assert.Equal(OrderStatus.AuthorisationRequired, repairOrchestror.ProcessOrder(true, true));
            Assert.Equal(OrderStatus.AuthorisationRequired, repairOrchestror.ProcessOrder(false, true));
        }

        [Fact]
        public void AllRushOrdersForNewCustomers_ShouldBeRequireAuthorisation()
        {
            var hirecustomer = new NewHireCustomerHandler();
            var hireOrderProcessor = new OrderProcessor(hirecustomer);

            var hireOrchestror = new OrderProcessorOrchestrator(hireOrderProcessor);

            var repairCustomer = new NewRepairCustomerHandler();
            var repairOrderProcessor = new OrderProcessor(repairCustomer);

            var repairOrchestrator = new OrderProcessorOrchestrator(repairOrderProcessor);

            Assert.Equal(OrderStatus.AuthorisationRequired, hireOrchestror.ProcessOrder(true, false));

            Assert.Equal(OrderStatus.AuthorisationRequired, repairOrchestrator.ProcessOrder(true, true));
            Assert.Equal(OrderStatus.AuthorisationRequired, repairOrchestrator.ProcessOrder(true, false));
        }

        [Fact]
        public void AllOtherOrdersShouldBeConfirmed()
        {
            var newHirecustomer = new NewHireCustomerHandler();
            var newHireOrderProcessor = new OrderProcessor(newHirecustomer);

            var newHireOrch = new OrderProcessorOrchestrator(newHireOrderProcessor);

            var newRepairCustomer = new NewRepairCustomerHandler();
            var newRepairOrderProcessor = new OrderProcessor(newRepairCustomer);

            var newRepairOrch = new OrderProcessorOrchestrator(newRepairOrderProcessor);

            var hirecustomer = new HireCustomerHandler();
            var hireOrderProcessor = new OrderProcessor(hirecustomer);

            var hireOrchestror = new OrderProcessorOrchestrator(hireOrderProcessor);

            var repairCustomer = new RepairCustomerHandler();
            var repairOrderProcessor = new OrderProcessor(repairCustomer);

            var repairOrchestror = new OrderProcessorOrchestrator(repairOrderProcessor);

            Assert.Equal(OrderStatus.Confirmed, newHireOrch.ProcessOrder(false, true));
            Assert.Equal(OrderStatus.Confirmed, newHireOrch.ProcessOrder(false, false));
            Assert.Equal(OrderStatus.Confirmed, newRepairOrch.ProcessOrder(false, false));

            Assert.Equal(OrderStatus.Confirmed, hireOrchestror.ProcessOrder(true, false));

            Assert.Equal(OrderStatus.Confirmed, repairOrchestror.ProcessOrder(false, false));
        }
    }
}