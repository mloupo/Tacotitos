using Tacotito_s.PruebasPrevias.SR;

namespace Tacotito_s.PruebasPrevias.OC
{
    public interface IReportGenerator
    {
        void CreateReport(List<Order> orders);
    }
}