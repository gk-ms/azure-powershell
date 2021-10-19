// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Extensions;

    /// <summary>agreementAcceptance</summary>
    public partial class MicrosoftGraphAgreementAcceptance
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphAgreementAcceptance.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphAgreementAcceptance.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphAgreementAcceptance FromJson(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonObject json ? new MicrosoftGraphAgreementAcceptance(json, new global::System.Collections.Generic.HashSet<string>(){ @"id",@"agreementFileId",@"agreementId",@"deviceDisplayName",@"deviceId",@"deviceOSType",@"deviceOSVersion",@"expirationDateTime",@"recordedDateTime",@"state",@"userDisplayName",@"userEmail",@"userId",@"userPrincipalName" }) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonObject into a new instance of <see cref="MicrosoftGraphAgreementAcceptance" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonObject instance to deserialize from.</param>
        /// <param name="exclusions"></param>
        internal MicrosoftGraphAgreementAcceptance(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonObject json, global::System.Collections.Generic.HashSet<string> exclusions = null)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.JsonSerializable.FromJson( json, ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IAssociativeArray<global::System.Object>)this).AdditionalProperties, Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.JsonSerializable.DeserializeDictionary(()=>new global::System.Collections.Generic.Dictionary<global::System.String,global::System.Object>()),exclusions );
            __microsoftGraphEntity = new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.MicrosoftGraphEntity(json);
            {_agreementFileId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString>("agreementFileId"), out var __jsonAgreementFileId) ? (string)__jsonAgreementFileId : (string)AgreementFileId;}
            {_agreementId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString>("agreementId"), out var __jsonAgreementId) ? (string)__jsonAgreementId : (string)AgreementId;}
            {_deviceDisplayName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString>("deviceDisplayName"), out var __jsonDeviceDisplayName) ? (string)__jsonDeviceDisplayName : (string)DeviceDisplayName;}
            {_deviceId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString>("deviceId"), out var __jsonDeviceId) ? (string)__jsonDeviceId : (string)DeviceId;}
            {_deviceOSType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString>("deviceOSType"), out var __jsonDeviceOSType) ? (string)__jsonDeviceOSType : (string)DeviceOSType;}
            {_deviceOSVersion = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString>("deviceOSVersion"), out var __jsonDeviceOSVersion) ? (string)__jsonDeviceOSVersion : (string)DeviceOSVersion;}
            {_expirationDateTime = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString>("expirationDateTime"), out var __jsonExpirationDateTime) ? global::System.DateTime.TryParse((string)__jsonExpirationDateTime, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonExpirationDateTimeValue) ? __jsonExpirationDateTimeValue : ExpirationDateTime : ExpirationDateTime;}
            {_recordedDateTime = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString>("recordedDateTime"), out var __jsonRecordedDateTime) ? global::System.DateTime.TryParse((string)__jsonRecordedDateTime, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonRecordedDateTimeValue) ? __jsonRecordedDateTimeValue : RecordedDateTime : RecordedDateTime;}
            {_state = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString>("state"), out var __jsonState) ? (string)__jsonState : (string)State;}
            {_userDisplayName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString>("userDisplayName"), out var __jsonUserDisplayName) ? (string)__jsonUserDisplayName : (string)UserDisplayName;}
            {_userEmail = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString>("userEmail"), out var __jsonUserEmail) ? (string)__jsonUserEmail : (string)UserEmail;}
            {_userId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString>("userId"), out var __jsonUserId) ? (string)__jsonUserId : (string)UserId;}
            {_userPrincipalName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString>("userPrincipalName"), out var __jsonUserPrincipalName) ? (string)__jsonUserPrincipalName : (string)UserPrincipalName;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="MicrosoftGraphAgreementAcceptance" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="MicrosoftGraphAgreementAcceptance" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.JsonSerializable.ToJson( ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IAssociativeArray<global::System.Object>)this).AdditionalProperties, container);
            __microsoftGraphEntity?.ToJson(container, serializationMode);
            AddIf( null != (((object)this._agreementFileId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString(this._agreementFileId.ToString()) : null, "agreementFileId" ,container.Add );
            AddIf( null != (((object)this._agreementId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString(this._agreementId.ToString()) : null, "agreementId" ,container.Add );
            AddIf( null != (((object)this._deviceDisplayName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString(this._deviceDisplayName.ToString()) : null, "deviceDisplayName" ,container.Add );
            AddIf( null != (((object)this._deviceId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString(this._deviceId.ToString()) : null, "deviceId" ,container.Add );
            AddIf( null != (((object)this._deviceOSType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString(this._deviceOSType.ToString()) : null, "deviceOSType" ,container.Add );
            AddIf( null != (((object)this._deviceOSVersion)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString(this._deviceOSVersion.ToString()) : null, "deviceOSVersion" ,container.Add );
            AddIf( null != this._expirationDateTime ? (Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString(this._expirationDateTime?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "expirationDateTime" ,container.Add );
            AddIf( null != this._recordedDateTime ? (Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString(this._recordedDateTime?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "recordedDateTime" ,container.Add );
            AddIf( null != (((object)this._state)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString(this._state.ToString()) : null, "state" ,container.Add );
            AddIf( null != (((object)this._userDisplayName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString(this._userDisplayName.ToString()) : null, "userDisplayName" ,container.Add );
            AddIf( null != (((object)this._userEmail)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString(this._userEmail.ToString()) : null, "userEmail" ,container.Add );
            AddIf( null != (((object)this._userId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString(this._userId.ToString()) : null, "userId" ,container.Add );
            AddIf( null != (((object)this._userPrincipalName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString(this._userPrincipalName.ToString()) : null, "userPrincipalName" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}