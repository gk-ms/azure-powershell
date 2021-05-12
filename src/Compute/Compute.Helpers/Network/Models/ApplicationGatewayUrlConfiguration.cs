// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Commands.Compute.Helpers.Network.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Url configuration of the Actions set in Application Gateway.
    /// </summary>
    public partial class ApplicationGatewayUrlConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationGatewayUrlConfiguration class.
        /// </summary>
        public ApplicationGatewayUrlConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationGatewayUrlConfiguration class.
        /// </summary>
        /// <param name="modifiedPath">Url path which user has provided for url
        /// rewrite. Null means no path will be updated. Default value is
        /// null.</param>
        /// <param name="modifiedQueryString">Query string which user has
        /// provided for url rewrite. Null means no query string will be
        /// updated. Default value is null.</param>
        /// <param name="reroute">If set as true, it will re-evaluate the url
        /// path map provided in path based request routing rules using
        /// modified path. Default value is false.</param>
        public ApplicationGatewayUrlConfiguration(string modifiedPath = default(string), string modifiedQueryString = default(string), bool? reroute = default(bool?))
        {
            ModifiedPath = modifiedPath;
            ModifiedQueryString = modifiedQueryString;
            Reroute = reroute;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets url path which user has provided for url rewrite. Null
        /// means no path will be updated. Default value is null.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedPath")]
        public string ModifiedPath { get; set; }

        /// <summary>
        /// Gets or sets query string which user has provided for url rewrite.
        /// Null means no query string will be updated. Default value is null.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedQueryString")]
        public string ModifiedQueryString { get; set; }

        /// <summary>
        /// Gets or sets if set as true, it will re-evaluate the url path map
        /// provided in path based request routing rules using modified path.
        /// Default value is false.
        /// </summary>
        [JsonProperty(PropertyName = "reroute")]
        public bool? Reroute { get; set; }

    }
}
