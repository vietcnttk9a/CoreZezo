using PMS.MultiTenancy.Payments.Stripe;

namespace PMS.Web.Controllers
{
    public class StripeController : StripeControllerBase
    {
        public StripeController(
            StripeGatewayManager stripeGatewayManager,
            StripePaymentGatewayConfiguration stripeConfiguration)
            : base(stripeGatewayManager, stripeConfiguration)
        {
        }
    }
}
