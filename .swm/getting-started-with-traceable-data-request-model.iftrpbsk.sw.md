---
title: Getting Started with Traceable Data Request Model
---
## Purpose and Usage

# Getting Started with Traceable Data Request Model

The Traceable Data Request Model encapsulates all the necessary information required to request patient data. This model includes details such as care contexts, date range, data push URL, health information types, transaction ID, key material, consent manager ID, consent ID, CM suffix, correlation ID, and patient UUID.

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" pos="8:3:3" line-data="        public TraceableDataRequest(">`TraceableDataRequest`</SwmToken> class is used to create instances of data requests that can be traced back using the provided identifiers and context information. This ensures that each data request can be uniquely identified and tracked throughout its lifecycle.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" line="8">

---

The constructor of the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" pos="8:3:3" line-data="        public TraceableDataRequest(">`TraceableDataRequest`</SwmToken> class initializes the object with various parameters such as care contexts, date range, data push URL, health information types, transaction ID, key material, consent manager ID, consent ID, CM suffix, correlation ID, and patient UUID. This ensures that all necessary information is encapsulated within the object for making a traceable data request.

```c#
        public TraceableDataRequest(
            IEnumerable<GrantedContext> careContexts,
            DateRange dateRange,
            string dataPushUrl,
            IEnumerable<HiType> hiType,
            string transactionId,
            KeyMaterial keyMaterial,
            string consentManagerId,
            string consentId,
            string cmSuffix,
            string correlationId,
            string patientUuid
            )
```

---

</SwmSnippet>

## Example Usage

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" pos="8:3:3" line-data="        public TraceableDataRequest(">`TraceableDataRequest`</SwmToken> class is used in various parts of the codebase, including <SwmPath>[src/In.ProjectEKA.HipService/DataFlow/CollectHipService.cs](src/In.ProjectEKA.HipService/DataFlow/CollectHipService.cs)</SwmPath>, <SwmPath>[src/In.ProjectEKA.DefaultHip/DataFlow/Collect.cs](src/In.ProjectEKA.DefaultHip/DataFlow/Collect.cs)</SwmPath>, <SwmPath>[src/In.ProjectEKA.HipLibrary/Patient/ICollect.cs](src/In.ProjectEKA.HipLibrary/Patient/ICollect.cs)</SwmPath>, <SwmPath>[src/In.ProjectEKA.HipService/DataFlow/ICollectHipService.cs](src/In.ProjectEKA.HipService/DataFlow/ICollectHipService.cs)</SwmPath>, <SwmPath>[src/In.ProjectEKA.HipService/DataFlow/MessagingQueueListener.cs](src/In.ProjectEKA.HipService/DataFlow/MessagingQueueListener.cs)</SwmPath>, <SwmPath>[src/In.ProjectEKA.HipService/DataFlow/DataFlowClient.cs](src/In.ProjectEKA.HipService/DataFlow/DataFlowClient.cs)</SwmPath>, and <SwmPath>[src/In.ProjectEKA.HipService/DataFlow/DataFlowMessageHandler.cs](src/In.ProjectEKA.HipService/DataFlow/DataFlowMessageHandler.cs)</SwmPath>.

<SwmSnippet path="/src/In.ProjectEKA.HipService/DataFlow/CollectHipService.cs" line="79">

---

In <SwmPath>[src/In.ProjectEKA.HipService/DataFlow/CollectHipService.cs](src/In.ProjectEKA.HipService/DataFlow/CollectHipService.cs)</SwmPath>, the <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/CollectHipService.cs" pos="79:9:9" line-data="        private static void LogDataRequest(TraceableDataRequest request)">`TraceableDataRequest`</SwmToken> is used in the <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/CollectHipService.cs" pos="79:7:7" line-data="        private static void LogDataRequest(TraceableDataRequest request)">`LogDataRequest`</SwmToken> method to log the details of the data request.

```c#
        private static void LogDataRequest(TraceableDataRequest request)
        {
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
