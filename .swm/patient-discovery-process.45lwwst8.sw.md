---
title: Patient Discovery Process
---
## Handling Discovery Requests

# Understanding Patient Discovery Process

Patient discovery is a process that involves identifying and retrieving patient information based on specific criteria provided in a discovery request.

## Retrieving Linked Care Contexts

The <SwmToken path="src/In.ProjectEKA.HipService/Discovery/PatientDiscovery.cs" pos="20:5:5" line-data="    public class PatientDiscovery : IPatientDiscovery">`PatientDiscovery`</SwmToken> class is responsible for handling patient discovery requests. It interacts with various repositories such as <SwmToken path="src/In.ProjectEKA.HipService/Discovery/PatientDiscovery.cs" pos="22:7:7" line-data="        private readonly IMatchingRepository matchingRepository;">`matchingRepository`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/Discovery/PatientDiscovery.cs" pos="23:7:7" line-data="        private readonly IDiscoveryRequestRepository discoveryRequestRepository;">`discoveryRequestRepository`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/Discovery/PatientDiscovery.cs" pos="63:14:14" line-data="            var (linkedAccounts, exception) = await linkPatientRepository.GetLinkedCareContexts(request.Patient.Id);">`linkPatientRepository`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/Discovery/PatientDiscovery.cs" pos="25:7:7" line-data="        private readonly IPatientRepository patientRepository;">`patientRepository`</SwmToken>, and <SwmToken path="src/In.ProjectEKA.HipService/Discovery/PatientDiscovery.cs" pos="26:7:7" line-data="        private readonly ICareContextRepository careContextRepository;">`careContextRepository`</SwmToken> to fetch and manage patient data.

When a discovery request is received, the <SwmToken path="src/In.ProjectEKA.HipService/Discovery/PatientDiscovery.cs" pos="51:17:17" line-data="        public virtual async Task&lt;ValueTuple&lt;DiscoveryRepresentation, ErrorRepresentation&gt;&gt; PatientFor(">`PatientFor`</SwmToken> method checks if a request with the same transaction ID already exists using the <SwmToken path="src/In.ProjectEKA.HipService/Discovery/PatientDiscovery.cs" pos="54:6:6" line-data="            if (await AlreadyExists(request.TransactionId))">`AlreadyExists`</SwmToken> method. If it does, an error is logged and returned.

## Fetching Patient Information

If the request is new, the method attempts to retrieve linked care contexts for the patient using the <SwmToken path="src/In.ProjectEKA.HipService/Discovery/PatientDiscovery.cs" pos="63:14:14" line-data="            var (linkedAccounts, exception) = await linkPatientRepository.GetLinkedCareContexts(request.Patient.Id);">`linkPatientRepository`</SwmToken>. If an exception occurs during this process, an error is logged and returned.

## Searching for Patients

If linked care contexts are found, the method fetches the patient information using the <SwmToken path="src/In.ProjectEKA.HipService/Discovery/PatientDiscovery.cs" pos="25:7:7" line-data="        private readonly IPatientRepository patientRepository;">`patientRepository`</SwmToken>. It then adds a new discovery request to the <SwmToken path="src/In.ProjectEKA.HipService/Discovery/PatientDiscovery.cs" pos="23:7:7" line-data="        private readonly IDiscoveryRequestRepository discoveryRequestRepository;">`discoveryRequestRepository`</SwmToken> and returns the patient information along with any unlinked care contexts.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Discovery/PatientDiscovery.cs" line="51">

---

If no linked care contexts are found, the method searches for patients using either a verified health ID or demographic information such as name, gender, year of birth, and phone number.

```c#
        public virtual async Task<ValueTuple<DiscoveryRepresentation, ErrorRepresentation>> PatientFor(
            DiscoveryRequest request)
        {
            if (await AlreadyExists(request.TransactionId))
            {
                logger.Log(LogLevel.Error, LogEvents.Discovery,
                    "Discovery Request already exists for {request.TransactionId}.");
                return (null,
                    new ErrorRepresentation(new Error(ErrorCode.DuplicateDiscoveryRequest,
                        "Discovery Request already exists")));
            }

            var (linkedAccounts, exception) = await linkPatientRepository.GetLinkedCareContexts(request.Patient.Id);

            if (exception != null)
            {
                logger.Log(LogLevel.Critical, LogEvents.Discovery, exception, "Failed to get care contexts");
                return (null,
                    new ErrorRepresentation(new Error(ErrorCode.FailedToGetLinkedCareContexts,
                        "Failed to get Linked Care Contexts")));
            }
```

---

</SwmSnippet>

## <SwmToken path="src/In.ProjectEKA.HipService/Discovery/PatientDiscovery.cs" pos="51:17:17" line-data="        public virtual async Task&lt;ValueTuple&lt;DiscoveryRepresentation, ErrorRepresentation&gt;&gt; PatientFor(">`PatientFor`</SwmToken>

# Main Functions

There are several main functions in this folder. Some of them are <SwmToken path="src/In.ProjectEKA.HipService/Discovery/PatientDiscovery.cs" pos="51:17:17" line-data="        public virtual async Task&lt;ValueTuple&lt;DiscoveryRepresentation, ErrorRepresentation&gt;&gt; PatientFor(">`PatientFor`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/Discovery/PatientDiscovery.cs" pos="54:6:6" line-data="            if (await AlreadyExists(request.TransactionId))">`AlreadyExists`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/Discovery/PatientDiscovery.cs" pos="63:16:16" line-data="            var (linkedAccounts, exception) = await linkPatientRepository.GetLinkedCareContexts(request.Patient.Id);">`GetLinkedCareContexts`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/Discovery/PatientDiscovery.cs" pos="74:4:4" line-data="            if (HasAny(linkedCareContexts))">`HasAny`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/Discovery/PatientDiscovery.cs" pos="88:1:1" line-data="                                GetUnlinkedCareContexts(linkedCareContexts, patient))),">`GetUnlinkedCareContexts`</SwmToken>, and <SwmToken path="src/In.ProjectEKA.HipService/Discovery/PatientDiscovery.cs" pos="45:11:11" line-data="        private ValueTuple&lt;DiscoveryRepresentation, ErrorRepresentation&gt; GetError(ErrorCode errorCode,">`GetError`</SwmToken>. We will dive a little into <SwmToken path="src/In.ProjectEKA.HipService/Discovery/PatientDiscovery.cs" pos="51:17:17" line-data="        public virtual async Task&lt;ValueTuple&lt;DiscoveryRepresentation, ErrorRepresentation&gt;&gt; PatientFor(">`PatientFor`</SwmToken> and <SwmToken path="src/In.ProjectEKA.HipService/Discovery/PatientDiscovery.cs" pos="54:6:6" line-data="            if (await AlreadyExists(request.TransactionId))">`AlreadyExists`</SwmToken>.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Discovery/PatientDiscovery.cs" line="51">

---

The <SwmToken path="src/In.ProjectEKA.HipService/Discovery/PatientDiscovery.cs" pos="51:17:17" line-data="        public virtual async Task&lt;ValueTuple&lt;DiscoveryRepresentation, ErrorRepresentation&gt;&gt; PatientFor(">`PatientFor`</SwmToken> function handles the main logic for processing a patient discovery request. It first checks if a request with the same transaction ID already exists using the <SwmToken path="src/In.ProjectEKA.HipService/Discovery/PatientDiscovery.cs" pos="54:6:6" line-data="            if (await AlreadyExists(request.TransactionId))">`AlreadyExists`</SwmToken> method. If it does, it logs an error and returns an error representation.

```c#
        public virtual async Task<ValueTuple<DiscoveryRepresentation, ErrorRepresentation>> PatientFor(
            DiscoveryRequest request)
        {
            if (await AlreadyExists(request.TransactionId))
            {
                logger.Log(LogLevel.Error, LogEvents.Discovery,
                    "Discovery Request already exists for {request.TransactionId}.");
                return (null,
                    new ErrorRepresentation(new Error(ErrorCode.DuplicateDiscoveryRequest,
                        "Discovery Request already exists")));
            }
```

---

</SwmSnippet>

# Patient Discovery Endpoints

The <SwmToken path="src/In.ProjectEKA.HipService/Discovery/PatientDiscovery.cs" pos="51:17:17" line-data="        public virtual async Task&lt;ValueTuple&lt;DiscoveryRepresentation, ErrorRepresentation&gt;&gt; PatientFor(">`PatientFor`</SwmToken> method in the <SwmToken path="src/In.ProjectEKA.HipService/Discovery/PatientDiscovery.cs" pos="20:5:5" line-data="    public class PatientDiscovery : IPatientDiscovery">`PatientDiscovery`</SwmToken> class handles patient discovery requests. It first checks if a request with the same transaction ID already exists using the <SwmToken path="src/In.ProjectEKA.HipService/Discovery/PatientDiscovery.cs" pos="54:6:6" line-data="            if (await AlreadyExists(request.TransactionId))">`AlreadyExists`</SwmToken> method. If it does, an error is logged and returned.

If the request is new, the method attempts to retrieve linked care contexts for the patient using the <SwmToken path="src/In.ProjectEKA.HipService/Discovery/PatientDiscovery.cs" pos="63:14:14" line-data="            var (linkedAccounts, exception) = await linkPatientRepository.GetLinkedCareContexts(request.Patient.Id);">`linkPatientRepository`</SwmToken>. If an exception occurs during this process, an error is logged and returned.

If linked care contexts are found, the method fetches the patient information using the <SwmToken path="src/In.ProjectEKA.HipService/Discovery/PatientDiscovery.cs" pos="25:7:7" line-data="        private readonly IPatientRepository patientRepository;">`patientRepository`</SwmToken>. It then adds a new discovery request to the <SwmToken path="src/In.ProjectEKA.HipService/Discovery/PatientDiscovery.cs" pos="23:7:7" line-data="        private readonly IDiscoveryRequestRepository discoveryRequestRepository;">`discoveryRequestRepository`</SwmToken> and returns the patient information along with any unlinked care contexts.

If no linked care contexts are found, the method searches for patients using either a verified health ID or demographic information such as name, gender, year of birth, and phone number.

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
