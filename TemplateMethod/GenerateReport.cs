using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class GenerateReport
    {
        //problem on this each repeatitions and eachtime create a task class we need to remeber to injec the audit trail
        private readonly AuditTrail _auditTrail;

        public GenerateReport(AuditTrail _auditTrail)
        {
            this._auditTrail = _auditTrail;
        }

        public void Execute()
        {
            _auditTrail.Record();
            Console.WriteLine("Generate Financial Report");
        }
    }
}
