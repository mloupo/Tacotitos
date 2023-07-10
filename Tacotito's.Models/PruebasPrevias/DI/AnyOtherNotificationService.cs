using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tacotito_s.PruebasPrevias.DI
{
    public class AnyOtherNotificationService : IEventNotificationService
    {
        public void LogEvent(string message)
        {
            //Code to log event on this monitoring service app
        }
    }
}
