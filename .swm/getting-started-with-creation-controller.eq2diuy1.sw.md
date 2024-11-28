---
title: Getting Started with Creation Controller
---
# Getting Started with Creation Controller

The <SwmToken path="src/In.ProjectEKA.HipService/Creation/CreationController.cs" pos="21:5:5" line-data="    public class CreationController : Controller">`CreationController`</SwmToken> is a class responsible for handling various creation-related operations in the application. It is decorated with the <SwmToken path="src/In.ProjectEKA.HipService/Creation/CreationController.cs" pos="19:1:3" line-data="    [ApiController]">`[ApiController]`</SwmToken> and `[`<SwmToken path="src/In.ProjectEKA.HipService/Creation/CreationController.cs" pos="20:2:2" line-data="    [Authorize(AuthenticationSchemes = BAHMNI_AUTH)]">`Authorize`</SwmToken>`]` attributes, ensuring that it handles API requests and requires authentication using the <SwmToken path="src/In.ProjectEKA.HipService/Creation/CreationController.cs" pos="20:8:8" line-data="    [Authorize(AuthenticationSchemes = BAHMNI_AUTH)]">`BAHMNI_AUTH`</SwmToken> scheme.

## Main Functions

The controller relies on several dependencies, including <SwmToken path="src/In.ProjectEKA.HipService/Creation/CreationController.cs" pos="23:5:5" line-data="        private readonly IGatewayClient gatewayClient;">`IGatewayClient`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/Creation/CreationController.cs" pos="24:5:5" line-data="        private readonly ILogger&lt;CreationController&gt; logger;">`ILogger`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/Creation/CreationController.cs" pos="25:5:5" line-data="        private readonly HttpClient httpClient;">`HttpClient`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/Creation/CreationController.cs" pos="26:5:5" line-data="        private readonly OpenMrsConfiguration openMrsConfiguration;">`OpenMrsConfiguration`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/Creation/CreationController.cs" pos="27:5:5" line-data="        private readonly GatewayConfiguration gatewayConfiguration;">`GatewayConfiguration`</SwmToken>, and <SwmToken path="src/In.ProjectEKA.HipService/Creation/CreationController.cs" pos="28:5:5" line-data="        private readonly IAbhaService abhaService;">`IAbhaService`</SwmToken>, which are injected through its constructor.

### Generate Aadhaar OTP

The <SwmToken path="src/In.ProjectEKA.HipService/Creation/CreationController.cs" pos="21:5:5" line-data="    public class CreationController : Controller">`CreationController`</SwmToken> has several main functions, including generating and verifying OTPs for Aadhaar and mobile numbers, creating ABHA IDs, creating ABHA addresses, and retrieving ABHA cards in PNG format.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Creation/CreationController.cs" line="44">

---

The <SwmToken path="src/In.ProjectEKA.HipService/Creation/CreationController.cs" pos="45:10:10" line-data="        public async Task&lt;ActionResult&gt; GenerateAadhaarOtp(">`GenerateAadhaarOtp`</SwmToken> method handles the generation of OTPs for Aadhaar by encrypting the Aadhaar number and sending a request to the gateway service.

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

<SwmSnippet path="/src/In.ProjectEKA.HipService/Creation/CreationController.cs" line="93">

---

### Verify Aadhaar OTP

The <SwmToken path="src/In.ProjectEKA.HipService/Creation/CreationController.cs" pos="94:10:10" line-data="        public async Task&lt;ActionResult&gt; VerifyAadhaarOtp(">`VerifyAadhaarOtp`</SwmToken> method verifies the OTP received for Aadhaar by encrypting the OTP and sending it to the gateway service for validation.

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

<SwmSnippet path="/src/In.ProjectEKA.HipService/Creation/CreationController.cs" line="141">

---

### Generate Mobile OTP

The <SwmToken path="src/In.ProjectEKA.HipService/Creation/CreationController.cs" pos="142:10:10" line-data="        public async Task&lt;ActionResult&gt; CheckAndGenerateMobileOTP(">`CheckAndGenerateMobileOTP`</SwmToken> method generates OTPs for mobile numbers.

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

<SwmSnippet path="/src/In.ProjectEKA.HipService/Creation/CreationController.cs" line="179">

---

### Verify Mobile OTP

The <SwmToken path="src/In.ProjectEKA.HipService/Creation/CreationController.cs" pos="180:10:10" line-data="        public async Task&lt;ActionResult&gt; VerifyMobileOTP(">`VerifyMobileOTP`</SwmToken> method verifies these OTPs.

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

<SwmSnippet path="/src/In.ProjectEKA.HipService/Creation/CreationController.cs" line="217">

---

### Create ABHA ID

The <SwmToken path="src/In.ProjectEKA.HipService/Creation/CreationController.cs" pos="218:10:10" line-data="        public async Task&lt;ActionResult&gt; CreateABHAId(">`CreateABHAId`</SwmToken> method is responsible for creating an ABHA ID by sending a request to the gateway service with the necessary details.

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

<SwmSnippet path="/src/In.ProjectEKA.HipService/Creation/CreationController.cs" line="262">

---

### Create ABHA Address

The <SwmToken path="src/In.ProjectEKA.HipService/Creation/CreationController.cs" pos="263:10:10" line-data="        public async Task&lt;ActionResult&gt; CreateABHAAddress(">`CreateABHAAddress`</SwmToken> method creates an ABHA address.

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

<SwmSnippet path="/src/In.ProjectEKA.HipService/Creation/CreationController.cs" line="293">

---

### Retrieve ABHA Card

The <SwmToken path="src/In.ProjectEKA.HipService/Creation/CreationController.cs" pos="294:10:10" line-data="        public async Task&lt;IActionResult&gt; getPngCard(">`getPngCard`</SwmToken> method retrieves the ABHA card in PNG format.

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

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
