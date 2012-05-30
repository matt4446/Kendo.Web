using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Orchard.UI.Resources;
using System.Collections;

namespace Kendo.Web
{
    public class KendoResourceManifest : IResourceManifestProvider
    {
        public static string MainScript = "kendo.web";
        private string VersionPath(string version, string file) 
        {
            return string.Format("{0}/{1}", version, file);
        }

        public void DefineScripts(ResourceManifest manifest, string key, string currentVersion, params string[] previousVersions)
        {
            var versions = new List<string>(previousVersions) { currentVersion };
            
            foreach (var ver in versions)
            {
                manifest.DefineScript(key).SetUrl(VersionPath(ver, "kendo.all.min.js") //, VersionPath(ver, "kendo.all.js")
                   )
                   .SetDependencies("jQuery")
                   .SetVersion(ver);    
            }

            manifest.DefineScript("kendo.datasource")
                .SetUrl("custom/datasource.js")
                .SetDependencies(key);
        }

        public static string keyFormat = "{0}.{1}";
        public void DefineStyles(ResourceManifest manifest, string key, string currentVersion, params string[] previousVersions) 
        {
            var versions = new List<string>(previousVersions) { currentVersion };
            //versions.AddRange(previousVersions);

            Func<string, string, string> format = (a,b) => {
                return string.Format(keyFormat, a, b);
            };

            string commonDependency = format(key, "common");

            foreach (var version in versions) 
            { 
                manifest.DefineStyle(format(key, "common"))
                    .SetUrl(VersionPath(version, "kendo.common.min.css"))
                    .SetVersion(version);

                manifest.DefineStyle(format(key, "default"))
                    .SetUrl(VersionPath(version, "kendo.default.min.css"))
                    .SetDependencies(commonDependency)
                    .SetVersion(version);

                manifest.DefineStyle(format(key, "black"))
                    .SetUrl(VersionPath(version, "kendo.black.min.css"))
                    .SetDependencies(commonDependency)
                    .SetVersion(version);

                manifest.DefineStyle(format(key, "blueopal"))
                    .SetUrl(VersionPath(version, "kendo.blueopal.min.css"))
                    .SetDependencies(commonDependency)
                    .SetVersion(version);

                manifest.DefineStyle(format(key, "metro"))
                    .SetUrl(VersionPath(version, "kendo.metro.min.css"))
                    .SetDependencies(commonDependency)
                    .SetVersion(version);

                manifest.DefineStyle(format(key, "silver"))
                    .SetUrl(VersionPath(version, "kendo.silver.min.css"))
                    .SetDependencies(commonDependency)
                    .SetVersion(version);

            }

        }

        public void DefineCultureSet(ResourceManifest manifest, string key, string currentVersion, params string[] previousVersions)
        {
            manifest.DefineScript("kendo.culture.en-gb")
                .SetUrl("culture/kendo.culture.en-gb.js")
                .SetDependencies(MainScript);

        }

        public void BuildManifests(ResourceManifestBuilder builder)
        {
            var manifest = builder.Add();

            var mainScript = MainScript;

            string currentVerison = "2012.2.621";
            string[] versions = new [] { "2012.1.327" };

            this.DefineScripts(manifest, mainScript, currentVerison, versions);
            this.DefineStyles(manifest, mainScript, currentVerison, versions);
            this.DefineCultureSet(manifest, mainScript, currentVerison, versions);

        }

    }
}
