---
title: Verification Controller Overview
---
# Understanding Verification Controller

The <SwmToken path="src/In.ProjectEKA.HipService/Verification/VerificationController.cs" pos="24:5:5" line-data="    public class VerificationController : Controller">`VerificationController`</SwmToken> is responsible for handling various verification-related requests in the application.

It includes endpoints for searching health IDs, initiating authentication, verifying OTPs, creating and updating PHR addresses, generating mobile OTPs, and verifying mobile OTPs.

## Example Usage

The controller interacts with the gateway client to communicate with external services and uses the ABHA service for encryption and profile retrieval.

## Main Functions

The <SwmToken path="src/In.ProjectEKA.HipService/Verification/VerificationController.cs" pos="24:5:5" line-data="    public class VerificationController : Controller">`VerificationController`</SwmToken> is responsible for handling various verification-related requests in the application. It includes endpoints for searching health IDs, initiating authentication, verifying OTPs, creating and updating PHR addresses, generating mobile OTPs, and verifying mobile OTPs. The controller interacts with the gateway client to communicate with external services and uses the ABHA service for encryption and profile retrieval. Logging is extensively used to track the flow of requests and handle exceptions.

### <SwmToken path="src/In.ProjectEKA.HipService/Verification/VerificationController.cs" pos="48:10:10" line-data="        public async Task&lt;ActionResult&gt; SearchHealthId(">`SearchHealthId`</SwmToken>

The main functions of the <SwmToken path="src/In.ProjectEKA.HipService/Verification/VerificationController.cs" pos="24:5:5" line-data="    public class VerificationController : Controller">`VerificationController`</SwmToken> include handling requests for health ID searches, OTP verification, and PHR address management.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Verification/VerificationController.cs" line="47">

---

The <SwmToken path="src/In.ProjectEKA.HipService/Verification/VerificationController.cs" pos="48:10:10" line-data="        public async Task&lt;ActionResult&gt; SearchHealthId(">`SearchHealthId`</SwmToken> function handles requests to search for health IDs. It logs the request details and calls the ABHA service to perform the search. If successful, it returns the search results; otherwise, it returns an error status.

```c#
        [Route(SEARCH_HEALTHID)]
        public async Task<ActionResult> SearchHealthId(
            [FromHeader(Name = CORRELATION_ID)] string correlationId, [FromBody] SearchHealthIdRequest searchHealthIdRequest)
        {
            try
            {
                logger.Log(LogLevel.Information,
                    LogEvents.Verification,
                    "Request for search healthId to gateway: {@GatewayResponse}", searchHealthIdRequest);
                logger.Log(LogLevel.Information,
                    LogEvents.Verification, $"correlationId: {{correlationId}}," +
                                        $" healthId: {{healthId}}",
                     correlationId, searchHealthIdRequest.healthId);
                using (var response = await gatewayClient.CallABHAService(HttpMethod.Post,gatewayConfiguration.AbhaNumberServiceUrl, SEARCH_HEALTHID, searchHealthIdRequest, correlationId))
                {
                    var responseContent = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    if (response.IsSuccessStatusCode)
                    {
                        var resp = JsonConvert.DeserializeObject<SearchHealthIdResponse>(responseContent);
                        return Accepted(resp);
                    }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Verification/VerificationController.cs" line="83">

---

### <SwmToken path="src/In.ProjectEKA.HipService/Verification/VerificationController.cs" pos="84:10:10" line-data="        public async Task&lt;ActionResult&gt; AuthInit(">`AuthInit`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipService/Verification/VerificationController.cs" pos="84:10:10" line-data="        public async Task&lt;ActionResult&gt; AuthInit(">`AuthInit`</SwmToken> method in the <SwmToken path="src/In.ProjectEKA.HipService/Verification/VerificationController.cs" pos="24:5:5" line-data="    public class VerificationController : Controller">`VerificationController`</SwmToken> demonstrates how to initiate authentication by sending a request to the gateway and handling the response.

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

### searchHealthId

## Verification Controller Endpoints

The <SwmToken path="src/In.ProjectEKA.HipService/Verification/VerificationController.cs" pos="24:5:5" line-data="    public class VerificationController : Controller">`VerificationController`</SwmToken> includes several endpoints to handle different verification-related tasks.

The `searchHealthId` endpoint is used to search for health IDs. This endpoint allows users to find health IDs based on certain criteria.

### verifyOtp

The `verifyOtp` endpoint is responsible for verifying OTPs. This endpoint ensures that the OTP provided by the user matches the one sent to their mobile device.

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
