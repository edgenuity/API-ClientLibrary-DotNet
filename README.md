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
### v1.6.3
* Changed return type of AUPP creates and deletes to void as data is not returned.
* Added additional AUPP methods for deleting generated xStaff and xStudent usernames and passwords.
    ```csharp
    // xStaffs
    DeleteXStaffPasswords(string refId)
    DeleteXStaffUsernames(string refId)

    // xStudents
    DeleteXStudentPasswords(string refId)
    DeleteXStudentUsernames(string refId)
    ```

### v1.6.2
* Added method to get the last page on Changes Since requests
    ```csharp
    GetLastPage(ServicePath servicePath, int? navigationPageSize, string opaqueMarker)
    ```
* Added new method to Authenticator that returns a single endpoint
    ```csharp
    Authenticator.GetEndpoint(providerId)
    ```

### v1.6.1
* Added support to return responses as JSON or XML strings.
	```csharp
	//JSON
	xPress.GetXLeas().Json;
	
	//XML
	xPress.GetXLeas().Xml;
	```
* Added support to request staff and students by state and local ids.
  * xStaffs/{id}
  * xStudents/{id}
* Additional code cleanup

### v1.6
* Support for multiple school years
    * Integer value, i.e. 2018 for the 2017-2018 school year
    * Available on all methods except except ones that accept the opaqueMarker for changes since
    ```csharp
    int schoolYear = 2018;
    xPress.GetXLeas(schoolYear).Data;
    ```
* Added paging requests for changes since
    ```csharp
    GetXRosters(int? navigationPage, int? navigationPageSize, string opaqueMarker);
    ```
* Changed order of GetLastPage method
    ```csharp
    //NEW
    GetLastPage(ServicePath servicePath, int? navigationPageSize)
    GetLastPage(ServicePath servicePath, string refId, int? navigationPageSize);

    //OLD
    GetLastPage(int? navigationPageSize, ServicePath servicePath)
    GetLastPage(int? navigationPageSize, ServicePath servicePath, string refId);

* Removed the single object REST calls with paging
	```csharp
	GetXLea(string refId, int? navigationPage, int? navigationPageSize);
	GetXSchool(string refId, int? navigationPage, int? navigationPageSize);
	GetXCalendar(string refId, int? navigationPage, int? navigationPageSize);
	GetXCourse(string refId, int? navigationPage, int? navigationPageSize);
	GetXRoster(string refId, int? navigationPage, int? navigationPageSize);
	GetXStaff(string refId, int? navigationPage, int? navigationPageSize);
	GetXStudent(string refId, int? navigationPage, int? navigationPageSize);
	GetXContact(string refId, int? navigationPage, int? navigationPageSize);
	```
* Removed the following REST calls by beds or local id, as they are not supported in the API
    ```csharp
    GetXLeasByXSchool(string idType, string id);
    GetXSchoolsByXLea(string idType, string id);
    GetXCalendarsByXLea(string idType, string id);
    GetXCalendarsByXSchool(string idType, string id);
    GetXCoursesByXLea(string idType, string id);
    GetXCoursesByXSchool(string idType, string id);
    GetXRostersByXLea(string idType, string id);
    GetXRostersByXSchool(string idType, string id);
    GetXStaffsByXLea(string idType, string id);
    GetXStaffsByXSchool(string idType, string id);
    GetXStudentsByXLea(string idType, string id);
    GetXStudentsByXSchool(string idType, string id);
    GetXContactsByXLea(string idType, string id);
    GetXContactsByXSchool(string idType, string id);
    ```
* Internal code cleanup
	
### v1.5.3
* New method added to Authenticator class
    * GetEndpoints(string providerId, Boolean returnAllEndpoints)
        * Ability to look for a specific provider endpoint and all assigned endpoints to an application if Boolean value set to true.
          If Boolean is false and provider endpoint defined, only that endpoints details will be returned.
		  
### v1.5.2
* Entry/Exit Codes now available
    * Added XOtherCodeListType & XOtherCodeType POCOs
    * Added entryType & exitType to XEnrollmentType
* Added paging methods when retrieving staff and student accounts via AUPP
    * GetXStaffUsers(string refId, int? navigationPage, int? navigationPageSize)
    * GetXStudentUsers(string refId, int? navigationPage, int? navigationPageSize)
	
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
