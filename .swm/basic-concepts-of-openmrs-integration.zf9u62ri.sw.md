---
title: Basic Concepts of OpenMRS Integration
---
# Basic Concepts of OpenMRS Integration

OpenMRS integration refers to the set of classes and interfaces used to interact with the OpenMRS system, an open-source platform that supports the delivery of healthcare.

## Configuration

This integration allows for seamless communication and data exchange between the HIP service and the OpenMRS system.

<SwmSnippet path="/src/In.ProjectEKA.HipService/OpenMrs/OpenMrsConfiguration.cs" line="3">

---

The <SwmToken path="src/In.ProjectEKA.HipService/OpenMrs/OpenMrsConfiguration.cs" pos="3:5:5" line-data="    public class OpenMrsConfiguration">`OpenMrsConfiguration`</SwmToken> class is used to configure the connection to the OpenMRS system. It includes properties such as URL, Username, Password, and <SwmToken path="src/In.ProjectEKA.HipService/OpenMrs/OpenMrsConfiguration.cs" pos="12:5:5" line-data="        public string PhoneNumber { get; set; }">`PhoneNumber`</SwmToken>.

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

<SwmSnippet path="/src/In.ProjectEKA.HipService/OpenMrs/OpenMrsClient.cs" line="11">

---

## Client

The <SwmToken path="src/In.ProjectEKA.HipService/OpenMrs/OpenMrsClient.cs" pos="11:5:5" line-data="    public class OpenMrsClient : IOpenMrsClient">`OpenMrsClient`</SwmToken> class implements the <SwmToken path="src/In.ProjectEKA.HipService/OpenMrs/OpenMrsClient.cs" pos="11:9:9" line-data="    public class OpenMrsClient : IOpenMrsClient">`IOpenMrsClient`</SwmToken> interface and is responsible for making API calls to the OpenMRS system. It uses the <SwmToken path="src/In.ProjectEKA.HipService/OpenMrs/OpenMrsClient.cs" pos="14:5:5" line-data="        private readonly OpenMrsConfiguration configuration;">`OpenMrsConfiguration`</SwmToken> class for configuration and handles the responses from the API calls.

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

        public async Task<HttpResponseMessage> GetAsync(string openMrsUrl)
        {
            var responseMessage = await httpClient.GetAsync(Path.Join(configuration.Url, openMrsUrl));

            if (!responseMessage.IsSuccessStatusCode)
            {
                var error = await responseMessage.Content.ReadAsStringAsync();
                Log.Error(
                    $"Failure in getting the data from OpenMrs with status code {responseMessage.StatusCode}" +
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/appsettings.json" line="61">

---

## OpenMRS API Endpoints

The OpenMRS integration in the HIP service involves several API endpoints that facilitate communication and data exchange with the OpenMRS system. These endpoints are configured using the <SwmToken path="src/In.ProjectEKA.HipService/OpenMrs/OpenMrsConfiguration.cs" pos="3:5:5" line-data="    public class OpenMrsConfiguration">`OpenMrsConfiguration`</SwmToken> class, which includes properties such as URL, Username, Password, and <SwmToken path="src/In.ProjectEKA.HipService/OpenMrs/OpenMrsConfiguration.cs" pos="12:5:5" line-data="        public string PhoneNumber { get; set; }">`PhoneNumber`</SwmToken>. The <SwmToken path="src/In.ProjectEKA.HipService/OpenMrs/OpenMrsClient.cs" pos="11:5:5" line-data="    public class OpenMrsClient : IOpenMrsClient">`OpenMrsClient`</SwmToken> class, implementing the <SwmToken path="src/In.ProjectEKA.HipService/OpenMrs/OpenMrsClient.cs" pos="11:9:9" line-data="    public class OpenMrsClient : IOpenMrsClient">`IOpenMrsClient`</SwmToken> interface, is responsible for making API calls to the OpenMRS system and handling the responses.

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

<SwmSnippet path="/src/In.ProjectEKA.HipService/appsettings.json" line="61">

---

The configuration for the OpenMRS endpoints is defined in the <SwmPath>[src/In.ProjectEKA.HipService/appsettings.json](src/In.ProjectEKA.HipService/appsettings.json)</SwmPath> file, where the URL, username, and password for the OpenMRS system are specified. This configuration is essential for establishing a connection to the OpenMRS system and making API calls.

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
