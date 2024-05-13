using Command.FX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class AddOrderCommand(OrderService _orderService) : ICommand
    {
        private readonly OrderService _orderService = _orderService;

        public void Execute()
        {
            _orderService.AddOrder();
        }
    }
}
