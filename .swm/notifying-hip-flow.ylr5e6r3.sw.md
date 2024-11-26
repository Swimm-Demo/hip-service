---
title: Notifying HIP Flow
---
In this document, we will explain the process of notifying the Health Information Provider (HIP) when certain actions occur. This process involves several steps, including setting up a notification, sending data to the gateway, and verifying the expected status code.

The flow starts with setting up a notification for the HIP. Once the notification is prepared, it is sent to the gateway. The system then checks if the notification was successfully sent by verifying the status code returned by the gateway.

# Flow drill down

```mermaid
graph TD;
      subgraph srcInProjectEKAHipServicePatient["src/In.ProjectEKA.HipService/Patient"]
b8f0089d8ea6037dc99d3b7074e9bf4676203c4e01fc5509c86a6e7d806d3168(ShouldNotifyHip) --> 3f2d5a6f5cb1cc424091b06bdb068860a4f354d2ce713bc43919259fc16aaad3(NotifyHip)
end

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

<SwmSnippet path="/test/In.ProjectEKA.HipServiceTest/Patient/PatientControllerTest.cs" line="45">

---

## <SwmToken path="test/In.ProjectEKA.HipServiceTest/Patient/PatientControllerTest.cs" pos="46:5:5" line-data="        private void ShouldNotifyHip()">`ShouldNotifyHip`</SwmToken>

First, the <SwmToken path="test/In.ProjectEKA.HipServiceTest/Patient/PatientControllerTest.cs" pos="46:5:5" line-data="        private void ShouldNotifyHip()">`ShouldNotifyHip`</SwmToken> method is a test method that verifies the functionality of the <SwmToken path="test/In.ProjectEKA.HipServiceTest/Patient/PatientControllerTest.cs" pos="63:7:7" line-data="            Assert.Equal(_patientController.NotifyHip(correlationId, hipPatientStatusNotification).Result.StatusCode,">`NotifyHip`</SwmToken> method. It sets up a mock notification and checks if the <SwmToken path="test/In.ProjectEKA.HipServiceTest/Patient/PatientControllerTest.cs" pos="63:7:7" line-data="            Assert.Equal(_patientController.NotifyHip(correlationId, hipPatientStatusNotification).Result.StatusCode,">`NotifyHip`</SwmToken> method returns the expected status code.

```c#
        [Fact]
        private void ShouldNotifyHip()
        {
            var requestId = Guid.NewGuid();
            var timestamp = DateTime.Now.ToUniversalTime();
            var patient = new HipNotifyPatient("test@sbx");
            var notification = new PatientNotification(HipService.Patient.Model.Action.DELETED, patient);
            var hipPatientStatusNotification = new HipPatientStatusNotification(requestId, timestamp, notification);
            var correlationId = Uuid.Generate().ToString();
            var cmSuffix = "ncg";
            var hipPatientNotifyConfirmation = new HipPatientNotifyConfirmation(Guid.NewGuid().ToString(), timestamp.ToString(DateTimeFormat),
                new PatientNotifyAcknowledgement(Status.SUCCESS.ToString()),
                null, new Resp(requestId.ToString()));
            _gatewayClient.Setup(
                    client =>
                        client.SendDataToGateway(PATH_PATIENT_ON_NOTIFY,
                            hipPatientNotifyConfirmation, cmSuffix, correlationId))
                .Returns(Task.FromResult(""));
            Assert.Equal(_patientController.NotifyHip(correlationId, hipPatientStatusNotification).Result.StatusCode,
                StatusCodes.Status202Accepted);
        }
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
