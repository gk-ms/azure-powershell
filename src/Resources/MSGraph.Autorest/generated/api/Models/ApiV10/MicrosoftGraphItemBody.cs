// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Extensions;

    /// <summary>itemBody</summary>
    public partial class MicrosoftGraphItemBody :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphItemBody,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphItemBodyInternal
    {

        /// <summary>Backing field for <see cref="Content" /> property.</summary>
        private string _content;

        /// <summary>The content of the item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string Content { get => this._content; set => this._content = value; }

        /// <summary>Backing field for <see cref="ContentType" /> property.</summary>
        private string _contentType;

        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string ContentType { get => this._contentType; set => this._contentType = value; }

        /// <summary>Creates an new <see cref="MicrosoftGraphItemBody" /> instance.</summary>
        public MicrosoftGraphItemBody()
        {

        }
    }
    /// itemBody
    public partial interface IMicrosoftGraphItemBody :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IAssociativeArray<global::System.Object>
    {
        /// <summary>The content of the item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The content of the item.",
        SerializedName = @"content",
        PossibleTypes = new [] { typeof(string) })]
        string Content { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"contentType",
        PossibleTypes = new [] { typeof(string) })]
        string ContentType { get; set; }

    }
    /// itemBody
    internal partial interface IMicrosoftGraphItemBodyInternal

    {
        /// <summary>The content of the item.</summary>
        string Content { get; set; }

        string ContentType { get; set; }

    }
}