using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public abstract class Task
    {
        private readonly AuditTrail _auditTrail;

        protected Task()
        {
            _auditTrail = new AuditTrail();
        }

        public Task(AuditTrail _auditTrail)
        {
            this._auditTrail = _auditTrail;
        }

        
        //Template Method
        public void Execute() 
        {
            _auditTrail.Record();
            DoExecute();
        }

        //called hook, because it is hooked to the excute method
        protected abstract void DoExecute(); //Potected: only its subclass know how to do the doExcute and this
                                             //couldn't shown in the consumer

    }
}
