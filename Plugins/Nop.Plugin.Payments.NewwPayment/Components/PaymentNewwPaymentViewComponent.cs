using Microsoft.AspNetCore.Mvc;
using Nop.Web.Framework.Components;

namespace Nop.Plugin.Payments.NewwPayment.Components
{
    [ViewComponent(Name = "PaymentNewwPayment")]
    public class PaymentPayPalStandardViewComponent : NopViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("~/Plugins/Payments.NewwPayment/Views/NewwPaymentInfo.cshtml");
        }
    }
}
