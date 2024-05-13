using Command.FX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class AddCustomerCommand : ICommand
    {
        private readonly CustomerService _customerService;

        public AddCustomerCommand(CustomerService _customerService)
        {
            this._customerService = _customerService;
        }

        public void Execute()
        {
            _customerService.AddCustomer();
        }
    }
}
