using System;
using System.Collections.Generic;
using System.Text;
using Nop.Web.Framework.Components;
using Microsoft.AspNetCore.Mvc;

namespace Nop.Plugin.New.FirstPlugin.Components
{
     public class FirstPluginViewComponents:NopViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("");
        }
         
    }
}
