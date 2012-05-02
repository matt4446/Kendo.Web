using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Orchard.UI.Resources;

namespace Kendo.Web
{
    public class ResourceManifest : IResourceManifestProvider
    {

        public void BuildManifests(ResourceManifestBuilder builder)
        {
            var manifest = builder.Add();

            var mainScript = "kendo.web";

            var version = "2012.1.327";

            manifest.DefineScript(mainScript)
                .SetUrl("kendo.all.min.js")
                .SetDependencies("jQuery")
                .SetVersion(version);

            manifest.DefineStyle("kendo.web.common")
                .SetUrl("kendo.common.min.css")
                .SetVersion(version);

            manifest.DefineStyle("kendo.web.default")
                .SetUrl("kendo.default.min.css")
                .SetVersion(version);

            manifest.DefineStyle("kendo.web.black")
                .SetUrl("kendo.black.min.css")
                .SetVersion(version);

            manifest.DefineStyle("kendo.web.blueopal")
                .SetUrl("kendo.blueopal.min.css")
                .SetVersion(version);

            manifest.DefineStyle("kendo.web.metro")
                .SetUrl("kendo.metro.min.css")
                .SetVersion(version);

            manifest.DefineStyle("kendo.web.silver")
                .SetUrl("kendo.silver.min.css")
                .SetVersion(version);
        }

    }
}
