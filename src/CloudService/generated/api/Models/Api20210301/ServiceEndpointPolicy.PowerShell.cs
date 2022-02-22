// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301
{
    using Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.PowerShell;

    /// <summary>Service End point policy resource.</summary>
    [System.ComponentModel.TypeConverter(typeof(ServiceEndpointPolicyTypeConverter))]
    public partial class ServiceEndpointPolicy
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ServiceEndpointPolicy"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicy" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicy DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ServiceEndpointPolicy(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ServiceEndpointPolicy"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicy" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicy DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ServiceEndpointPolicy(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ServiceEndpointPolicy" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicy FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ServiceEndpointPolicy"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ServiceEndpointPolicy(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyPropertiesFormat) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ServiceEndpointPolicyPropertiesFormatTypeConverter.ConvertFrom);
            }
            if (content.Contains("Etag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyInternal)this).Etag = (string) content.GetValueForProperty("Etag",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyInternal)this).Etag, global::System.Convert.ToString);
            }
            if (content.Contains("Kind"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyInternal)this).Kind = (string) content.GetValueForProperty("Kind",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyInternal)this).Kind, global::System.Convert.ToString);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ResourceTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState.CreateFrom);
            }
            if (content.Contains("Definition"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyInternal)this).Definition = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyDefinition[]) content.GetValueForProperty("Definition",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyInternal)this).Definition, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyDefinition>(__y, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ServiceEndpointPolicyDefinitionTypeConverter.ConvertFrom));
            }
            if (content.Contains("Subnet"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyInternal)this).Subnet = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISubnet[]) content.GetValueForProperty("Subnet",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyInternal)this).Subnet, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISubnet>(__y, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.SubnetTypeConverter.ConvertFrom));
            }
            if (content.Contains("ResourceGuid"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyInternal)this).ResourceGuid = (string) content.GetValueForProperty("ResourceGuid",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyInternal)this).ResourceGuid, global::System.Convert.ToString);
            }
            if (content.Contains("ServiceAlias"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyInternal)this).ServiceAlias = (string) content.GetValueForProperty("ServiceAlias",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyInternal)this).ServiceAlias, global::System.Convert.ToString);
            }
            if (content.Contains("ContextualServiceEndpointPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyInternal)this).ContextualServiceEndpointPolicy = (string[]) content.GetValueForProperty("ContextualServiceEndpointPolicy",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyInternal)this).ContextualServiceEndpointPolicy, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ServiceEndpointPolicy"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ServiceEndpointPolicy(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyPropertiesFormat) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ServiceEndpointPolicyPropertiesFormatTypeConverter.ConvertFrom);
            }
            if (content.Contains("Etag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyInternal)this).Etag = (string) content.GetValueForProperty("Etag",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyInternal)this).Etag, global::System.Convert.ToString);
            }
            if (content.Contains("Kind"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyInternal)this).Kind = (string) content.GetValueForProperty("Kind",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyInternal)this).Kind, global::System.Convert.ToString);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ResourceTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState.CreateFrom);
            }
            if (content.Contains("Definition"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyInternal)this).Definition = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyDefinition[]) content.GetValueForProperty("Definition",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyInternal)this).Definition, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyDefinition>(__y, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ServiceEndpointPolicyDefinitionTypeConverter.ConvertFrom));
            }
            if (content.Contains("Subnet"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyInternal)this).Subnet = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISubnet[]) content.GetValueForProperty("Subnet",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyInternal)this).Subnet, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISubnet>(__y, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.SubnetTypeConverter.ConvertFrom));
            }
            if (content.Contains("ResourceGuid"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyInternal)this).ResourceGuid = (string) content.GetValueForProperty("ResourceGuid",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyInternal)this).ResourceGuid, global::System.Convert.ToString);
            }
            if (content.Contains("ServiceAlias"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyInternal)this).ServiceAlias = (string) content.GetValueForProperty("ServiceAlias",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyInternal)this).ServiceAlias, global::System.Convert.ToString);
            }
            if (content.Contains("ContextualServiceEndpointPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyInternal)this).ContextualServiceEndpointPolicy = (string[]) content.GetValueForProperty("ContextualServiceEndpointPolicy",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IServiceEndpointPolicyInternal)this).ContextualServiceEndpointPolicy, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Service End point policy resource.
    [System.ComponentModel.TypeConverter(typeof(ServiceEndpointPolicyTypeConverter))]
    public partial interface IServiceEndpointPolicy

    {

    }
}