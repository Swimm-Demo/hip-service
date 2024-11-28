---
title: Overview of SMS Notification in Hip Service
---
# Components

# Overview of SMS Notification

SMS notification refers to the functionality of sending SMS messages to users within the Hip Service.

The <SwmToken path="src/In.ProjectEKA.HipService/SmsNotification/SmsNotificationService.cs" pos="18:11:11" line-data="            var notification = new Model.SmsNotification(smsNotifyRequest.phoneNo,hip);">`SmsNotification`</SwmToken> class is used to create an SMS notification object, which includes the recipient's phone number and the <SwmToken path="src/In.ProjectEKA.HipService/SmsNotification/SmsNotificationService.cs" pos="17:9:9" line-data="            var hip = new SmsNotifyHip(bahmniConfiguration.Id, bahmniConfiguration.Id);">`SmsNotifyHip`</SwmToken> object.

# Service

The <SwmToken path="src/In.ProjectEKA.HipService/SmsNotification/SmsNotificationService.cs" pos="17:9:9" line-data="            var hip = new SmsNotifyHip(bahmniConfiguration.Id, bahmniConfiguration.Id);">`SmsNotifyHip`</SwmToken> class contains information about the Health Information Provider (HIP), such as its name and ID.

The <SwmToken path="src/In.ProjectEKA.HipService/SmsNotification/SmsNotificationService.cs" pos="10:5:5" line-data="    public class SmsNotificationService : ISmsNotificationService">`SmsNotificationService`</SwmToken> class is responsible for handling the logic related to sending SMS notifications.

<SwmSnippet path="/src/In.ProjectEKA.HipService/SmsNotification/SmsNotificationService.cs" line="17">

---

In <SwmToken path="src/In.ProjectEKA.HipService/SmsNotification/SmsNotificationService.cs" pos="10:5:5" line-data="    public class SmsNotificationService : ISmsNotificationService">`SmsNotificationService`</SwmToken>, the <SwmToken path="src/In.ProjectEKA.HipService/SmsNotification/SmsNotificationService.cs" pos="18:11:11" line-data="            var notification = new Model.SmsNotification(smsNotifyRequest.phoneNo,hip);">`SmsNotification`</SwmToken> object is created and used to send SMS notifications.

```c#
            var hip = new SmsNotifyHip(bahmniConfiguration.Id, bahmniConfiguration.Id);
            var notification = new Model.SmsNotification(smsNotifyRequest.phoneNo,hip);
```

---

</SwmSnippet>

# Controller

The `SmsNotificationController` class manages the API endpoints for SMS notifications, allowing external systems to trigger SMS notifications.

This controller provides endpoints to send SMS notifications to users. It interacts with the <SwmToken path="src/In.ProjectEKA.HipService/SmsNotification/SmsNotificationService.cs" pos="10:5:5" line-data="    public class SmsNotificationService : ISmsNotificationService">`SmsNotificationService`</SwmToken> to handle the logic related to sending SMS notifications.

## <SwmToken path="src/In.ProjectEKA.HipService/SmsNotification/SmsNotificationService.cs" pos="12:11:11" line-data="        public Tuple&lt;GatewaySmsNotifyRequestRepresentation, ErrorRepresentation&gt; SmsNotifyRequest(">`SmsNotifyRequest`</SwmToken>

# Main Functions

There are several main functions in this folder. Some of them are <SwmToken path="src/In.ProjectEKA.HipService/SmsNotification/SmsNotificationService.cs" pos="12:11:11" line-data="        public Tuple&lt;GatewaySmsNotifyRequestRepresentation, ErrorRepresentation&gt; SmsNotifyRequest(">`SmsNotifyRequest`</SwmToken>, `SendSMSNotification`, and `SmsNotifyStatus`. We will dive a little into <SwmToken path="src/In.ProjectEKA.HipService/SmsNotification/SmsNotificationService.cs" pos="12:11:11" line-data="        public Tuple&lt;GatewaySmsNotifyRequestRepresentation, ErrorRepresentation&gt; SmsNotifyRequest(">`SmsNotifyRequest`</SwmToken> and `SendSMSNotification`.

<SwmSnippet path="/src/In.ProjectEKA.HipService/SmsNotification/SmsNotificationService.cs" line="12">

---

The <SwmToken path="src/In.ProjectEKA.HipService/SmsNotification/SmsNotificationService.cs" pos="12:11:11" line-data="        public Tuple&lt;GatewaySmsNotifyRequestRepresentation, ErrorRepresentation&gt; SmsNotifyRequest(">`SmsNotifyRequest`</SwmToken> function is responsible for creating a request to send an SMS notification. It generates a unique request ID and timestamp, and constructs the notification object with the recipient's phone number and HIP details.

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

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
