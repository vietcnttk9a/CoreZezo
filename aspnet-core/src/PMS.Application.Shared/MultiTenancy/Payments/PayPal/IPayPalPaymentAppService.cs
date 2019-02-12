using System.Threading.Tasks;
using Abp.Application.Services;
using PMS.MultiTenancy.Payments.Dto;
using PMS.MultiTenancy.Payments.PayPal.Dto;

namespace PMS.MultiTenancy.Payments.PayPal
{
    public interface IPayPalPaymentAppService : IApplicationService
    {
        Task ConfirmPayment(long paymentId, string paypalPaymentId, string paypalPayerId);

        PayPalConfigurationDto GetConfiguration();

        Task CancelPayment(CancelPaymentDto input);
    }
}
