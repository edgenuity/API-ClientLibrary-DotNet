Copyright © 2014-2015 New York State Education Department. All rights reserved.

# RICOne API .NET Client Library
The RICOne .NET Client Library was developed using .NET 4 and RestSharp (http://restsharp.org/).

### Features
* Makes calls to the RICOne API using the SIFxPress model in .NET projects
* User can login to OAuth server using credentials to retrieve provider information
* Uses POCO object responses

#### Basic Use
```csharp
Authenticator auth = new Authenticator(username, password);

foreach (Endpoint e in auth.GetEndpoints())
{
	RicOneApiClient ricOne = new RicOneApiClient(e);
}
```

### Project Contents
* RicOneApi - Client Library
* RicOneApi.Tests - Test Console Outputs
* SampleConsole - Simple console app showing use

### Getting Started
1. Download the Project
2. Get your OAuth server credentials
3. Open SampleConsole
4. Add credentials to username and password
```csharp
const string username = "YOUR USERNAME";
const string password = "YOUR PASSWORD";
```
## Change Log
### v1.1.1
* Modified Endpoint.java model file to include provider id
* In Authenticator.java, switched GetEndPoints() to match on provider id versus provider name

### v1.1
* Added max page size
* Renamed SIFxPress model files to reflect data API naming types
