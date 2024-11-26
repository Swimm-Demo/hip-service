---
title: Introduction to Verification Process
---
# Steps in the Verification Process

# Introduction to Verification Process

Verification refers to the process of confirming the authenticity of a user's identity or request. This is essential for ensuring that only authorized individuals can access or manipulate sensitive health information.

# <SwmToken path="src/In.ProjectEKA.HipService/Verification/VerificationController.cs" pos="34:3:3" line-data="        public VerificationController(IGatewayClient gatewayClient,">`VerificationController`</SwmToken>

The verification process involves several steps such as generating and verifying OTPs (One-Time Passwords), initializing authentication requests, and handling responses. These steps are implemented through different classes and methods within the <SwmToken path="src/In.ProjectEKA.HipService/Verification/VerificationController.cs" pos="10:8:8" line-data="using In.ProjectEKA.HipService.Verification.Model;">`Verification`</SwmToken> namespace.

## Example Usage

The <SwmToken path="src/In.ProjectEKA.HipService/Verification/VerificationController.cs" pos="34:3:3" line-data="        public VerificationController(IGatewayClient gatewayClient,">`VerificationController`</SwmToken> is responsible for handling various verification-related requests in the application. It includes endpoints for searching health IDs, initiating authentication, verifying OTPs, creating and updating PHR addresses, generating mobile OTPs, and verifying mobile OTPs.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Verification/VerificationController.cs" line="83">

---

The <SwmToken path="src/In.ProjectEKA.HipService/Verification/VerificationController.cs" pos="84:10:10" line-data="        public async Task&lt;ActionResult&gt; AuthInit(">`AuthInit`</SwmToken> method in the <SwmToken path="src/In.ProjectEKA.HipService/Verification/VerificationController.cs" pos="34:3:3" line-data="        public VerificationController(IGatewayClient gatewayClient,">`VerificationController`</SwmToken> demonstrates how to initiate authentication by sending a request to the gateway and handling the response.

```c#
        [Route(AUTH_INIT_VERIFY)]
        public async Task<ActionResult> AuthInit(
            [FromHeader(Name = CORRELATION_ID)] string correlationId, [FromBody] AuthInitRequest authInitRequest)
        {
            string sessionId = HttpContext.Items[SESSION_ID] as string;

            try
            {
                logger.Log(LogLevel.Information,
                    LogEvents.Verification,
                    "Request for auth init to gateway: {@GatewayResponse}", authInitRequest);
                logger.Log(LogLevel.Information,
                    LogEvents.Verification, $"correlationId: {{correlationId}}," +
                                            $" healthId: {{healthId}}" + $" authMethod: {{authMethod}}",
                    correlationId, authInitRequest.healthid,authInitRequest.authMethod);
                using (var response = await gatewayClient.CallABHAService(HttpMethod.Post,gatewayConfiguration.AbhaNumberServiceUrl, AUTH_INIT_VERIFY, authInitRequest, correlationId))
                {
                    var responseContent = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    if (response.IsSuccessStatusCode)
                    {
                        var generationResponse =
```

---

</SwmSnippet>

## searchHealthId

# Verification APIs

The <SwmToken path="src/In.ProjectEKA.HipService/Verification/VerificationController.cs" pos="34:3:3" line-data="        public VerificationController(IGatewayClient gatewayClient,">`VerificationController`</SwmToken> includes several APIs to facilitate the verification process.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Verification/VerificationController.cs" line="10">

---

The `searchHealthId` endpoint is used to search for a health ID based on the provided criteria. This endpoint helps in identifying and retrieving the health ID associated with a user.

```c#
using In.ProjectEKA.HipService.Verification.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using static In.ProjectEKA.HipService.Creation.CreationMap;

namespace In.ProjectEKA.HipService.Verification
{
    using static Constants;
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Verification/VerificationController.cs" line="30">

---

## verifyOtp

The `verifyOtp` endpoint is responsible for verifying the OTP (One-Time Password) sent to the user's mobile number. This step is crucial for authenticating the user's identity before granting access to sensitive health information.

```c#
        private readonly GatewayConfiguration gatewayConfiguration;
        private readonly IAbhaService abhaService;
        public static string public_key;

        public VerificationController(IGatewayClient gatewayClient,
            ILogger<VerificationController> logger,
            HttpClient httpClient,
            OpenMrsConfiguration openMrsConfiguration, GatewayConfiguration gatewayConfiguration, IAbhaService abhaService)
        {
            this.gatewayClient = gatewayClient;
            this.logger = logger;
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
