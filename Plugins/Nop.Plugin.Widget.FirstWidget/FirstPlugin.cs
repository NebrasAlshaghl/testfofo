using System;
using System.Collections.Generic;
using System.Text;
using Nop.Services.Plugins;
using Nop.Services.Cms;
using Nop.Web.Framework.Infrastructure;


namespace Nop.Plugin.Widget.FirstPlugin
{
    public class FirstPlugin: BasePlugin,IWidgetPlugin
    {
        public bool HideInWidgetList => false;

        public string GetWidgetViewComponentName(string widgetZone)
        {
            return "This is the News Section";
        }

        public IList<string> GetWidgetZones()
        {
            return new List<string> { PublicWidgetZones.HomepageBeforeNews };
        }

        public override void Install()
        {
            base.Install();
        }

        public override void Uninstall()
        {
            base.Uninstall();
        }
    }
}
