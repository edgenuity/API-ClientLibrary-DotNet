
Copyright © NERIC 2015

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software distributed under the License
is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
or implied.
See the License for the specific language governing permissions and limitations under the License.


The RICOne .NET Client Library was developed using .NET 4 and RestSharp (http://restsharp.org/).The 
client library supports OAuth2 authentication and the JSON return type.

## v1.0

### Features
* Makes calls to the RICOne API using the SIFxPress model in .NET projects
* User can login to OAuth server using credentials to retrieve provider information
* Uses POCO object responses

#### Basic Use
```csharp
Authenticator auth = new Authenticator(username, password);

foreach (Endpoint e in auth.GetEndpoints())
{
	RicOneAPIClient ricOne = new RicOneAPIClient(e);
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
