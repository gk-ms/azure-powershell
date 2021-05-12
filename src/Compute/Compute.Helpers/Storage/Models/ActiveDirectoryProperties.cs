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
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Settings properties for Active Directory (AD).
    /// </summary>
    public partial class ActiveDirectoryProperties
    {
        /// <summary>
        /// Initializes a new instance of the ActiveDirectoryProperties class.
        /// </summary>
        public ActiveDirectoryProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ActiveDirectoryProperties class.
        /// </summary>
        /// <param name="domainName">Specifies the primary domain that the AD
        /// DNS server is authoritative for.</param>
        /// <param name="netBiosDomainName">Specifies the NetBIOS domain
        /// name.</param>
        /// <param name="forestName">Specifies the Active Directory forest to
        /// get.</param>
        /// <param name="domainGuid">Specifies the domain GUID.</param>
        /// <param name="domainSid">Specifies the security identifier
        /// (SID).</param>
        /// <param name="azureStorageSid">Specifies the security identifier
        /// (SID) for Azure Storage.</param>
        public ActiveDirectoryProperties(string domainName, string netBiosDomainName, string forestName, string domainGuid, string domainSid, string azureStorageSid)
        {
            DomainName = domainName;
            NetBiosDomainName = netBiosDomainName;
            ForestName = forestName;
            DomainGuid = domainGuid;
            DomainSid = domainSid;
            AzureStorageSid = azureStorageSid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies the primary domain that the AD DNS server is
        /// authoritative for.
        /// </summary>
        [JsonProperty(PropertyName = "domainName")]
        public string DomainName { get; set; }

        /// <summary>
        /// Gets or sets specifies the NetBIOS domain name.
        /// </summary>
        [JsonProperty(PropertyName = "netBiosDomainName")]
        public string NetBiosDomainName { get; set; }

        /// <summary>
        /// Gets or sets specifies the Active Directory forest to get.
        /// </summary>
        [JsonProperty(PropertyName = "forestName")]
        public string ForestName { get; set; }

        /// <summary>
        /// Gets or sets specifies the domain GUID.
        /// </summary>
        [JsonProperty(PropertyName = "domainGuid")]
        public string DomainGuid { get; set; }

        /// <summary>
        /// Gets or sets specifies the security identifier (SID).
        /// </summary>
        [JsonProperty(PropertyName = "domainSid")]
        public string DomainSid { get; set; }

        /// <summary>
        /// Gets or sets specifies the security identifier (SID) for Azure
        /// Storage.
        /// </summary>
        [JsonProperty(PropertyName = "azureStorageSid")]
        public string AzureStorageSid { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DomainName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DomainName");
            }
            if (NetBiosDomainName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "NetBiosDomainName");
            }
            if (ForestName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ForestName");
            }
            if (DomainGuid == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DomainGuid");
            }
            if (DomainSid == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DomainSid");
            }
            if (AzureStorageSid == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AzureStorageSid");
            }
        }
    }
}
