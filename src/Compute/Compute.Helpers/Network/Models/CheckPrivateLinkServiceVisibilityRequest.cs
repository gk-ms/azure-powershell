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
    /// Request body of the CheckPrivateLinkServiceVisibility API service call.
    /// </summary>
    public partial class CheckPrivateLinkServiceVisibilityRequest
    {
        /// <summary>
        /// Initializes a new instance of the
        /// CheckPrivateLinkServiceVisibilityRequest class.
        /// </summary>
        public CheckPrivateLinkServiceVisibilityRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// CheckPrivateLinkServiceVisibilityRequest class.
        /// </summary>
        /// <param name="privateLinkServiceAlias">The alias of the private link
        /// service.</param>
        public CheckPrivateLinkServiceVisibilityRequest(string privateLinkServiceAlias = default(string))
        {
            PrivateLinkServiceAlias = privateLinkServiceAlias;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the alias of the private link service.
        /// </summary>
        [JsonProperty(PropertyName = "privateLinkServiceAlias")]
        public string PrivateLinkServiceAlias { get; set; }

    }
}
