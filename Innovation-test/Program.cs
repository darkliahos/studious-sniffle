// See https://aka.ms/new-console-template for more information
using Innovation_test;
using Innovation_test.Models;
using Innovation_test.Processors;

Console.WriteLine("===Is this for a new customer? (y/n) ===");

string isCustomerString = Console.ReadLine();

// Note this probably not a good way to handle this, lets assume the user behaves themselves :D
bool isNewCustomer = isCustomerString.ToLower() == "y" ? true : false;

Console.WriteLine("=== What type of order is this? (Type Repair, or Hire ) ===");

string orderTypeString = Console.ReadLine();

OrderType orderType = (OrderType)Enum.Parse(typeof(OrderType), orderTypeString, true);

Console.WriteLine("===Is this a rush order? (y/n) ===");
string isRushString = Console.ReadLine();
bool isRushOrder = isRushString.ToLower() == "y" ? true : false;

Console.WriteLine("===Is this a large order? (y/n) ===");
string isLargeString = Console.ReadLine();
bool isLargeOrder = isLargeString.ToLower() == "y" ? true : false;


// TODO: Be good to autofac or another DI container

var factory = new CustomerHandlerFactory();

var customerHandler = factory.CreateCustomer(orderType, isNewCustomer);

var processor = new OrderProcessor(customerHandler);

var orchestrator = new OrderProcessorOrchestrator(processor);

var result = orchestrator.ProcessOrder(isRushOrder, isLargeOrder);

Console.WriteLine("=== Order Status ===");

Console.WriteLine(result);

Console.ReadLine();
