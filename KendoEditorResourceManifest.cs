using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Orchard.Environment.Extensions;
using Orchard.UI.Resources;

namespace Kendo.Web
{
    [OrchardFeature("Kendo.Admin.Editor")]
    public class KendoEditorResourceManifest : IResourceManifestProvider
    {
        public KendoEditorResourceManifest() 
        {
            
        }

        public void BuildManifests(ResourceManifestBuilder builder)
        {
            var manifest = builder.Add();

            manifest.DefineScript("kendo.Editor")
                .SetDependencies("kendo.web");
            
        }
    }
}
