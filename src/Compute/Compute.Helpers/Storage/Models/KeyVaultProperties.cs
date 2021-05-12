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
    /// Properties of key vault.
    /// </summary>
    public partial class KeyVaultProperties
    {
        /// <summary>
        /// Initializes a new instance of the KeyVaultProperties class.
        /// </summary>
        public KeyVaultProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the KeyVaultProperties class.
        /// </summary>
        /// <param name="keyName">The name of KeyVault key.</param>
        /// <param name="keyVersion">The version of KeyVault key.</param>
        /// <param name="keyVaultUri">The Uri of KeyVault.</param>
        /// <param name="currentVersionedKeyIdentifier">The object identifier
        /// of the current versioned Key Vault Key in use.</param>
        /// <param name="lastKeyRotationTimestamp">Timestamp of last rotation
        /// of the Key Vault Key.</param>
        public KeyVaultProperties(string keyName = default(string), string keyVersion = default(string), string keyVaultUri = default(string), string currentVersionedKeyIdentifier = default(string), System.DateTime? lastKeyRotationTimestamp = default(System.DateTime?))
        {
            KeyName = keyName;
            KeyVersion = keyVersion;
            KeyVaultUri = keyVaultUri;
            CurrentVersionedKeyIdentifier = currentVersionedKeyIdentifier;
            LastKeyRotationTimestamp = lastKeyRotationTimestamp;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of KeyVault key.
        /// </summary>
        [JsonProperty(PropertyName = "keyname")]
        public string KeyName { get; set; }

        /// <summary>
        /// Gets or sets the version of KeyVault key.
        /// </summary>
        [JsonProperty(PropertyName = "keyversion")]
        public string KeyVersion { get; set; }

        /// <summary>
        /// Gets or sets the Uri of KeyVault.
        /// </summary>
        [JsonProperty(PropertyName = "keyvaulturi")]
        public string KeyVaultUri { get; set; }

        /// <summary>
        /// Gets the object identifier of the current versioned Key Vault Key
        /// in use.
        /// </summary>
        [JsonProperty(PropertyName = "currentVersionedKeyIdentifier")]
        public string CurrentVersionedKeyIdentifier { get; private set; }

        /// <summary>
        /// Gets timestamp of last rotation of the Key Vault Key.
        /// </summary>
        [JsonProperty(PropertyName = "lastKeyRotationTimestamp")]
        public System.DateTime? LastKeyRotationTimestamp { get; private set; }

    }
}
