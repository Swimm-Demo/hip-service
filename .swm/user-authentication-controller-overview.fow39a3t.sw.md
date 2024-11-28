---
title: User Authentication Controller Overview
---
# Methods in <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthController.cs" pos="28:5:5" line-data="    public class UserAuthController : Controller">`UserAuthController`</SwmToken>

# Overview

The <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthController.cs" pos="28:5:5" line-data="    public class UserAuthController : Controller">`UserAuthController`</SwmToken> is a class responsible for handling user authentication-related requests. It utilizes various services and configurations such as <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthController.cs" pos="30:5:5" line-data="        private readonly IGatewayClient gatewayClient;">`IGatewayClient`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthController.cs" pos="31:5:5" line-data="        private readonly ILogger&lt;UserAuthController&gt; logger;">`ILogger`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthController.cs" pos="32:5:5" line-data="        private readonly BahmniConfiguration bahmniConfiguration;">`BahmniConfiguration`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthController.cs" pos="33:5:5" line-data="        private readonly IUserAuthService userAuthService;">`IUserAuthService`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthController.cs" pos="34:5:5" line-data="        private readonly GatewayConfiguration gatewayConfiguration;">`GatewayConfiguration`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthController.cs" pos="35:5:5" line-data="        private readonly HttpClient httpClient;">`HttpClient`</SwmToken>, and <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthController.cs" pos="36:5:5" line-data="        private readonly OpenMrsConfiguration openMrsConfiguration;">`OpenMrsConfiguration`</SwmToken> to perform its operations.

The controller includes several methods that handle different aspects of user authentication. These methods include <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthController.cs" pos="57:10:10" line-data="        public async Task&lt;ActionResult&gt; GetAuthModes(">`GetAuthModes`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthController.cs" pos="119:5:5" line-data="        public AcceptedResult SetAuthModes(OnFetchAuthModeRequest request)">`SetAuthModes`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthController.cs" pos="143:10:10" line-data="        public async Task&lt;ActionResult&gt; GetTransactionId(">`GetTransactionId`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthController.cs" pos="156:5:5" line-data="        public AcceptedResult SetTransactionId(AuthOnInitRequest request)">`SetTransactionId`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthController.cs" pos="182:10:10" line-data="        public async Task&lt;ActionResult&gt; GetAccessToken(">`GetAccessToken`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthController.cs" pos="195:10:10" line-data="        public async Task&lt;ActionResult&gt; SetAccessToken(OnAuthConfirmRequest request)">`SetAccessToken`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthController.cs" pos="222:7:7" line-data="        public async Task SetDemographicDetails(">`SetDemographicDetails`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthController.cs" pos="235:10:10" line-data="        public async Task&lt;ActionResult&gt; DemographicAuth([FromBody] NdhmDemographics ndhmDemographics)">`DemographicAuth`</SwmToken>, and <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthController.cs" pos="254:10:10" line-data="        public async Task&lt;ActionResult&gt; AuthNotify([FromHeader(Name = CORRELATION_ID)] string correlationId, ">`AuthNotify`</SwmToken>.

## <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthController.cs" pos="57:10:10" line-data="        public async Task&lt;ActionResult&gt; GetAuthModes(">`GetAuthModes`</SwmToken>

These methods are responsible for various tasks such as fetching authentication modes, initializing authentication, confirming authentication, and handling demographic details.

<SwmSnippet path="/src/In.ProjectEKA.HipService/UserAuth/UserAuthController.cs" line="55">

---

The <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthController.cs" pos="57:10:10" line-data="        public async Task&lt;ActionResult&gt; GetAuthModes(">`GetAuthModes`</SwmToken> method is responsible for fetching the available authentication modes for a user. This endpoint is typically used to determine which authentication methods are supported and can be utilized for user authentication.

```c#
        [Authorize(AuthenticationSchemes = BAHMNI_AUTH)]
        [Route(PATH_FETCH_MODES)]
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
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/UserAuth/UserAuthController.cs" line="22">

---

## <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthController.cs" pos="119:5:5" line-data="        public AcceptedResult SetAuthModes(OnFetchAuthModeRequest request)">`SetAuthModes`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthController.cs" pos="119:5:5" line-data="        public AcceptedResult SetAuthModes(OnFetchAuthModeRequest request)">`SetAuthModes`</SwmToken> method is used to initialize the authentication process by setting the chosen authentication mode for the user. This endpoint is crucial for starting the authentication flow and ensuring that the selected mode is applied correctly.

```c#

namespace In.ProjectEKA.HipService.UserAuth
{
    using static Constants;

    [ApiController]
    public class UserAuthController : Controller
    {
        private readonly IGatewayClient gatewayClient;
        private readonly ILogger<UserAuthController> logger;
        private readonly BahmniConfiguration bahmniConfiguration;
```

---

</SwmSnippet>

## <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthController.cs" pos="156:5:5" line-data="        public AcceptedResult SetTransactionId(AuthOnInitRequest request)">`SetTransactionId`</SwmToken>

## <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthController.cs" pos="143:10:10" line-data="        public async Task&lt;ActionResult&gt; GetTransactionId(">`GetTransactionId`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthController.cs" pos="143:10:10" line-data="        public async Task&lt;ActionResult&gt; GetTransactionId(">`GetTransactionId`</SwmToken> method retrieves the current transaction ID associated with the user's authentication process. This ID is essential for tracking and managing the authentication session.

## <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthController.cs" pos="182:10:10" line-data="        public async Task&lt;ActionResult&gt; GetAccessToken(">`GetAccessToken`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthController.cs" pos="156:5:5" line-data="        public AcceptedResult SetTransactionId(AuthOnInitRequest request)">`SetTransactionId`</SwmToken> method sets a new transaction ID for the user's authentication session. This is typically used to start a new authentication process or reset the current session.

## <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthController.cs" pos="195:10:10" line-data="        public async Task&lt;ActionResult&gt; SetAccessToken(OnAuthConfirmRequest request)">`SetAccessToken`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthController.cs" pos="182:10:10" line-data="        public async Task&lt;ActionResult&gt; GetAccessToken(">`GetAccessToken`</SwmToken> method retrieves the access token for the user. This token is used to authenticate the user in subsequent requests and access protected resources.

## <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthController.cs" pos="222:7:7" line-data="        public async Task SetDemographicDetails(">`SetDemographicDetails`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthController.cs" pos="195:10:10" line-data="        public async Task&lt;ActionResult&gt; SetAccessToken(OnAuthConfirmRequest request)">`SetAccessToken`</SwmToken> method sets a new access token for the user. This is typically done after successful authentication to allow the user to access protected resources.

## <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthController.cs" pos="235:10:10" line-data="        public async Task&lt;ActionResult&gt; DemographicAuth([FromBody] NdhmDemographics ndhmDemographics)">`DemographicAuth`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthController.cs" pos="222:7:7" line-data="        public async Task SetDemographicDetails(">`SetDemographicDetails`</SwmToken> method sets the demographic details of the user. This information is used to verify the user's identity during the authentication process.

## <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthController.cs" pos="254:10:10" line-data="        public async Task&lt;ActionResult&gt; AuthNotify([FromHeader(Name = CORRELATION_ID)] string correlationId, ">`AuthNotify`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthController.cs" pos="235:10:10" line-data="        public async Task&lt;ActionResult&gt; DemographicAuth([FromBody] NdhmDemographics ndhmDemographics)">`DemographicAuth`</SwmToken> method handles the authentication process based on the user's demographic details. This method verifies the provided details and confirms the user's identity.

# Logging and Configuration

The <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthController.cs" pos="254:10:10" line-data="        public async Task&lt;ActionResult&gt; AuthNotify([FromHeader(Name = CORRELATION_ID)] string correlationId, ">`AuthNotify`</SwmToken> method handles notifications related to the authentication process. This can include sending alerts or updates to the user about the status of their authentication.

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
