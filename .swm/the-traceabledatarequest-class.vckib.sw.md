---
title: The TraceableDataRequest class
---
This document will cover the class <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" pos="8:3:3" line-data="        public TraceableDataRequest(">`TraceableDataRequest`</SwmToken> in detail. We will cover:

1. What is <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" pos="8:3:3" line-data="        public TraceableDataRequest(">`TraceableDataRequest`</SwmToken>
2. Variables and functions

# Variables and functions

# What is <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" pos="8:3:3" line-data="        public TraceableDataRequest(">`TraceableDataRequest`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" pos="8:3:3" line-data="        public TraceableDataRequest(">`TraceableDataRequest`</SwmToken> class is used to create instances of data requests that can be traced back using the provided identifiers and context information. This ensures that each data request can be uniquely identified and tracked throughout its lifecycle.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" line="8">

---

The constructor <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" pos="8:3:3" line-data="        public TraceableDataRequest(">`TraceableDataRequest`</SwmToken> initializes the object with various parameters such as care contexts, date range, data push URL, health information types, transaction ID, key material, consent manager ID, consent ID, CM suffix, correlation ID, and patient UUID.

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
        {
            CareContexts = careContexts;
            DateRange = dateRange;
            DataPushUrl = dataPushUrl;
            HiType = hiType;
            TransactionId = transactionId;
            KeyMaterial = keyMaterial;
            ConsentManagerId = consentManagerId;
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" line="47">

---

The function <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" pos="47:7:7" line-data="        public override string ToString()">`ToString`</SwmToken> overrides the default <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" pos="47:7:7" line-data="        public override string ToString()">`ToString`</SwmToken> method to provide a string representation of the data request, including the health information types.

```c#
        public override string ToString()
        {
            var hiTypes = HiType
                .Select(hiType => hiType.ToString())
                .Aggregate("", (source, value) => source + " " + value);
            return $"Data Request with {hiTypes}";
        }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" line="35">

---

The variable <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" pos="35:8:8" line-data="        public IEnumerable&lt;GrantedContext&gt; CareContexts { get; }">`CareContexts`</SwmToken> is used to store the care contexts associated with the data request.

```c#
        public IEnumerable<GrantedContext> CareContexts { get; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" line="36">

---

The variable <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" pos="36:3:3" line-data="        public DateRange DateRange { get; }">`DateRange`</SwmToken> is used to store the date range for which the data is requested.

```c#
        public DateRange DateRange { get; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" line="37">

---

The variable <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" pos="37:5:5" line-data="        public string DataPushUrl { get; }">`DataPushUrl`</SwmToken> is used to store the URL to which the data will be pushed.

```c#
        public string DataPushUrl { get; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" line="38">

---

The variable <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" pos="38:5:5" line-data="        public IEnumerable&lt;HiType&gt; HiType { get; }">`HiType`</SwmToken> is used to store the types of health information being requested.

```c#
        public IEnumerable<HiType> HiType { get; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" line="39">

---

The variable <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" pos="39:5:5" line-data="        public string TransactionId { get; }">`TransactionId`</SwmToken> is used to store the transaction ID associated with the data request.

```c#
        public string TransactionId { get; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" line="40">

---

The variable <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" pos="40:3:3" line-data="        public KeyMaterial KeyMaterial { get; }">`KeyMaterial`</SwmToken> is used to store the key material required for the data request.

```c#
        public KeyMaterial KeyMaterial { get; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" line="41">

---

The variable <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" pos="41:5:5" line-data="        public string ConsentManagerId { get; }">`ConsentManagerId`</SwmToken> is used to store the ID of the consent manager.

```c#
        public string ConsentManagerId { get; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" line="42">

---

The variable <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" pos="42:5:5" line-data="        public string ConsentId { get; }">`ConsentId`</SwmToken> is used to store the ID of the consent.

```c#
        public string ConsentId { get; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" line="43">

---

The variable <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" pos="43:5:5" line-data="        public string CmSuffix { get; }">`CmSuffix`</SwmToken> is used to store the suffix of the consent manager.

```c#
        public string CmSuffix { get; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" line="44">

---

The variable <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" pos="44:5:5" line-data="        public string CorrelationId { get; }">`CorrelationId`</SwmToken> is used to store the correlation ID associated with the data request.

```c#
        public string CorrelationId { get; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" line="45">

---

The variable <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" pos="45:5:5" line-data="        public string PatientUuid { get; }">`PatientUuid`</SwmToken> is used to store the UUID of the patient.

```c#
        public string PatientUuid { get; }
```

---

</SwmSnippet>

# Usage

## Collect Class

## ICollect Interface

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" pos="8:3:3" line-data="        public TraceableDataRequest(">`TraceableDataRequest`</SwmToken> is used in the `ICollect` interface, where it is passed as a parameter to the `CollectData` method. This method is responsible for collecting data based on the provided <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" pos="8:3:3" line-data="        public TraceableDataRequest(">`TraceableDataRequest`</SwmToken>.

## DataFlowMessageHandler

In the `Collect` class, the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" pos="8:3:3" line-data="        public TraceableDataRequest(">`TraceableDataRequest`</SwmToken> is used in the `CollectData` method to find patient data and log the data request. The `FindPatientData` method takes a <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" pos="8:3:3" line-data="        public TraceableDataRequest(">`TraceableDataRequest`</SwmToken> as an argument to retrieve the relevant patient data.

## DataFlowClient

The `DataFlowMessageHandler` class uses the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" pos="8:3:3" line-data="        public TraceableDataRequest(">`TraceableDataRequest`</SwmToken> in the `HandleDataFlowMessage` method. This method handles the data flow message by collecting data using the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" pos="8:3:3" line-data="        public TraceableDataRequest(">`TraceableDataRequest`</SwmToken>.

## MessagingQueueListener

In the `DataFlowClient` class, the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" pos="8:3:3" line-data="        public TraceableDataRequest(">`TraceableDataRequest`</SwmToken> is used in the `SendDataToHiu` method. This method sends data to the Health Information User (HIU) based on the provided <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" pos="8:3:3" line-data="        public TraceableDataRequest(">`TraceableDataRequest`</SwmToken>.

## CollectHipService

The `MessagingQueueListener` class uses the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" pos="8:3:3" line-data="        public TraceableDataRequest(">`TraceableDataRequest`</SwmToken> to deserialize messages from the queue. The deserialized <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" pos="8:3:3" line-data="        public TraceableDataRequest(">`TraceableDataRequest`</SwmToken> is then handled by the `DataFlowMessageHandler`.

## ICollectHipService Interface

In the `CollectHipService` class, the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" pos="8:3:3" line-data="        public TraceableDataRequest(">`TraceableDataRequest`</SwmToken> is used in the `CollectData` method to collect patient data. The `FindPatientData` method also uses the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" pos="8:3:3" line-data="        public TraceableDataRequest(">`TraceableDataRequest`</SwmToken> to find and log patient data.

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
