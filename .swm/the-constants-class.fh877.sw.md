---
title: The Constants class
---
This document will cover the class <SwmToken path="src/In.ProjectEKA.HipService/Gateway/GatewayClient.cs" pos="52:18:18" line-data="                    RequestUri = new Uri($&quot;{configuration.Url}/{Constants.PATH_SESSIONS}&quot;),">`Constants`</SwmToken> in the file <SwmPath>[src/In.ProjectEKA.HipService/Common/Constants.cs](src/In.ProjectEKA.HipService/Common/Constants.cs)</SwmPath>. We will cover:

1. What is Constants
2. Variables and functions

# Variables and functions

# What is Constants

The <SwmToken path="src/In.ProjectEKA.HipService/Gateway/GatewayClient.cs" pos="52:18:18" line-data="                    RequestUri = new Uri($&quot;{configuration.Url}/{Constants.PATH_SESSIONS}&quot;),">`Constants`</SwmToken> class in <SwmPath>[src/In.ProjectEKA.HipService/Common/Constants.cs](src/In.ProjectEKA.HipService/Common/Constants.cs)</SwmPath> is a static class that defines various constant values used across the application. By centralizing these constants, the codebase becomes more maintainable and less prone to errors caused by hardcoding values in multiple places.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Common/Constants.cs" line="5">

---

The variable <SwmToken path="src/In.ProjectEKA.HipService/Common/Constants.cs" pos="5:7:7" line-data="        public const string CURRENT_VERSION = &quot;v0.5&quot;;">`CURRENT_VERSION`</SwmToken> is used to store the current version of the application.

```c#
        public const string CURRENT_VERSION = "v0.5";
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Common/Constants.cs" line="6">

---

The variable <SwmToken path="src/In.ProjectEKA.HipService/Common/Constants.cs" pos="6:7:7" line-data="        public const string UPDATED_VERSION = &quot;v1.0&quot;;">`UPDATED_VERSION`</SwmToken> is used to store the updated version of the application.

```c#
        public const string UPDATED_VERSION = "v1.0";
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Common/Constants.cs" line="7">

---

The variable <SwmToken path="src/In.ProjectEKA.HipService/Common/Constants.cs" pos="7:7:7" line-data="        public const string VERSION_V1 = &quot;v1&quot;;">`VERSION_V1`</SwmToken> is used to store the version 1 identifier.

```c#
        public const string VERSION_V1 = "v1";
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Common/Constants.cs" line="8">

---

The variable <SwmToken path="src/In.ProjectEKA.HipService/Common/Constants.cs" pos="8:7:7" line-data="        public const string VERSION_V2 = &quot;v2&quot;;">`VERSION_V2`</SwmToken> is used to store the version 2 identifier.

```c#
        public const string VERSION_V2 = "v2";
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Common/Constants.cs" line="9">

---

The variable <SwmToken path="src/In.ProjectEKA.HipService/Common/Constants.cs" pos="9:7:7" line-data="        public const string PATH_SESSIONS = CURRENT_VERSION + &quot;/sessions&quot;;">`PATH_SESSIONS`</SwmToken> is used to store the path for sessions.

```c#
        public const string PATH_SESSIONS = CURRENT_VERSION + "/sessions";
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Common/Constants.cs" line="10">

---

The variable <SwmToken path="src/In.ProjectEKA.HipService/Common/Constants.cs" pos="10:7:7" line-data="        public const string PATH_CARE_CONTEXTS_DISCOVER = CURRENT_VERSION + &quot;/care-contexts/discover&quot;;">`PATH_CARE_CONTEXTS_DISCOVER`</SwmToken> is used to store the path for discovering care contexts.

```c#
        public const string PATH_CARE_CONTEXTS_DISCOVER = CURRENT_VERSION + "/care-contexts/discover";
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Common/Constants.cs" line="11">

---

The variable <SwmToken path="src/In.ProjectEKA.HipService/Common/Constants.cs" pos="11:7:7" line-data="        public const string PATH_CONSENTS_HIP = CURRENT_VERSION + &quot;/consents/hip/notify&quot;;">`PATH_CONSENTS_HIP`</SwmToken> is used to store the path for HIP consents notification.

```c#
        public const string PATH_CONSENTS_HIP = CURRENT_VERSION + "/consents/hip/notify";
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Common/Constants.cs" line="12">

---

The variable <SwmToken path="src/In.ProjectEKA.HipService/Common/Constants.cs" pos="12:7:7" line-data="        public const string PATH_LINKS_LINK_INIT = CURRENT_VERSION + &quot;/links/link/init&quot;;">`PATH_LINKS_LINK_INIT`</SwmToken> is used to store the path for initializing links.

```c#
        public const string PATH_LINKS_LINK_INIT = CURRENT_VERSION + "/links/link/init";
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Common/Constants.cs" line="13">

---

The variable <SwmToken path="src/In.ProjectEKA.HipService/Common/Constants.cs" pos="13:7:7" line-data="        public const string PATH_LINKS_LINK_CONFIRM = CURRENT_VERSION + &quot;/links/link/confirm&quot;;">`PATH_LINKS_LINK_CONFIRM`</SwmToken> is used to store the path for confirming links.

```c#
        public const string PATH_LINKS_LINK_CONFIRM = CURRENT_VERSION + "/links/link/confirm";
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Common/Constants.cs" line="14">

---

The variable <SwmToken path="src/In.ProjectEKA.HipService/Common/Constants.cs" pos="14:7:7" line-data="        public const string PATH_HEALTH_INFORMATION_HIP_REQUEST = CURRENT_VERSION + &quot;/health-information/hip/request&quot;;">`PATH_HEALTH_INFORMATION_HIP_REQUEST`</SwmToken> is used to store the path for HIP health information requests.

```c#
        public const string PATH_HEALTH_INFORMATION_HIP_REQUEST = CURRENT_VERSION + "/health-information/hip/request";
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Common/Constants.cs" line="15">

---

The variable <SwmToken path="src/In.ProjectEKA.HipService/Common/Constants.cs" pos="15:7:7" line-data="        public const string PATH_HEART_BEAT = CURRENT_VERSION + &quot;/heartbeat&quot;;">`PATH_HEART_BEAT`</SwmToken> is used to store the path for heartbeat checks.

```c#
        public const string PATH_HEART_BEAT = CURRENT_VERSION + "/heartbeat";
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Common/Constants.cs" line="16">

---

The variable <SwmToken path="src/In.ProjectEKA.HipService/Common/Constants.cs" pos="16:7:7" line-data="        public const string PATH_READINESS = CURRENT_VERSION + &quot;/readiness&quot;;">`PATH_READINESS`</SwmToken> is used to store the path for readiness checks.

```c#
        public const string PATH_READINESS = CURRENT_VERSION + "/readiness";
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Common/Constants.cs" line="18">

---

The variable <SwmToken path="src/In.ProjectEKA.HipService/Common/Constants.cs" pos="18:7:7" line-data="        public const string PATH_ON_AUTH_CONFIRM = CURRENT_VERSION + &quot;/users/auth/on-confirm&quot;;">`PATH_ON_AUTH_CONFIRM`</SwmToken> is used to store the path for confirming user authentication.

```c#
        public const string PATH_ON_AUTH_CONFIRM = CURRENT_VERSION + "/users/auth/on-confirm";
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Common/Constants.cs" line="19">

---

The variable <SwmToken path="src/In.ProjectEKA.HipService/Common/Constants.cs" pos="19:7:7" line-data="        public const string PATH_ON_AUTH_INIT = &quot;/&quot; + CURRENT_VERSION + &quot;/users/auth/on-init&quot;;">`PATH_ON_AUTH_INIT`</SwmToken> is used to store the path for initializing user authentication.

```c#
        public const string PATH_ON_AUTH_INIT = "/" + CURRENT_VERSION + "/users/auth/on-init";
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Common/Constants.cs" line="20">

---

The variable <SwmToken path="src/In.ProjectEKA.HipService/Common/Constants.cs" pos="20:7:7" line-data="        public const string PATH_ON_FETCH_AUTH_MODES = &quot;/&quot; + CURRENT_VERSION + &quot;/users/auth/on-fetch-modes&quot;;">`PATH_ON_FETCH_AUTH_MODES`</SwmToken> is used to store the path for fetching authentication modes.

```c#
        public const string PATH_ON_FETCH_AUTH_MODES = "/" + CURRENT_VERSION + "/users/auth/on-fetch-modes";
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Common/Constants.cs" line="21">

---

The variable <SwmToken path="src/In.ProjectEKA.HipService/Common/Constants.cs" pos="21:7:7" line-data="        public const string PATH_ON_ADD_CONTEXTS = &quot;/&quot; + CURRENT_VERSION + &quot;/links/link/on-add-contexts&quot;;">`PATH_ON_ADD_CONTEXTS`</SwmToken> is used to store the path for adding contexts.

```c#
        public const string PATH_ON_ADD_CONTEXTS = "/" + CURRENT_VERSION + "/links/link/on-add-contexts";
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Common/Constants.cs" line="22">

---

The variable <SwmToken path="src/In.ProjectEKA.HipService/Common/Constants.cs" pos="22:7:7" line-data="        public const string PATH_ON_NOTIFY_CONTEXTS = &quot;/&quot; + CURRENT_VERSION + &quot;/links/context/on-notify&quot;;">`PATH_ON_NOTIFY_CONTEXTS`</SwmToken> is used to store the path for notifying contexts.

```c#
        public const string PATH_ON_NOTIFY_CONTEXTS = "/" + CURRENT_VERSION + "/links/context/on-notify";
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Common/Constants.cs" line="23">

---

The variable <SwmToken path="src/In.ProjectEKA.HipService/Common/Constants.cs" pos="23:9:9" line-data="        public static readonly string DateTimeFormat = &quot;yyyy-MM-ddTHH:mm:ss.fffZ&quot;;">`DateTimeFormat`</SwmToken> is used to store the date-time format string.

```c#
        public static readonly string DateTimeFormat = "yyyy-MM-ddTHH:mm:ss.fffZ";
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Common/Constants.cs" line="24">

---

The variable <SwmToken path="src/In.ProjectEKA.HipService/Common/Constants.cs" pos="24:9:9" line-data="        public static readonly string PATH_ON_DISCOVER = &quot;/&quot; + CURRENT_VERSION + &quot;/care-contexts/on-discover&quot;;">`PATH_ON_DISCOVER`</SwmToken> is used to store the path for discovering care contexts.

```c#
        public static readonly string PATH_ON_DISCOVER = "/" + CURRENT_VERSION + "/care-contexts/on-discover";
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Common/Constants.cs" line="25">

---

The variable <SwmToken path="src/In.ProjectEKA.HipService/Common/Constants.cs" pos="25:9:9" line-data="        public static readonly string PATH_ON_LINK_INIT = &quot;/&quot; + CURRENT_VERSION + &quot;/links/link/on-init&quot;;">`PATH_ON_LINK_INIT`</SwmToken> is used to store the path for initializing links.

```c#
        public static readonly string PATH_ON_LINK_INIT = "/" + CURRENT_VERSION + "/links/link/on-init";
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Common/Constants.cs" line="26">

---

The variable <SwmToken path="src/In.ProjectEKA.HipService/Common/Constants.cs" pos="26:9:9" line-data="        public static readonly string PATH_ON_LINK_CONFIRM = &quot;/&quot; + CURRENT_VERSION + &quot;/links/link/on-confirm&quot;;">`PATH_ON_LINK_CONFIRM`</SwmToken> is used to store the path for confirming links.

```c#
        public static readonly string PATH_ON_LINK_CONFIRM = "/" + CURRENT_VERSION + "/links/link/on-confirm";
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Common/Constants.cs" line="27">

---

The variable <SwmToken path="src/In.ProjectEKA.HipService/Common/Constants.cs" pos="27:9:9" line-data="        public static readonly string PATH_CONSENT_ON_NOTIFY = &quot;/&quot; + CURRENT_VERSION + &quot;/consents/hip/on-notify&quot;;">`PATH_CONSENT_ON_NOTIFY`</SwmToken> is used to store the path for notifying HIP consents.

```c#
        public static readonly string PATH_CONSENT_ON_NOTIFY = "/" + CURRENT_VERSION + "/consents/hip/on-notify";
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Common/Constants.cs" line="29">

---

The variable <SwmToken path="src/In.ProjectEKA.HipService/Common/Constants.cs" pos="29:9:9" line-data="        public static readonly string PATH_HEALTH_INFORMATION_ON_REQUEST = &quot;/&quot; + CURRENT_VERSION +">`PATH_HEALTH_INFORMATION_ON_REQUEST`</SwmToken> is used to store the path for HIP health information requests.

```c#
        public static readonly string PATH_HEALTH_INFORMATION_ON_REQUEST = "/" + CURRENT_VERSION +
                                                                           "/health-information/hip/on-request";
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Common/Constants.cs" line="32">

---

The variable <SwmToken path="src/In.ProjectEKA.HipService/Common/Constants.cs" pos="32:9:9" line-data="        public static readonly string PATH_HEALTH_INFORMATION_NOTIFY_GATEWAY = &quot;/&quot; + CURRENT_VERSION +">`PATH_HEALTH_INFORMATION_NOTIFY_GATEWAY`</SwmToken> is used to store the path for notifying health information to the gateway.

```c#
        public static readonly string PATH_HEALTH_INFORMATION_NOTIFY_GATEWAY = "/" + CURRENT_VERSION +
                                                                               "/health-information/notify";
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Common/Constants.cs" line="35">

---

The variable <SwmToken path="src/In.ProjectEKA.HipService/Common/Constants.cs" pos="35:9:9" line-data="        public static readonly string PATH_AUTH_CONFIRM = &quot;/&quot; + CURRENT_VERSION + &quot;/users/auth/confirm&quot;;">`PATH_AUTH_CONFIRM`</SwmToken> is used to store the path for confirming user authentication.

```c#
        public static readonly string PATH_AUTH_CONFIRM = "/" + CURRENT_VERSION + "/users/auth/confirm";
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Common/Constants.cs" line="37">

---

The variable <SwmToken path="src/In.ProjectEKA.HipService/Common/Constants.cs" pos="37:9:9" line-data="        public static readonly string PATH_OPENMRS_FHIR = &quot;ws/fhir2/R4/metadata&quot;;">`PATH_OPENMRS_FHIR`</SwmToken> is used to store the path for <SwmToken path="src/In.ProjectEKA.HipService/Startup.cs" pos="142:3:3" line-data="                        {&quot;OpenMRS-FHIR&quot;, Constants.PATH_OPENMRS_FHIR},">`OpenMRS`</SwmToken> FHIR metadata.

```c#
        public static readonly string PATH_OPENMRS_FHIR = "ws/fhir2/R4/metadata";
```

---

</SwmSnippet>

# Usage

## PatientControllerTest

## GatewayClientTest

In the `GatewayClientTest` class, <SwmToken path="src/In.ProjectEKA.HipService/Gateway/GatewayClient.cs" pos="52:18:18" line-data="                    RequestUri = new Uri($&quot;{configuration.Url}/{Constants.PATH_SESSIONS}&quot;),">`Constants`</SwmToken> is used to import static members, allowing for cleaner and more readable code when referencing constants.

## <SwmToken path="src/In.ProjectEKA.HipService/Gateway/GatewayClient.cs" pos="23:5:5" line-data="    public class GatewayClient: IGatewayClient">`GatewayClient`</SwmToken>

Similarly, in the `PatientControllerTest` class, <SwmToken path="src/In.ProjectEKA.HipService/Gateway/GatewayClient.cs" pos="52:18:18" line-data="                    RequestUri = new Uri($&quot;{configuration.Url}/{Constants.PATH_SESSIONS}&quot;),">`Constants`</SwmToken> is imported statically to facilitate the use of constant values without needing to reference the class name explicitly.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Gateway/GatewayClient.cs" line="49">

---

In the <SwmToken path="src/In.ProjectEKA.HipService/Gateway/GatewayClient.cs" pos="23:5:5" line-data="    public class GatewayClient: IGatewayClient">`GatewayClient`</SwmToken> class, <SwmToken path="src/In.ProjectEKA.HipService/Gateway/GatewayClient.cs" pos="52:18:18" line-data="                    RequestUri = new Uri($&quot;{configuration.Url}/{Constants.PATH_SESSIONS}&quot;),">`Constants`</SwmToken> is used to define paths and headers for HTTP requests, ensuring consistency and reducing the risk of errors from hardcoding strings.

```c#
                });
                var message = new HttpRequestMessage
                {
                    RequestUri = new Uri($"{configuration.Url}/{Constants.PATH_SESSIONS}"),
                    Method = HttpMethod.Post,
                    Content = new StringContent(json, Encoding.UTF8, MediaTypeNames.Application.Json)
                };
                if (correlationId != null)
                    message.Headers.Add(Constants.CORRELATION_ID, correlationId);
                var responseMessage = await httpClient.SendAsync(message).ConfigureAwait(false);
                var response = await responseMessage.Content.ReadAsStringAsync();
```

---

</SwmSnippet>

## <SwmToken path="test/In.ProjectEKA.HipServiceTest/Link/LinkPatientTest.cs" pos="28:5:5" line-data="    public class LinkPatientTest">`LinkPatientTest`</SwmToken>

## SmsNotificationControllerTest

The `SmsNotificationControllerTest` class also uses <SwmToken path="src/In.ProjectEKA.HipService/Gateway/GatewayClient.cs" pos="52:18:18" line-data="                    RequestUri = new Uri($&quot;{configuration.Url}/{Constants.PATH_SESSIONS}&quot;),">`Constants`</SwmToken> to import static members, streamlining the code and making it easier to manage constant values.

<SwmSnippet path="/test/In.ProjectEKA.HipServiceTest/Link/LinkPatientTest.cs" line="144">

---

In the <SwmToken path="test/In.ProjectEKA.HipServiceTest/Link/LinkPatientTest.cs" pos="28:5:5" line-data="    public class LinkPatientTest">`LinkPatientTest`</SwmToken> class, <SwmToken path="test/In.ProjectEKA.HipServiceTest/Link/LinkPatientTest.cs" pos="147:17:17" line-data="            var dateTimeStamp = DateTime.Now.ToUniversalTime().ToString(Constants.DateTimeFormat);">`Constants`</SwmToken> is used to format date-time strings, ensuring that the date-time values are consistently formatted throughout the tests.

```c#
        {
            var sessionId = TestBuilders.Faker().Random.Hash();
            var otpToken = TestBuilders.Faker().Random.Number().ToString();
            var dateTimeStamp = DateTime.Now.ToUniversalTime().ToString(Constants.DateTimeFormat);
            var testOtpMessage = new OtpMessage(ResponseType.OtpInvalid, "Invalid Otp");
```

---

</SwmSnippet>

## UserAuthControllerTest

## CareContextControllerTest

The `CareContextControllerTest` class imports <SwmToken path="src/In.ProjectEKA.HipService/Gateway/GatewayClient.cs" pos="52:18:18" line-data="                    RequestUri = new Uri($&quot;{configuration.Url}/{Constants.PATH_SESSIONS}&quot;),">`Constants`</SwmToken> statically to simplify the use of constant values in the test methods.

## <SwmToken path="test/In.ProjectEKA.HipServiceTest/Link/LinkPatientTest.cs" pos="81:7:7" line-data="                    , new OtpGenerationDetail(TestBuilder.Faker().Random.Word(), OtpAction.LINK_PATIENT_CARECONTEXT.ToString()))))">`TestBuilder`</SwmToken>

In the `UserAuthControllerTest` class, <SwmToken path="src/In.ProjectEKA.HipService/Gateway/GatewayClient.cs" pos="52:18:18" line-data="                    RequestUri = new Uri($&quot;{configuration.Url}/{Constants.PATH_SESSIONS}&quot;),">`Constants`</SwmToken> is used to import static members, making the code more concise and easier to read.

<SwmSnippet path="/test/In.ProjectEKA.HipServiceTest/DataFlow/Builder/TestBuilder.cs" line="97">

---

The <SwmToken path="test/In.ProjectEKA.HipServiceTest/Link/LinkPatientTest.cs" pos="81:7:7" line-data="                    , new OtpGenerationDetail(TestBuilder.Faker().Random.Word(), OtpAction.LINK_PATIENT_CARECONTEXT.ToString()))))">`TestBuilder`</SwmToken> class uses <SwmToken path="test/In.ProjectEKA.HipServiceTest/DataFlow/Builder/TestBuilder.cs" pos="100:16:16" line-data="            return new DataNotificationRequest(transactionId, DateTime.Now.ToString(Constants.DateTimeFormat), notifier, statusNotification, consentId, Guid.NewGuid());">`Constants`</SwmToken> to format date-time strings, ensuring consistency in date-time formatting across different parts of the code.

```c#
                SessionStatus.TRANSFERRED,
                "IN0410000183",
                new List<StatusResponse>());
            return new DataNotificationRequest(transactionId, DateTime.Now.ToString(Constants.DateTimeFormat), notifier, statusNotification, consentId, Guid.NewGuid());
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Startup.cs" line="139">

---

## Startup

In the <SwmToken path="src/In.ProjectEKA.HipService/Startup.cs" pos="54:5:5" line-data="    public class Startup">`Startup`</SwmToken> class, <SwmToken path="src/In.ProjectEKA.HipService/Startup.cs" pos="142:9:9" line-data="                        {&quot;OpenMRS-FHIR&quot;, Constants.PATH_OPENMRS_FHIR},">`Constants`</SwmToken> is used to define configuration keys and authentication schemes, promoting consistency and reducing the likelihood of errors from hardcoding strings.

```c#
                .AddSingleton(HttpClient)
                .AddScoped<IHealthCheckClient>(_ => new OpenMrsHealthCheckClient(new Dictionary<string, string>
                    {
                        {"OpenMRS-FHIR", Constants.PATH_OPENMRS_FHIR},
                        {"OpenMRS-REST", Constants.PATH_OPENMRS_REST}
                    },
                    new OpenMrsClient(HttpClient,
                        Configuration.GetSection(Constants.CONFIG_KEY).Get<OpenMrsConfiguration>())))
                .AddSingleton<IHealthCheckStatus, HealthCheckStatus>()
```

---

</SwmSnippet>

## <SwmToken path="src/In.ProjectEKA.HipService/Gateway/GatewayClient.cs" pos="11:7:7" line-data="    using static Common.HttpRequestHelper;">`HttpRequestHelper`</SwmToken>

## <SwmToken path="src/In.ProjectEKA.HipService/Startup.cs" pos="125:6:6" line-data="                .AddScoped&lt;IPatientNotificationService,PatientNotificationService&gt;()">`PatientNotificationService`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipService/Startup.cs" pos="125:6:6" line-data="                .AddScoped&lt;IPatientNotificationService,PatientNotificationService&gt;()">`PatientNotificationService`</SwmToken> class uses <SwmToken path="src/In.ProjectEKA.HipService/Gateway/GatewayClient.cs" pos="52:18:18" line-data="                    RequestUri = new Uri($&quot;{configuration.Url}/{Constants.PATH_SESSIONS}&quot;),">`Constants`</SwmToken> to define paths for HTTP requests, ensuring that the paths are consistent and easy to manage.

## <SwmToken path="src/In.ProjectEKA.HipService/Startup.cs" pos="109:4:4" line-data="                .AddDbContext&lt;PatientContext&gt;(options =&gt;">`PatientContext`</SwmToken>

In the <SwmToken path="src/In.ProjectEKA.HipService/Gateway/GatewayClient.cs" pos="11:7:7" line-data="    using static Common.HttpRequestHelper;">`HttpRequestHelper`</SwmToken> class, <SwmToken path="src/In.ProjectEKA.HipService/Gateway/GatewayClient.cs" pos="52:18:18" line-data="                    RequestUri = new Uri($&quot;{configuration.Url}/{Constants.PATH_SESSIONS}&quot;),">`Constants`</SwmToken> is imported statically to simplify the use of constant values in the helper methods.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Patient/Database/PatientContext.cs" line="22">

---

The <SwmToken path="src/In.ProjectEKA.HipService/Startup.cs" pos="109:4:4" line-data="                .AddDbContext&lt;PatientContext&gt;(options =&gt;">`PatientContext`</SwmToken> class uses <SwmToken path="src/In.ProjectEKA.HipService/Patient/Database/PatientContext.cs" pos="25:14:14" line-data="                    v =&gt; DateTime.Parse(v).ToString(Constants.DateTimeFormat),">`Constants`</SwmToken> to format date-time strings, ensuring that date-time values are consistently formatted when interacting with the database.

```c#
                builder.HasKey(p => p.RequestId);
                builder.Property(p => p.RequestId);
                builder.Property(p => p.DateTimeStamp).HasConversion(
                    v => DateTime.Parse(v).ToString(Constants.DateTimeFormat),
                    v => v);
                builder.Property(p => p.HipCode);
                builder.Property(p => p.Profile).HasConversion(
```

---

</SwmSnippet>

## VerificationController

## <SwmToken path="src/In.ProjectEKA.HipService/Startup.cs" pos="211:7:7" line-data="                .AddScheme&lt;CustomAuthenticationOptions, CustomAuthenticationHandler&gt;(Constants.BAHMNI_AUTH, options =&gt; { });">`CustomAuthenticationHandler`</SwmToken>

In the <SwmToken path="src/In.ProjectEKA.HipService/Startup.cs" pos="211:7:7" line-data="                .AddScheme&lt;CustomAuthenticationOptions, CustomAuthenticationHandler&gt;(Constants.BAHMNI_AUTH, options =&gt; { });">`CustomAuthenticationHandler`</SwmToken> class, <SwmToken path="src/In.ProjectEKA.HipService/Gateway/GatewayClient.cs" pos="52:18:18" line-data="                    RequestUri = new Uri($&quot;{configuration.Url}/{Constants.PATH_SESSIONS}&quot;),">`Constants`</SwmToken> is imported statically to facilitate the use of constant values in the authentication handler.

## <SwmToken path="src/In.ProjectEKA.HipService/Startup.cs" pos="129:6:6" line-data="                .AddScoped&lt;IPatientProfileService,PatientProfileService&gt;()">`PatientProfileService`</SwmToken>

The `VerificationController` class uses <SwmToken path="src/In.ProjectEKA.HipService/Gateway/GatewayClient.cs" pos="52:18:18" line-data="                    RequestUri = new Uri($&quot;{configuration.Url}/{Constants.PATH_SESSIONS}&quot;),">`Constants`</SwmToken> to define authentication schemes, ensuring that the schemes are consistent and easy to manage.

## PatientController

In the <SwmToken path="src/In.ProjectEKA.HipService/Startup.cs" pos="129:6:6" line-data="                .AddScoped&lt;IPatientProfileService,PatientProfileService&gt;()">`PatientProfileService`</SwmToken> class, <SwmToken path="src/In.ProjectEKA.HipService/Gateway/GatewayClient.cs" pos="52:18:18" line-data="                    RequestUri = new Uri($&quot;{configuration.Url}/{Constants.PATH_SESSIONS}&quot;),">`Constants`</SwmToken> is imported statically to simplify the use of constant values in the service methods.

## ConsentNotificationController

The `PatientController` class uses <SwmToken path="src/In.ProjectEKA.HipService/Gateway/GatewayClient.cs" pos="52:18:18" line-data="                    RequestUri = new Uri($&quot;{configuration.Url}/{Constants.PATH_SESSIONS}&quot;),">`Constants`</SwmToken> to import static members, making the code more concise and easier to read.

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
