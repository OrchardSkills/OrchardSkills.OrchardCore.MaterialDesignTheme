using OrchardCore.ResourceManagement;

namespace OrchardCore.Themes.MaterialDesignTheme
{
    public class ResourceManifest : IResourceManifestProvider
    {
        public void BuildManifests(IResourceManifestBuilder builder)
        {
            var manifest = builder.Add();



            manifest
                .DefineStyle("MaterialDesignTheme-css" )
                .SetUrl("~/MaterialDesignTheme/css/mdb.min.css", "~/MaterialDesignTheme/css/mdb.css")
                .SetVersion("1.0.0");

            manifest
                .DefineScript("MaterialDesignTheme-js")
                .SetUrl("~/MaterialDesignTheme/js/mdb.min.js", "~/MaterialDesignTheme/js/mdb.js")
                .SetVersion("1.0.0");

            manifest
                .DefineStyle("MaterialDesignTheme-vendor-font-awesome")
                .SetUrl("~/MaterialDesignTheme/vendor/fontawesome-free/css/all.min.css", "~/MaterialDesignTheme/vendor/fontawesome-free/css/all.css")
                .SetCdn("https://cdn.jsdelivr.net/npm/@fortawesome/fontawesome-free@5.13.0/css/all.min.css", "https://cdn.jsdelivr.net/npm/@fortawesome/fontawesome-free@5.13.0/css/all.css")
                .SetCdnIntegrity("sha384-Bfad6CLCknfcloXFOyFnlgtENryhrpZCe29RTifKEixXQZ38WheV+i/6YWSzkz3V", "sha384-I4s88/QBf6OKVFMRRyjRY9wYdRoEO/PnNLQ1xY+G0OQfntKp8FxRsOg9qjmtbnvL")
                .SetVersion("5.13.0");

            manifest
                .DefineScript("MaterialDesignTheme-vendor-font-awesome")
                .SetCdn("https://cdn.jsdelivr.net/npm/@fortawesome/fontawesome-free@5.13.0/js/all.min.js", "https://cdn.jsdelivr.net/npm/@fortawesome/fontawesome-free@5.13.0/js/all.js")
                .SetCdnIntegrity("sha384-ujbKXb9V3HdK7jcWL6kHL1c+2Lj4MR4Gkjl7UtwpSHg/ClpViddK9TI7yU53frPN", "sha384-Z4FE6Znluj29FL1tQBLSSjn1Pr72aJzuelbmGmqSAFTeFd42hQ4WHTc0JC30kbQi")
                .SetVersion("5.13.0");
        }
    }
}
