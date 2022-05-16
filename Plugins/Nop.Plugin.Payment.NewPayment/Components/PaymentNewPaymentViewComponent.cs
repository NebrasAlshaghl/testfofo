﻿using Microsoft.AspNetCore.Mvc;
using Nop.Web.Framework.Components;

namespace Nop.Plugin.Payments.NewPayment.Components
{
    [ViewComponent(Name = "PaymentNewPayment")]
    public class PaymentNewPaymentViewComponent : NopViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("~/Plugins/Payments.NewPayment/Views/NewPaymentInfo.cshtml");
        }
    }
}
