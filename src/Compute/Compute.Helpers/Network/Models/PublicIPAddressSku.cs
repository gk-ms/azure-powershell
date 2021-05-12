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
    /// SKU of a public IP address.
    /// </summary>
    public partial class PublicIPAddressSku
    {
        /// <summary>
        /// Initializes a new instance of the PublicIPAddressSku class.
        /// </summary>
        public PublicIPAddressSku()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PublicIPAddressSku class.
        /// </summary>
        /// <param name="name">Name of a public IP address SKU. Possible values
        /// include: 'Basic', 'Standard'</param>
        /// <param name="tier">Tier of a public IP address SKU. Possible values
        /// include: 'Regional', 'Global'</param>
        public PublicIPAddressSku(string name = default(string), string tier = default(string))
        {
            Name = name;
            Tier = tier;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of a public IP address SKU. Possible values
        /// include: 'Basic', 'Standard'
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets tier of a public IP address SKU. Possible values
        /// include: 'Regional', 'Global'
        /// </summary>
        [JsonProperty(PropertyName = "tier")]
        public string Tier { get; set; }

    }
}
