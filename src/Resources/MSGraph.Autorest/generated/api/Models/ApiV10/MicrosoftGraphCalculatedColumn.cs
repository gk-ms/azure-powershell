// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Extensions;

    /// <summary>calculatedColumn</summary>
    public partial class MicrosoftGraphCalculatedColumn :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphCalculatedColumn,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphCalculatedColumnInternal
    {

        /// <summary>Backing field for <see cref="Format" /> property.</summary>
        private string _format;

        /// <summary>
        /// For dateTime output types, the format of the value. Must be one of dateOnly or dateTime.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string Format { get => this._format; set => this._format = value; }

        /// <summary>Backing field for <see cref="Formula" /> property.</summary>
        private string _formula;

        /// <summary>The formula used to compute the value for this column.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string Formula { get => this._formula; set => this._formula = value; }

        /// <summary>Backing field for <see cref="OutputType" /> property.</summary>
        private string _outputType;

        /// <summary>
        /// The output type used to format values in this column. Must be one of boolean, currency, dateTime, number, or text.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string OutputType { get => this._outputType; set => this._outputType = value; }

        /// <summary>Creates an new <see cref="MicrosoftGraphCalculatedColumn" /> instance.</summary>
        public MicrosoftGraphCalculatedColumn()
        {

        }
    }
    /// calculatedColumn
    public partial interface IMicrosoftGraphCalculatedColumn :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IAssociativeArray<global::System.Object>
    {
        /// <summary>
        /// For dateTime output types, the format of the value. Must be one of dateOnly or dateTime.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"For dateTime output types, the format of the value. Must be one of dateOnly or dateTime.",
        SerializedName = @"format",
        PossibleTypes = new [] { typeof(string) })]
        string Format { get; set; }
        /// <summary>The formula used to compute the value for this column.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The formula used to compute the value for this column.",
        SerializedName = @"formula",
        PossibleTypes = new [] { typeof(string) })]
        string Formula { get; set; }
        /// <summary>
        /// The output type used to format values in this column. Must be one of boolean, currency, dateTime, number, or text.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The output type used to format values in this column. Must be one of boolean, currency, dateTime, number, or text.",
        SerializedName = @"outputType",
        PossibleTypes = new [] { typeof(string) })]
        string OutputType { get; set; }

    }
    /// calculatedColumn
    internal partial interface IMicrosoftGraphCalculatedColumnInternal

    {
        /// <summary>
        /// For dateTime output types, the format of the value. Must be one of dateOnly or dateTime.
        /// </summary>
        string Format { get; set; }
        /// <summary>The formula used to compute the value for this column.</summary>
        string Formula { get; set; }
        /// <summary>
        /// The output type used to format values in this column. Must be one of boolean, currency, dateTime, number, or text.
        /// </summary>
        string OutputType { get; set; }

    }
}