using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tacotito_s.PruebasPrevias.SR
{
    public interface ILoggerService
    {
        void Info(string info);
        void Debug(string info);
        void Error(string message, Exception ex);
    }
}
