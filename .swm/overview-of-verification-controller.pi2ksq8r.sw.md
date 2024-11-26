---
title: Overview of Verification Controller
---
# What is Verification Controller

The <SwmToken path="src/In.ProjectEKA.HipService/Verification/VerificationController.cs" pos="24:5:5" line-data="    public class VerificationController : Controller">`VerificationController`</SwmToken> is responsible for handling various verification-related requests in the application. It includes endpoints for searching health IDs, initiating authentication, verifying OTPs, creating and updating PHR addresses, generating mobile OTPs, and verifying mobile OTPs. The controller interacts with the gateway client to communicate with external services and uses the ABHA service for encryption and profile retrieval. Logging is extensively used to track the flow of requests and handle exceptions.

## Example Usage

The <SwmToken path="src/In.ProjectEKA.HipService/Verification/VerificationController.cs" pos="84:10:10" line-data="        public async Task&lt;ActionResult&gt; AuthInit(">`AuthInit`</SwmToken> method in the <SwmToken path="src/In.ProjectEKA.HipService/Verification/VerificationController.cs" pos="24:5:5" line-data="    public class VerificationController : Controller">`VerificationController`</SwmToken> demonstrates how to initiate authentication by sending a request to the gateway and handling the response.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Verification/VerificationController.cs" line="83">

---

The <SwmToken path="src/In.ProjectEKA.HipService/Verification/VerificationController.cs" pos="84:10:10" line-data="        public async Task&lt;ActionResult&gt; AuthInit(">`AuthInit`</SwmToken> method initiates authentication by logging the request, calling the ABHA service, and managing the transaction ID.

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

## Main Functions

The <SwmToken path="src/In.ProjectEKA.HipService/Verification/VerificationController.cs" pos="24:5:5" line-data="    public class VerificationController : Controller">`VerificationController`</SwmToken> includes several main functions that handle different aspects of verification.

### <SwmToken path="src/In.ProjectEKA.HipService/Verification/VerificationController.cs" pos="48:10:10" line-data="        public async Task&lt;ActionResult&gt; SearchHealthId(">`SearchHealthId`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipService/Verification/VerificationController.cs" pos="48:10:10" line-data="        public async Task&lt;ActionResult&gt; SearchHealthId(">`SearchHealthId`</SwmToken> function handles the request to search for a health ID. It logs the request, calls the ABHA service, and returns the response.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Verification/VerificationController.cs" line="47">

---

The <SwmToken path="src/In.ProjectEKA.HipService/Verification/VerificationController.cs" pos="48:10:10" line-data="        public async Task&lt;ActionResult&gt; SearchHealthId(">`SearchHealthId`</SwmToken> function logs the request, calls the ABHA service, and returns the response.

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

### <SwmToken path="src/In.ProjectEKA.HipService/Verification/VerificationController.cs" pos="84:10:10" line-data="        public async Task&lt;ActionResult&gt; AuthInit(">`AuthInit`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipService/Verification/VerificationController.cs" pos="84:10:10" line-data="        public async Task&lt;ActionResult&gt; AuthInit(">`AuthInit`</SwmToken> function initiates the authentication process. It logs the request, calls the ABHA service, and manages the transaction ID.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Verification/VerificationController.cs" line="83">

---

The <SwmToken path="src/In.ProjectEKA.HipService/Verification/VerificationController.cs" pos="84:10:10" line-data="        public async Task&lt;ActionResult&gt; AuthInit(">`AuthInit`</SwmToken> function logs the request, calls the ABHA service, and manages the transaction ID.

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

### <SwmToken path="src/In.ProjectEKA.HipService/Verification/VerificationController.cs" pos="129:10:10" line-data="        public async Task&lt;ActionResult&gt; VerifyOTP(">`VerifyOTP`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipService/Verification/VerificationController.cs" pos="129:10:10" line-data="        public async Task&lt;ActionResult&gt; VerifyOTP(">`VerifyOTP`</SwmToken> function verifies the OTP provided by the user. It encrypts the OTP, logs the request, calls the ABHA service, and retrieves the user's profile.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Verification/VerificationController.cs" line="128">

---

The <SwmToken path="src/In.ProjectEKA.HipService/Verification/VerificationController.cs" pos="129:10:10" line-data="        public async Task&lt;ActionResult&gt; VerifyOTP(">`VerifyOTP`</SwmToken> function encrypts the OTP, logs the request, calls the ABHA service, and retrieves the user's profile.

```c#
        [Route(CONFIRM_OTP_VERIFY)]
        public async Task<ActionResult> VerifyOTP(
            [FromHeader(Name = CORRELATION_ID)] string correlationId, [FromBody] OtpVerifyRequest otpVerifyRequest)
        {
            string sessionId = HttpContext.Items[SESSION_ID] as string;
            
            var txnId = TxnDictionary.ContainsKey(sessionId) ? TxnDictionary[sessionId] : null;
            try
            {
                string encryptedOTP = await abhaService.EncryptText(public_key,otpVerifyRequest.otp);
                logger.Log(LogLevel.Information,
                    LogEvents.Verification, $"Request for otp verify to gateway:" +
                                        $"txnId: {{txnId}}",txnId);
                using (var response = await gatewayClient.CallABHAService(HttpMethod.Post,gatewayConfiguration.AbhaNumberServiceUrl, 
                    otpVerifyRequest.authMethod == AuthMode.MOBILE_OTP ? CONFIRM_WITH_MOBILE_OTP : CONFIRM_WITH_AADHAAR_OTP, 
                    new OTPVerifyRequest(txnId, encryptedOTP), correlationId))
                {
                    var responseContent = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    if (response.IsSuccessStatusCode)
                    {
                        var otpResponse = JsonConvert.DeserializeObject<TokenRequest>(responseContent);
```

---

</SwmSnippet>

### <SwmToken path="src/In.ProjectEKA.HipService/Verification/VerificationController.cs" pos="232:10:10" line-data="        public async Task&lt;ActionResult&gt; GenerateMobileOtp(">`GenerateMobileOtp`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipService/Verification/VerificationController.cs" pos="232:10:10" line-data="        public async Task&lt;ActionResult&gt; GenerateMobileOtp(">`GenerateMobileOtp`</SwmToken> function generates an OTP for mobile verification. It logs the request, calls the ABHA service, and manages the transaction ID.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Verification/VerificationController.cs" line="231">

---

The <SwmToken path="src/In.ProjectEKA.HipService/Verification/VerificationController.cs" pos="232:10:10" line-data="        public async Task&lt;ActionResult&gt; GenerateMobileOtp(">`GenerateMobileOtp`</SwmToken> function logs the request, calls the ABHA service, and manages the transaction ID.

```c#
        [Route(MOBILE_GENERATE_OTP)]
        public async Task<ActionResult> GenerateMobileOtp(
            [FromHeader(Name = CORRELATION_ID)] string correlationId, [FromBody] GenerateMobileOtpRequest generateMobileOtpRequest)
        {
            string sessionId = HttpContext.Items[SESSION_ID] as string;

            try
            {
                logger.Log(LogLevel.Information,
                    LogEvents.Verification,
                    "Request for generate mobile otp to gateway: {@GatewayResponse}", generateMobileOtpRequest);
                logger.Log(LogLevel.Information,
                    LogEvents.Verification, $"correlationId: {{correlationId}}," +
                                            $" mobile: {{mobile}}",
                    correlationId, generateMobileOtpRequest.mobile);
                using (var response = await gatewayClient.CallABHAService(HttpMethod.Post,gatewayConfiguration.AbhaNumberServiceUrl, MOBILE_GENERATE_OTP, generateMobileOtpRequest, correlationId))
                {
                    var responseContent = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    if (response.IsSuccessStatusCode)
                    {
                        var generationResponse =
```

---

</SwmSnippet>

### <SwmToken path="src/In.ProjectEKA.HipService/Verification/VerificationController.cs" pos="277:10:10" line-data="        public async Task&lt;ActionResult&gt; VerifyMobileOtp(">`VerifyMobileOtp`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipService/Verification/VerificationController.cs" pos="277:10:10" line-data="        public async Task&lt;ActionResult&gt; VerifyMobileOtp(">`VerifyMobileOtp`</SwmToken> function verifies the mobile OTP provided by the user. It encrypts the OTP, logs the request, calls the ABHA service, and manages the verified mobile token.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Verification/VerificationController.cs" line="276">

---

The <SwmToken path="src/In.ProjectEKA.HipService/Verification/VerificationController.cs" pos="277:10:10" line-data="        public async Task&lt;ActionResult&gt; VerifyMobileOtp(">`VerifyMobileOtp`</SwmToken> function encrypts the OTP, logs the request, calls the ABHA service, and manages the verified mobile token.

```c#
        [Route(MOBILE_VERIFY_OTP)]
        public async Task<ActionResult> VerifyMobileOtp(
            [FromHeader(Name = CORRELATION_ID)] string correlationId, [FromBody] VerifyMobileOtpRequest verifyMobileOtpRequest)
        {
            string sessionId = HttpContext.Items[SESSION_ID] as string;

            var txnId = TxnDictionary.ContainsKey(sessionId) ? TxnDictionary[sessionId] : null;
            try
            {
                string encryptedOTP = await abhaService.EncryptText(public_key, verifyMobileOtpRequest.otp);
                logger.Log(LogLevel.Information,
                    LogEvents.Verification, $"Request for verify mobile otp to gateway:" +
                                            $"txnId: {{txnId}}", txnId);
                using (var response = await gatewayClient.CallABHAService(HttpMethod.Post,
                    gatewayConfiguration.AbhaNumberServiceUrl,
                    MOBILE_VERIFY_OTP,
                    new OTPVerifyRequest(txnId, encryptedOTP), correlationId))
                {
                    var responseContent = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    if (response.IsSuccessStatusCode)
                    {
```

---

</SwmSnippet>

## Verification Controller Endpoints

The <SwmToken path="src/In.ProjectEKA.HipService/Verification/VerificationController.cs" pos="24:5:5" line-data="    public class VerificationController : Controller">`VerificationController`</SwmToken> includes several endpoints that handle different aspects of verification.

### searchHealthId

The `searchHealthId` endpoint is used to search for health IDs. It interacts with the gateway client to communicate with external services and uses the ABHA service for encryption and profile retrieval.

### verifyOtp

The `verifyOtp` endpoint is used to verify OTPs. It ensures that the OTP provided by the user matches the one sent to their mobile device, facilitating secure authentication.

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
