// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Commands.Compute.Helpers.Storage.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Filters limit replication to a subset of blobs within the storage
    /// account. A logical OR is performed on values in the filter. If multiple
    /// filters are defined, a logical AND is performed on all filters.
    /// </summary>
    public partial class ObjectReplicationPolicyFilter
    {
        /// <summary>
        /// Initializes a new instance of the ObjectReplicationPolicyFilter
        /// class.
        /// </summary>
        public ObjectReplicationPolicyFilter()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ObjectReplicationPolicyFilter
        /// class.
        /// </summary>
        /// <param name="prefixMatch">Optional. Filters the results to
        /// replicate only blobs whose names begin with the specified
        /// prefix.</param>
        /// <param name="minCreationTime">Blobs created after the time will be
        /// replicated to the destination. It must be in datetime format
        /// 'yyyy-MM-ddTHH:mm:ssZ'. Example: 2020-02-19T16:05:00Z</param>
        public ObjectReplicationPolicyFilter(IList<string> prefixMatch = default(IList<string>), string minCreationTime = default(string))
        {
            PrefixMatch = prefixMatch;
            MinCreationTime = minCreationTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets optional. Filters the results to replicate only blobs
        /// whose names begin with the specified prefix.
        /// </summary>
        [JsonProperty(PropertyName = "prefixMatch")]
        public IList<string> PrefixMatch { get; set; }

        /// <summary>
        /// Gets or sets blobs created after the time will be replicated to the
        /// destination. It must be in datetime format 'yyyy-MM-ddTHH:mm:ssZ'.
        /// Example: 2020-02-19T16:05:00Z
        /// </summary>
        [JsonProperty(PropertyName = "minCreationTime")]
        public string MinCreationTime { get; set; }

    }
}
