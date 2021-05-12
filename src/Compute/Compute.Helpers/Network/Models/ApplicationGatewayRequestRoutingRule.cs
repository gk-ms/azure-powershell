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
    /// Request routing rule of an application gateway.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ApplicationGatewayRequestRoutingRule : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationGatewayRequestRoutingRule class.
        /// </summary>
        public ApplicationGatewayRequestRoutingRule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationGatewayRequestRoutingRule class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="ruleType">Rule type. Possible values include: 'Basic',
        /// 'PathBasedRouting'</param>
        /// <param name="priority">Priority of the request routing
        /// rule.</param>
        /// <param name="backendAddressPool">Backend address pool resource of
        /// the application gateway.</param>
        /// <param name="backendHttpSettings">Backend http settings resource of
        /// the application gateway.</param>
        /// <param name="httpListener">Http listener resource of the
        /// application gateway.</param>
        /// <param name="urlPathMap">URL path map resource of the application
        /// gateway.</param>
        /// <param name="rewriteRuleSet">Rewrite Rule Set resource in Basic
        /// rule of the application gateway.</param>
        /// <param name="redirectConfiguration">Redirect configuration resource
        /// of the application gateway.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// request routing rule resource. Possible values include:
        /// 'Succeeded', 'Updating', 'Deleting', 'Failed'</param>
        /// <param name="name">Name of the request routing rule that is unique
        /// within an Application Gateway.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        /// <param name="type">Type of the resource.</param>
        public ApplicationGatewayRequestRoutingRule(string id = default(string), string ruleType = default(string), int? priority = default(int?), SubResource backendAddressPool = default(SubResource), SubResource backendHttpSettings = default(SubResource), SubResource httpListener = default(SubResource), SubResource urlPathMap = default(SubResource), SubResource rewriteRuleSet = default(SubResource), SubResource redirectConfiguration = default(SubResource), string provisioningState = default(string), string name = default(string), string etag = default(string), string type = default(string))
            : base(id)
        {
            RuleType = ruleType;
            Priority = priority;
            BackendAddressPool = backendAddressPool;
            BackendHttpSettings = backendHttpSettings;
            HttpListener = httpListener;
            UrlPathMap = urlPathMap;
            RewriteRuleSet = rewriteRuleSet;
            RedirectConfiguration = redirectConfiguration;
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
        /// Gets or sets rule type. Possible values include: 'Basic',
        /// 'PathBasedRouting'
        /// </summary>
        [JsonProperty(PropertyName = "properties.ruleType")]
        public string RuleType { get; set; }

        /// <summary>
        /// Gets or sets priority of the request routing rule.
        /// </summary>
        [JsonProperty(PropertyName = "properties.priority")]
        public int? Priority { get; set; }

        /// <summary>
        /// Gets or sets backend address pool resource of the application
        /// gateway.
        /// </summary>
        [JsonProperty(PropertyName = "properties.backendAddressPool")]
        public SubResource BackendAddressPool { get; set; }

        /// <summary>
        /// Gets or sets backend http settings resource of the application
        /// gateway.
        /// </summary>
        [JsonProperty(PropertyName = "properties.backendHttpSettings")]
        public SubResource BackendHttpSettings { get; set; }

        /// <summary>
        /// Gets or sets http listener resource of the application gateway.
        /// </summary>
        [JsonProperty(PropertyName = "properties.httpListener")]
        public SubResource HttpListener { get; set; }

        /// <summary>
        /// Gets or sets URL path map resource of the application gateway.
        /// </summary>
        [JsonProperty(PropertyName = "properties.urlPathMap")]
        public SubResource UrlPathMap { get; set; }

        /// <summary>
        /// Gets or sets rewrite Rule Set resource in Basic rule of the
        /// application gateway.
        /// </summary>
        [JsonProperty(PropertyName = "properties.rewriteRuleSet")]
        public SubResource RewriteRuleSet { get; set; }

        /// <summary>
        /// Gets or sets redirect configuration resource of the application
        /// gateway.
        /// </summary>
        [JsonProperty(PropertyName = "properties.redirectConfiguration")]
        public SubResource RedirectConfiguration { get; set; }

        /// <summary>
        /// Gets the provisioning state of the request routing rule resource.
        /// Possible values include: 'Succeeded', 'Updating', 'Deleting',
        /// 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets name of the request routing rule that is unique within
        /// an Application Gateway.
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
            if (Priority > 20000)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "Priority", 20000);
            }
            if (Priority < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "Priority", 1);
            }
        }
    }
}
