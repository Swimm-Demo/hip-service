---
title: The Log class
---
This document will cover the class <SwmToken path="src/In.ProjectEKA.HipService/Logger/Log.cs" pos="9:3:3" line-data="            Serilog.Log.Information(format, arg);">`Log`</SwmToken> in the file <SwmPath>[src/In.ProjectEKA.HipService/Logger/Log.cs](src/In.ProjectEKA.HipService/Logger/Log.cs)</SwmPath>. We will cover:

1. What <SwmToken path="src/In.ProjectEKA.HipService/Logger/Log.cs" pos="9:3:3" line-data="            Serilog.Log.Information(format, arg);">`Log`</SwmToken> is and what it is used for.
2. The variables and functions defined in <SwmToken path="src/In.ProjectEKA.HipService/Logger/Log.cs" pos="9:3:3" line-data="            Serilog.Log.Information(format, arg);">`Log`</SwmToken>.

# Variables and functions

# What is Log

The <SwmToken path="src/In.ProjectEKA.HipService/Logger/Log.cs" pos="9:3:3" line-data="            Serilog.Log.Information(format, arg);">`Log`</SwmToken> class in <SwmPath>[src/In.ProjectEKA.HipService/Logger/Log.cs](src/In.ProjectEKA.HipService/Logger/Log.cs)</SwmPath> is a static class used for logging information, errors, and fatal exceptions in the application. It leverages the Serilog library to log messages in a structured and efficient manner.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Logger/Log.cs" line="7">

---

The function <SwmToken path="src/In.ProjectEKA.HipService/Logger/Log.cs" pos="7:7:7" line-data="        public static void Information(string format, params object[] arg)">`Information`</SwmToken> is used to log informational messages. It takes a format string and an array of objects as parameters and logs the message using Serilog's <SwmToken path="src/In.ProjectEKA.HipService/Logger/Log.cs" pos="7:7:7" line-data="        public static void Information(string format, params object[] arg)">`Information`</SwmToken> method.

```c#
        public static void Information(string format, params object[] arg)
        {
            Serilog.Log.Information(format, arg);
        }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Logger/Log.cs" line="12">

---

The function <SwmToken path="src/In.ProjectEKA.HipService/Logger/Log.cs" pos="12:7:7" line-data="        public static void Error(string format, params object[] arg)">`Error`</SwmToken> is used to log error messages. It takes a format string and an array of objects as parameters and logs the message using Serilog's <SwmToken path="src/In.ProjectEKA.HipService/Logger/Log.cs" pos="12:7:7" line-data="        public static void Error(string format, params object[] arg)">`Error`</SwmToken> method.

```c#
        public static void Error(string format, params object[] arg)
        {
            Serilog.Log.Error(format, arg);
        }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Logger/Log.cs" line="17">

---

The function <SwmToken path="src/In.ProjectEKA.HipService/Logger/Log.cs" pos="17:7:7" line-data="        public static void Fatal(Exception exception, string format, params object[] arg)">`Fatal`</SwmToken> is used to log fatal exceptions. It takes an exception, a format string, and an array of objects as parameters and logs the message using Serilog's <SwmToken path="src/In.ProjectEKA.HipService/Logger/Log.cs" pos="19:5:5" line-data="            Serilog.Log.Error(exception, format, arg);">`Error`</SwmToken> method.

```c#
        public static void Fatal(Exception exception, string format, params object[] arg)
        {
            Serilog.Log.Error(exception, format, arg);
        }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Logger/Log.cs" line="22">

---

The function <SwmToken path="src/In.ProjectEKA.HipService/Logger/Log.cs" pos="22:7:7" line-data="        public static void Error(params object[] arg)">`Error`</SwmToken> is overloaded to log error messages using a predefined error template. It takes an array of objects as parameters and logs the message using Serilog's <SwmToken path="src/In.ProjectEKA.HipService/Logger/Log.cs" pos="22:7:7" line-data="        public static void Error(params object[] arg)">`Error`</SwmToken> method.

```c#
        public static void Error(params object[] arg)
        {
            Serilog.Log.Error(LogTemplate.ErrorTemplate, arg);
        }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Logger/Log.cs" line="27">

---

The function <SwmToken path="src/In.ProjectEKA.HipService/Logger/Log.cs" pos="27:7:7" line-data="        public static void Fatal(Exception exception, params object[] arg)">`Fatal`</SwmToken> is overloaded to log fatal exceptions using a predefined exception template. It takes an exception and an array of objects as parameters and logs the message using Serilog's <SwmToken path="src/In.ProjectEKA.HipService/Logger/Log.cs" pos="29:5:5" line-data="            Serilog.Log.Error(exception, LogTemplate.ExceptionTemplate, arg);">`Error`</SwmToken> method.

```c#
        public static void Fatal(Exception exception, params object[] arg)
        {
            Serilog.Log.Error(exception, LogTemplate.ExceptionTemplate, arg);
        }
```

---

</SwmSnippet>

# Usage

<SwmSnippet path="/test/In.ProjectEKA.HipServiceTest/UserAuth/UserAuthControllerTest.cs" line="128">

---

## <SwmToken path="test/In.ProjectEKA.HipServiceTest/UserAuth/UserAuthControllerTest.cs" pos="28:5:5" line-data="    public class UserAuthControllerTest">`UserAuthControllerTest`</SwmToken>

In the <SwmToken path="test/In.ProjectEKA.HipServiceTest/UserAuth/UserAuthControllerTest.cs" pos="28:5:5" line-data="    public class UserAuthControllerTest">`UserAuthControllerTest`</SwmToken> class, the <SwmToken path="test/In.ProjectEKA.HipServiceTest/UserAuth/UserAuthControllerTest.cs" pos="130:1:1" line-data="                Log.Information(authMode.ToString());">`Log`</SwmToken> class is used to log information about the results of various authentication methods. For example, when getting authentication modes, transaction IDs, or access tokens, the <SwmToken path="test/In.ProjectEKA.HipServiceTest/UserAuth/UserAuthControllerTest.cs" pos="130:1:3" line-data="                Log.Information(authMode.ToString());">`Log.Information`</SwmToken> method is called to log the results.

```c#
            if (userAuthController.GetAuthModes(correlationId, request).Result is JsonResult authMode)
            {
                Log.Information(authMode.ToString());
                authMode.Value?.Equals(HttpStatusCode.GatewayTimeout);
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Program.cs" line="20">

---

## Program

In the <SwmToken path="src/In.ProjectEKA.HipService/Program.cs" pos="11:5:5" line-data="    public class Program">`Program`</SwmToken> class, the <SwmToken path="src/In.ProjectEKA.HipService/Program.cs" pos="23:1:1" line-data="            Log.Logger = CreateLogger(host);">`Log`</SwmToken> class is used to log the start of the application, any fatal exceptions that occur, and to ensure that the log is properly closed and flushed when the application terminates.

```c#
            if (host is null)
                throw new ArgumentNullException(nameof(host));

            Log.Logger = CreateLogger(host);
            try
            {
                Log.Information("Started application");
                host.Run();
            }
#pragma warning disable CA1031 // Do not catch general exception types
            catch (Exception exception)
#pragma warning restore CA1031 // Do not catch general exception types
            {
                Log.Fatal(exception, "Application terminated unexpectedly");
            }
            finally
            {
                Log.CloseAndFlush();
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.DefaultHip/DataFlow/Collect.cs" line="32">

---

## Collect

In the <SwmToken path="src/In.ProjectEKA.DefaultHip/DataFlow/Collect.cs" pos="18:5:5" line-data="    public class Collect : ICollect">`Collect`</SwmToken> class, the <SwmToken path="src/In.ProjectEKA.DefaultHip/DataFlow/Collect.cs" pos="35:1:1" line-data="                    Log.Information($&quot;Returning file: {result}&quot;);">`Log`</SwmToken> class is used to log various events such as returning files, errors in parsing dates, and errors that occur while collecting data. This helps in tracking the flow of data and identifying issues.

```c#
            foreach (var careContextReference in careContextReferences)
                foreach (var result in patientData.GetOrDefault(careContextReference))
                {
                    Log.Information($"Returning file: {result}");
                    bundles.Add(new CareBundle(careContextReference, await FileReader.ReadJsonAsync<Bundle>(result)));
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Gateway/GatewayClient.cs" line="61">

---

## <SwmToken path="test/In.ProjectEKA.HipServiceTest/UserAuth/UserAuthControllerTest.cs" pos="35:7:7" line-data="        private readonly Mock&lt;GatewayClient&gt; gatewayClient = new Mock&lt;GatewayClient&gt;(MockBehavior.Strict, null, null);">`GatewayClient`</SwmToken>

In the <SwmToken path="test/In.ProjectEKA.HipServiceTest/UserAuth/UserAuthControllerTest.cs" pos="35:7:7" line-data="        private readonly Mock&lt;GatewayClient&gt; gatewayClient = new Mock&lt;GatewayClient&gt;(MockBehavior.Strict, null, null);">`GatewayClient`</SwmToken> class, the <SwmToken path="src/In.ProjectEKA.HipService/Gateway/GatewayClient.cs" pos="64:1:1" line-data="                    Log.Error(">`Log`</SwmToken> class is used to log errors that occur during HTTP requests, such as failures in getting tokens and exceptions that are caught. This helps in debugging issues related to communication with external services.

```c#
                if (!responseMessage.IsSuccessStatusCode)
                {
                    var error = await responseMessage.Content.ReadAsStringAsync();
                    Log.Error(
                        $"Failure in getting the token with status code {responseMessage.StatusCode} {error}");
                    return Option.None<string>();
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/UserAuth/UserAuthService.cs" line="69">

---

## <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthService.cs" pos="22:5:5" line-data="    public class UserAuthService : IUserAuthService">`UserAuthService`</SwmToken>

In the <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthService.cs" pos="22:5:5" line-data="    public class UserAuthService : IUserAuthService">`UserAuthService`</SwmToken> class, the <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/UserAuthService.cs" pos="71:3:3" line-data="                logger.Log(LogLevel.Information,">`Log`</SwmToken> class is used to log information about authentication requests and responses. This includes logging the details of requests sent to the gateway and the responses received, which aids in monitoring and debugging the authentication process.

```c#
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
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Patient/PatientProfileService.cs" line="44">

---

## <SwmToken path="src/In.ProjectEKA.HipService/Patient/PatientProfileService.cs" pos="24:5:5" line-data="    public class PatientProfileService : IPatientProfileService">`PatientProfileService`</SwmToken>

In the <SwmToken path="src/In.ProjectEKA.HipService/Patient/PatientProfileService.cs" pos="24:5:5" line-data="    public class PatientProfileService : IPatientProfileService">`PatientProfileService`</SwmToken> class, the <SwmToken path="src/In.ProjectEKA.HipService/Patient/PatientProfileService.cs" pos="47:1:1" line-data="                Log.Information(&quot;Patient saved to queue&quot;);">`Log`</SwmToken> class is used to log information about patient profiles being saved to the queue and to log fatal exceptions that occur during the process. This ensures that any issues with patient data handling are recorded.

```c#
            var patient = shareProfileRequest.Profile.PatientDemographics;
            var response = await Save(new PatientQueue(requesId, timeStamp, patient, hipCode));
            if(response.HasValue)
                Log.Information("Patient saved to queue");
            return response.ValueOrDefault();
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Patient/PatientNotificationService.cs" line="73">

---

## <SwmToken path="src/In.ProjectEKA.HipService/Patient/PatientNotificationService.cs" pos="16:5:5" line-data="    public class PatientNotificationService : IPatientNotificationService">`PatientNotificationService`</SwmToken>

In the <SwmToken path="src/In.ProjectEKA.HipService/Patient/PatientNotificationService.cs" pos="16:5:5" line-data="    public class PatientNotificationService : IPatientNotificationService">`PatientNotificationService`</SwmToken> class, the <SwmToken path="src/In.ProjectEKA.HipService/Patient/PatientNotificationService.cs" pos="73:1:1" line-data="            Log.Information(&quot;endpoint being called: &quot; + path);">`Log`</SwmToken> class is used to log the endpoint being called and the content of the response received. This helps in tracking the notifications sent to patients and the responses from the server.

```c#
            Log.Information("endpoint being called: " + path);
            var response = await openMrsClient.GetAsync(path);
            var content = await response.Content.ReadAsStringAsync();
            Log.Information(content);
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Verification/VerificationController.cs" line="53">

---

## <SwmToken path="src/In.ProjectEKA.HipService/Verification/VerificationController.cs" pos="24:5:5" line-data="    public class VerificationController : Controller">`VerificationController`</SwmToken>

In the <SwmToken path="src/In.ProjectEKA.HipService/Verification/VerificationController.cs" pos="24:5:5" line-data="    public class VerificationController : Controller">`VerificationController`</SwmToken> class, the <SwmToken path="src/In.ProjectEKA.HipService/Verification/VerificationController.cs" pos="53:3:3" line-data="                logger.Log(LogLevel.Information,">`Log`</SwmToken> class is used to log information about health ID search requests sent to the gateway. This includes logging the details of the request and the correlation ID, which helps in tracking and debugging the verification process.

```c#
                logger.Log(LogLevel.Information,
                    LogEvents.Verification,
                    "Request for search healthId to gateway: {@GatewayResponse}", searchHealthIdRequest);
                logger.Log(LogLevel.Information,
                    LogEvents.Verification, $"correlationId: {{correlationId}}," +
                                        $" healthId: {{healthId}}",
                     correlationId, searchHealthIdRequest.healthId);
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
