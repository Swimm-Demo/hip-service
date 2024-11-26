---
title: Exploring Creation Controller
---
# Exploring Creation Controller

The <SwmToken path="src/In.ProjectEKA.HipService/Creation/LinkPhrController.cs" pos="32:3:3" line-data="            ILogger&lt;CreationController&gt; logger,">`CreationController`</SwmToken> is responsible for handling various endpoints related to the creation and verification of ABHA IDs and OTPs. It uses dependency injection to initialize services like <SwmToken path="src/In.ProjectEKA.HipService/Creation/LinkPhrController.cs" pos="31:5:5" line-data="        public LinkController(IGatewayClient gatewayClient,">`IGatewayClient`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/Creation/LinkPhrController.cs" pos="32:1:1" line-data="            ILogger&lt;CreationController&gt; logger,">`ILogger`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/Creation/LinkPhrController.cs" pos="33:1:1" line-data="            HttpClient httpClient,">`HttpClient`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/Creation/LinkPhrController.cs" pos="27:5:5" line-data="        private readonly OpenMrsConfiguration openMrsConfiguration;">`OpenMrsConfiguration`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/Creation/LinkPhrController.cs" pos="28:5:5" line-data="        private readonly GatewayConfiguration gatewayConfiguration;">`GatewayConfiguration`</SwmToken>, and <SwmToken path="src/In.ProjectEKA.HipService/Creation/CreationController.cs" pos="28:5:5" line-data="        private readonly IAbhaService abhaService;">`IAbhaService`</SwmToken>. The controller includes methods for generating and verifying Aadhaar and mobile OTPs, creating ABHA IDs, and creating ABHA addresses. Each method logs the request details and calls the appropriate service methods to perform the required operations. The responses from these service calls are processed and returned to the client, with appropriate status codes.

## Usage in LinkPhrController

The <SwmToken path="src/In.ProjectEKA.HipService/Creation/LinkPhrController.cs" pos="32:3:3" line-data="            ILogger&lt;CreationController&gt; logger,">`CreationController`</SwmToken> is used in the `LinkPhrController`.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Creation/LinkPhrController.cs" line="31">

---

The `LinkPhrController` initializes the <SwmToken path="src/In.ProjectEKA.HipService/Creation/LinkPhrController.cs" pos="32:3:3" line-data="            ILogger&lt;CreationController&gt; logger,">`CreationController`</SwmToken> with the necessary dependencies.

```c#
        public LinkController(IGatewayClient gatewayClient,
            ILogger<CreationController> logger,
            HttpClient httpClient,
```

---

</SwmSnippet>

## Main Functions

There are several main functions in this controller. Some of them are <SwmToken path="src/In.ProjectEKA.HipService/Creation/CreationController.cs" pos="45:10:10" line-data="        public async Task&lt;ActionResult&gt; GenerateAadhaarOtp(">`GenerateAadhaarOtp`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/Creation/CreationController.cs" pos="94:10:10" line-data="        public async Task&lt;ActionResult&gt; VerifyAadhaarOtp(">`VerifyAadhaarOtp`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/Creation/CreationController.cs" pos="142:10:10" line-data="        public async Task&lt;ActionResult&gt; CheckAndGenerateMobileOTP(">`CheckAndGenerateMobileOTP`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/Creation/CreationController.cs" pos="180:10:10" line-data="        public async Task&lt;ActionResult&gt; VerifyMobileOTP(">`VerifyMobileOTP`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/Creation/CreationController.cs" pos="218:10:10" line-data="        public async Task&lt;ActionResult&gt; CreateABHAId(">`CreateABHAId`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/Creation/CreationController.cs" pos="263:10:10" line-data="        public async Task&lt;ActionResult&gt; CreateABHAAddress(">`CreateABHAAddress`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/Creation/CreationController.cs" pos="294:10:10" line-data="        public async Task&lt;IActionResult&gt; getPngCard(">`getPngCard`</SwmToken>, and <SwmToken path="src/In.ProjectEKA.HipService/Creation/CreationController.cs" pos="320:10:10" line-data="        public async Task&lt;IActionResult&gt; createAbhaIdByDemographics(">`createAbhaIdByDemographics`</SwmToken>. We will dive a little into each of these functions.

### <SwmToken path="src/In.ProjectEKA.HipService/Creation/CreationController.cs" pos="45:10:10" line-data="        public async Task&lt;ActionResult&gt; GenerateAadhaarOtp(">`GenerateAadhaarOtp`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipService/Creation/CreationController.cs" pos="45:10:10" line-data="        public async Task&lt;ActionResult&gt; GenerateAadhaarOtp(">`GenerateAadhaarOtp`</SwmToken> function handles the generation of an OTP for Aadhaar verification. It logs the request, encrypts the Aadhaar number, and calls the ABHA service to generate the OTP. The response is processed and returned to the client.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Creation/CreationController.cs" line="44">

---

The <SwmToken path="src/In.ProjectEKA.HipService/Creation/CreationController.cs" pos="45:10:10" line-data="        public async Task&lt;ActionResult&gt; GenerateAadhaarOtp(">`GenerateAadhaarOtp`</SwmToken> method logs the request details, encrypts the Aadhaar number, and calls the ABHA service to generate the OTP.

```c#
        [Route(AADHAAR_GENERATE_OTP)]
        public async Task<ActionResult> GenerateAadhaarOtp(
            [FromHeader(Name = CORRELATION_ID)] string correlationId, [FromBody] AadhaarOTPGenerationRequest aadhaarOtpGenerationRequest)
        {
            string sessionId = HttpContext.Items[SESSION_ID] as string;

            try
            {
                logger.Log(LogLevel.Information,
                    LogEvents.Creation,
                    "Request for generate-aadhaar-otp to gateway: {@GatewayResponse}",
                    aadhaarOtpGenerationRequest);
                logger.Log(LogLevel.Information,
                    LogEvents.Creation, $"correlationId: {{correlationId}}," +
                                        $" aadhaar: {{aadhaar}}",
                     correlationId, aadhaarOtpGenerationRequest.aadhaar);
                string text = await abhaService.EncryptText(public_key,aadhaarOtpGenerationRequest.aadhaar);
                using (var response = await gatewayClient.CallABHAService(HttpMethod.Post,gatewayConfiguration.AbhaNumberServiceUrl, AADHAAR_GENERATE_OTP, new AadhaarOTPGenerationRequest(text), correlationId))
                {
                    var responseContent = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    if (response.IsSuccessStatusCode)
```

---

</SwmSnippet>

### <SwmToken path="src/In.ProjectEKA.HipService/Creation/CreationController.cs" pos="94:10:10" line-data="        public async Task&lt;ActionResult&gt; VerifyAadhaarOtp(">`VerifyAadhaarOtp`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipService/Creation/CreationController.cs" pos="94:10:10" line-data="        public async Task&lt;ActionResult&gt; VerifyAadhaarOtp(">`VerifyAadhaarOtp`</SwmToken> function verifies the OTP received for Aadhaar. It encrypts the OTP, logs the request, and calls the ABHA service to verify the OTP. The response is processed, and if successful, the ABHA profile is retrieved and returned to the client.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Creation/CreationController.cs" line="93">

---

The <SwmToken path="src/In.ProjectEKA.HipService/Creation/CreationController.cs" pos="94:10:10" line-data="        public async Task&lt;ActionResult&gt; VerifyAadhaarOtp(">`VerifyAadhaarOtp`</SwmToken> method logs the request details, encrypts the OTP, and calls the ABHA service to verify the OTP.

```c#
        [Route(AADHAAR_VERIFY_OTP)]
        public async Task<ActionResult> VerifyAadhaarOtp(
            [FromHeader(Name = CORRELATION_ID)] string correlationId, OTPVerifyRequest otpVerifyRequest)
        {
            string sessionId = HttpContext.Items[SESSION_ID] as string;

            var txnId = TxnDictionary.ContainsKey(sessionId) ? TxnDictionary[sessionId] : null;
            try
            {
                string encryptedOTP = await abhaService.EncryptText(public_key,otpVerifyRequest.otp);
                logger.Log(LogLevel.Information,
                    LogEvents.Creation, $"Request for verify-aadhaar-otp to gateway:  correlationId: {{correlationId}}," +
                                        $"txnId: {{txnId}}",
                     correlationId,txnId);

                using (var response = await gatewayClient.CallABHAService(HttpMethod.Post, gatewayConfiguration.AbhaNumberServiceUrl,AADHAAR_VERIFY_OTP,
                    new OTPVerifyRequest(txnId, encryptedOTP), correlationId))
                {
                    var responseContent = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    if (response.IsSuccessStatusCode)
                    {
```

---

</SwmSnippet>

### <SwmToken path="src/In.ProjectEKA.HipService/Creation/CreationController.cs" pos="142:10:10" line-data="        public async Task&lt;ActionResult&gt; CheckAndGenerateMobileOTP(">`CheckAndGenerateMobileOTP`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipService/Creation/CreationController.cs" pos="142:10:10" line-data="        public async Task&lt;ActionResult&gt; CheckAndGenerateMobileOTP(">`CheckAndGenerateMobileOTP`</SwmToken> function handles the generation of an OTP for mobile number verification. It logs the request, calls the ABHA service to generate the OTP, and processes the response to return to the client.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Creation/CreationController.cs" line="141">

---

The <SwmToken path="src/In.ProjectEKA.HipService/Creation/CreationController.cs" pos="142:10:10" line-data="        public async Task&lt;ActionResult&gt; CheckAndGenerateMobileOTP(">`CheckAndGenerateMobileOTP`</SwmToken> method logs the request details, calls the ABHA service to generate the OTP, and processes the response.

```c#
        [Route(CHECK_GENERATE_MOBILE_OTP)]
        public async Task<ActionResult> CheckAndGenerateMobileOTP(
            [FromHeader(Name = CORRELATION_ID)] string correlationId, MobileOTPGenerationRequest mobileOtpGenerationRequest)
        {
            string sessionId = HttpContext.Items[SESSION_ID] as string;

            var txnId = TxnDictionary.ContainsKey(sessionId) ? TxnDictionary[sessionId] : null;
            var mobileNumber = mobileOtpGenerationRequest.mobile;
            try
            {
                logger.Log(LogLevel.Information,
                    LogEvents.Creation, $"Request for generate-mobile-otp to gateway: correlationId: {{correlationId}}," +
                                        $" mobile: {{mobile}}",
                    correlationId,mobileNumber);
                using (var response = await gatewayClient.CallABHAService(HttpMethod.Post, gatewayConfiguration.AbhaNumberServiceUrl, CHECK_GENERATE_MOBILE_OTP,
                    new MobileOTPGenerationRequest(txnId, mobileNumber), correlationId))
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    if (response.IsSuccessStatusCode)
                    {
                        var generationResponse = JsonConvert.DeserializeObject<MobileOTPGenerationResponse>(responseContent);
```

---

</SwmSnippet>

### <SwmToken path="src/In.ProjectEKA.HipService/Creation/CreationController.cs" pos="180:10:10" line-data="        public async Task&lt;ActionResult&gt; VerifyMobileOTP(">`VerifyMobileOTP`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipService/Creation/CreationController.cs" pos="180:10:10" line-data="        public async Task&lt;ActionResult&gt; VerifyMobileOTP(">`VerifyMobileOTP`</SwmToken> function verifies the OTP received for mobile number verification. It encrypts the OTP, logs the request, and calls the ABHA service to verify the OTP. The response is processed and returned to the client.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Creation/CreationController.cs" line="179">

---

The <SwmToken path="src/In.ProjectEKA.HipService/Creation/CreationController.cs" pos="180:10:10" line-data="        public async Task&lt;ActionResult&gt; VerifyMobileOTP(">`VerifyMobileOTP`</SwmToken> method logs the request details, encrypts the OTP, and calls the ABHA service to verify the OTP.

```c#
        [Route(VERIFY_MOBILE_OTP)]
        public async Task<ActionResult> VerifyMobileOTP(
            [FromHeader(Name = CORRELATION_ID)] string correlationId, OTPVerifyRequest otpVerifyRequest)
        {
            string sessionId = HttpContext.Items[SESSION_ID] as string;

            var txnId = TxnDictionary.ContainsKey(sessionId) ? TxnDictionary[sessionId] : null;
            try
            {
                string encryptedOTP = await abhaService.EncryptText(public_key,otpVerifyRequest.otp);
                logger.Log(LogLevel.Information,
                    LogEvents.Creation, $"Request for verify-mobile-otp to gateway:  correlationId: {{correlationId}}," +
                                        $"txnId: {{txnId}}",
                    correlationId,txnId);

                using (var response = await gatewayClient.CallABHAService(HttpMethod.Post, gatewayConfiguration.AbhaNumberServiceUrl,VERIFY_MOBILE_OTP,
                    new OTPVerifyRequest(txnId, encryptedOTP), correlationId))
                {
                    var responseContent = await response?.Content.ReadAsStringAsync();
                    if (response.IsSuccessStatusCode)
                    {
```

---

</SwmSnippet>

### <SwmToken path="src/In.ProjectEKA.HipService/Creation/CreationController.cs" pos="218:10:10" line-data="        public async Task&lt;ActionResult&gt; CreateABHAId(">`CreateABHAId`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipService/Creation/CreationController.cs" pos="218:10:10" line-data="        public async Task&lt;ActionResult&gt; CreateABHAId(">`CreateABHAId`</SwmToken> function handles the creation of an ABHA ID. It logs the request, calls the ABHA service to create the ID, and processes the response to return to the client.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Creation/CreationController.cs" line="217">

---

The <SwmToken path="src/In.ProjectEKA.HipService/Creation/CreationController.cs" pos="218:10:10" line-data="        public async Task&lt;ActionResult&gt; CreateABHAId(">`CreateABHAId`</SwmToken> method logs the request details, calls the ABHA service to create the ID, and processes the response.

```c#
        [Route(Constants.CREATE_ABHA_ID)]
        public async Task<ActionResult> CreateABHAId(
            [FromHeader(Name = CORRELATION_ID)] string correlationId)
        {
            string sessionId = HttpContext.Items[SESSION_ID] as string;
        
            var txnId = TxnDictionary.ContainsKey(sessionId) ? TxnDictionary[sessionId] : null;
            try
            {
                logger.Log(LogLevel.Information,
                    LogEvents.Creation, $"Request for create-ABHA to gateway:  correlationId: {{correlationId}}," +
                                        $"txnId: {{txnId}}",
                    correlationId,txnId);
                using (var response = await gatewayClient.CallABHAService(HttpMethod.Post,gatewayConfiguration.AbhaNumberServiceUrl, CREATE_ABHA_ID,
                    new CreateABHARequest(txnId), correlationId))
                {
                    var responseContent = await response?.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode)
                    {
                        var createAbhaResponse = JsonConvert.DeserializeObject<CreateABHAResponse>(responseContent);
```

---

</SwmSnippet>

### <SwmToken path="src/In.ProjectEKA.HipService/Creation/CreationController.cs" pos="263:10:10" line-data="        public async Task&lt;ActionResult&gt; CreateABHAAddress(">`CreateABHAAddress`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipService/Creation/CreationController.cs" pos="263:10:10" line-data="        public async Task&lt;ActionResult&gt; CreateABHAAddress(">`CreateABHAAddress`</SwmToken> function handles the creation of an ABHA address. It logs the request, calls the ABHA service to create the address, and processes the response to return to the client.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Creation/CreationController.cs" line="262">

---

The <SwmToken path="src/In.ProjectEKA.HipService/Creation/CreationController.cs" pos="263:10:10" line-data="        public async Task&lt;ActionResult&gt; CreateABHAAddress(">`CreateABHAAddress`</SwmToken> method logs the request details, calls the ABHA service to create the address, and processes the response.

```c#
        [Route(Constants.CREATE_PHR)]
        public async Task<ActionResult> CreateABHAAddress(
            [FromHeader(Name = CORRELATION_ID)] string correlationId, CreateABHAAddressRequest createAbhaRequest)
        {
            string sessionId = HttpContext.Items[SESSION_ID] as string;
            
            try
            {
                logger.Log(LogLevel.Information,
                    LogEvents.Creation, $"Request for create ABHA-Address to gateway:  correlationId: {{correlationId}}",
                    correlationId);
                using (var response = await gatewayClient.CallABHAService(HttpMethod.Post,gatewayConfiguration.AbhaNumberServiceUrl, CREATE_PHR,
                    createAbhaRequest, correlationId, $"{HealthIdNumberTokenDictionary[sessionId].tokenType} {HealthIdNumberTokenDictionary[sessionId].token}"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        return Accepted();
                    }
                    var responseContent = await response?.Content.ReadAsStringAsync();
                    return StatusCode((int)response.StatusCode,responseContent);
                }
```

---

</SwmSnippet>

### <SwmToken path="src/In.ProjectEKA.HipService/Creation/CreationController.cs" pos="294:10:10" line-data="        public async Task&lt;IActionResult&gt; getPngCard(">`getPngCard`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipService/Creation/CreationController.cs" pos="294:10:10" line-data="        public async Task&lt;IActionResult&gt; getPngCard(">`getPngCard`</SwmToken> function retrieves the ABHA card in PNG format. It logs the request, calls the ABHA service to get the card, and returns the card as a file stream to the client.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Creation/CreationController.cs" line="293">

---

The <SwmToken path="src/In.ProjectEKA.HipService/Creation/CreationController.cs" pos="294:10:10" line-data="        public async Task&lt;IActionResult&gt; getPngCard(">`getPngCard`</SwmToken> method logs the request details, calls the ABHA service to get the card, and returns the card as a file stream.

```c#
        [Route(GET_ABHA_CARD)]
        public async Task<IActionResult> getPngCard(
            [FromHeader(Name = CORRELATION_ID)] string correlationId)
        {
            string sessionId = HttpContext.Items[SESSION_ID] as string;
            
            try
            {
                logger.Log(LogLevel.Information,
                    LogEvents.Creation, $"Request for abha-card to gateway:  correlationId: {{correlationId}}",
                    correlationId);

                var response = await gatewayClient.CallABHAService<string>(HttpMethod.Get, gatewayConfiguration.AbhaNumberServiceUrl, GET_ABHA_CARD,
                    null, correlationId, $"{HealthIdNumberTokenDictionary[sessionId].tokenType} {HealthIdNumberTokenDictionary[sessionId].token}");
                var stream = await response.Content.ReadAsStreamAsync();
                return File(stream,"image/png");
                
            }
            catch (Exception exception)
            {
                logger.LogError(LogEvents.Creation, exception, "Error happened for Abha-card generation");
```

---

</SwmSnippet>

### <SwmToken path="src/In.ProjectEKA.HipService/Creation/CreationController.cs" pos="320:10:10" line-data="        public async Task&lt;IActionResult&gt; createAbhaIdByDemographics(">`createAbhaIdByDemographics`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipService/Creation/CreationController.cs" pos="320:10:10" line-data="        public async Task&lt;IActionResult&gt; createAbhaIdByDemographics(">`createAbhaIdByDemographics`</SwmToken> function handles the creation of an ABHA ID using demographic information. It logs the request, retrieves the necessary data, calls the ABHA service to create the ID, and processes the response to return to the client.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Creation/CreationController.cs" line="319">

---

The <SwmToken path="src/In.ProjectEKA.HipService/Creation/CreationController.cs" pos="320:10:10" line-data="        public async Task&lt;IActionResult&gt; createAbhaIdByDemographics(">`createAbhaIdByDemographics`</SwmToken> method logs the request details, retrieves the necessary data, calls the ABHA service to create the ID, and processes the response.

```c#
        [Route(CREATE_ABHA_ID_BY_AADHAAR_DEMO)]
        public async Task<IActionResult> createAbhaIdByDemographics(
            [FromHeader(Name = CORRELATION_ID)] string correlationId, AadhaarDemoAuthRequest demoAuthRequest)
        {
            try
            {
                logger.Log(LogLevel.Information,
                    LogEvents.Creation, $"Request for aadhaar demo auth to gateway:  correlationId: {{correlationId}}",
                    correlationId);
                
                var createAbhaRequest = await abhaService.GetHidDemoAuthRequest(demoAuthRequest);

                if (createAbhaRequest != null)
                {
                    using (var response = await gatewayClient.CallABHAService(HttpMethod.Post,
                        gatewayConfiguration.AbhaNumberServiceUrl, CREATE_ABHA_ID_BY_AADHAAR_DEMO,
                        createAbhaRequest, correlationId))
                    {
                        var responseContent = await response?.Content.ReadAsStringAsync();

                        if (response.IsSuccessStatusCode)
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
