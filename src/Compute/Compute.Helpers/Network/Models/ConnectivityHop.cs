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
    /// Information about a hop between the source and the destination.
    /// </summary>
    public partial class ConnectivityHop
    {
        /// <summary>
        /// Initializes a new instance of the ConnectivityHop class.
        /// </summary>
        public ConnectivityHop()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ConnectivityHop class.
        /// </summary>
        /// <param name="type">The type of the hop.</param>
        /// <param name="id">The ID of the hop.</param>
        /// <param name="address">The IP address of the hop.</param>
        /// <param name="resourceId">The ID of the resource corresponding to
        /// this hop.</param>
        /// <param name="nextHopIds">List of next hop identifiers.</param>
        /// <param name="previousHopIds">List of previous hop
        /// identifiers.</param>
        /// <param name="links">List of hop links.</param>
        /// <param name="previousLinks">List of previous hop links.</param>
        /// <param name="issues">List of issues.</param>
        public ConnectivityHop(string type = default(string), string id = default(string), string address = default(string), string resourceId = default(string), IList<string> nextHopIds = default(IList<string>), IList<string> previousHopIds = default(IList<string>), IList<HopLink> links = default(IList<HopLink>), IList<HopLink> previousLinks = default(IList<HopLink>), IList<ConnectivityIssue> issues = default(IList<ConnectivityIssue>))
        {
            Type = type;
            Id = id;
            Address = address;
            ResourceId = resourceId;
            NextHopIds = nextHopIds;
            PreviousHopIds = previousHopIds;
            Links = links;
            PreviousLinks = previousLinks;
            Issues = issues;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the type of the hop.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets the ID of the hop.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets the IP address of the hop.
        /// </summary>
        [JsonProperty(PropertyName = "address")]
        public string Address { get; private set; }

        /// <summary>
        /// Gets the ID of the resource corresponding to this hop.
        /// </summary>
        [JsonProperty(PropertyName = "resourceId")]
        public string ResourceId { get; private set; }

        /// <summary>
        /// Gets list of next hop identifiers.
        /// </summary>
        [JsonProperty(PropertyName = "nextHopIds")]
        public IList<string> NextHopIds { get; private set; }

        /// <summary>
        /// Gets list of previous hop identifiers.
        /// </summary>
        [JsonProperty(PropertyName = "previousHopIds")]
        public IList<string> PreviousHopIds { get; private set; }

        /// <summary>
        /// Gets list of hop links.
        /// </summary>
        [JsonProperty(PropertyName = "links")]
        public IList<HopLink> Links { get; private set; }

        /// <summary>
        /// Gets list of previous hop links.
        /// </summary>
        [JsonProperty(PropertyName = "previousLinks")]
        public IList<HopLink> PreviousLinks { get; private set; }

        /// <summary>
        /// Gets list of issues.
        /// </summary>
        [JsonProperty(PropertyName = "issues")]
        public IList<ConnectivityIssue> Issues { get; private set; }

    }
}
