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
    /// ExpressRouteConnection list.
    /// </summary>
    public partial class ExpressRouteConnectionList
    {
        /// <summary>
        /// Initializes a new instance of the ExpressRouteConnectionList class.
        /// </summary>
        public ExpressRouteConnectionList()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExpressRouteConnectionList class.
        /// </summary>
        /// <param name="value">The list of ExpressRoute connections.</param>
        public ExpressRouteConnectionList(IList<ExpressRouteConnection> value = default(IList<ExpressRouteConnection>))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the list of ExpressRoute connections.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<ExpressRouteConnection> Value { get; set; }

    }
}
