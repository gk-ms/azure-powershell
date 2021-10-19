// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Extensions;

    /// <summary>inferenceClassificationOverride</summary>
    public partial class MicrosoftGraphInferenceClassificationOverride :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphInferenceClassificationOverride,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphInferenceClassificationOverrideInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphEntity"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphEntity __microsoftGraphEntity = new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.MicrosoftGraphEntity();

        /// <summary>Backing field for <see cref="ClassifyAs" /> property.</summary>
        private string _classifyAs;

        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string ClassifyAs { get => this._classifyAs; set => this._classifyAs = value; }

        /// <summary>Read-only.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphEntityInternal)__microsoftGraphEntity).Id; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphEntityInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphEntityInternal)__microsoftGraphEntity).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphEntityInternal)__microsoftGraphEntity).Id = value; }

        /// <summary>Backing field for <see cref="SenderEmailAddress" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphEmailAddress _senderEmailAddress;

        /// <summary>emailAddress</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphEmailAddress SenderEmailAddress { get => (this._senderEmailAddress = this._senderEmailAddress ?? new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.MicrosoftGraphEmailAddress()); set => this._senderEmailAddress = value; }

        /// <summary>
        /// Creates an new <see cref="MicrosoftGraphInferenceClassificationOverride" /> instance.
        /// </summary>
        public MicrosoftGraphInferenceClassificationOverride()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__microsoftGraphEntity), __microsoftGraphEntity);
            await eventListener.AssertObjectIsValid(nameof(__microsoftGraphEntity), __microsoftGraphEntity);
        }
    }
    /// inferenceClassificationOverride
    public partial interface IMicrosoftGraphInferenceClassificationOverride :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphEntity,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IAssociativeArray<global::System.Object>
    {
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"classifyAs",
        PossibleTypes = new [] { typeof(string) })]
        string ClassifyAs { get; set; }
        /// <summary>emailAddress</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"emailAddress",
        SerializedName = @"senderEmailAddress",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphEmailAddress) })]
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphEmailAddress SenderEmailAddress { get; set; }

    }
    /// inferenceClassificationOverride
    internal partial interface IMicrosoftGraphInferenceClassificationOverrideInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphEntityInternal
    {
        string ClassifyAs { get; set; }
        /// <summary>emailAddress</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphEmailAddress SenderEmailAddress { get; set; }

    }
}