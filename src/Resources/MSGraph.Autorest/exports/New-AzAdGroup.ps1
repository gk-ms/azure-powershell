
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License. See License.txt in the project root for license information.
# Code generated by Microsoft (R) AutoRest Code Generator.
# Changes may cause incorrect behavior and will be lost if the code is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Add new entity to groups
.Description
Add new entity to groups
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphGroup
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphGroup
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

ACCEPTEDSENDER <IMicrosoftGraphDirectoryObject[]>: The list of users or groups that are allowed to create post's or calendar events in this group. If this list is non-empty then only users or groups listed here are allowed to post.
  [DeletedDateTime <DateTime?>]: 
  [DisplayName <String>]: The name displayed in directory
  [OdataId <String>]: The full id of object in directory
  [OdataType <String>]: The type of object in directory

APPROLEASSIGNMENT <IMicrosoftGraphAppRoleAssignmentAutoGenerated[]>: Represents the app roles a group has been granted for an application. Supports $expand.
  [DeletedDateTime <DateTime?>]: 
  [DisplayName <String>]: The name displayed in directory
  [OdataId <String>]: The full id of object in directory
  [OdataType <String>]: The type of object in directory
  [AppRoleId <String>]: The identifier (id) for the app role which is assigned to the principal. This app role must be exposed in the appRoles property on the resource application's service principal (resourceId). If the resource application has not declared any app roles, a default app role ID of 00000000-0000-0000-0000-000000000000 can be specified to signal that the principal is assigned to the resource app without any specific app roles. Required on create.
  [CreatedDateTime <DateTime?>]: The time when the app role assignment was created.The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
  [PrincipalDisplayName <String>]: The display name of the user, group, or service principal that was granted the app role assignment. Read-only. Supports $filter (eq and startswith).
  [PrincipalId <String>]: The unique identifier (id) for the user, group or service principal being granted the app role. Required on create.
  [PrincipalType <String>]: The type of the assigned principal. This can either be User, Group or ServicePrincipal. Read-only.
  [ResourceDisplayName <String>]: The display name of the resource app's service principal to which the assignment is made.
  [ResourceId <String>]: The unique identifier (id) for the resource service principal for which the assignment is made. Required on create. Supports $filter (eq only).

BODY <IMicrosoftGraphGroup>: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
  [(Any) <Object>]: This indicates any property can be added to this object.
  [DeletedDateTime <DateTime?>]: 
  [DisplayName <String>]: The name displayed in directory
  [OdataId <String>]: The full id of object in directory
  [OdataType <String>]: The type of object in directory
  [AppRoleAssignment <IMicrosoftGraphAppRoleAssignmentAutoGenerated[]>]: Represents the app roles a group has been granted for an application. Supports $expand.
    [DeletedDateTime <DateTime?>]: 
    [DisplayName <String>]: The name displayed in directory
    [OdataId <String>]: The full id of object in directory
    [OdataType <String>]: The type of object in directory
    [AppRoleId <String>]: The identifier (id) for the app role which is assigned to the principal. This app role must be exposed in the appRoles property on the resource application's service principal (resourceId). If the resource application has not declared any app roles, a default app role ID of 00000000-0000-0000-0000-000000000000 can be specified to signal that the principal is assigned to the resource app without any specific app roles. Required on create.
    [CreatedDateTime <DateTime?>]: The time when the app role assignment was created.The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
    [PrincipalDisplayName <String>]: The display name of the user, group, or service principal that was granted the app role assignment. Read-only. Supports $filter (eq and startswith).
    [PrincipalId <String>]: The unique identifier (id) for the user, group or service principal being granted the app role. Required on create.
    [PrincipalType <String>]: The type of the assigned principal. This can either be User, Group or ServicePrincipal. Read-only.
    [ResourceDisplayName <String>]: The display name of the resource app's service principal to which the assignment is made.
    [ResourceId <String>]: The unique identifier (id) for the resource service principal for which the assignment is made. Required on create. Supports $filter (eq only).
  [Classification <String>]: Describes a classification for the group (such as low, medium or high business impact). Valid values for this property are defined by creating a ClassificationList setting value, based on the template definition.Returned by default. Supports $filter (eq, ne, NOT, ge, le, startsWith).
  [CreatedOnBehalfOf <IMicrosoftGraphDirectoryObject>]: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
    [DeletedDateTime <DateTime?>]: 
    [DisplayName <String>]: The name displayed in directory
    [OdataId <String>]: The full id of object in directory
    [OdataType <String>]: The type of object in directory
  [Description <String>]: An optional description for the group. Returned by default. Supports $filter (eq, ne, NOT, ge, le, startsWith) and $search.
  [GroupType <String[]>]: Specifies the group type and its membership.  If the collection contains Unified, the group is a Microsoft 365 group; otherwise, it's either a security group or distribution group. For details, see groups overview.If the collection includes DynamicMembership, the group has dynamic membership; otherwise, membership is static.  Returned by default. Supports $filter (eq, NOT).
  [HasMembersWithLicenseError <Boolean?>]: Indicates whether there are members in this group that have license errors from its group-based license assignment. This property is never returned on a GET operation. You can use it as a $filter argument to get groups that have members with license errors (that is, filter for this property being true).  Supports $filter (eq).
  [IsArchived <Boolean?>]: 
  [IsAssignableToRole <Boolean?>]: Indicates whether this group can be assigned to an Azure Active Directory role.This property can only be set while creating the group and is immutable. If set to true, the securityEnabled property must also be set to true and the group cannot be a dynamic group (that is, groupTypes cannot contain DynamicMembership). Only callers in Global administrator and Privileged role administrator roles can set this property. The caller must also be assigned the Directory.AccessAsUser.All permission to set this property. For more, see Using a group to manage Azure AD role assignmentsReturned by default. Supports $filter (eq, ne, NOT).
  [MailEnabled <Boolean?>]: Specifies whether the group is mail-enabled. Returned by default. Supports $filter (eq, ne, NOT).
  [MailNickname <String>]: The mail alias for the group, unique in the organization. This property must be specified when a group is created. These characters cannot be used in the mailNickName: @()/[]';:.<>,SPACE. Returned by default. Supports $filter (eq, ne, NOT, ge, le, in, startsWith).
  [MembershipRule <String>]: The rule that determines members for this group if the group is a dynamic group (groupTypes contains DynamicMembership). For more information about the syntax of the membership rule, see Membership Rules syntax. Returned by default. Supports $filter (eq, ne, NOT, ge, le, startsWith).
  [MembershipRuleProcessingState <String>]: Indicates whether the dynamic membership processing is on or paused. Possible values are On or Paused. Returned by default. Supports $filter (eq, ne, NOT, in).
  [PermissionGrant <IMicrosoftGraphResourceSpecificPermissionGrant[]>]: The permissions that have been granted for a group to a specific application. Supports $expand.
    [DeletedDateTime <DateTime?>]: 
    [DisplayName <String>]: The name displayed in directory
    [OdataId <String>]: The full id of object in directory
    [OdataType <String>]: The type of object in directory
    [ClientAppId <String>]: ID of the service principal of the Azure AD app that has been granted access. Read-only.
    [ClientId <String>]: ID of the Azure AD app that has been granted access. Read-only.
    [Permission <String>]: The name of the resource-specific permission. Read-only.
    [PermissionType <String>]: The type of permission. Possible values are: Application, Delegated. Read-only.
    [ResourceAppId <String>]: ID of the Azure AD app that is hosting the resource. Read-only.
  [PreferredDataLocation <String>]: The preferred data location for the group. For more information, see  OneDrive Online Multi-Geo. Returned by default.
  [PreferredLanguage <String>]: The preferred language for a Microsoft 365 group. Should follow ISO 639-1 Code; for example 'en-US'. Returned by default. Supports $filter (eq, ne, NOT, ge, le, in, startsWith).
  [SecurityEnabled <Boolean?>]: Specifies whether the group is a security group. Returned by default. Supports $filter (eq, ne, NOT, in).
  [SecurityIdentifier <String>]: Security identifier of the group, used in Windows scenarios. Returned by default.
  [Theme <String>]: Specifies a Microsoft 365 group's color theme. Possible values are Teal, Purple, Green, Blue, Pink, Orange or Red. Returned by default.
  [Visibility <String>]: Specifies the group join policy and group content visibility for groups. Possible values are: Private, Public, or Hiddenmembership. Hiddenmembership can be set only for Microsoft 365 groups, when the groups are created. It can't be updated later. Other values of visibility can be updated after group creation. If visibility value is not specified during group creation on Microsoft Graph, a security group is created as Private by default and Microsoft 365 group is Public. See group visibility options to learn more. Returned by default.

CREATEDONBEHALFOF <IMicrosoftGraphDirectoryObject>: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
  [DeletedDateTime <DateTime?>]: 
  [DisplayName <String>]: The name displayed in directory
  [OdataId <String>]: The full id of object in directory
  [OdataType <String>]: The type of object in directory

PERMISSIONGRANT <IMicrosoftGraphResourceSpecificPermissionGrant[]>: The permissions that have been granted for a group to a specific application. Supports $expand.
  [DeletedDateTime <DateTime?>]: 
  [DisplayName <String>]: The name displayed in directory
  [OdataId <String>]: The full id of object in directory
  [OdataType <String>]: The type of object in directory
  [ClientAppId <String>]: ID of the service principal of the Azure AD app that has been granted access. Read-only.
  [ClientId <String>]: ID of the Azure AD app that has been granted access. Read-only.
  [Permission <String>]: The name of the resource-specific permission. Read-only.
  [PermissionType <String>]: The type of permission. Possible values are: Application, Delegated. Read-only.
  [ResourceAppId <String>]: ID of the Azure AD app that is hosting the resource. Read-only.

SETTING <IMicrosoftGraphGroupSetting[]>: Settings that can govern this group's behavior, like whether members can invite guest users to the group. Nullable.
  [DisplayName <String>]: Display name of this group of settings, which comes from the associated template.
  [TemplateId <String>]: Unique identifier for the template used to create this group of settings. Read-only.
  [Value <IMicrosoftGraphSettingValue[]>]: Collection of name value pairs. Must contain and set all the settings defined in the template.
    [Name <String>]: Name of the setting (as defined by the directorySettingTemplate).
    [Value <String>]: Value of the setting.

TRANSITIVEMEMBER <IMicrosoftGraphDirectoryObject[]>: .
  [DeletedDateTime <DateTime?>]: 
  [DisplayName <String>]: The name displayed in directory
  [OdataId <String>]: The full id of object in directory
  [OdataType <String>]: The type of object in directory

TRANSITIVEMEMBEROF <IMicrosoftGraphDirectoryObject[]>: .
  [DeletedDateTime <DateTime?>]: 
  [DisplayName <String>]: The name displayed in directory
  [OdataId <String>]: The full id of object in directory
  [OdataType <String>]: The type of object in directory
.Link
https://docs.microsoft.com/powershell/module/az.resources/new-azadgroup
#>
function New-AzAdGroup {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphGroup])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Body')]
    [System.String]
    # The display name for the group.
    # This property is required when a group is created and cannot be cleared during updates.
    # Returned by default.
    # Supports $filter (eq, ne, NOT, ge, le, in, startsWith), $search, and $orderBy.
    ${DisplayName},

    [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Body')]
    [System.String]
    # The mail alias for the group, unique in the organization.
    # This property must be specified when a group is created.
    # These characters cannot be used in the mailNickName: @()/[]';:.<>,SPACE.
    # Returned by default.
    # Supports $filter (eq, ne, NOT, ge, le, in, startsWith).
    ${MailNickname},

    [Parameter(ParameterSetName='CreateExpanded')]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDirectoryObject[]]
    # The list of users or groups that are allowed to create post's or calendar events in this group.
    # If this list is non-empty then only users or groups listed here are allowed to post.
    # To construct, see NOTES section for ACCEPTEDSENDER properties and create a hash table.
    ${AcceptedSender},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Body')]
    [System.Collections.Hashtable]
    # Additional Parameters
    ${AdditionalProperties},

    [Parameter(ParameterSetName='CreateExpanded')]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphAppRoleAssignmentAutoGenerated[]]
    # Represents the app roles a group has been granted for an application.
    # Supports $expand.
    # To construct, see NOTES section for APPROLEASSIGNMENT properties and create a hash table.
    ${AppRoleAssignment},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Body')]
    [System.String]
    # Describes a classification for the group (such as low, medium or high business impact).
    # Valid values for this property are defined by creating a ClassificationList setting value, based on the template definition.Returned by default.
    # Supports $filter (eq, ne, NOT, ge, le, startsWith).
    ${Classification},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDirectoryObject]
    # Represents an Azure Active Directory object.
    # The directoryObject type is the base type for many other directory entity types.
    # To construct, see NOTES section for CREATEDONBEHALFOF properties and create a hash table.
    ${CreatedOnBehalfOf},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Body')]
    [System.DateTime]
    # .
    ${DeletedDateTime},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Body')]
    [System.String]
    # An optional description for the group.
    # Returned by default.
    # Supports $filter (eq, ne, NOT, ge, le, startsWith) and $search.
    ${Description},

    [Parameter(ParameterSetName='CreateExpanded')]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Body')]
    [System.String[]]
    # Specifies the group type and its membership.
    # If the collection contains Unified, the group is a Microsoft 365 group; otherwise, it's either a security group or distribution group.
    # For details, see groups overview.If the collection includes DynamicMembership, the group has dynamic membership; otherwise, membership is static.
    # Returned by default.
    # Supports $filter (eq, NOT).
    ${GroupType},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Indicates whether there are members in this group that have license errors from its group-based license assignment.
    # This property is never returned on a GET operation.
    # You can use it as a $filter argument to get groups that have members with license errors (that is, filter for this property being true).
    # Supports $filter (eq).
    ${HasMembersWithLicenseError},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # .
    ${IsArchived},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Indicates whether this group can be assigned to an Azure Active Directory role.This property can only be set while creating the group and is immutable.
    # If set to true, the securityEnabled property must also be set to true and the group cannot be a dynamic group (that is, groupTypes cannot contain DynamicMembership).
    # Only callers in Global administrator and Privileged role administrator roles can set this property.
    # The caller must also be assigned the Directory.AccessAsUser.All permission to set this property.
    # For more, see Using a group to manage Azure AD role assignmentsReturned by default.
    # Supports $filter (eq, ne, NOT).
    ${IsAssignableToRole},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Specifies whether the group is mail-enabled.
    # Returned by default.
    # Supports $filter (eq, ne, NOT).
    ${MailEnabled},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Body')]
    [System.String]
    # The rule that determines members for this group if the group is a dynamic group (groupTypes contains DynamicMembership).
    # For more information about the syntax of the membership rule, see Membership Rules syntax.
    # Returned by default.
    # Supports $filter (eq, ne, NOT, ge, le, startsWith).
    ${MembershipRule},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Body')]
    [System.String]
    # Indicates whether the dynamic membership processing is on or paused.
    # Possible values are On or Paused.
    # Returned by default.
    # Supports $filter (eq, ne, NOT, in).
    ${MembershipRuleProcessingState},

    [Parameter(ParameterSetName='CreateExpanded')]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphResourceSpecificPermissionGrant[]]
    # The permissions that have been granted for a group to a specific application.
    # Supports $expand.
    # To construct, see NOTES section for PERMISSIONGRANT properties and create a hash table.
    ${PermissionGrant},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Body')]
    [System.String]
    # The preferred data location for the group.
    # For more information, see OneDrive Online Multi-Geo.
    # Returned by default.
    ${PreferredDataLocation},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Body')]
    [System.String]
    # The preferred language for a Microsoft 365 group.
    # Should follow ISO 639-1 Code; for example 'en-US'.
    # Returned by default.
    # Supports $filter (eq, ne, NOT, ge, le, in, startsWith).
    ${PreferredLanguage},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Specifies whether the group is a security group.
    # Returned by default.
    # Supports $filter (eq, ne, NOT, in).
    ${SecurityEnabled},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Body')]
    [System.String]
    # Security identifier of the group, used in Windows scenarios.
    # Returned by default.
    ${SecurityIdentifier},

    [Parameter(ParameterSetName='CreateExpanded')]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphGroupSetting[]]
    # Settings that can govern this group's behavior, like whether members can invite guest users to the group.
    # Nullable.
    # To construct, see NOTES section for SETTING properties and create a hash table.
    ${Setting},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Body')]
    [System.String]
    # Specifies a Microsoft 365 group's color theme.
    # Possible values are Teal, Purple, Green, Blue, Pink, Orange or Red.
    # Returned by default.
    ${Theme},

    [Parameter(ParameterSetName='CreateExpanded')]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDirectoryObject[]]
    # .
    # To construct, see NOTES section for TRANSITIVEMEMBER properties and create a hash table.
    ${TransitiveMember},

    [Parameter(ParameterSetName='CreateExpanded')]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphDirectoryObject[]]
    # .
    # To construct, see NOTES section for TRANSITIVEMEMBEROF properties and create a hash table.
    ${TransitiveMemberOf},

    [Parameter(ParameterSetName='CreateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Body')]
    [System.String]
    # Specifies the group join policy and group content visibility for groups.
    # Possible values are: Private, Public, or Hiddenmembership.
    # Hiddenmembership can be set only for Microsoft 365 groups, when the groups are created.
    # It can't be updated later.
    # Other values of visibility can be updated after group creation.
    # If visibility value is not specified during group creation on Microsoft Graph, a security group is created as Private by default and Microsoft 365 group is Public.
    # See group visibility options to learn more.
    # Returned by default.
    ${Visibility},

    [Parameter(ParameterSetName='Create', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphGroup]
    # Represents an Azure Active Directory object.
    # The directoryObject type is the base type for many other directory entity types.
    # To construct, see NOTES section for BODY properties and create a hash table.
    ${Body},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            CreateExpanded = 'MSGraph.custom\New-AzAdGroup';
            Create = 'MSGraph.custom\New-AzAdGroup';
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}
