using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace testThread
{
    public class attente
    {
        private readonly EventWaitHandle WaitAcknowledgment = new EventWaitHandle(false, EventResetMode.AutoReset);
        public attente()
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
