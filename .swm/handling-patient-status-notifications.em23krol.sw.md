---
title: Handling Patient Status Notifications
---
In this document, we will explain the process of handling patient status notifications. The process involves receiving the notification, performing necessary actions based on the status, and sending a confirmation response.

The flow starts with receiving a patient status notification. The notification is then processed to extract the health ID and status. If the status indicates that the health ID should be deleted, the system removes the health ID from various repositories. Finally, a confirmation response is sent back to acknowledge the notification.

# Flow drill down

```mermaid
graph TD;
      subgraph srcInProjectEKAHipServicePatient["src/In.ProjectEKA.HipService/Patient"]
3f2d5a6f5cb1cc424091b06bdb068860a4f354d2ce713bc43919259fc16aaad3(NotifyHip) --> 3b07dd7c95afefec0b27d0727be771f2ff292806a8d5f1860c0247631a42f39a(Perform)
end

subgraph srcInProjectEKAHipServicePatient["src/In.ProjectEKA.HipService/Patient"]
3b07dd7c95afefec0b27d0727be771f2ff292806a8d5f1860c0247631a42f39a(Perform) --> dee62618d7eb30359074d9896245bb83b9c6d71ffd7d9c5f9498f71dd04254d9(DeleteHealthIdInHip)
end

subgraph srcInProjectEKAHipServiceDiscoveryDiscoveryRequestRepositorycs["src/In.ProjectEKA.HipService/Discovery/DiscoveryRequestRepository.cs"]
dee62618d7eb30359074d9896245bb83b9c6d71ffd7d9c5f9498f71dd04254d9(DeleteHealthIdInHip) --> 6a9416263ad7307a49112e132f8b9359f6581bf308b0561e568d75a0c90ac25c(DeleteDiscoveryRequest)
end


      classDef mainFlowStyle color:#000000,fill:#7CB9F4
classDef rootsStyle color:#000000,fill:#00FFF4
classDef Style1 color:#000000,fill:#00FFAA
classDef Style2 color:#000000,fill:#FFFF00
classDef Style3 color:#000000,fill:#AA7CB9
```

<SwmSnippet path="/src/In.ProjectEKA.HipService/Patient/PatientController.cs" line="31">

---

## <SwmToken path="src/In.ProjectEKA.HipService/Patient/PatientController.cs" pos="32:10:10" line-data="        public async Task&lt;AcceptedResult&gt; NotifyHip([FromHeader(Name = CORRELATION_ID)] string correlationId,">`NotifyHip`</SwmToken>

First, the <SwmToken path="src/In.ProjectEKA.HipService/Patient/PatientController.cs" pos="32:10:10" line-data="        public async Task&lt;AcceptedResult&gt; NotifyHip([FromHeader(Name = CORRELATION_ID)] string correlationId,">`NotifyHip`</SwmToken> method receives a patient status notification and processes it. It calls the <SwmToken path="src/In.ProjectEKA.HipService/Patient/PatientController.cs" pos="36:5:5" line-data="            await _patientNotificationService.Perform(hipPatientStatusNotification);">`Perform`</SwmToken> method to handle the notification and then sends a confirmation response back to the gateway.

```c#
        [Route(PATH_PATIENT_NOTIFY)]
        public async Task<AcceptedResult> NotifyHip([FromHeader(Name = CORRELATION_ID)] string correlationId,
            [FromBody] HipPatientStatusNotification hipPatientStatusNotification)
        {
            var cmSuffix = _gatewayConfiguration.CmSuffix;
            await _patientNotificationService.Perform(hipPatientStatusNotification);
            var gatewayResponse = new HipPatientNotifyConfirmation(
                Guid.NewGuid().ToString(),
                DateTime.Now.ToUniversalTime().ToString(DateTimeFormat),
                new PatientNotifyAcknowledgement(Status.SUCCESS.ToString()), null,
                new Resp(hipPatientStatusNotification.requestId.ToString()));
            await _gatewayClient.SendDataToGateway(PATH_PATIENT_ON_NOTIFY,
                gatewayResponse,
                cmSuffix,
                correlationId);
            return Accepted();
        }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Patient/PatientNotificationService.cs" line="34">

---

## Perform

Next, the <SwmToken path="src/In.ProjectEKA.HipService/Patient/PatientNotificationService.cs" pos="34:7:7" line-data="        public async Task Perform(HipPatientStatusNotification hipPatientStatusNotification)">`Perform`</SwmToken> method extracts the health ID and status from the notification. If the status is defined as an action, it checks if the status is 'DELETED'. If so, it calls <SwmToken path="src/In.ProjectEKA.HipService/Patient/PatientNotificationService.cs" pos="40:18:18" line-data="                if (status.Equals(Action.DELETED.ToString())) DeleteHealthIdInHip(healthId);">`DeleteHealthIdInHip`</SwmToken> to remove the health ID from the system.

```c#
        public async Task Perform(HipPatientStatusNotification hipPatientStatusNotification)
        {
            var healthId = hipPatientStatusNotification.notification.patient.id;
            var status = hipPatientStatusNotification.notification.status.ToString();
            if (Enum.IsDefined(typeof(Action), status))
            {
                if (status.Equals(Action.DELETED.ToString())) DeleteHealthIdInHip(healthId);
                await RemoveHealthIdInOpenMrs(healthId, status);
            }
        }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Patient/PatientNotificationService.cs" line="45">

---

## <SwmToken path="src/In.ProjectEKA.HipService/Patient/PatientNotificationService.cs" pos="45:5:5" line-data="        private void DeleteHealthIdInHip(string healthId)">`DeleteHealthIdInHip`</SwmToken>

Then, the <SwmToken path="src/In.ProjectEKA.HipService/Patient/PatientNotificationService.cs" pos="45:5:5" line-data="        private void DeleteHealthIdInHip(string healthId)">`DeleteHealthIdInHip`</SwmToken> method deletes the health ID from various repositories, including discovery requests, linked accounts, link enquiries, user authentication, and consent artifacts.

```c#
        private void DeleteHealthIdInHip(string healthId)
        {
            discoveryRequestRepository.DeleteDiscoveryRequest(healthId);
            linkPatientRepository.DeleteLinkedAccounts(healthId);
            linkPatientRepository.DeleteLinkEnquires(healthId);
            userAuthRepository.Delete(healthId);
            userAuthRepository.DeleteDemographics(healthId);
            consentRepository.DeleteConsentArtefact(healthId);
        }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Discovery/DiscoveryRequestRepository.cs" line="52">

---

## <SwmToken path="src/In.ProjectEKA.HipService/Discovery/DiscoveryRequestRepository.cs" pos="52:7:7" line-data="        public async Task DeleteDiscoveryRequest(string healthId)">`DeleteDiscoveryRequest`</SwmToken>

Finally, the <SwmToken path="src/In.ProjectEKA.HipService/Discovery/DiscoveryRequestRepository.cs" pos="52:7:7" line-data="        public async Task DeleteDiscoveryRequest(string healthId)">`DeleteDiscoveryRequest`</SwmToken> method removes discovery requests associated with the given health ID from the discovery context and saves the changes.

```c#
        public async Task DeleteDiscoveryRequest(string healthId)
        {
            var discoveryRequests = discoveryContext.DiscoveryRequest
                .Where(request =>
                    request.ConsentManagerUserId == healthId);
            foreach (var discoveryRequest in discoveryRequests)
            {
                discoveryContext.Remove(discoveryRequest);
            }

            await discoveryContext.SaveChangesAsync();
        }
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
