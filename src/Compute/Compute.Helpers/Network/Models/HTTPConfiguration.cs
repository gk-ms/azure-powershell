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
    /// HTTP configuration of the connectivity check.
    /// </summary>
    public partial class HTTPConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the HTTPConfiguration class.
        /// </summary>
        public HTTPConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HTTPConfiguration class.
        /// </summary>
        /// <param name="method">HTTP method. Possible values include:
        /// 'Get'</param>
        /// <param name="headers">List of HTTP headers.</param>
        /// <param name="validStatusCodes">Valid status codes.</param>
        public HTTPConfiguration(string method = default(string), IList<HTTPHeader> headers = default(IList<HTTPHeader>), IList<int?> validStatusCodes = default(IList<int?>))
        {
            Method = method;
            Headers = headers;
            ValidStatusCodes = validStatusCodes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets HTTP method. Possible values include: 'Get'
        /// </summary>
        [JsonProperty(PropertyName = "method")]
        public string Method { get; set; }

        /// <summary>
        /// Gets or sets list of HTTP headers.
        /// </summary>
        [JsonProperty(PropertyName = "headers")]
        public IList<HTTPHeader> Headers { get; set; }

        /// <summary>
        /// Gets or sets valid status codes.
        /// </summary>
        [JsonProperty(PropertyName = "validStatusCodes")]
        public IList<int?> ValidStatusCodes { get; set; }

    }
}
