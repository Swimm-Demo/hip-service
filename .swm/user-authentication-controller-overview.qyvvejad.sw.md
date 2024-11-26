---
title: User Authentication Controller Overview
---
## Main Functions

# Overview

The <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthController.cs" pos="31:7:7" line-data="        private readonly ILogger&lt;UserAuthController&gt; logger;">`UserAuthController`</SwmToken> is responsible for handling user authentication-related requests. It interacts with various services and configurations such as <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthController.cs" pos="30:5:5" line-data="        private readonly IGatewayClient gatewayClient;">`IGatewayClient`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthController.cs" pos="31:5:5" line-data="        private readonly ILogger&lt;UserAuthController&gt; logger;">`ILogger`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthController.cs" pos="32:5:5" line-data="        private readonly BahmniConfiguration bahmniConfiguration;">`BahmniConfiguration`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthController.cs" pos="33:5:5" line-data="        private readonly IUserAuthService userAuthService;">`IUserAuthService`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthController.cs" pos="34:5:5" line-data="        private readonly GatewayConfiguration gatewayConfiguration;">`GatewayConfiguration`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthController.cs" pos="35:5:5" line-data="        private readonly HttpClient httpClient;">`HttpClient`</SwmToken>, and <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthController.cs" pos="36:5:5" line-data="        private readonly OpenMrsConfiguration openMrsConfiguration;">`OpenMrsConfiguration`</SwmToken>.

### Fetching Authentication Modes

The controller includes methods for fetching authentication modes, initializing authentication, confirming authentication, and handling demographic details. It uses the <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthController.cs" pos="33:7:7" line-data="        private readonly IUserAuthService userAuthService;">`userAuthService`</SwmToken> to process requests and communicate with the gateway for authentication purposes.

<SwmSnippet path="/src/In.ProjectEKA.HipService/UserAuth/UserAuthController.cs" line="57">

---

The <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthController.cs" pos="57:10:10" line-data="        public async Task&lt;ActionResult&gt; GetAuthModes(">`GetAuthModes`</SwmToken> function is responsible for fetching the available authentication modes for a user. It processes the request using <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthController.cs" pos="61:1:1" line-data="                userAuthService.FetchModeResponse(fetchRequest, bahmniConfiguration);">`userAuthService`</SwmToken> and communicates with the gateway to retrieve the modes.

```c#
        public async Task<ActionResult> GetAuthModes(
            [FromHeader(Name = CORRELATION_ID)] string correlationId, [FromBody] FetchRequest fetchRequest)
        {
            var (gatewayFetchModesRequestRepresentation, error) =
                userAuthService.FetchModeResponse(fetchRequest, bahmniConfiguration);
            if (error != null)
                return StatusCode(StatusCodes.Status400BadRequest, error);
            Guid requestId = gatewayFetchModesRequestRepresentation.requestId;
            var cmSuffix = gatewayConfiguration.CmSuffix;

            try
            {
                logger.Log(LogLevel.Information,
                    LogEvents.UserAuth,
                    "Request for fetch-modes to gateway: {@GatewayResponse}",
                    gatewayFetchModesRequestRepresentation.dump(gatewayFetchModesRequestRepresentation));
                logger.Log(LogLevel.Information,
                    LogEvents.UserAuth, $"cmSuffix: {{cmSuffix}}, correlationId: {{correlationId}}," +
                                        $" healthId: {{healthId}}, requestId: {{requestId}}",
                    cmSuffix, correlationId, gatewayFetchModesRequestRepresentation.query.id, requestId);
                await gatewayClient.SendDataToGateway(PATH_FETCH_AUTH_MODES, gatewayFetchModesRequestRepresentation,
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/UserAuth/UserAuthController.cs" line="30">

---

### Initializing Authentication

The `InitializeAuth` method is used to initiate the authentication process. This endpoint takes user details and interacts with the <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthController.cs" pos="33:7:7" line-data="        private readonly IUserAuthService userAuthService;">`userAuthService`</SwmToken> and <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthController.cs" pos="30:7:7" line-data="        private readonly IGatewayClient gatewayClient;">`gatewayClient`</SwmToken> to start the authentication process, returning the initial authentication response to the client.

```c#
        private readonly IGatewayClient gatewayClient;
        private readonly ILogger<UserAuthController> logger;
        private readonly BahmniConfiguration bahmniConfiguration;
        private readonly IUserAuthService userAuthService;
        private readonly GatewayConfiguration gatewayConfiguration;
        private readonly HttpClient httpClient;
        private readonly OpenMrsConfiguration openMrsConfiguration;

        public UserAuthController(IGatewayClient gatewayClient,
            ILogger<UserAuthController> logger,
            IUserAuthService userAuthService,
            BahmniConfiguration bahmniConfiguration,
            GatewayConfiguration gatewayConfiguration,
            HttpClient httpClient,
            OpenMrsConfiguration openMrsConfiguration)
        {
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/UserAuth/UserAuthController.cs" line="47">

---

### Confirming Authentication

The `ConfirmAuth` method confirms the authentication process. It verifies the user details and interacts with the <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthController.cs" pos="48:3:3" line-data="            this.userAuthService = userAuthService;">`userAuthService`</SwmToken> to finalize the authentication.

```c#
            this.logger = logger;
            this.userAuthService = userAuthService;
            this.bahmniConfiguration = bahmniConfiguration;
            this.gatewayConfiguration = gatewayConfiguration;
            this.httpClient = httpClient;
            this.openMrsConfiguration = openMrsConfiguration;
        }

        [Authorize(AuthenticationSchemes = BAHMNI_AUTH)]
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/UserAuth/UserAuthController.cs" line="117">

---

### Handling Demographic Details

The `HandleDemographics` method manages the demographic details of the user. It processes the demographic data and interacts with the <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthController.cs" pos="33:7:7" line-data="        private readonly IUserAuthService userAuthService;">`userAuthService`</SwmToken> to update the user information.

```c#
        [Authorize]
        [HttpPost(PATH_ON_FETCH_AUTH_MODES)]
        public AcceptedResult SetAuthModes(OnFetchAuthModeRequest request)
        {
            logger.Log(LogLevel.Information,
                LogEvents.UserAuth, "On fetch mode request received." +
                                    $" RequestId:{request.RequestId}, " +
                                    $" Timestamp:{request.Timestamp}," +
                                    $" ResponseRequestId:{request.Resp.RequestId}, ");
            if (request.Error != null)
            {
                RequestIdToErrorMessage.Add(Guid.Parse(request.Resp.RequestId), request.Error);
                logger.Log(LogLevel.Information,
                    LogEvents.UserAuth, $" Error Code:{request.Error.Code}," +
                                        $" Error Message:{request.Error.Message}.");
            }
            else if (request.Auth != null)
            {
                RequestIdToAuthModes.Add(Guid.Parse(request.Resp.RequestId), request.Auth.Modes);
            }

```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
