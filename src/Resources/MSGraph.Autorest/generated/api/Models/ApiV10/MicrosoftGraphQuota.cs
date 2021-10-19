// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Extensions;

    /// <summary>quota</summary>
    public partial class MicrosoftGraphQuota :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphQuota,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphQuotaInternal
    {

        /// <summary>Backing field for <see cref="Deleted" /> property.</summary>
        private long? _deleted;

        /// <summary>Total space consumed by files in the recycle bin, in bytes. Read-only.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public long? Deleted { get => this._deleted; set => this._deleted = value; }

        /// <summary>Backing field for <see cref="Remaining" /> property.</summary>
        private long? _remaining;

        /// <summary>Total space remaining before reaching the quota limit, in bytes. Read-only.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public long? Remaining { get => this._remaining; set => this._remaining = value; }

        /// <summary>Backing field for <see cref="State" /> property.</summary>
        private string _state;

        /// <summary>Enumeration value that indicates the state of the storage space. Read-only.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string State { get => this._state; set => this._state = value; }

        /// <summary>Backing field for <see cref="StoragePlanInformation" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphStoragePlanInformation _storagePlanInformation;

        /// <summary>storagePlanInformation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphStoragePlanInformation StoragePlanInformation { get => (this._storagePlanInformation = this._storagePlanInformation ?? new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.MicrosoftGraphStoragePlanInformation()); set => this._storagePlanInformation = value; }

        /// <summary>Backing field for <see cref="Total" /> property.</summary>
        private long? _total;

        /// <summary>Total allowed storage space, in bytes. Read-only.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public long? Total { get => this._total; set => this._total = value; }

        /// <summary>Backing field for <see cref="Used" /> property.</summary>
        private long? _used;

        /// <summary>Total space used, in bytes. Read-only.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public long? Used { get => this._used; set => this._used = value; }

        /// <summary>Creates an new <see cref="MicrosoftGraphQuota" /> instance.</summary>
        public MicrosoftGraphQuota()
        {

        }
    }
    /// quota
    public partial interface IMicrosoftGraphQuota :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IAssociativeArray<global::System.Object>
    {
        /// <summary>Total space consumed by files in the recycle bin, in bytes. Read-only.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Total space consumed by files in the recycle bin, in bytes. Read-only.",
        SerializedName = @"deleted",
        PossibleTypes = new [] { typeof(long) })]
        long? Deleted { get; set; }
        /// <summary>Total space remaining before reaching the quota limit, in bytes. Read-only.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Total space remaining before reaching the quota limit, in bytes. Read-only.",
        SerializedName = @"remaining",
        PossibleTypes = new [] { typeof(long) })]
        long? Remaining { get; set; }
        /// <summary>Enumeration value that indicates the state of the storage space. Read-only.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Enumeration value that indicates the state of the storage space. Read-only.",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(string) })]
        string State { get; set; }
        /// <summary>storagePlanInformation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"storagePlanInformation",
        SerializedName = @"storagePlanInformation",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphStoragePlanInformation) })]
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphStoragePlanInformation StoragePlanInformation { get; set; }
        /// <summary>Total allowed storage space, in bytes. Read-only.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Total allowed storage space, in bytes. Read-only.",
        SerializedName = @"total",
        PossibleTypes = new [] { typeof(long) })]
        long? Total { get; set; }
        /// <summary>Total space used, in bytes. Read-only.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Total space used, in bytes. Read-only.",
        SerializedName = @"used",
        PossibleTypes = new [] { typeof(long) })]
        long? Used { get; set; }

    }
    /// quota
    internal partial interface IMicrosoftGraphQuotaInternal

    {
        /// <summary>Total space consumed by files in the recycle bin, in bytes. Read-only.</summary>
        long? Deleted { get; set; }
        /// <summary>Total space remaining before reaching the quota limit, in bytes. Read-only.</summary>
        long? Remaining { get; set; }
        /// <summary>Enumeration value that indicates the state of the storage space. Read-only.</summary>
        string State { get; set; }
        /// <summary>storagePlanInformation</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphStoragePlanInformation StoragePlanInformation { get; set; }
        /// <summary>Total allowed storage space, in bytes. Read-only.</summary>
        long? Total { get; set; }
        /// <summary>Total space used, in bytes. Read-only.</summary>
        long? Used { get; set; }

    }
}