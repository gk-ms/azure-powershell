// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Extensions;

    /// <summary>Properties of the PrivateLinkServiceConnection.</summary>
    public partial class PrivateLinkServiceConnectionProperties :
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPrivateLinkServiceConnectionProperties,
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPrivateLinkServiceConnectionPropertiesInternal
    {

        /// <summary>Backing field for <see cref="GroupId" /> property.</summary>
        private string[] _groupId;

        /// <summary>
        /// The ID(s) of the group(s) obtained from the remote resource that this private endpoint should connect to.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public string[] GroupId { get => this._groupId; set => this._groupId = value; }

        /// <summary>Internal Acessors for PrivateLinkServiceConnectionState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPrivateLinkServiceConnectionState Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPrivateLinkServiceConnectionPropertiesInternal.PrivateLinkServiceConnectionState { get => (this._privateLinkServiceConnectionState = this._privateLinkServiceConnectionState ?? new Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.PrivateLinkServiceConnectionState()); set { {_privateLinkServiceConnectionState = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPrivateLinkServiceConnectionPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Backing field for <see cref="PrivateLinkServiceConnectionState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPrivateLinkServiceConnectionState _privateLinkServiceConnectionState;

        /// <summary>
        /// A collection of read-only information about the state of the connection to the remote resource.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPrivateLinkServiceConnectionState PrivateLinkServiceConnectionState { get => (this._privateLinkServiceConnectionState = this._privateLinkServiceConnectionState ?? new Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.PrivateLinkServiceConnectionState()); set => this._privateLinkServiceConnectionState = value; }

        /// <summary>
        /// A message indicating if changes on the service provider require any updates on the consumer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public string PrivateLinkServiceConnectionStateActionsRequired { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPrivateLinkServiceConnectionStateInternal)PrivateLinkServiceConnectionState).ActionsRequired; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPrivateLinkServiceConnectionStateInternal)PrivateLinkServiceConnectionState).ActionsRequired = value ?? null; }

        /// <summary>The reason for approval/rejection of the connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public string PrivateLinkServiceConnectionStateDescription { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPrivateLinkServiceConnectionStateInternal)PrivateLinkServiceConnectionState).Description; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPrivateLinkServiceConnectionStateInternal)PrivateLinkServiceConnectionState).Description = value ?? null; }

        /// <summary>
        /// Indicates whether the connection has been Approved/Rejected/Removed by the owner of the service.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public string PrivateLinkServiceConnectionStateStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPrivateLinkServiceConnectionStateInternal)PrivateLinkServiceConnectionState).Status; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPrivateLinkServiceConnectionStateInternal)PrivateLinkServiceConnectionState).Status = value ?? null; }

        /// <summary>Backing field for <see cref="PrivateLinkServiceId" /> property.</summary>
        private string _privateLinkServiceId;

        /// <summary>The resource id of private link service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public string PrivateLinkServiceId { get => this._privateLinkServiceId; set => this._privateLinkServiceId = value; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? _provisioningState;

        /// <summary>The provisioning state of the private link service connection resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="RequestMessage" /> property.</summary>
        private string _requestMessage;

        /// <summary>
        /// A message passed to the owner of the remote resource with this connection request. Restricted to 140 chars.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public string RequestMessage { get => this._requestMessage; set => this._requestMessage = value; }

        /// <summary>Creates an new <see cref="PrivateLinkServiceConnectionProperties" /> instance.</summary>
        public PrivateLinkServiceConnectionProperties()
        {

        }
    }
    /// Properties of the PrivateLinkServiceConnection.
    public partial interface IPrivateLinkServiceConnectionProperties :
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The ID(s) of the group(s) obtained from the remote resource that this private endpoint should connect to.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The ID(s) of the group(s) obtained from the remote resource that this private endpoint should connect to.",
        SerializedName = @"groupIds",
        PossibleTypes = new [] { typeof(string) })]
        string[] GroupId { get; set; }
        /// <summary>
        /// A message indicating if changes on the service provider require any updates on the consumer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A message indicating if changes on the service provider require any updates on the consumer.",
        SerializedName = @"actionsRequired",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateLinkServiceConnectionStateActionsRequired { get; set; }
        /// <summary>The reason for approval/rejection of the connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The reason for approval/rejection of the connection.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateLinkServiceConnectionStateDescription { get; set; }
        /// <summary>
        /// Indicates whether the connection has been Approved/Rejected/Removed by the owner of the service.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicates whether the connection has been Approved/Rejected/Removed by the owner of the service.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateLinkServiceConnectionStateStatus { get; set; }
        /// <summary>The resource id of private link service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource id of private link service.",
        SerializedName = @"privateLinkServiceId",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateLinkServiceId { get; set; }
        /// <summary>The provisioning state of the private link service connection resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The provisioning state of the private link service connection resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? ProvisioningState { get;  }
        /// <summary>
        /// A message passed to the owner of the remote resource with this connection request. Restricted to 140 chars.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A message passed to the owner of the remote resource with this connection request. Restricted to 140 chars.",
        SerializedName = @"requestMessage",
        PossibleTypes = new [] { typeof(string) })]
        string RequestMessage { get; set; }

    }
    /// Properties of the PrivateLinkServiceConnection.
    internal partial interface IPrivateLinkServiceConnectionPropertiesInternal

    {
        /// <summary>
        /// The ID(s) of the group(s) obtained from the remote resource that this private endpoint should connect to.
        /// </summary>
        string[] GroupId { get; set; }
        /// <summary>
        /// A collection of read-only information about the state of the connection to the remote resource.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPrivateLinkServiceConnectionState PrivateLinkServiceConnectionState { get; set; }
        /// <summary>
        /// A message indicating if changes on the service provider require any updates on the consumer.
        /// </summary>
        string PrivateLinkServiceConnectionStateActionsRequired { get; set; }
        /// <summary>The reason for approval/rejection of the connection.</summary>
        string PrivateLinkServiceConnectionStateDescription { get; set; }
        /// <summary>
        /// Indicates whether the connection has been Approved/Rejected/Removed by the owner of the service.
        /// </summary>
        string PrivateLinkServiceConnectionStateStatus { get; set; }
        /// <summary>The resource id of private link service.</summary>
        string PrivateLinkServiceId { get; set; }
        /// <summary>The provisioning state of the private link service connection resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>
        /// A message passed to the owner of the remote resource with this connection request. Restricted to 140 chars.
        /// </summary>
        string RequestMessage { get; set; }

    }
}