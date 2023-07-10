using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tacotito_s.PruebasPrevias.DI
{
    public interface IEventNotificationService
    {
        void LogEvent(string message);
    }
}
