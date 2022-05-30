using Innovation_test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innovation_test.Handlers
{
    public interface ICustomerHandler
    {
        OrderStatus LargeOrder();

        OrderStatus LargeRushOrder();

        OrderStatus Order();

        OrderStatus RushOrder();


    }
}
