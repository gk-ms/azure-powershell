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
    using System.Linq;

    /// <summary>
    /// Management policy action for snapshot.
    /// </summary>
    public partial class ManagementPolicySnapShot
    {
        /// <summary>
        /// Initializes a new instance of the ManagementPolicySnapShot class.
        /// </summary>
        public ManagementPolicySnapShot()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManagementPolicySnapShot class.
        /// </summary>
        /// <param name="tierToCool">The function to tier blob snapshot to cool
        /// storage. Support blob snapshot currently at Hot tier</param>
        /// <param name="tierToArchive">The function to tier blob snapshot to
        /// archive storage. Support blob snapshot currently at Hot or Cool
        /// tier</param>
        /// <param name="delete">The function to delete the blob
        /// snapshot</param>
        public ManagementPolicySnapShot(DateAfterCreation tierToCool = default(DateAfterCreation), DateAfterCreation tierToArchive = default(DateAfterCreation), DateAfterCreation delete = default(DateAfterCreation))
        {
            TierToCool = tierToCool;
            TierToArchive = tierToArchive;
            Delete = delete;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the function to tier blob snapshot to cool storage.
        /// Support blob snapshot currently at Hot tier
        /// </summary>
        [JsonProperty(PropertyName = "tierToCool")]
        public DateAfterCreation TierToCool { get; set; }

        /// <summary>
        /// Gets or sets the function to tier blob snapshot to archive storage.
        /// Support blob snapshot currently at Hot or Cool tier
        /// </summary>
        [JsonProperty(PropertyName = "tierToArchive")]
        public DateAfterCreation TierToArchive { get; set; }

        /// <summary>
        /// Gets or sets the function to delete the blob snapshot
        /// </summary>
        [JsonProperty(PropertyName = "delete")]
        public DateAfterCreation Delete { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (TierToCool != null)
            {
                TierToCool.Validate();
            }
            if (TierToArchive != null)
            {
                TierToArchive.Validate();
            }
            if (Delete != null)
            {
                Delete.Validate();
            }
        }
    }
}
