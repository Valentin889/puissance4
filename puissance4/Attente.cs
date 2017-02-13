using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace puissance4
{
    public class Attente
    {
        private readonly EventWaitHandle WaitAcknowledgment = new EventWaitHandle(false, EventResetMode.AutoReset);
        public Attente()
        {

        }
        public void MethodWait()
        {
            WaitAcknowledgment.WaitOne();
        }
        public void MethodeRelease()
        {
            WaitAcknowledgment.Set();
        }
    }
}
