// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Extensions;

    /// <summary>person</summary>
    public partial class MicrosoftGraphPerson :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphPerson,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphPersonInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphEntity"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphEntity __microsoftGraphEntity = new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.MicrosoftGraphEntity();

        /// <summary>Backing field for <see cref="Birthday" /> property.</summary>
        private string _birthday;

        /// <summary>The person's birthday.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string Birthday { get => this._birthday; set => this._birthday = value; }

        /// <summary>Backing field for <see cref="CompanyName" /> property.</summary>
        private string _companyName;

        /// <summary>The name of the person's company.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string CompanyName { get => this._companyName; set => this._companyName = value; }

        /// <summary>Backing field for <see cref="Department" /> property.</summary>
        private string _department;

        /// <summary>The person's department.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string Department { get => this._department; set => this._department = value; }

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>The person's display name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Backing field for <see cref="GivenName" /> property.</summary>
        private string _givenName;

        /// <summary>The person's given name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string GivenName { get => this._givenName; set => this._givenName = value; }

        /// <summary>Read-only.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphEntityInternal)__microsoftGraphEntity).Id; }

        /// <summary>Backing field for <see cref="ImAddress" /> property.</summary>
        private string _imAddress;

        /// <summary>
        /// The instant message voice over IP (VOIP) session initiation protocol (SIP) address for the user. Read-only.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string ImAddress { get => this._imAddress; set => this._imAddress = value; }

        /// <summary>Backing field for <see cref="IsFavorite" /> property.</summary>
        private bool? _isFavorite;

        /// <summary>true if the user has flagged this person as a favorite.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public bool? IsFavorite { get => this._isFavorite; set => this._isFavorite = value; }

        /// <summary>Backing field for <see cref="JobTitle" /> property.</summary>
        private string _jobTitle;

        /// <summary>The person's job title.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string JobTitle { get => this._jobTitle; set => this._jobTitle = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphEntityInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphEntityInternal)__microsoftGraphEntity).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphEntityInternal)__microsoftGraphEntity).Id = value; }

        /// <summary>Backing field for <see cref="OfficeLocation" /> property.</summary>
        private string _officeLocation;

        /// <summary>The location of the person's office.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string OfficeLocation { get => this._officeLocation; set => this._officeLocation = value; }

        /// <summary>Backing field for <see cref="PersonNote" /> property.</summary>
        private string _personNote;

        /// <summary>Free-form notes that the user has taken about this person.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string PersonNote { get => this._personNote; set => this._personNote = value; }

        /// <summary>Backing field for <see cref="PersonType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphPersonType _personType;

        /// <summary>personType</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphPersonType PersonType { get => (this._personType = this._personType ?? new Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.MicrosoftGraphPersonType()); set => this._personType = value; }

        /// <summary>Backing field for <see cref="Phone" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphPhone[] _phone;

        /// <summary>The person's phone numbers.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphPhone[] Phone { get => this._phone; set => this._phone = value; }

        /// <summary>Backing field for <see cref="PostalAddress" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphLocation[] _postalAddress;

        /// <summary>The person's addresses.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphLocation[] PostalAddress { get => this._postalAddress; set => this._postalAddress = value; }

        /// <summary>Backing field for <see cref="Profession" /> property.</summary>
        private string _profession;

        /// <summary>The person's profession.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string Profession { get => this._profession; set => this._profession = value; }

        /// <summary>Backing field for <see cref="ScoredEmailAddress" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphScoredEmailAddress[] _scoredEmailAddress;

        /// <summary>The person's email addresses.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphScoredEmailAddress[] ScoredEmailAddress { get => this._scoredEmailAddress; set => this._scoredEmailAddress = value; }

        /// <summary>Backing field for <see cref="Surname" /> property.</summary>
        private string _surname;

        /// <summary>The person's surname.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string Surname { get => this._surname; set => this._surname = value; }

        /// <summary>Backing field for <see cref="UserPrincipalName" /> property.</summary>
        private string _userPrincipalName;

        /// <summary>
        /// The user principal name (UPN) of the person. The UPN is an Internet-style login name for the person based on the Internet
        /// standard RFC 822. By convention, this should map to the person's email name. The general format is alias@domain.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string UserPrincipalName { get => this._userPrincipalName; set => this._userPrincipalName = value; }

        /// <summary>Backing field for <see cref="Website" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphWebsite[] _website;

        /// <summary>The person's websites.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphWebsite[] Website { get => this._website; set => this._website = value; }

        /// <summary>Backing field for <see cref="YomiCompany" /> property.</summary>
        private string _yomiCompany;

        /// <summary>The phonetic Japanese name of the person's company.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string YomiCompany { get => this._yomiCompany; set => this._yomiCompany = value; }

        /// <summary>Creates an new <see cref="MicrosoftGraphPerson" /> instance.</summary>
        public MicrosoftGraphPerson()
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
    /// person
    public partial interface IMicrosoftGraphPerson :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphEntity,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IAssociativeArray<global::System.Object>
    {
        /// <summary>The person's birthday.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The person's birthday.",
        SerializedName = @"birthday",
        PossibleTypes = new [] { typeof(string) })]
        string Birthday { get; set; }
        /// <summary>The name of the person's company.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the person's company.",
        SerializedName = @"companyName",
        PossibleTypes = new [] { typeof(string) })]
        string CompanyName { get; set; }
        /// <summary>The person's department.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The person's department.",
        SerializedName = @"department",
        PossibleTypes = new [] { typeof(string) })]
        string Department { get; set; }
        /// <summary>The person's display name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The person's display name.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>The person's given name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The person's given name.",
        SerializedName = @"givenName",
        PossibleTypes = new [] { typeof(string) })]
        string GivenName { get; set; }
        /// <summary>
        /// The instant message voice over IP (VOIP) session initiation protocol (SIP) address for the user. Read-only.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The instant message voice over IP (VOIP) session initiation protocol (SIP) address for the user. Read-only.",
        SerializedName = @"imAddress",
        PossibleTypes = new [] { typeof(string) })]
        string ImAddress { get; set; }
        /// <summary>true if the user has flagged this person as a favorite.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"true if the user has flagged this person as a favorite.",
        SerializedName = @"isFavorite",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsFavorite { get; set; }
        /// <summary>The person's job title.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The person's job title.",
        SerializedName = @"jobTitle",
        PossibleTypes = new [] { typeof(string) })]
        string JobTitle { get; set; }
        /// <summary>The location of the person's office.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The location of the person's office.",
        SerializedName = @"officeLocation",
        PossibleTypes = new [] { typeof(string) })]
        string OfficeLocation { get; set; }
        /// <summary>Free-form notes that the user has taken about this person.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Free-form notes that the user has taken about this person.",
        SerializedName = @"personNotes",
        PossibleTypes = new [] { typeof(string) })]
        string PersonNote { get; set; }
        /// <summary>personType</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"personType",
        SerializedName = @"personType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphPersonType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphPersonType PersonType { get; set; }
        /// <summary>The person's phone numbers.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The person's phone numbers.",
        SerializedName = @"phones",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphPhone) })]
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphPhone[] Phone { get; set; }
        /// <summary>The person's addresses.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The person's addresses.",
        SerializedName = @"postalAddresses",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphLocation) })]
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphLocation[] PostalAddress { get; set; }
        /// <summary>The person's profession.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The person's profession.",
        SerializedName = @"profession",
        PossibleTypes = new [] { typeof(string) })]
        string Profession { get; set; }
        /// <summary>The person's email addresses.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The person's email addresses.",
        SerializedName = @"scoredEmailAddresses",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphScoredEmailAddress) })]
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphScoredEmailAddress[] ScoredEmailAddress { get; set; }
        /// <summary>The person's surname.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The person's surname.",
        SerializedName = @"surname",
        PossibleTypes = new [] { typeof(string) })]
        string Surname { get; set; }
        /// <summary>
        /// The user principal name (UPN) of the person. The UPN is an Internet-style login name for the person based on the Internet
        /// standard RFC 822. By convention, this should map to the person's email name. The general format is alias@domain.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The user principal name (UPN) of the person. The UPN is an Internet-style login name for the person based on the Internet standard RFC 822. By convention, this should map to the person's email name. The general format is alias@domain.",
        SerializedName = @"userPrincipalName",
        PossibleTypes = new [] { typeof(string) })]
        string UserPrincipalName { get; set; }
        /// <summary>The person's websites.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The person's websites.",
        SerializedName = @"websites",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphWebsite) })]
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphWebsite[] Website { get; set; }
        /// <summary>The phonetic Japanese name of the person's company.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The phonetic Japanese name of the person's company.",
        SerializedName = @"yomiCompany",
        PossibleTypes = new [] { typeof(string) })]
        string YomiCompany { get; set; }

    }
    /// person
    internal partial interface IMicrosoftGraphPersonInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphEntityInternal
    {
        /// <summary>The person's birthday.</summary>
        string Birthday { get; set; }
        /// <summary>The name of the person's company.</summary>
        string CompanyName { get; set; }
        /// <summary>The person's department.</summary>
        string Department { get; set; }
        /// <summary>The person's display name.</summary>
        string DisplayName { get; set; }
        /// <summary>The person's given name.</summary>
        string GivenName { get; set; }
        /// <summary>
        /// The instant message voice over IP (VOIP) session initiation protocol (SIP) address for the user. Read-only.
        /// </summary>
        string ImAddress { get; set; }
        /// <summary>true if the user has flagged this person as a favorite.</summary>
        bool? IsFavorite { get; set; }
        /// <summary>The person's job title.</summary>
        string JobTitle { get; set; }
        /// <summary>The location of the person's office.</summary>
        string OfficeLocation { get; set; }
        /// <summary>Free-form notes that the user has taken about this person.</summary>
        string PersonNote { get; set; }
        /// <summary>personType</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphPersonType PersonType { get; set; }
        /// <summary>The person's phone numbers.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphPhone[] Phone { get; set; }
        /// <summary>The person's addresses.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphLocation[] PostalAddress { get; set; }
        /// <summary>The person's profession.</summary>
        string Profession { get; set; }
        /// <summary>The person's email addresses.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphScoredEmailAddress[] ScoredEmailAddress { get; set; }
        /// <summary>The person's surname.</summary>
        string Surname { get; set; }
        /// <summary>
        /// The user principal name (UPN) of the person. The UPN is an Internet-style login name for the person based on the Internet
        /// standard RFC 822. By convention, this should map to the person's email name. The general format is alias@domain.
        /// </summary>
        string UserPrincipalName { get; set; }
        /// <summary>The person's websites.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphWebsite[] Website { get; set; }
        /// <summary>The phonetic Japanese name of the person's company.</summary>
        string YomiCompany { get; set; }

    }
}