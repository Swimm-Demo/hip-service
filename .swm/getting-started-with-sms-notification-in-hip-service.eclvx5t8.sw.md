---
title: Getting Started with SMS Notification in HIP Service
---
# Getting Started with SMS Notification in HIP Service

This document provides a comprehensive guide on setting up and using SMS notifications within the HIP Service. SMS notifications are used for various purposes such as account verification, consent confirmation, and data transfer notifications.

## <SwmToken path="src/In.ProjectEKA.HipService/SmsNotification/Model/SmsNotification.cs" pos="3:5:5" line-data="    public class SmsNotification">`SmsNotification`</SwmToken> Class

The <SwmToken path="src/In.ProjectEKA.HipService/SmsNotification/Model/SmsNotification.cs" pos="3:5:5" line-data="    public class SmsNotification">`SmsNotification`</SwmToken> class is used to create an SMS notification object that includes the recipient's phone number and the Health Information Provider (HIP) details.

<SwmSnippet path="/src/In.ProjectEKA.HipService/SmsNotification/Model/SmsNotification.cs" line="3">

---

The <SwmToken path="src/In.ProjectEKA.HipService/SmsNotification/Model/SmsNotification.cs" pos="3:5:5" line-data="    public class SmsNotification">`SmsNotification`</SwmToken> class defines the structure of an SMS notification, including the recipient's phone number and HIP details.

```c#
    public class SmsNotification
    {
        public string phoneNo { get; }
        public SmsNotifyHip hip { get; }

        public SmsNotification(string phoneNo, SmsNotifyHip hip)
        {
            this.phoneNo = phoneNo;
            this.hip = hip;
        }
    }
```

---

</SwmSnippet>

## <SwmToken path="src/In.ProjectEKA.HipService/SmsNotification/Model/SmsNotification.cs" pos="6:3:3" line-data="        public SmsNotifyHip hip { get; }">`SmsNotifyHip`</SwmToken> Class

The <SwmToken path="src/In.ProjectEKA.HipService/SmsNotification/Model/SmsNotification.cs" pos="6:3:3" line-data="        public SmsNotifyHip hip { get; }">`SmsNotifyHip`</SwmToken> class represents the HIP details, including the name and ID of the HIP, which are included in the SMS notification.

## <SwmToken path="src/In.ProjectEKA.HipService/SmsNotification/SmsNotificationService.cs" pos="10:5:5" line-data="    public class SmsNotificationService : ISmsNotificationService">`SmsNotificationService`</SwmToken> Class

The <SwmToken path="src/In.ProjectEKA.HipService/SmsNotification/SmsNotificationService.cs" pos="10:5:5" line-data="    public class SmsNotificationService : ISmsNotificationService">`SmsNotificationService`</SwmToken> class is responsible for handling the logic of sending SMS notifications. This includes creating the notification object and interfacing with the SMS gateway.

<SwmSnippet path="/src/In.ProjectEKA.HipService/SmsNotification/SmsNotificationService.cs" line="10">

---

The <SwmToken path="src/In.ProjectEKA.HipService/SmsNotification/SmsNotificationService.cs" pos="10:5:5" line-data="    public class SmsNotificationService : ISmsNotificationService">`SmsNotificationService`</SwmToken> class handles the creation of the SMS notification object and sends it to the SMS gateway.

```c#
    public class SmsNotificationService : ISmsNotificationService
    {
        public Tuple<GatewaySmsNotifyRequestRepresentation, ErrorRepresentation> SmsNotifyRequest(
            SmsNotifyRequest smsNotifyRequest, BahmniConfiguration bahmniConfiguration)
        {
            var timeStamp = DateTime.Now.ToUniversalTime().ToString(DateTimeFormat);
            var requestId = Guid.NewGuid();
            var hip = new SmsNotifyHip(bahmniConfiguration.Id, bahmniConfiguration.Id);
            var notification = new Model.SmsNotification(smsNotifyRequest.phoneNo,hip);

            return new Tuple<GatewaySmsNotifyRequestRepresentation, ErrorRepresentation>(
                new GatewaySmsNotifyRequestRepresentation(requestId, timeStamp, notification), null);

        }
    }
```

---

</SwmSnippet>

## <SwmToken path="src/In.ProjectEKA.HipService/SmsNotification/SmsNotificationController.cs" pos="21:5:5" line-data="    public class SmsNotificationController : Controller">`SmsNotificationController`</SwmToken> Class

The <SwmToken path="src/In.ProjectEKA.HipService/SmsNotification/SmsNotificationController.cs" pos="21:5:5" line-data="    public class SmsNotificationController : Controller">`SmsNotificationController`</SwmToken> class provides endpoints for triggering SMS notifications. It allows other parts of the system to request SMS notifications to be sent.

## Main Functions

There are several main functions in the SMS notification module. Two of the key functions are <SwmToken path="src/In.ProjectEKA.HipService/SmsNotification/SmsNotificationController.cs" pos="50:10:10" line-data="        public async Task&lt;ActionResult&gt; SendSMSNotification([FromHeader(Name = CORRELATION_ID)] string correlationId, [FromBody] SmsNotifyRequest smsNotifyRequest)">`SendSMSNotification`</SwmToken> and <SwmToken path="src/In.ProjectEKA.HipService/SmsNotification/SmsNotificationService.cs" pos="12:11:11" line-data="        public Tuple&lt;GatewaySmsNotifyRequestRepresentation, ErrorRepresentation&gt; SmsNotifyRequest(">`SmsNotifyRequest`</SwmToken>.

### <SwmToken path="src/In.ProjectEKA.HipService/SmsNotification/SmsNotificationController.cs" pos="50:10:10" line-data="        public async Task&lt;ActionResult&gt; SendSMSNotification([FromHeader(Name = CORRELATION_ID)] string correlationId, [FromBody] SmsNotifyRequest smsNotifyRequest)">`SendSMSNotification`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipService/SmsNotification/SmsNotificationController.cs" pos="50:10:10" line-data="        public async Task&lt;ActionResult&gt; SendSMSNotification([FromHeader(Name = CORRELATION_ID)] string correlationId, [FromBody] SmsNotifyRequest smsNotifyRequest)">`SendSMSNotification`</SwmToken> function is responsible for handling the request to send an SMS notification. It processes the request, logs the information, and sends the data to the gateway.

<SwmSnippet path="/src/In.ProjectEKA.HipService/SmsNotification/SmsNotificationController.cs" line="49">

---

The <SwmToken path="src/In.ProjectEKA.HipService/SmsNotification/SmsNotificationController.cs" pos="50:10:10" line-data="        public async Task&lt;ActionResult&gt; SendSMSNotification([FromHeader(Name = CORRELATION_ID)] string correlationId, [FromBody] SmsNotifyRequest smsNotifyRequest)">`SendSMSNotification`</SwmToken> function processes the SMS notification request and sends it to the gateway.

```c#
        [Route(PATH_HIP_SMS_NOTIFY)]
        public async Task<ActionResult> SendSMSNotification([FromHeader(Name = CORRELATION_ID)] string correlationId, [FromBody] SmsNotifyRequest smsNotifyRequest)
        {
            var (gatewaySmsNotifyRequestRepresentation, error) =
                _smsNotificationService.SmsNotifyRequest(smsNotifyRequest, bahmniConfiguration);
            if (error != null)
                return StatusCode(StatusCodes.Status400BadRequest, error);
            Guid requestId = gatewaySmsNotifyRequestRepresentation.requestId;
            var cmSuffix = gatewayConfiguration.CmSuffix;

            try
            {
                logger.Log(LogLevel.Information,
                    LogEvents.SmsNotify,
                    "Request for sms Notify to gateway: {@GatewayResponse}",
                    gatewaySmsNotifyRequestRepresentation.dump(gatewaySmsNotifyRequestRepresentation));
                
                await gatewayClient.SendDataToGateway(PATH_SMS_NOTIFY, gatewaySmsNotifyRequestRepresentation,
                    cmSuffix, correlationId);
                return Accepted();
            }
```

---

</SwmSnippet>

### <SwmToken path="src/In.ProjectEKA.HipService/SmsNotification/SmsNotificationService.cs" pos="12:11:11" line-data="        public Tuple&lt;GatewaySmsNotifyRequestRepresentation, ErrorRepresentation&gt; SmsNotifyRequest(">`SmsNotifyRequest`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipService/SmsNotification/SmsNotificationService.cs" pos="12:11:11" line-data="        public Tuple&lt;GatewaySmsNotifyRequestRepresentation, ErrorRepresentation&gt; SmsNotifyRequest(">`SmsNotifyRequest`</SwmToken> function in the <SwmToken path="src/In.ProjectEKA.HipService/SmsNotification/SmsNotificationService.cs" pos="10:5:5" line-data="    public class SmsNotificationService : ISmsNotificationService">`SmsNotificationService`</SwmToken> class creates the SMS notification request object, including the timestamp and request ID, and returns it along with any error representation.

<SwmSnippet path="/src/In.ProjectEKA.HipService/SmsNotification/SmsNotificationService.cs" line="12">

---

The <SwmToken path="src/In.ProjectEKA.HipService/SmsNotification/SmsNotificationService.cs" pos="12:11:11" line-data="        public Tuple&lt;GatewaySmsNotifyRequestRepresentation, ErrorRepresentation&gt; SmsNotifyRequest(">`SmsNotifyRequest`</SwmToken> function creates the SMS notification request object and returns it.

```c#
        public Tuple<GatewaySmsNotifyRequestRepresentation, ErrorRepresentation> SmsNotifyRequest(
            SmsNotifyRequest smsNotifyRequest, BahmniConfiguration bahmniConfiguration)
        {
            var timeStamp = DateTime.Now.ToUniversalTime().ToString(DateTimeFormat);
            var requestId = Guid.NewGuid();
            var hip = new SmsNotifyHip(bahmniConfiguration.Id, bahmniConfiguration.Id);
            var notification = new Model.SmsNotification(smsNotifyRequest.phoneNo,hip);

            return new Tuple<GatewaySmsNotifyRequestRepresentation, ErrorRepresentation>(
                new GatewaySmsNotifyRequestRepresentation(requestId, timeStamp, notification), null);

        }
```

---

</SwmSnippet>

## SMS Notification APIs

The SMS Notification APIs provide endpoints for triggering SMS notifications. The <SwmToken path="src/In.ProjectEKA.HipService/SmsNotification/SmsNotificationController.cs" pos="21:5:5" line-data="    public class SmsNotificationController : Controller">`SmsNotificationController`</SwmToken> class handles these HTTP requests and interacts with the <SwmToken path="src/In.ProjectEKA.HipService/SmsNotification/SmsNotificationService.cs" pos="10:5:5" line-data="    public class SmsNotificationService : ISmsNotificationService">`SmsNotificationService`</SwmToken> to process and send the SMS notifications.

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
