---
title: Handling Care Context Not Found Error
---
This document explains the process of handling a scenario where a care context is not found for a given patient. The process involves setting up a patient reference request, mocking the patient repository, calling the <SwmToken path="test/In.ProjectEKA.HipServiceTest/Link/LinkPatientTest.cs" pos="135:16:16" line-data="            var (_, error) = await linkPatient.LinkPatients(patientReferenceRequest);">`LinkPatients`</SwmToken> method, and verifying the returned error.

The flow starts by setting up a patient reference request and mocking the patient repository to return a specific patient. Then, the <SwmToken path="test/In.ProjectEKA.HipServiceTest/Link/LinkPatientTest.cs" pos="135:16:16" line-data="            var (_, error) = await linkPatient.LinkPatients(patientReferenceRequest);">`LinkPatients`</SwmToken> method is called, and the system checks if the returned error matches the expected <SwmToken path="test/In.ProjectEKA.HipServiceTest/Link/LinkPatientTest.cs" pos="133:7:7" line-data="                new Error(ErrorCode.CareContextNotFound, ErrorMessage.CareContextNotFound));">`CareContextNotFound`</SwmToken> error. Finally, the patient repository is verified, and the invocation count of the discovery request repository is checked to ensure it is zero.

# Flow drill down

```mermaid
graph TD;
      subgraph srcInProjectEKAHipServiceLinkLinkPatientcs["src/In.ProjectEKA.HipService/Link/LinkPatient.cs"]
42b2f2db44491be753d76fb0a639b0d479eb0f59868d5544848afe3e9b45a80c(ShouldReturnCareContextNotFoundError) --> 6849245398465158b3bb7d239519e4ad884bdc0b550271120553ecc8f6139d55(LinkPatients)
end

subgraph srcInProjectEKAHipServiceLinkLinkPatientcs["src/In.ProjectEKA.HipService/Link/LinkPatient.cs"]
6849245398465158b3bb7d239519e4ad884bdc0b550271120553ecc8f6139d55(LinkPatients) --> b395028df58004c5b0618f353245d7cbbf24f41d38a776657b2662153d5a8772(PatientAndCareContextValidation)
end

subgraph srcInProjectEKAHipServiceOpenMrs["src/In.ProjectEKA.HipService/OpenMrs"]
b395028df58004c5b0618f353245d7cbbf24f41d38a776657b2662153d5a8772(PatientAndCareContextValidation) --> dd70669797c818b313d9a11e817dc9ed83b93f37739339c86521cb905bd3dcae(PatientWithAsync)
end

subgraph srcInProjectEKAHipServiceOpenMrs["src/In.ProjectEKA.HipService/OpenMrs"]
dd70669797c818b313d9a11e817dc9ed83b93f37739339c86521cb905bd3dcae(PatientWithAsync) --> bc8341f884da0777a1cb7088037bd750965dfa48508b07c3fef1dafb683bb701(GetCareContexts)
end


      classDef mainFlowStyle color:#000000,fill:#7CB9F4
classDef rootsStyle color:#000000,fill:#00FFF4
classDef Style1 color:#000000,fill:#00FFAA
classDef Style2 color:#000000,fill:#FFFF00
classDef Style3 color:#000000,fill:#AA7CB9
```

<SwmSnippet path="/test/In.ProjectEKA.HipServiceTest/Link/LinkPatientTest.cs" line="126">

---

## <SwmToken path="test/In.ProjectEKA.HipServiceTest/Link/LinkPatientTest.cs" pos="127:7:7" line-data="        private async void ShouldReturnCareContextNotFoundError()">`ShouldReturnCareContextNotFoundError`</SwmToken>

The <SwmToken path="test/In.ProjectEKA.HipServiceTest/Link/LinkPatientTest.cs" pos="127:7:7" line-data="        private async void ShouldReturnCareContextNotFoundError()">`ShouldReturnCareContextNotFoundError`</SwmToken> method is a test case designed to verify that the system correctly handles the scenario where a care context is not found for a given patient. This method sets up a patient reference request and mocks the patient repository to return a specific patient. It then calls the <SwmToken path="test/In.ProjectEKA.HipServiceTest/Link/LinkPatientTest.cs" pos="135:16:16" line-data="            var (_, error) = await linkPatient.LinkPatients(patientReferenceRequest);">`LinkPatients`</SwmToken> method and checks if the returned error matches the expected <SwmToken path="test/In.ProjectEKA.HipServiceTest/Link/LinkPatientTest.cs" pos="133:7:7" line-data="                new Error(ErrorCode.CareContextNotFound, ErrorMessage.CareContextNotFound));">`CareContextNotFound`</SwmToken> error.

```c#
        [Fact]
        private async void ShouldReturnCareContextNotFoundError()
        {
            var patientReferenceRequest = getPatientReferenceRequest("1234");
            patientRepository.Setup(e => e.PatientWithAsync(testPatient.Identifier))
                .ReturnsAsync(Option.Some(testPatient));
            var expectedError = new ErrorRepresentation(
                new Error(ErrorCode.CareContextNotFound, ErrorMessage.CareContextNotFound));

            var (_, error) = await linkPatient.LinkPatients(patientReferenceRequest);

            patientRepository.Verify();
            discoveryRequestRepository.Invocations.Count.Should().Be(0);
            error.Should().BeEquivalentTo(expectedError);
        }
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
