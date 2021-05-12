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
    /// IP configuration for virtual network gateway.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class VirtualNetworkGatewayIPConfiguration : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualNetworkGatewayIPConfiguration class.
        /// </summary>
        public VirtualNetworkGatewayIPConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// VirtualNetworkGatewayIPConfiguration class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="privateIPAllocationMethod">The private IP address
        /// allocation method. Possible values include: 'Static',
        /// 'Dynamic'</param>
        /// <param name="subnet">The reference to the subnet resource.</param>
        /// <param name="publicIPAddress">The reference to the public IP
        /// resource.</param>
        /// <param name="privateIPAddress">Private IP Address for this
        /// gateway.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// virtual network gateway IP configuration resource. Possible values
        /// include: 'Succeeded', 'Updating', 'Deleting', 'Failed'</param>
        /// <param name="name">The name of the resource that is unique within a
        /// resource group. This name can be used to access the
        /// resource.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        public VirtualNetworkGatewayIPConfiguration(string id = default(string), string privateIPAllocationMethod = default(string), SubResource subnet = default(SubResource), SubResource publicIPAddress = default(SubResource), string privateIPAddress = default(string), string provisioningState = default(string), string name = default(string), string etag = default(string))
            : base(id)
        {
            PrivateIPAllocationMethod = privateIPAllocationMethod;
            Subnet = subnet;
            PublicIPAddress = publicIPAddress;
            PrivateIPAddress = privateIPAddress;
            ProvisioningState = provisioningState;
            Name = name;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the private IP address allocation method. Possible
        /// values include: 'Static', 'Dynamic'
        /// </summary>
        [JsonProperty(PropertyName = "properties.privateIPAllocationMethod")]
        public string PrivateIPAllocationMethod { get; set; }

        /// <summary>
        /// Gets or sets the reference to the subnet resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.subnet")]
        public SubResource Subnet { get; set; }

        /// <summary>
        /// Gets or sets the reference to the public IP resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.publicIPAddress")]
        public SubResource PublicIPAddress { get; set; }

        /// <summary>
        /// Gets private IP Address for this gateway.
        /// </summary>
        [JsonProperty(PropertyName = "properties.privateIPAddress")]
        public string PrivateIPAddress { get; private set; }

        /// <summary>
        /// Gets the provisioning state of the virtual network gateway IP
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

    }
}
