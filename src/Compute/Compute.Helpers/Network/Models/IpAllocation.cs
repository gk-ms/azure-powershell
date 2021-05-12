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
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// IpAllocation resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class IpAllocation : Resource
    {
        /// <summary>
        /// Initializes a new instance of the IpAllocation class.
        /// </summary>
        public IpAllocation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IpAllocation class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="location">Resource location.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="subnet">The Subnet that using the prefix of this
        /// IpAllocation resource.</param>
        /// <param name="virtualNetwork">The VirtualNetwork that using the
        /// prefix of this IpAllocation resource.</param>
        /// <param name="ipAllocationType">The type for the IpAllocation.
        /// Possible values include: 'Undefined', 'Hypernet'</param>
        /// <param name="prefix">The address prefix for the
        /// IpAllocation.</param>
        /// <param name="prefixLength">The address prefix length for the
        /// IpAllocation.</param>
        /// <param name="prefixType">The address prefix Type for the
        /// IpAllocation. Possible values include: 'IPv4', 'IPv6'</param>
        /// <param name="ipamAllocationId">The IPAM allocation ID.</param>
        /// <param name="allocationTags">IpAllocation tags.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        public IpAllocation(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), SubResource subnet = default(SubResource), SubResource virtualNetwork = default(SubResource), string ipAllocationType = default(string), string prefix = default(string), int? prefixLength = default(int?), string prefixType = default(string), string ipamAllocationId = default(string), IDictionary<string, string> allocationTags = default(IDictionary<string, string>), string etag = default(string))
            : base(id, name, type, location, tags)
        {
            Subnet = subnet;
            VirtualNetwork = virtualNetwork;
            IpAllocationType = ipAllocationType;
            Prefix = prefix;
            PrefixLength = prefixLength;
            PrefixType = prefixType;
            IpamAllocationId = ipamAllocationId;
            AllocationTags = allocationTags;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the Subnet that using the prefix of this IpAllocation
        /// resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.subnet")]
        public SubResource Subnet { get; private set; }

        /// <summary>
        /// Gets the VirtualNetwork that using the prefix of this IpAllocation
        /// resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.virtualNetwork")]
        public SubResource VirtualNetwork { get; private set; }

        /// <summary>
        /// Gets or sets the type for the IpAllocation. Possible values
        /// include: 'Undefined', 'Hypernet'
        /// </summary>
        [JsonProperty(PropertyName = "properties.type")]
        public string IpAllocationType { get; set; }

        /// <summary>
        /// Gets or sets the address prefix for the IpAllocation.
        /// </summary>
        [JsonProperty(PropertyName = "properties.prefix")]
        public string Prefix { get; set; }

        /// <summary>
        /// Gets or sets the address prefix length for the IpAllocation.
        /// </summary>
        [JsonProperty(PropertyName = "properties.prefixLength")]
        public int? PrefixLength { get; set; }

        /// <summary>
        /// Gets or sets the address prefix Type for the IpAllocation. Possible
        /// values include: 'IPv4', 'IPv6'
        /// </summary>
        [JsonProperty(PropertyName = "properties.prefixType")]
        public string PrefixType { get; set; }

        /// <summary>
        /// Gets or sets the IPAM allocation ID.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ipamAllocationId")]
        public string IpamAllocationId { get; set; }

        /// <summary>
        /// Gets or sets ipAllocation tags.
        /// </summary>
        [JsonProperty(PropertyName = "properties.allocationTags")]
        public IDictionary<string, string> AllocationTags { get; set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

    }
}
