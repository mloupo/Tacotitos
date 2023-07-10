using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tacotito_s.PruebasPrevias.SR
{
    public interface INotificationService
    {
        bool EmailInvoice(InvoiceService invoice);
    }
}
