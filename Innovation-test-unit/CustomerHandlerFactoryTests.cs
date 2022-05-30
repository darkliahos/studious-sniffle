using Innovation_test;
using Innovation_test.Handlers;
using Xunit;

namespace Innovation_test_unit
{
    public class CustomerHandlerFactoryTests
    {
        [Fact]
        public void FactoryThrowsErrorIfNotHireOrRepair()
        {
            var customerHandlerFactory = new CustomerHandlerFactory();
            Assert.Throws(typeof(NotImplementedException), ()=> customerHandlerFactory.CreateCustomer(Innovation_test.Models.OrderType.None, true));
        }

        [Fact]
        public void FactoryReturnsHireCustomersIfHire()
        {
            var customerHandlerFactory = new CustomerHandlerFactory();
            var result = customerHandlerFactory.CreateCustomer(Innovation_test.Models.OrderType.Hire, false);
            var newResult = customerHandlerFactory.CreateCustomer(Innovation_test.Models.OrderType.Hire, true);
            Assert.Equal(typeof(HireCustomerHandler), result.GetType());
            Assert.Equal(typeof(NewHireCustomerHandler), newResult.GetType());
        }

        [Fact]
        public void FactoryReturnsRepairCustomersIfRepair()
        {
            var customerHandlerFactory = new CustomerHandlerFactory();
            var result = customerHandlerFactory.CreateCustomer(Innovation_test.Models.OrderType.Repair, false);
            var newResult = customerHandlerFactory.CreateCustomer(Innovation_test.Models.OrderType.Repair, true);
            Assert.Equal(typeof(RepairCustomerHandler), result.GetType());
            Assert.Equal(typeof(NewRepairCustomerHandler), newResult.GetType());
        }
    }
}