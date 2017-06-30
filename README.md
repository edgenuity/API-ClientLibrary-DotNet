Copyright © 2014-2017 New York State Education Department. All rights reserved.

# RICOne API .NET Client Library
The RICOne .NET Client Library was developed using .NET 4 and RestSharp (http://restsharp.org/).

### Features
* Makes calls to the RICOne API using the xPress model in .NET projects
* User can login to the authentication server using credentials to retrieve provider information
* Uses POCO object responses

#### Basic Use
```csharp
Authenticator auth = Authenticator.Instance;
auth.Authenticate(authUrl, clientId, clientSecret);

foreach (Endpoint e in auth.GetEndpoints())
{
	XPress xPress = new XPress(e.href);
}
```

### Project Contents
* RicOneApi - Client Library
* RicOneApi.Tests - Test console outputs of all service paths
* SampleConsole - Simple console app showing use

### Getting Started
1. View the library <a href="http://www.ricone.org/vendors/ric-one-api/net-client-developers-guide/" target="_blank">documentation</a>
2. Download the Project
3. Get your OAuth server credentials
4. Open SampleConsole
5. Add the auth url and credentials to clientId and clientSecret
```csharp
const string authUrl = "AUTH URL";
const string clientId = "YOUR USERNAME";
const string clientSecret = "YOUR PASSWORD";
```
## Change Log
### v1.5.2
* Entry/Exit Codes now available
    * Added XOtherCodeListType & XOtherCodeType POCOs
    * Added entryType & exitType to XEnrollmentType
	
### v1.5.1
* Added ability to request xLea or xSchool objects by BEDS or Local Id code.
	* xLeas/{id}
	* xSchools/{id}
	* xLeas/{id}/xObject
	* xSchools/{id}/xObject
	
### v1.5
* Added Changes Since support to XPress.cs
	* Supported calls include: GetXLeas(string), GetXSchools(string), GetXCalendars(string), GetXCoursess(string), GetXRosters(string), GetXStaffs(string), GetXStudents(string), GetXContactss(string)
	* More info on Changes Since can be found in the API Developer's Guide <a href="http://www.ricone.org/vendors/ric-one-api/api-developers-guide/" target="_blank">here</a>
* Added TimestampToISO8601(Date) to Util.cs
* Added custom exception class for failed authentication - AuthenticationException.cs
	* Will return 401 UNAUTHORIZED message on failed login attempt

### v1.4.1
* Modifications to the xPress data model
	* Deprecated schoolCalendarRefId and sessionCode in XRosterType
	* Added schoolCalendarRefId and sessionCode to XMeetingTimeType
	
### v1.4
* Updated Authenticator class to include Authenticate() where the auth server url and credentials are passed
* Removed GetDecodedToken from Authenticator class and moved it to the DecodedToken class

### v1.3.1
* Modified Authenticator.cs
* Modified XPress.cs
	* Check token expiration and refresh if expired
	
### v1.3
* Code clean-up
	* Removed RicOneApiClient.cs
	* Reworked Authenticator.cs
* Included example loading authentication values from config file

### v1.2.2
* Added xStaff and xStudent account provisioning methods

### v1.2.1
* Added GetToken() method to Authenticator
* Added GetDecodedToken() method to Authenticator
	* Returns JWT token payload values: application_id, iss, iat, exp
	
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
