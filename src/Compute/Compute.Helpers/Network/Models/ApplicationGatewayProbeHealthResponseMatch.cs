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
    /// Application gateway probe health response match.
    /// </summary>
    public partial class ApplicationGatewayProbeHealthResponseMatch
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationGatewayProbeHealthResponseMatch class.
        /// </summary>
        public ApplicationGatewayProbeHealthResponseMatch()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationGatewayProbeHealthResponseMatch class.
        /// </summary>
        /// <param name="body">Body that must be contained in the health
        /// response. Default value is empty.</param>
        /// <param name="statusCodes">Allowed ranges of healthy status codes.
        /// Default range of healthy status codes is 200-399.</param>
        public ApplicationGatewayProbeHealthResponseMatch(string body = default(string), IList<string> statusCodes = default(IList<string>))
        {
            Body = body;
            StatusCodes = statusCodes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets body that must be contained in the health response.
        /// Default value is empty.
        /// </summary>
        [JsonProperty(PropertyName = "body")]
        public string Body { get; set; }

        /// <summary>
        /// Gets or sets allowed ranges of healthy status codes. Default range
        /// of healthy status codes is 200-399.
        /// </summary>
        [JsonProperty(PropertyName = "statusCodes")]
        public IList<string> StatusCodes { get; set; }

    }
}
