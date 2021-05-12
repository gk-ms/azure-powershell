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
    /// Inbound NAT pool of the load balancer.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class InboundNatPool : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the InboundNatPool class.
        /// </summary>
        public InboundNatPool()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the InboundNatPool class.
        /// </summary>
        /// <param name="protocol">The reference to the transport protocol used
        /// by the inbound NAT pool. Possible values include: 'Udp', 'Tcp',
        /// 'All'</param>
        /// <param name="frontendPortRangeStart">The first port number in the
        /// range of external ports that will be used to provide Inbound Nat to
        /// NICs associated with a load balancer. Acceptable values range
        /// between 1 and 65534.</param>
        /// <param name="frontendPortRangeEnd">The last port number in the
        /// range of external ports that will be used to provide Inbound Nat to
        /// NICs associated with a load balancer. Acceptable values range
        /// between 1 and 65535.</param>
        /// <param name="backendPort">The port used for internal connections on
        /// the endpoint. Acceptable values are between 1 and 65535.</param>
        /// <param name="id">Resource ID.</param>
        /// <param name="frontendIPConfiguration">A reference to frontend IP
        /// addresses.</param>
        /// <param name="idleTimeoutInMinutes">The timeout for the TCP idle
        /// connection. The value can be set between 4 and 30 minutes. The
        /// default value is 4 minutes. This element is only used when the
        /// protocol is set to TCP.</param>
        /// <param name="enableFloatingIP">Configures a virtual machine's
        /// endpoint for the floating IP capability required to configure a SQL
        /// AlwaysOn Availability Group. This setting is required when using
        /// the SQL AlwaysOn Availability Groups in SQL server. This setting
        /// can't be changed after you create the endpoint.</param>
        /// <param name="enableTcpReset">Receive bidirectional TCP Reset on TCP
        /// flow idle timeout or unexpected connection termination. This
        /// element is only used when the protocol is set to TCP.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// inbound NAT pool resource. Possible values include: 'Succeeded',
        /// 'Updating', 'Deleting', 'Failed'</param>
        /// <param name="name">The name of the resource that is unique within
        /// the set of inbound NAT pools used by the load balancer. This name
        /// can be used to access the resource.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        /// <param name="type">Type of the resource.</param>
        public InboundNatPool(string protocol, int frontendPortRangeStart, int frontendPortRangeEnd, int backendPort, string id = default(string), SubResource frontendIPConfiguration = default(SubResource), int? idleTimeoutInMinutes = default(int?), bool? enableFloatingIP = default(bool?), bool? enableTcpReset = default(bool?), string provisioningState = default(string), string name = default(string), string etag = default(string), string type = default(string))
            : base(id)
        {
            FrontendIPConfiguration = frontendIPConfiguration;
            Protocol = protocol;
            FrontendPortRangeStart = frontendPortRangeStart;
            FrontendPortRangeEnd = frontendPortRangeEnd;
            BackendPort = backendPort;
            IdleTimeoutInMinutes = idleTimeoutInMinutes;
            EnableFloatingIP = enableFloatingIP;
            EnableTcpReset = enableTcpReset;
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
        /// Gets or sets a reference to frontend IP addresses.
        /// </summary>
        [JsonProperty(PropertyName = "properties.frontendIPConfiguration")]
        public SubResource FrontendIPConfiguration { get; set; }

        /// <summary>
        /// Gets or sets the reference to the transport protocol used by the
        /// inbound NAT pool. Possible values include: 'Udp', 'Tcp', 'All'
        /// </summary>
        [JsonProperty(PropertyName = "properties.protocol")]
        public string Protocol { get; set; }

        /// <summary>
        /// Gets or sets the first port number in the range of external ports
        /// that will be used to provide Inbound Nat to NICs associated with a
        /// load balancer. Acceptable values range between 1 and 65534.
        /// </summary>
        [JsonProperty(PropertyName = "properties.frontendPortRangeStart")]
        public int FrontendPortRangeStart { get; set; }

        /// <summary>
        /// Gets or sets the last port number in the range of external ports
        /// that will be used to provide Inbound Nat to NICs associated with a
        /// load balancer. Acceptable values range between 1 and 65535.
        /// </summary>
        [JsonProperty(PropertyName = "properties.frontendPortRangeEnd")]
        public int FrontendPortRangeEnd { get; set; }

        /// <summary>
        /// Gets or sets the port used for internal connections on the
        /// endpoint. Acceptable values are between 1 and 65535.
        /// </summary>
        [JsonProperty(PropertyName = "properties.backendPort")]
        public int BackendPort { get; set; }

        /// <summary>
        /// Gets or sets the timeout for the TCP idle connection. The value can
        /// be set between 4 and 30 minutes. The default value is 4 minutes.
        /// This element is only used when the protocol is set to TCP.
        /// </summary>
        [JsonProperty(PropertyName = "properties.idleTimeoutInMinutes")]
        public int? IdleTimeoutInMinutes { get; set; }

        /// <summary>
        /// Gets or sets configures a virtual machine's endpoint for the
        /// floating IP capability required to configure a SQL AlwaysOn
        /// Availability Group. This setting is required when using the SQL
        /// AlwaysOn Availability Groups in SQL server. This setting can't be
        /// changed after you create the endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enableFloatingIP")]
        public bool? EnableFloatingIP { get; set; }

        /// <summary>
        /// Gets or sets receive bidirectional TCP Reset on TCP flow idle
        /// timeout or unexpected connection termination. This element is only
        /// used when the protocol is set to TCP.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enableTcpReset")]
        public bool? EnableTcpReset { get; set; }

        /// <summary>
        /// Gets the provisioning state of the inbound NAT pool resource.
        /// Possible values include: 'Succeeded', 'Updating', 'Deleting',
        /// 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets the name of the resource that is unique within the set
        /// of inbound NAT pools used by the load balancer. This name can be
        /// used to access the resource.
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
        /// Gets type of the resource.
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
            if (Protocol == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Protocol");
            }
        }
    }
}
