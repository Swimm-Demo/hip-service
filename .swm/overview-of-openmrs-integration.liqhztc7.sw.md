---
title: Overview of OpenMRS Integration
---
# What is <SwmToken path="src/In.ProjectEKA.HipService/Startup.cs" pos="142:3:3" line-data="                        {&quot;OpenMRS-FHIR&quot;, Constants.PATH_OPENMRS_FHIR},">`OpenMRS`</SwmToken> Integration

<SwmToken path="src/In.ProjectEKA.HipService/Startup.cs" pos="142:3:3" line-data="                        {&quot;OpenMRS-FHIR&quot;, Constants.PATH_OPENMRS_FHIR},">`OpenMRS`</SwmToken> integration refers to the set of classes and interfaces used to interact with the <SwmToken path="src/In.ProjectEKA.HipService/Startup.cs" pos="142:3:3" line-data="                        {&quot;OpenMRS-FHIR&quot;, Constants.PATH_OPENMRS_FHIR},">`OpenMRS`</SwmToken> system, an open-source platform that supports the delivery of healthcare. This integration allows for seamless communication and data exchange between the HIP service and the <SwmToken path="src/In.ProjectEKA.HipService/Startup.cs" pos="142:3:3" line-data="                        {&quot;OpenMRS-FHIR&quot;, Constants.PATH_OPENMRS_FHIR},">`OpenMRS`</SwmToken> system.

## <SwmToken path="src/In.ProjectEKA.HipService/Startup.cs" pos="142:3:3" line-data="                        {&quot;OpenMRS-FHIR&quot;, Constants.PATH_OPENMRS_FHIR},">`OpenMRS`</SwmToken> Configuration

The <SwmToken path="src/In.ProjectEKA.HipService/OpenMrs/OpenMrsConfiguration.cs" pos="3:5:5" line-data="    public class OpenMrsConfiguration">`OpenMrsConfiguration`</SwmToken> class is used to configure the connection to the <SwmToken path="src/In.ProjectEKA.HipService/Startup.cs" pos="142:3:3" line-data="                        {&quot;OpenMRS-FHIR&quot;, Constants.PATH_OPENMRS_FHIR},">`OpenMRS`</SwmToken> system. It includes properties such as <SwmToken path="src/In.ProjectEKA.HipService/OpenMrs/OpenMrsConfiguration.cs" pos="5:5:5" line-data="        public string Url { get; set; }">`Url`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/OpenMrs/OpenMrsConfiguration.cs" pos="7:5:5" line-data="        public string Username { get; set; }">`Username`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/OpenMrs/OpenMrsConfiguration.cs" pos="9:5:5" line-data="        public string Password { get; set; }">`Password`</SwmToken>, and <SwmToken path="src/In.ProjectEKA.HipService/OpenMrs/OpenMrsConfiguration.cs" pos="12:5:5" line-data="        public string PhoneNumber { get; set; }">`PhoneNumber`</SwmToken>.

<SwmSnippet path="/src/In.ProjectEKA.HipService/OpenMrs/OpenMrsConfiguration.cs" line="3">

---

The <SwmToken path="src/In.ProjectEKA.HipService/OpenMrs/OpenMrsConfiguration.cs" pos="3:5:5" line-data="    public class OpenMrsConfiguration">`OpenMrsConfiguration`</SwmToken> class defines the necessary properties for connecting to the <SwmToken path="src/In.ProjectEKA.HipService/Startup.cs" pos="142:3:3" line-data="                        {&quot;OpenMRS-FHIR&quot;, Constants.PATH_OPENMRS_FHIR},">`OpenMRS`</SwmToken> system.

```c#
    public class OpenMrsConfiguration
    {
        public string Url { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }
        
        
        public string PhoneNumber { get; set; }
        public int PatientQueueTimeLimit { get; set; }

    }
```

---

</SwmSnippet>

## <SwmToken path="src/In.ProjectEKA.HipService/Startup.cs" pos="142:3:3" line-data="                        {&quot;OpenMRS-FHIR&quot;, Constants.PATH_OPENMRS_FHIR},">`OpenMRS`</SwmToken> Client

The <SwmToken path="src/In.ProjectEKA.HipService/OpenMrs/OpenMrsClient.cs" pos="11:5:5" line-data="    public class OpenMrsClient : IOpenMrsClient">`OpenMrsClient`</SwmToken> class implements the <SwmToken path="src/In.ProjectEKA.HipService/OpenMrs/OpenMrsClient.cs" pos="11:9:9" line-data="    public class OpenMrsClient : IOpenMrsClient">`IOpenMrsClient`</SwmToken> interface and is responsible for making API calls to the <SwmToken path="src/In.ProjectEKA.HipService/Startup.cs" pos="142:3:3" line-data="                        {&quot;OpenMRS-FHIR&quot;, Constants.PATH_OPENMRS_FHIR},">`OpenMRS`</SwmToken> system. It uses the <SwmToken path="src/In.ProjectEKA.HipService/OpenMrs/OpenMrsConfiguration.cs" pos="3:5:5" line-data="    public class OpenMrsConfiguration">`OpenMrsConfiguration`</SwmToken> class for configuration and handles the responses from the API calls.

<SwmSnippet path="/src/In.ProjectEKA.HipService/OpenMrs/OpenMrsClient.cs" line="11">

---

The <SwmToken path="src/In.ProjectEKA.HipService/OpenMrs/OpenMrsClient.cs" pos="11:5:5" line-data="    public class OpenMrsClient : IOpenMrsClient">`OpenMrsClient`</SwmToken> class constructor initializes the HTTP client and sets up header authorization using the configuration provided.

```c#
    public class OpenMrsClient : IOpenMrsClient
    {
        private readonly HttpClient httpClient;
        private readonly OpenMrsConfiguration configuration;
        public OpenMrsClient(HttpClient httpClient, OpenMrsConfiguration openMrsConfiguration)
        {
            this.httpClient = httpClient;
            configuration = openMrsConfiguration;

            SettingUpHeaderAuthorization();
        }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/OpenMrs/OpenMrsClient.cs" line="23">

---

The <SwmToken path="src/In.ProjectEKA.HipService/OpenMrs/OpenMrsClient.cs" pos="23:10:10" line-data="        public async Task&lt;HttpResponseMessage&gt; GetAsync(string openMrsUrl)">`GetAsync`</SwmToken> method in the <SwmToken path="src/In.ProjectEKA.HipService/OpenMrs/OpenMrsClient.cs" pos="11:5:5" line-data="    public class OpenMrsClient : IOpenMrsClient">`OpenMrsClient`</SwmToken> class constructs the URL using the <SwmToken path="src/In.ProjectEKA.HipService/OpenMrs/OpenMrsClient.cs" pos="25:19:19" line-data="            var responseMessage = await httpClient.GetAsync(Path.Join(configuration.Url, openMrsUrl));">`Url`</SwmToken> property from <SwmToken path="src/In.ProjectEKA.HipService/OpenMrs/OpenMrsConfiguration.cs" pos="3:5:5" line-data="    public class OpenMrsConfiguration">`OpenMrsConfiguration`</SwmToken> and makes a GET request to the <SwmToken path="src/In.ProjectEKA.HipService/Startup.cs" pos="142:3:3" line-data="                        {&quot;OpenMRS-FHIR&quot;, Constants.PATH_OPENMRS_FHIR},">`OpenMRS`</SwmToken> system. If the response is not successful, it logs the error and throws an <SwmToken path="src/In.ProjectEKA.HipService/OpenMrs/OpenMrsClient.cs" pos="33:5:5" line-data="                throw new OpenMrsConnectionException();">`OpenMrsConnectionException`</SwmToken>.

```c#
        public async Task<HttpResponseMessage> GetAsync(string openMrsUrl)
        {
            var responseMessage = await httpClient.GetAsync(Path.Join(configuration.Url, openMrsUrl));

            if (!responseMessage.IsSuccessStatusCode)
            {
                var error = await responseMessage.Content.ReadAsStringAsync();
                Log.Error(
                    $"Failure in getting the data from OpenMrs with status code {responseMessage.StatusCode}" +
                    $" {error}");
                throw new OpenMrsConnectionException();
            }

            return responseMessage;
        }
```

---

</SwmSnippet>

## Usage in Startup

The <SwmToken path="src/In.ProjectEKA.HipService/OpenMrs/OpenMrsConfiguration.cs" pos="3:5:5" line-data="    public class OpenMrsConfiguration">`OpenMrsConfiguration`</SwmToken> and <SwmToken path="src/In.ProjectEKA.HipService/OpenMrs/OpenMrsClient.cs" pos="11:5:5" line-data="    public class OpenMrsClient : IOpenMrsClient">`OpenMrsClient`</SwmToken> classes are registered as singletons in the dependency injection container in the <SwmPath>[src/In.ProjectEKA.HipService/Startup.cs](src/In.ProjectEKA.HipService/Startup.cs)</SwmPath> file.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Startup.cs" line="160">

---

The <SwmToken path="src/In.ProjectEKA.HipService/Startup.cs" pos="160:15:15" line-data="                .AddSingleton(Configuration.GetSection(&quot;OpenMrs&quot;).Get&lt;OpenMrsConfiguration&gt;())">`OpenMrsConfiguration`</SwmToken> and <SwmToken path="src/In.ProjectEKA.HipService/Startup.cs" pos="161:6:6" line-data="                .AddSingleton(new OpenMrsClient(HttpClient,">`OpenMrsClient`</SwmToken> classes are registered in the dependency injection container, allowing them to be used throughout the application.

```c#
                .AddSingleton(Configuration.GetSection("OpenMrs").Get<OpenMrsConfiguration>())
                .AddSingleton(new OpenMrsClient(HttpClient,
                    Configuration.GetSection("OpenMrs").Get<OpenMrsConfiguration>()))
                .AddSingleton(Configuration.GetSection("Jwt").Get<JwtConfiguration>())
                .AddScoped<IOpenMrsClient, OpenMrsClient>()
                .AddScoped<IOpenMrsPatientData, OpenMrsPatientData>()
```

---

</SwmSnippet>

## <SwmToken path="src/In.ProjectEKA.HipService/Startup.cs" pos="142:3:3" line-data="                        {&quot;OpenMRS-FHIR&quot;, Constants.PATH_OPENMRS_FHIR},">`OpenMRS`</SwmToken> Endpoints

The <SwmToken path="src/In.ProjectEKA.HipService/OpenMrs/OpenMrsClient.cs" pos="31:15:15" line-data="                    $&quot;Failure in getting the data from OpenMrs with status code {responseMessage.StatusCode}&quot; +">`OpenMrs`</SwmToken> section in the configuration file defines the connection settings for the <SwmToken path="src/In.ProjectEKA.HipService/Startup.cs" pos="142:3:3" line-data="                        {&quot;OpenMRS-FHIR&quot;, Constants.PATH_OPENMRS_FHIR},">`OpenMRS`</SwmToken> system, including the URL, username, password, phone number, and patient queue time limit.

<SwmSnippet path="/src/In.ProjectEKA.HipService/appsettings.json" line="61">

---

The <SwmToken path="src/In.ProjectEKA.HipService/appsettings.json" pos="61:2:2" line-data="  &quot;OpenMrs&quot;: {">`OpenMrs`</SwmToken> section in the configuration file specifies the connection settings for the <SwmToken path="src/In.ProjectEKA.HipService/Startup.cs" pos="142:3:3" line-data="                        {&quot;OpenMRS-FHIR&quot;, Constants.PATH_OPENMRS_FHIR},">`OpenMRS`</SwmToken> system.

```json
  "OpenMrs": {
    "url": "$BAHMNI_URL",
    "username": "superman",
    "password": "$OPENMRS_PASSWORD",
    "phoneNumber": "phoneNumber",
    "patientQueueTimeLimit": 30 //in_minutes
  },
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/appsettings.Development.json" line="57">

---

The development configuration file also includes the <SwmToken path="src/In.ProjectEKA.HipService/appsettings.Development.json" pos="57:2:2" line-data="  &quot;OpenMrs&quot;: {">`OpenMrs`</SwmToken> section with the necessary connection settings.

```json
  "OpenMrs": {
    "url": "$BAHMNI_URL",
    "username": "superman",
    "password": "$OPENMRS_PASSWORD",
    "phoneNumber": "phoneNumber",
    "patientQueueTimeLimit": 30 //in_minutes
  },
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
