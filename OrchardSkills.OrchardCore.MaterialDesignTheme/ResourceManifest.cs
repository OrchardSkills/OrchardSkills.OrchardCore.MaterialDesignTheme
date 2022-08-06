using Microsoft.Extensions.Options;
using OrchardCore.ResourceManagement;

namespace OrchardCore.Themes.MaterialDesignTheme
{
    public class ResourceManagementOptionsConfiguration : IConfigureOptions<ResourceManagementOptions>
    {
        private static ResourceManifest _manifest;
        static ResourceManagementOptionsConfiguration()
        {
            _manifest = new ResourceManifest();

            _manifest
                .DefineStyle("MaterialDesignTheme-css" )
                .SetCdn("https://cdnjs.cloudflare.com/ajax/libs/mdb-ui-kit/4.2.0/mdb.min.css")
                .SetCdnIntegrity("sha512-YE4ntZgHu6nnEp3CzcxwP07khLufHMwLthDhSd4SJQI2xhsdWjjjpCY7wF8e0eKhdGO6i0o1YVxZd6f1z4zN+Q==")
                .SetUrl("~/MaterialDesignTheme/css/mdb.min.css")
                .SetVersion("4.2.0");

            _manifest
                .DefineScript("MaterialDesignTheme-js")
                .SetCdn("https://cdnjs.cloudflare.com/ajax/libs/mdb-ui-kit/4.2.0/mdb.min.js")
                .SetCdnIntegrity("sha512-Wq5ip5NUbm4Ka2BqR/KkJIJdRFQAdpVluNIENMHHPJysUkBtIR1MmqKu2tfPZvuJdm4q5/KQDgqLSR6BL23pFw==")
                .SetUrl("~/MaterialDesignTheme/js/mdb.min.js")
                .SetVersion("4.2.0");

            _manifest
                .DefineStyle("MaterialDesignTheme-vendor-font-awesome")
                .SetUrl("https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.1.1/css/all.min.css")
                .SetCdnIntegrity("sha512-KfkfwYDsLkIlwQp6LFnl8zNdLGxu9YAA1QvwINks4PhcElQSvqcyVLLD9aMhXd13uQjoXtEKNosOWaZqXgel0g==")
                .SetVersion("6.1.1");

            _manifest
                .DefineScript("MaterialDesignTheme-vendor-font-awesome")
                .SetCdn("https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.1.1/js/all.min.js")
                .SetCdnIntegrity("sha512-6PM0qYu5KExuNcKt5bURAoT6KCThUmHRewN3zUFNaoI6Di7XJPTMoT6K0nsagZKk2OB4L7E3q1uQKHNHd4stIQ==")
                .SetVersion("6.1.1");
        }
        public void Configure(ResourceManagementOptions options)
        {
            options.ResourceManifests.Add(_manifest);
        }
    }
}
