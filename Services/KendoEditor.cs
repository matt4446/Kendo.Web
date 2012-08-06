using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Orchard.Environment.Extensions;
using Orchard.Services;

namespace Kendo.Web.Services
{
    [OrchardFeature("Kendo.Admin.Editor")]
    public class KendoEditor : IHtmlFilter
    {
        public string ProcessContent(string text, string flavor)
        {
            return 
                flavor.Equals("kendo", StringComparison.OrdinalIgnoreCase) ? 
                KendoReplaceText(text) : 
                text;
        }

        private static string KendoReplaceText(string text)
        {
            if (string.IsNullOrEmpty(text))
                return string.Empty;

            return text;
        }
    }
}
