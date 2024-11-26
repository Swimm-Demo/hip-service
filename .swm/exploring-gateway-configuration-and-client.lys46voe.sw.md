---
title: Exploring Gateway Configuration and Client
---
## Overview

The Gateway in the HIP service handles communication with external services. It consists of two main components: <SwmToken path="src/In.ProjectEKA.HipService/Gateway/GatewayConfiguration.cs" pos="3:5:5" line-data="    public class GatewayConfiguration">`GatewayConfiguration`</SwmToken> and <SwmToken path="src/In.ProjectEKA.HipService/Gateway/GatewayClient.cs" pos="23:5:5" line-data="    public class GatewayClient: IGatewayClient">`GatewayClient`</SwmToken>. The <SwmToken path="src/In.ProjectEKA.HipService/Gateway/GatewayConfiguration.cs" pos="3:5:5" line-data="    public class GatewayConfiguration">`GatewayConfiguration`</SwmToken> class is used to configure the gateway settings, while the <SwmToken path="src/In.ProjectEKA.HipService/Gateway/GatewayClient.cs" pos="23:5:5" line-data="    public class GatewayClient: IGatewayClient">`GatewayClient`</SwmToken> class is responsible for making HTTP requests to the configured gateway URL.

## Gateway Configuration

The <SwmToken path="src/In.ProjectEKA.HipService/Gateway/GatewayConfiguration.cs" pos="3:5:5" line-data="    public class GatewayConfiguration">`GatewayConfiguration`</SwmToken> class includes properties such as <SwmToken path="src/In.ProjectEKA.HipService/Gateway/GatewayConfiguration.cs" pos="5:5:5" line-data="        public string Url { get; set; }">`Url`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/Gateway/GatewayConfiguration.cs" pos="7:5:5" line-data="        public int TimeOut { get; set; }">`TimeOut`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/Gateway/GatewayConfiguration.cs" pos="20:5:5" line-data="        public string BenefitName { get; set; }">`BenefitName`</SwmToken>, and <SwmToken path="src/In.ProjectEKA.HipService/Gateway/GatewayConfiguration.cs" pos="10:5:5" line-data="        public string ClientId { get; set; }">`ClientId`</SwmToken> to configure the gateway settings.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Gateway/GatewayConfiguration.cs" line="3">

---

The <SwmToken path="src/In.ProjectEKA.HipService/Gateway/GatewayConfiguration.cs" pos="3:5:5" line-data="    public class GatewayConfiguration">`GatewayConfiguration`</SwmToken> class defines various properties required for configuring the gateway settings.

```c#
    public class GatewayConfiguration
    {
        public string Url { get; set; }
        
        public int TimeOut { get; set; }
        
        public int Counter { get; set; }
        public string ClientId { get; set; }

        public string ClientSecret { get; set; }

        public string CmSuffix { get; set; }
        
        public string AbhaNumberServiceUrl { get; set; }
        
        public string AbhaAddressServiceUrl { get; set; }
        
        public string BenefitName { get; set; }
    }
```

---

</SwmSnippet>

## Gateway Client

The <SwmToken path="src/In.ProjectEKA.HipService/Gateway/GatewayClient.cs" pos="23:5:5" line-data="    public class GatewayClient: IGatewayClient">`GatewayClient`</SwmToken> class is responsible for making HTTP requests to the configured gateway URL. It uses the <SwmToken path="src/In.ProjectEKA.HipService/Gateway/GatewayConfiguration.cs" pos="3:5:5" line-data="    public class GatewayConfiguration">`GatewayConfiguration`</SwmToken> to get the necessary settings for these requests.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Gateway/GatewayClient.cs" line="23">

---

The <SwmToken path="src/In.ProjectEKA.HipService/Gateway/GatewayClient.cs" pos="23:5:5" line-data="    public class GatewayClient: IGatewayClient">`GatewayClient`</SwmToken> class initializes with <SwmToken path="src/In.ProjectEKA.HipService/Gateway/GatewayClient.cs" pos="26:5:5" line-data="        private readonly HttpClient httpClient;">`HttpClient`</SwmToken> and <SwmToken path="src/In.ProjectEKA.HipService/Gateway/GatewayClient.cs" pos="25:5:5" line-data="        private readonly GatewayConfiguration configuration;">`GatewayConfiguration`</SwmToken> to make HTTP requests.

```c#
    public class GatewayClient: IGatewayClient
    {
        private readonly GatewayConfiguration configuration;
        private readonly HttpClient httpClient;

        public GatewayClient(HttpClient httpClient, GatewayConfiguration gatewayConfiguration)
        {
            this.httpClient = httpClient;
            configuration = gatewayConfiguration;
        }
```

---

</SwmSnippet>

## Usage in Various Components

The <SwmToken path="src/In.ProjectEKA.HipService/Gateway/GatewayConfiguration.cs" pos="3:5:5" line-data="    public class GatewayConfiguration">`GatewayConfiguration`</SwmToken> and <SwmToken path="src/In.ProjectEKA.HipService/Gateway/GatewayClient.cs" pos="23:5:5" line-data="    public class GatewayClient: IGatewayClient">`GatewayClient`</SwmToken> are used across various components in the HIP service for different operations such as authentication, data flow, SMS notifications, and more.

### <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthService.cs" pos="22:5:5" line-data="    public class UserAuthService : IUserAuthService">`UserAuthService`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipService/Gateway/GatewayConfiguration.cs" pos="3:5:5" line-data="    public class GatewayConfiguration">`GatewayConfiguration`</SwmToken> is used in the <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthService.cs" pos="22:5:5" line-data="    public class UserAuthService : IUserAuthService">`UserAuthService`</SwmToken> class for authentication initialization and confirmation.

<SwmSnippet path="/src/In.ProjectEKA.HipService/UserAuth/UserAuthService.cs" line="61">

---

The <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthService.cs" pos="61:10:10" line-data="        public async Task&lt;ErrorRepresentation&gt; AuthInit(AuthInitRequest authInitRequest,string correlationId,BahmniConfiguration bahmniConfiguration,GatewayConfiguration gatewayConfiguration)">`AuthInit`</SwmToken> method in <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthService.cs" pos="22:5:5" line-data="    public class UserAuthService : IUserAuthService">`UserAuthService`</SwmToken> uses <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthService.cs" pos="61:24:24" line-data="        public async Task&lt;ErrorRepresentation&gt; AuthInit(AuthInitRequest authInitRequest,string correlationId,BahmniConfiguration bahmniConfiguration,GatewayConfiguration gatewayConfiguration)">`GatewayConfiguration`</SwmToken> for authentication initialization.

```c#
        public async Task<ErrorRepresentation> AuthInit(AuthInitRequest authInitRequest,string correlationId,BahmniConfiguration bahmniConfiguration,GatewayConfiguration gatewayConfiguration)
        {
            var (gatewayAuthInitRequestRepresentation, error) = AuthInitResponse(authInitRequest, bahmniConfiguration);
            if (error != null)
                return error;
            Guid requestId = gatewayAuthInitRequestRepresentation.requestId;
            var cmSuffix = gatewayConfiguration.CmSuffix;

            try
            {
                logger.Log(LogLevel.Information,
                    LogEvents.UserAuth,
                    "Request for auth-init to gateway: {@GatewayResponse}",
                    gatewayAuthInitRequestRepresentation.dump(gatewayAuthInitRequestRepresentation));
                logger.Log(LogLevel.Information, LogEvents.UserAuth, $"cmSuffix: {{cmSuffix}}," +
                                                                     $" correlationId: {{correlationId}}, " +
                                                                     $"healthId: {{healthId}}, requestId: {{requestId}}",
                    cmSuffix, correlationId, gatewayAuthInitRequestRepresentation.query.id, requestId);
                await gatewayClient.SendDataToGateway(PATH_AUTH_INIT, gatewayAuthInitRequestRepresentation, cmSuffix,
                    correlationId);
                var i = 0;
```

---

</SwmSnippet>

### <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/DataFlowController.cs" pos="18:5:5" line-data="    public class DataFlowController : ControllerBase">`DataFlowController`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipService/Gateway/GatewayConfiguration.cs" pos="3:5:5" line-data="    public class GatewayConfiguration">`GatewayConfiguration`</SwmToken> is used in the <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/DataFlowController.cs" pos="18:5:5" line-data="    public class DataFlowController : ControllerBase">`DataFlowController`</SwmToken> class for handling data flow operations.

<SwmSnippet path="/src/In.ProjectEKA.HipService/DataFlow/DataFlowController.cs" line="76">

---

The <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/DataFlowController.cs" pos="18:5:5" line-data="    public class DataFlowController : ControllerBase">`DataFlowController`</SwmToken> class uses <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/DataFlowController.cs" pos="77:1:1" line-data="            GatewayConfiguration gatewayConfiguration">`GatewayConfiguration`</SwmToken> for data flow operations.

```c#
            ILogger<PatientDataFlowController> logger,
            GatewayConfiguration gatewayConfiguration
        )
```

---

</SwmSnippet>

### <SwmToken path="src/In.ProjectEKA.HipService/SmsNotification/SmsNotificationController.cs" pos="21:5:5" line-data="    public class SmsNotificationController : Controller">`SmsNotificationController`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipService/Gateway/GatewayConfiguration.cs" pos="3:5:5" line-data="    public class GatewayConfiguration">`GatewayConfiguration`</SwmToken> is used in the <SwmToken path="src/In.ProjectEKA.HipService/SmsNotification/SmsNotificationController.cs" pos="21:5:5" line-data="    public class SmsNotificationController : Controller">`SmsNotificationController`</SwmToken> class for handling SMS notifications.

<SwmSnippet path="/src/In.ProjectEKA.HipService/SmsNotification/SmsNotificationController.cs" line="34">

---

The <SwmToken path="src/In.ProjectEKA.HipService/SmsNotification/SmsNotificationController.cs" pos="21:5:5" line-data="    public class SmsNotificationController : Controller">`SmsNotificationController`</SwmToken> class uses <SwmToken path="src/In.ProjectEKA.HipService/SmsNotification/SmsNotificationController.cs" pos="35:1:1" line-data="            GatewayConfiguration gatewayConfiguration,">`GatewayConfiguration`</SwmToken> for SMS notifications.

```c#
            BahmniConfiguration bahmniConfiguration,
            GatewayConfiguration gatewayConfiguration,
            HttpClient httpClient,
```

---

</SwmSnippet>

### <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthService.cs" pos="25:7:7" line-data="        private readonly ILogger&lt;UserAuthController&gt; logger;">`UserAuthController`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipService/Gateway/GatewayConfiguration.cs" pos="3:5:5" line-data="    public class GatewayConfiguration">`GatewayConfiguration`</SwmToken> is used in the <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthService.cs" pos="25:7:7" line-data="        private readonly ILogger&lt;UserAuthController&gt; logger;">`UserAuthController`</SwmToken> class for user authentication operations.

<SwmSnippet path="/src/In.ProjectEKA.HipService/UserAuth/UserAuthController.cs" line="41">

---

The <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthService.cs" pos="25:7:7" line-data="        private readonly ILogger&lt;UserAuthController&gt; logger;">`UserAuthController`</SwmToken> class uses <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthController.cs" pos="42:1:1" line-data="            GatewayConfiguration gatewayConfiguration,">`GatewayConfiguration`</SwmToken> for user authentication operations.

```c#
            BahmniConfiguration bahmniConfiguration,
            GatewayConfiguration gatewayConfiguration,
            HttpClient httpClient,
```

---

</SwmSnippet>

### <SwmToken path="src/In.ProjectEKA.HipService/Verification/VerificationController.cs" pos="34:3:3" line-data="        public VerificationController(IGatewayClient gatewayClient,">`VerificationController`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipService/Gateway/GatewayConfiguration.cs" pos="3:5:5" line-data="    public class GatewayConfiguration">`GatewayConfiguration`</SwmToken> is used in the <SwmToken path="src/In.ProjectEKA.HipService/Verification/VerificationController.cs" pos="34:3:3" line-data="        public VerificationController(IGatewayClient gatewayClient,">`VerificationController`</SwmToken> class for verification operations.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Verification/VerificationController.cs" line="29">

---

The <SwmToken path="src/In.ProjectEKA.HipService/Verification/VerificationController.cs" pos="34:3:3" line-data="        public VerificationController(IGatewayClient gatewayClient,">`VerificationController`</SwmToken> class uses <SwmToken path="src/In.ProjectEKA.HipService/Verification/VerificationController.cs" pos="30:5:5" line-data="        private readonly GatewayConfiguration gatewayConfiguration;">`GatewayConfiguration`</SwmToken> for verification operations.

```c#
        private readonly OpenMrsConfiguration openMrsConfiguration;
        private readonly GatewayConfiguration gatewayConfiguration;
        private readonly IAbhaService abhaService;
        public static string public_key;

        public VerificationController(IGatewayClient gatewayClient,
            ILogger<VerificationController> logger,
            HttpClient httpClient,
            OpenMrsConfiguration openMrsConfiguration, GatewayConfiguration gatewayConfiguration, IAbhaService abhaService)
        {
```

---

</SwmSnippet>

### <SwmToken path="src/In.ProjectEKA.HipService/Creation/CreationController.cs" pos="24:7:7" line-data="        private readonly ILogger&lt;CreationController&gt; logger;">`CreationController`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipService/Gateway/GatewayConfiguration.cs" pos="3:5:5" line-data="    public class GatewayConfiguration">`GatewayConfiguration`</SwmToken> is used in the <SwmToken path="src/In.ProjectEKA.HipService/Creation/CreationController.cs" pos="24:7:7" line-data="        private readonly ILogger&lt;CreationController&gt; logger;">`CreationController`</SwmToken> class for creation operations.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Creation/CreationController.cs" line="26">

---

The <SwmToken path="src/In.ProjectEKA.HipService/Creation/CreationController.cs" pos="31:3:3" line-data="        public CreationController(IGatewayClient gatewayClient,">`CreationController`</SwmToken> class uses <SwmToken path="src/In.ProjectEKA.HipService/Creation/CreationController.cs" pos="27:5:5" line-data="        private readonly GatewayConfiguration gatewayConfiguration;">`GatewayConfiguration`</SwmToken> for creation operations.

```c#
        private readonly OpenMrsConfiguration openMrsConfiguration;
        private readonly GatewayConfiguration gatewayConfiguration;
        private readonly IAbhaService abhaService;
        public static string public_key;

        public CreationController(IGatewayClient gatewayClient,
            ILogger<CreationController> logger,
            HttpClient httpClient,
            OpenMrsConfiguration openMrsConfiguration, GatewayConfiguration gatewayConfiguration, IAbhaService abhaService)
        {
```

---

</SwmSnippet>

### LinkPhrController

The <SwmToken path="src/In.ProjectEKA.HipService/Gateway/GatewayConfiguration.cs" pos="3:5:5" line-data="    public class GatewayConfiguration">`GatewayConfiguration`</SwmToken> is used in the `LinkPhrController` class for linking PHR operations.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Creation/LinkPhrController.cs" line="33">

---

The `LinkPhrController` class uses <SwmToken path="src/In.ProjectEKA.HipService/Creation/LinkPhrController.cs" pos="34:6:6" line-data="            OpenMrsConfiguration openMrsConfiguration, GatewayConfiguration gatewayConfiguration)">`GatewayConfiguration`</SwmToken> for linking PHR operations.

```c#
            HttpClient httpClient,
            OpenMrsConfiguration openMrsConfiguration, GatewayConfiguration gatewayConfiguration)
        {
```

---

</SwmSnippet>

### <SwmToken path="src/In.ProjectEKA.HipService/Creation/AbhaService.cs" pos="23:7:7" line-data="        private readonly ILogger&lt;AbhaService&gt; logger;">`AbhaService`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipService/Gateway/GatewayConfiguration.cs" pos="3:5:5" line-data="    public class GatewayConfiguration">`GatewayConfiguration`</SwmToken> is used in the <SwmToken path="src/In.ProjectEKA.HipService/Creation/AbhaService.cs" pos="23:7:7" line-data="        private readonly ILogger&lt;AbhaService&gt; logger;">`AbhaService`</SwmToken> class for ABHA service operations.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Creation/AbhaService.cs" line="23">

---

The <SwmToken path="src/In.ProjectEKA.HipService/Creation/AbhaService.cs" pos="23:7:7" line-data="        private readonly ILogger&lt;AbhaService&gt; logger;">`AbhaService`</SwmToken> class uses <SwmToken path="src/In.ProjectEKA.HipService/Creation/AbhaService.cs" pos="24:5:5" line-data="        private readonly GatewayConfiguration gatewayConfiguration;">`GatewayConfiguration`</SwmToken> for ABHA service operations.

```c#
        private readonly ILogger<AbhaService> logger;
        private readonly GatewayConfiguration gatewayConfiguration;
        private readonly IOpenMrsClient openMrsClient;

        public AbhaService(IGatewayClient gatewayClient,
            ILogger<AbhaService> logger,
            GatewayConfiguration gatewayConfiguration, IOpenMrsClient openMrsClient)
        {
```

---

</SwmSnippet>

### <SwmToken path="src/In.ProjectEKA.HipService/Link/CareContextController.cs" pos="27:3:3" line-data="            ILogger&lt;CareContextController&gt; logger,">`CareContextController`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipService/Gateway/GatewayConfiguration.cs" pos="3:5:5" line-data="    public class GatewayConfiguration">`GatewayConfiguration`</SwmToken> is used in the <SwmToken path="src/In.ProjectEKA.HipService/Link/CareContextController.cs" pos="27:3:3" line-data="            ILogger&lt;CareContextController&gt; logger,">`CareContextController`</SwmToken> class for care context operations.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/CareContextController.cs" line="27">

---

The <SwmToken path="src/In.ProjectEKA.HipService/Link/CareContextController.cs" pos="27:3:3" line-data="            ILogger&lt;CareContextController&gt; logger,">`CareContextController`</SwmToken> class uses <SwmToken path="src/In.ProjectEKA.HipService/Link/CareContextController.cs" pos="28:1:1" line-data="            GatewayConfiguration gatewayConfiguration,">`GatewayConfiguration`</SwmToken> for care context operations.

```c#
            ILogger<CareContextController> logger,
            GatewayConfiguration gatewayConfiguration,
            ICareContextService careContextService,
```

---

</SwmSnippet>

### <SwmToken path="src/In.ProjectEKA.HipService/Patient/PatientController.cs" pos="22:3:3" line-data="        public PatientController(GatewayClient gatewayClient, IPatientNotificationService patientNotificationService,">`PatientController`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipService/Gateway/GatewayConfiguration.cs" pos="3:5:5" line-data="    public class GatewayConfiguration">`GatewayConfiguration`</SwmToken> is used in the <SwmToken path="src/In.ProjectEKA.HipService/Patient/PatientController.cs" pos="22:3:3" line-data="        public PatientController(GatewayClient gatewayClient, IPatientNotificationService patientNotificationService,">`PatientController`</SwmToken> class for patient operations.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Patient/PatientController.cs" line="17">

---

The <SwmToken path="src/In.ProjectEKA.HipService/Patient/PatientController.cs" pos="22:3:3" line-data="        public PatientController(GatewayClient gatewayClient, IPatientNotificationService patientNotificationService,">`PatientController`</SwmToken> class uses <SwmToken path="src/In.ProjectEKA.HipService/Patient/PatientController.cs" pos="18:5:5" line-data="        private readonly GatewayConfiguration _gatewayConfiguration;">`GatewayConfiguration`</SwmToken> for patient operations.

```c#
        private readonly IPatientNotificationService _patientNotificationService;
        private readonly GatewayConfiguration _gatewayConfiguration;
        private readonly IPatientProfileService _patientProfileService;


        public PatientController(GatewayClient gatewayClient, IPatientNotificationService patientNotificationService,
            GatewayConfiguration gatewayConfiguration, IPatientProfileService patientProfileService)
```

---

</SwmSnippet>

### Startup

The <SwmToken path="src/In.ProjectEKA.HipService/Gateway/GatewayConfiguration.cs" pos="3:5:5" line-data="    public class GatewayConfiguration">`GatewayConfiguration`</SwmToken> is registered in the <SwmToken path="src/In.ProjectEKA.HipService/Startup.cs" pos="54:5:5" line-data="    public class Startup">`Startup`</SwmToken> class for dependency injection.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Startup.cs" line="153">

---

The <SwmToken path="src/In.ProjectEKA.HipService/Startup.cs" pos="54:5:5" line-data="    public class Startup">`Startup`</SwmToken> class registers <SwmToken path="src/In.ProjectEKA.HipService/Startup.cs" pos="154:15:15" line-data="                .AddSingleton(Configuration.GetSection(&quot;Gateway&quot;).Get&lt;GatewayConfiguration&gt;())">`GatewayConfiguration`</SwmToken> for dependency injection.

```c#
                .AddScoped<IHealthInformationRepository, HealthInformationRepository>()
                .AddSingleton(Configuration.GetSection("Gateway").Get<GatewayConfiguration>())
                .AddSingleton(Configuration.GetSection("Bahmni").Get<BahmniConfiguration>())
                .AddSingleton(Configuration.GetSection("Cors").Get<CorsConfiguration>())
                .AddSingleton(new GatewayClient(HttpClient,
                    Configuration.GetSection("Gateway").Get<GatewayConfiguration>()))
                .AddScoped<IGatewayClient, GatewayClient>()
```

---

</SwmSnippet>

### <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/DataFlowNotificationClient.cs" pos="16:3:3" line-data="        public DataFlowNotificationClient(GatewayClient gatewayClient)">`DataFlowNotificationClient`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipService/Gateway/GatewayClient.cs" pos="23:5:5" line-data="    public class GatewayClient: IGatewayClient">`GatewayClient`</SwmToken> is used in the <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/DataFlowNotificationClient.cs" pos="16:3:3" line-data="        public DataFlowNotificationClient(GatewayClient gatewayClient)">`DataFlowNotificationClient`</SwmToken> class for data flow notifications.

<SwmSnippet path="/src/In.ProjectEKA.HipService/DataFlow/DataFlowNotificationClient.cs" line="13">

---

The <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/DataFlowNotificationClient.cs" pos="16:3:3" line-data="        public DataFlowNotificationClient(GatewayClient gatewayClient)">`DataFlowNotificationClient`</SwmToken> class uses <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/DataFlowNotificationClient.cs" pos="14:5:5" line-data="        private readonly GatewayClient gatewayClient;">`GatewayClient`</SwmToken> for data flow notifications.

```c#
    {
        private readonly GatewayClient gatewayClient;

        public DataFlowNotificationClient(GatewayClient gatewayClient)
        {
```

---

</SwmSnippet>

### <SwmToken path="src/In.ProjectEKA.HipService/Creation/LinkPhrController.cs" pos="21:5:5" line-data="    public class LinkController : Controller">`LinkController`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipService/Gateway/GatewayClient.cs" pos="23:5:5" line-data="    public class GatewayClient: IGatewayClient">`GatewayClient`</SwmToken> is used in the <SwmToken path="src/In.ProjectEKA.HipService/Creation/LinkPhrController.cs" pos="21:5:5" line-data="    public class LinkController : Controller">`LinkController`</SwmToken> class for linking operations.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/LinkController.cs" line="33">

---

The <SwmToken path="src/In.ProjectEKA.HipService/Creation/LinkPhrController.cs" pos="21:5:5" line-data="    public class LinkController : Controller">`LinkController`</SwmToken> class uses <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkController.cs" pos="34:6:6" line-data="            LinkPatient linkPatient, GatewayClient gatewayClient)">`GatewayClient`</SwmToken> for linking operations.

```c#
            IBackgroundJobClient backgroundJob,
            LinkPatient linkPatient, GatewayClient gatewayClient)
        {
```

---

</SwmSnippet>

### <SwmToken path="src/In.ProjectEKA.HipService/Consent/ConsentNotificationController.cs" pos="25:3:3" line-data="        public ConsentNotificationController(">`ConsentNotificationController`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipService/Gateway/GatewayClient.cs" pos="23:5:5" line-data="    public class GatewayClient: IGatewayClient">`GatewayClient`</SwmToken> is used in the <SwmToken path="src/In.ProjectEKA.HipService/Consent/ConsentNotificationController.cs" pos="25:3:3" line-data="        public ConsentNotificationController(">`ConsentNotificationController`</SwmToken> class for consent notifications.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Consent/ConsentNotificationController.cs" line="22">

---

The <SwmToken path="src/In.ProjectEKA.HipService/Consent/ConsentNotificationController.cs" pos="25:3:3" line-data="        public ConsentNotificationController(">`ConsentNotificationController`</SwmToken> class uses <SwmToken path="src/In.ProjectEKA.HipService/Consent/ConsentNotificationController.cs" pos="23:5:5" line-data="        private readonly GatewayClient gatewayClient;">`GatewayClient`</SwmToken> for consent notifications.

```c#
        private readonly IConsentRepository consentRepository;
        private readonly GatewayClient gatewayClient;

        public ConsentNotificationController(
            IConsentRepository consentRepository,
            IBackgroundJobClient backgroundJob,
            GatewayClient gatewayClient)
        {
```

---

</SwmSnippet>

### <SwmToken path="src/In.ProjectEKA.HipService/Patient/PatientController.cs" pos="22:3:3" line-data="        public PatientController(GatewayClient gatewayClient, IPatientNotificationService patientNotificationService,">`PatientController`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipService/Gateway/GatewayClient.cs" pos="23:5:5" line-data="    public class GatewayClient: IGatewayClient">`GatewayClient`</SwmToken> is used in the <SwmToken path="src/In.ProjectEKA.HipService/Patient/PatientController.cs" pos="22:3:3" line-data="        public PatientController(GatewayClient gatewayClient, IPatientNotificationService patientNotificationService,">`PatientController`</SwmToken> class for patient operations.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Patient/PatientController.cs" line="15">

---

The <SwmToken path="src/In.ProjectEKA.HipService/Patient/PatientController.cs" pos="22:3:3" line-data="        public PatientController(GatewayClient gatewayClient, IPatientNotificationService patientNotificationService,">`PatientController`</SwmToken> class uses <SwmToken path="src/In.ProjectEKA.HipService/Patient/PatientController.cs" pos="16:5:5" line-data="        private readonly GatewayClient _gatewayClient;">`GatewayClient`</SwmToken> for patient operations.

```c#
    {
        private readonly GatewayClient _gatewayClient;
        private readonly IPatientNotificationService _patientNotificationService;
        private readonly GatewayConfiguration _gatewayConfiguration;
        private readonly IPatientProfileService _patientProfileService;


        public PatientController(GatewayClient gatewayClient, IPatientNotificationService patientNotificationService,
            GatewayConfiguration gatewayConfiguration, IPatientProfileService patientProfileService)
```

---

</SwmSnippet>

### <SwmToken path="src/In.ProjectEKA.HipService/Creation/CreationController.cs" pos="24:7:7" line-data="        private readonly ILogger&lt;CreationController&gt; logger;">`CreationController`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipService/Gateway/GatewayClient.cs" pos="23:8:8" line-data="    public class GatewayClient: IGatewayClient">`IGatewayClient`</SwmToken> is used in the <SwmToken path="src/In.ProjectEKA.HipService/Creation/CreationController.cs" pos="24:7:7" line-data="        private readonly ILogger&lt;CreationController&gt; logger;">`CreationController`</SwmToken> class for creation operations.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Creation/CreationController.cs" line="22">

---

The <SwmToken path="src/In.ProjectEKA.HipService/Creation/CreationController.cs" pos="24:7:7" line-data="        private readonly ILogger&lt;CreationController&gt; logger;">`CreationController`</SwmToken> class uses <SwmToken path="src/In.ProjectEKA.HipService/Creation/CreationController.cs" pos="23:5:5" line-data="        private readonly IGatewayClient gatewayClient;">`IGatewayClient`</SwmToken> for creation operations.

```c#
    {
        private readonly IGatewayClient gatewayClient;
        private readonly ILogger<CreationController> logger;
        private readonly HttpClient httpClient;
        private readonly OpenMrsConfiguration openMrsConfiguration;
        private readonly GatewayConfiguration gatewayConfiguration;
        private readonly IAbhaService abhaService;
        public static string public_key;

        public CreationController(IGatewayClient gatewayClient,
            ILogger<CreationController> logger,
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
