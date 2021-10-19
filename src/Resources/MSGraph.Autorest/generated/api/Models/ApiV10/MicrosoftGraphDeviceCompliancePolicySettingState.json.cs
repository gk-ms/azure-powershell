// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Extensions;

    /// <summary>Device Compilance Policy Setting State for a given device.</summary>
    public partial class MicrosoftGraphDeviceCompliancePolicySettingState
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
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceCompliancePolicySettingState.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceCompliancePolicySettingState.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDeviceCompliancePolicySettingState FromJson(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonObject json ? new MicrosoftGraphDeviceCompliancePolicySettingState(json, new global::System.Collections.Generic.HashSet<string>(){ @"currentValue",@"errorCode",@"errorDescription",@"instanceDisplayName",@"setting",@"settingName",@"sources",@"state",@"userEmail",@"userId",@"userName",@"userPrincipalName" }) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonObject into a new instance of <see cref="MicrosoftGraphDeviceCompliancePolicySettingState"
        /// />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonObject instance to deserialize from.</param>
        /// <param name="exclusions"></param>
        internal MicrosoftGraphDeviceCompliancePolicySettingState(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonObject json, global::System.Collections.Generic.HashSet<string> exclusions = null)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.JsonSerializable.FromJson( json, ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IAssociativeArray<global::System.Object>)this).AdditionalProperties, Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.JsonSerializable.DeserializeDictionary(()=>new global::System.Collections.Generic.Dictionary<global::System.String,global::System.Object>()),exclusions );
            {_currentValue = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString>("currentValue"), out var __jsonCurrentValue) ? (string)__jsonCurrentValue : (string)CurrentValue;}
            {_errorCode = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNumber>("errorCode"), out var __jsonErrorCode) ? (long?)__jsonErrorCode : ErrorCode;}
            {_errorDescription = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString>("errorDescription"), out var __jsonErrorDescription) ? (string)__jsonErrorDescription : (string)ErrorDescription;}
            {_instanceDisplayName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString>("instanceDisplayName"), out var __jsonInstanceDisplayName) ? (string)__jsonInstanceDisplayName : (string)InstanceDisplayName;}
            {_setting = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString>("setting"), out var __jsonSetting) ? (string)__jsonSetting : (string)Setting;}
            {_settingName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString>("settingName"), out var __jsonSettingName) ? (string)__jsonSettingName : (string)SettingName;}
            {_source = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonArray>("sources"), out var __jsonSources) ? If( __jsonSources as Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphSettingSource[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphSettingSource) (Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.MicrosoftGraphSettingSource.FromJson(__u) )) ))() : null : Source;}
            {_state = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString>("state"), out var __jsonState) ? (string)__jsonState : (string)State;}
            {_userEmail = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString>("userEmail"), out var __jsonUserEmail) ? (string)__jsonUserEmail : (string)UserEmail;}
            {_userId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString>("userId"), out var __jsonUserId) ? (string)__jsonUserId : (string)UserId;}
            {_userName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString>("userName"), out var __jsonUserName) ? (string)__jsonUserName : (string)UserName;}
            {_userPrincipalName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString>("userPrincipalName"), out var __jsonUserPrincipalName) ? (string)__jsonUserPrincipalName : (string)UserPrincipalName;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="MicrosoftGraphDeviceCompliancePolicySettingState" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="MicrosoftGraphDeviceCompliancePolicySettingState" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNode"
        /// />.
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
            AddIf( null != (((object)this._currentValue)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString(this._currentValue.ToString()) : null, "currentValue" ,container.Add );
            AddIf( null != this._errorCode ? (Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNumber((long)this._errorCode) : null, "errorCode" ,container.Add );
            AddIf( null != (((object)this._errorDescription)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString(this._errorDescription.ToString()) : null, "errorDescription" ,container.Add );
            AddIf( null != (((object)this._instanceDisplayName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString(this._instanceDisplayName.ToString()) : null, "instanceDisplayName" ,container.Add );
            AddIf( null != (((object)this._setting)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString(this._setting.ToString()) : null, "setting" ,container.Add );
            AddIf( null != (((object)this._settingName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString(this._settingName.ToString()) : null, "settingName" ,container.Add );
            if (null != this._source)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.XNodeArray();
                foreach( var __x in this._source )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("sources",__w);
            }
            AddIf( null != (((object)this._state)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString(this._state.ToString()) : null, "state" ,container.Add );
            AddIf( null != (((object)this._userEmail)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString(this._userEmail.ToString()) : null, "userEmail" ,container.Add );
            AddIf( null != (((object)this._userId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString(this._userId.ToString()) : null, "userId" ,container.Add );
            AddIf( null != (((object)this._userName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString(this._userName.ToString()) : null, "userName" ,container.Add );
            AddIf( null != (((object)this._userPrincipalName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Json.JsonString(this._userPrincipalName.ToString()) : null, "userPrincipalName" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}