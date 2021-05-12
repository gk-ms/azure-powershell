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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Application gateway BackendHealthHttp settings.
    /// </summary>
    public partial class ApplicationGatewayBackendHealthHttpSettings
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationGatewayBackendHealthHttpSettings class.
        /// </summary>
        public ApplicationGatewayBackendHealthHttpSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationGatewayBackendHealthHttpSettings class.
        /// </summary>
        /// <param name="backendHttpSettings">Reference to an
        /// ApplicationGatewayBackendHttpSettings resource.</param>
        /// <param name="servers">List of ApplicationGatewayBackendHealthServer
        /// resources.</param>
        public ApplicationGatewayBackendHealthHttpSettings(ApplicationGatewayBackendHttpSettings backendHttpSettings = default(ApplicationGatewayBackendHttpSettings), IList<ApplicationGatewayBackendHealthServer> servers = default(IList<ApplicationGatewayBackendHealthServer>))
        {
            BackendHttpSettings = backendHttpSettings;
            Servers = servers;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets reference to an ApplicationGatewayBackendHttpSettings
        /// resource.
        /// </summary>
        [JsonProperty(PropertyName = "backendHttpSettings")]
        public ApplicationGatewayBackendHttpSettings BackendHttpSettings { get; set; }

        /// <summary>
        /// Gets or sets list of ApplicationGatewayBackendHealthServer
        /// resources.
        /// </summary>
        [JsonProperty(PropertyName = "servers")]
        public IList<ApplicationGatewayBackendHealthServer> Servers { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (BackendHttpSettings != null)
            {
                BackendHttpSettings.Validate();
            }
            if (Servers != null)
            {
                foreach (var element in Servers)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
