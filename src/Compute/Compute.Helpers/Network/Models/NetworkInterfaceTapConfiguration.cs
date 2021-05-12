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
    using System.Linq;

    /// <summary>
    /// Tap configuration in a Network Interface.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class NetworkInterfaceTapConfiguration : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the NetworkInterfaceTapConfiguration
        /// class.
        /// </summary>
        public NetworkInterfaceTapConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NetworkInterfaceTapConfiguration
        /// class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="virtualNetworkTap">The reference to the Virtual
        /// Network Tap resource.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// network interface tap configuration resource. Possible values
        /// include: 'Succeeded', 'Updating', 'Deleting', 'Failed'</param>
        /// <param name="name">The name of the resource that is unique within a
        /// resource group. This name can be used to access the
        /// resource.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        /// <param name="type">Sub Resource type.</param>
        public NetworkInterfaceTapConfiguration(string id = default(string), VirtualNetworkTap virtualNetworkTap = default(VirtualNetworkTap), string provisioningState = default(string), string name = default(string), string etag = default(string), string type = default(string))
            : base(id)
        {
            VirtualNetworkTap = virtualNetworkTap;
            ProvisioningState = provisioningState;
            Name = name;
            Etag = etag;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the reference to the Virtual Network Tap resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.virtualNetworkTap")]
        public VirtualNetworkTap VirtualNetworkTap { get; set; }

        /// <summary>
        /// Gets the provisioning state of the network interface tap
        /// configuration resource. Possible values include: 'Succeeded',
        /// 'Updating', 'Deleting', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets the name of the resource that is unique within a
        /// resource group. This name can be used to access the resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

        /// <summary>
        /// Gets sub Resource type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (VirtualNetworkTap != null)
            {
                VirtualNetworkTap.Validate();
            }
        }
    }
}
