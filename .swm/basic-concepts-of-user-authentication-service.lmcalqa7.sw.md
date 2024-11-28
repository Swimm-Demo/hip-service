---
title: Basic Concepts of User Authentication Service
---
# Overview of User Authentication Service

The <SwmToken path="src/In.ProjectEKA.HipService/Startup.cs" pos="124:6:6" line-data="                .AddScoped&lt;IUserAuthService,UserAuthService&gt;()">`UserAuthService`</SwmToken> class is responsible for handling user authentication processes. It interacts with the <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthService.cs" pos="24:5:5" line-data="        private readonly IUserAuthRepository userAuthRepository;">`IUserAuthRepository`</SwmToken> to manage user authentication data and logs relevant information using the <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthService.cs" pos="25:5:8" line-data="        private readonly ILogger&lt;UserAuthController&gt; logger;">`ILogger<UserAuthController>`</SwmToken>.

# Key Methods

The service also communicates with the <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthService.cs" pos="26:5:5" line-data="        private readonly IGatewayClient gatewayClient;">`IGatewayClient`</SwmToken> to send and receive data from the gateway, ensuring that authentication requests are processed correctly.

## <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthService.cs" pos="61:10:10" line-data="        public async Task&lt;ErrorRepresentation&gt; AuthInit(AuthInitRequest authInitRequest,string correlationId,BahmniConfiguration bahmniConfiguration,GatewayConfiguration gatewayConfiguration)">`AuthInit`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipService/Startup.cs" pos="124:6:6" line-data="                .AddScoped&lt;IUserAuthService,UserAuthService&gt;()">`UserAuthService`</SwmToken> includes several key methods that facilitate the authentication process.

<SwmSnippet path="/src/In.ProjectEKA.HipService/UserAuth/UserAuthService.cs" line="61">

---

The <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthService.cs" pos="61:10:10" line-data="        public async Task&lt;ErrorRepresentation&gt; AuthInit(AuthInitRequest authInitRequest,string correlationId,BahmniConfiguration bahmniConfiguration,GatewayConfiguration gatewayConfiguration)">`AuthInit`</SwmToken> method initializes the authentication process by sending a request to the gateway and handling the response. This method logs the request details and waits for the gateway's response, updating the authentication status accordingly.

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

## <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthService.cs" pos="178:15:15" line-data="         public async Task&lt;Tuple&lt;AuthConfirmResponse, ErrorRepresentation&gt;&gt; AuthConfirm(AuthConfirmRequest authConfirmRequest,string correlationId,GatewayConfiguration gatewayConfiguration)">`AuthConfirm`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthService.cs" pos="178:15:15" line-data="         public async Task&lt;Tuple&lt;AuthConfirmResponse, ErrorRepresentation&gt;&gt; AuthConfirm(AuthConfirmRequest authConfirmRequest,string correlationId,GatewayConfiguration gatewayConfiguration)">`AuthConfirm`</SwmToken> method confirms the authentication by verifying the provided credentials and updating the authentication status. This method ensures that the user's credentials are correctly validated and the authentication status is updated accordingly.

## <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthService.cs" pos="121:11:11" line-data="        public Tuple&lt;AuthConfirmPatient, ErrorRepresentation&gt; GetPatientDetailsForDirectAuth(">`GetPatientDetailsForDirectAuth`</SwmToken>

## <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthService.cs" pos="38:11:11" line-data="        public Tuple&lt;GatewayFetchModesRequestRepresentation, ErrorRepresentation&gt; FetchModeResponse(">`FetchModeResponse`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthService.cs" pos="38:11:11" line-data="        public Tuple&lt;GatewayFetchModesRequestRepresentation, ErrorRepresentation&gt; FetchModeResponse(">`FetchModeResponse`</SwmToken> method is used to fetch authentication modes available for the user.

# Usage Example

The <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthService.cs" pos="121:11:11" line-data="        public Tuple&lt;AuthConfirmPatient, ErrorRepresentation&gt; GetPatientDetailsForDirectAuth(">`GetPatientDetailsForDirectAuth`</SwmToken> method retrieves patient details directly for authentication purposes.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Startup.cs" line="123">

---

The <SwmToken path="src/In.ProjectEKA.HipService/Startup.cs" pos="124:6:6" line-data="                .AddScoped&lt;IUserAuthService,UserAuthService&gt;()">`UserAuthService`</SwmToken> is used in <SwmPath>[src/In.ProjectEKA.HipService/Startup.cs](src/In.ProjectEKA.HipService/Startup.cs)</SwmPath> to initialize and configure the authentication service.

```c#
                .AddScoped<IPatientDiscovery, PatientDiscovery>()
                .AddScoped<IUserAuthService,UserAuthService>()
                .AddScoped<IPatientNotificationService,PatientNotificationService>()
                .AddScoped<ICareContextService,CareContextService>()
                .AddScoped<ISmsNotificationService,SmsNotificationService>()
                .AddScoped<IUserAuthService, UserAuthService>()
                .AddScoped<IPatientProfileService,PatientProfileService>()
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
