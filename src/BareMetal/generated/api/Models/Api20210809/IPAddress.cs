// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Models.Api20210809
{
    using static Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Runtime.Extensions;

    /// <summary>Specifies the IP address of the network interface.</summary>
    public partial class IPAddress :
        Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Models.Api20210809.IIPAddress,
        Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Models.Api20210809.IIPAddressInternal
    {

        /// <summary>Backing field for <see cref="IPAddress1" /> property.</summary>
        private string _iPAddress1;

        /// <summary>Specifies the IP address of the network interface.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Origin(Microsoft.Azure.PowerShell.Cmdlets.BareMetal.PropertyOrigin.Owned)]
        public string IPAddress1 { get => this._iPAddress1; set => this._iPAddress1 = value; }

        /// <summary>Creates an new <see cref="IPAddress" /> instance.</summary>
        public IPAddress()
        {

        }
    }
    /// Specifies the IP address of the network interface.
    public partial interface IIPAddress :
        Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Runtime.IJsonSerializable
    {
        /// <summary>Specifies the IP address of the network interface.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BareMetal.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies the IP address of the network interface.",
        SerializedName = @"ipAddress",
        PossibleTypes = new [] { typeof(string) })]
        string IPAddress1 { get; set; }

    }
    /// Specifies the IP address of the network interface.
    internal partial interface IIPAddressInternal

    {
        /// <summary>Specifies the IP address of the network interface.</summary>
        string IPAddress1 { get; set; }

    }
}