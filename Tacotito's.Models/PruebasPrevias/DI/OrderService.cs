using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tacotito_s.PruebasPrevias.DI
{
    public class OrderService
    {
        public readonly IEventNotificationService _evenNotificationService;

        public OrderService(IEventNotificationService dataDogService)
        {
            _evenNotificationService = dataDogService;
        }
        public void GenerateOrder(OrderService order)
        {
            //Code to create Order
            //Send notification to Datadog
            _evenNotificationService.LogEvent("The Order was Successfully Created");
        }
    }
}
