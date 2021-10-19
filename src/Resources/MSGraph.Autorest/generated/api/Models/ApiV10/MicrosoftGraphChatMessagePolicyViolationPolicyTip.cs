// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Extensions;

    /// <summary>chatMessagePolicyViolationPolicyTip</summary>
    public partial class MicrosoftGraphChatMessagePolicyViolationPolicyTip :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphChatMessagePolicyViolationPolicyTip,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphChatMessagePolicyViolationPolicyTipInternal
    {

        /// <summary>Backing field for <see cref="ComplianceUrl" /> property.</summary>
        private string _complianceUrl;

        /// <summary>
        /// The URL a user can visit to read about the data loss prevention policies for the organization. (ie, policies about what
        /// users shouldn't say in chats)
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string ComplianceUrl { get => this._complianceUrl; set => this._complianceUrl = value; }

        /// <summary>Backing field for <see cref="GeneralText" /> property.</summary>
        private string _generalText;

        /// <summary>Explanatory text shown to the sender of the message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string GeneralText { get => this._generalText; set => this._generalText = value; }

        /// <summary>Backing field for <see cref="MatchedConditionDescription" /> property.</summary>
        private string[] _matchedConditionDescription;

        /// <summary>
        /// The list of improper data in the message that was detected by the data loss prevention app. Each DLP app defines its own
        /// conditions, examples include 'Credit Card Number' and 'Social Security Number'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string[] MatchedConditionDescription { get => this._matchedConditionDescription; set => this._matchedConditionDescription = value; }

        /// <summary>
        /// Creates an new <see cref="MicrosoftGraphChatMessagePolicyViolationPolicyTip" /> instance.
        /// </summary>
        public MicrosoftGraphChatMessagePolicyViolationPolicyTip()
        {

        }
    }
    /// chatMessagePolicyViolationPolicyTip
    public partial interface IMicrosoftGraphChatMessagePolicyViolationPolicyTip :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IAssociativeArray<global::System.Object>
    {
        /// <summary>
        /// The URL a user can visit to read about the data loss prevention policies for the organization. (ie, policies about what
        /// users shouldn't say in chats)
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The URL a user can visit to read about the data loss prevention policies for the organization. (ie, policies about what users shouldn't say in chats)",
        SerializedName = @"complianceUrl",
        PossibleTypes = new [] { typeof(string) })]
        string ComplianceUrl { get; set; }
        /// <summary>Explanatory text shown to the sender of the message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Explanatory text shown to the sender of the message.",
        SerializedName = @"generalText",
        PossibleTypes = new [] { typeof(string) })]
        string GeneralText { get; set; }
        /// <summary>
        /// The list of improper data in the message that was detected by the data loss prevention app. Each DLP app defines its own
        /// conditions, examples include 'Credit Card Number' and 'Social Security Number'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of improper data in the message that was detected by the data loss prevention app. Each DLP app defines its own conditions, examples include 'Credit Card Number' and 'Social Security Number'.",
        SerializedName = @"matchedConditionDescriptions",
        PossibleTypes = new [] { typeof(string) })]
        string[] MatchedConditionDescription { get; set; }

    }
    /// chatMessagePolicyViolationPolicyTip
    internal partial interface IMicrosoftGraphChatMessagePolicyViolationPolicyTipInternal

    {
        /// <summary>
        /// The URL a user can visit to read about the data loss prevention policies for the organization. (ie, policies about what
        /// users shouldn't say in chats)
        /// </summary>
        string ComplianceUrl { get; set; }
        /// <summary>Explanatory text shown to the sender of the message.</summary>
        string GeneralText { get; set; }
        /// <summary>
        /// The list of improper data in the message that was detected by the data loss prevention app. Each DLP app defines its own
        /// conditions, examples include 'Credit Card Number' and 'Social Security Number'.
        /// </summary>
        string[] MatchedConditionDescription { get; set; }

    }
}