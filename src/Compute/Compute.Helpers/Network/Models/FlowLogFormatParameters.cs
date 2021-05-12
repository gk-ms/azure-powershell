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
    /// Parameters that define the flow log format.
    /// </summary>
    public partial class FlowLogFormatParameters
    {
        /// <summary>
        /// Initializes a new instance of the FlowLogFormatParameters class.
        /// </summary>
        public FlowLogFormatParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FlowLogFormatParameters class.
        /// </summary>
        /// <param name="type">The file type of flow log. Possible values
        /// include: 'JSON'</param>
        /// <param name="version">The version (revision) of the flow
        /// log.</param>
        public FlowLogFormatParameters(string type = default(string), int? version = default(int?))
        {
            Type = type;
            Version = version;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the file type of flow log. Possible values include:
        /// 'JSON'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the version (revision) of the flow log.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public int? Version { get; set; }

    }
}
