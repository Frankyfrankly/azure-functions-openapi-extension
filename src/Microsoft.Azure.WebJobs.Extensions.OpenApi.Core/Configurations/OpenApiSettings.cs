using System;
using System.Collections.Generic;

using Microsoft.OpenApi.Models;

namespace Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Configurations
{
    /// <summary>
    /// This represents the settings entity for Open API metadata.
    /// </summary>
    [Obsolete("This class is obsolete from 0.5.0-preview. Use OpenApiConfigurationOptions instead", error: true)]
    public sealed class OpenApiSettings : IOpenApiConfigurationOptions
    {
        /// <inheritdoc />
        public OpenApiInfo Info { get; set; } = new OpenApiInfo()
        {
            Version = "1.0.0",
            Title = "Azure Functions Open API Extension",
        };

        /// <inheritdoc />
        public List<OpenApiServer> Servers { get; set; } = new List<OpenApiServer>();
    }
}
