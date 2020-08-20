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
                .SetUrl("~/MaterialDesignTheme/css/mdb.min.css")
                .SetVersion("1.0.0");

            manifest
                .DefineScript("MaterialDesignTheme-js")
                .SetUrl("~/MaterialDesignTheme/js/mdb.min.js")
                .SetVersion("1.0.0");

            manifest
                .DefineStyle("MaterialDesignTheme-vendor-font-awesome")
                .SetUrl("https://cdn.jsdelivr.net/npm/@fortawesome/fontawesome-free@5.14.0/css/all.min.css")
                .SetCdnIntegrity("sha256-FMvZuGapsJLjouA6k7Eo2lusoAX9i0ShlWFG6qt7SLc=")
                .SetVersion("5.14.0");

            manifest
                .DefineScript("MaterialDesignTheme-vendor-font-awesome")
                .SetCdn("https://cdn.jsdelivr.net/npm/@fortawesome/fontawesome-free@5.14.0/js/fontawesome.min.js")
                .SetCdnIntegrity("sha256-dNZKI9qQEpJG03MLdR2Rg9Dva1o+50fN3zmlDP+3I+Y=")
                .SetVersion("5.14.0");
        }
    }
}
