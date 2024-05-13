using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class TransferMoneyTask : Task
    {

        public TransferMoneyTask() 
        {
                
        }

        public TransferMoneyTask(AuditTrail _auditTrail) : base(_auditTrail)
        {
           
        }

        override protected void DoExecute()
        {
            Console.WriteLine("Transfer Money between Accounts");
        }

        
    }
}
