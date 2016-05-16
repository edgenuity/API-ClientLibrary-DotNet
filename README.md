Copyright © 2014-2015 New York State Education Department. All rights reserved.

# RICOne API .NET Client Library
The RICOne .NET Client Library was developed using .NET 4 and RestSharp (http://restsharp.org/).

### Features
* Makes calls to the RICOne API using the SIFxPress model in .NET projects
* User can login to auth server using credentials to retrieve provider information
* Uses POCO object responses

#### Basic Use
```csharp
Authenticator auth = new Authenticator(authUrl, username, password);

foreach (Endpoint e in auth.GetEndpoints())
{
	RicOneApiClient ricOne = new RicOneApiClient(e);
}
```

### Project Contents
* RicOneApi - Client Library
* RicOneApi.Tests - Test console outputs of all service paths
* SampleConsole - Simple console app showing use

### Getting Started
1. View the library <a href="https://docs.google.com/document/d/1SiNPq6jetOqyYdpSJG_77paEV5YELcSGjfj-YcbY2f0/pub" target="_blank">documentation</a>
2. Download the Project
3. Get your auth server credentials
4. Open SampleConsole
5. Add the auth url and credentials to username and password
```csharp
const string authUrl = "AUTH URL";
const string username = "YOUR USERNAME";
const string password = "YOUR PASSWORD";
```
## Change Log
### v1.2
* Paging passed via header
* Dropped SIF prefix from SIFXPress class, now XPress
* Ability to access response status code, status message, and headers
* Removed LoginId from XContactType, XStaffType, and XStudentType
* Added XAppProvisioningInfoType
	* Added to XContactType, XStaffType, and XStudentType
* Changed XYearGroupListType to XGradeLevelListType
	* Changed in XSchoolType

### v1.1.3.1
* Auth url now configurable

### v1.1.3
* Updated auth url

### v1.1.2
* Additional Service Paths
     * xLeas/{id}/xCalendars
     * xSchools/{id}/xCourses
     * xSaffs/{id}/xLeas
     * xRosters/{id}/xLeas
     * xRosters/{id}/xCourses
     * xStudents/{id}/xStaffs
* Added System.Net assembly due to invalid certificate on testing server 

### v1.1.1
* Modified Endpoint.cs model file to include provider id
* In Authenticator.cs, switched GetEndPoints() to match on provider id versus provider name

### v1.1
* Added max page size
* Renamed SIFxPress model files to reflect data API naming types
