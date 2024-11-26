---
title: Basic Concepts of Discovery Request Model
---
# Basic Concepts of Discovery Request Model

The Discovery Request Model is essential for initiating a patient discovery process. It encapsulates all the necessary details required for this process.

## <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DiscoveryRequest.cs" pos="10:3:3" line-data="        public PatientEnquiry Patient { get; }">`PatientEnquiry`</SwmToken> Object

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DiscoveryRequest.cs" pos="10:3:3" line-data="        public PatientEnquiry Patient { get; }">`PatientEnquiry`</SwmToken> object holds the patient's details necessary for the discovery. This object is a crucial part of the Discovery Request Model as it provides the information needed to identify the patient.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/DiscoveryRequest.cs" line="10">

---

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DiscoveryRequest.cs" pos="10:5:5" line-data="        public PatientEnquiry Patient { get; }">`Patient`</SwmToken> property in the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DiscoveryRequest.cs" pos="20:3:3" line-data="        public DiscoveryRequest(PatientEnquiry patient, string requestId, string transactionId, DateTime timestamp)">`DiscoveryRequest`</SwmToken> class holds the patient's details necessary for the discovery process.

```c#
        public PatientEnquiry Patient { get; }
```

---

</SwmSnippet>

## <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DiscoveryRequest.cs" pos="23:1:1" line-data="            RequestId = requestId;">`RequestId`</SwmToken> Property

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DiscoveryRequest.cs" pos="23:1:1" line-data="            RequestId = requestId;">`RequestId`</SwmToken> property uniquely identifies the discovery request. It is a required field, ensuring that each discovery request can be distinctly recognized.

## <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DiscoveryRequest.cs" pos="16:5:5" line-data="        public string TransactionId { get; }">`TransactionId`</SwmToken> Property

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DiscoveryRequest.cs" pos="16:5:5" line-data="        public string TransactionId { get; }">`TransactionId`</SwmToken> property ensures the uniqueness of the transaction. It has a maximum length of 50 characters to maintain consistency and avoid errors.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/DiscoveryRequest.cs" line="15">

---

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DiscoveryRequest.cs" pos="16:5:5" line-data="        public string TransactionId { get; }">`TransactionId`</SwmToken> property is required and has a maximum length of 50 characters, ensuring the uniqueness of the transaction.

```c#
        [Required, MaxLength(50)]
        public string TransactionId { get; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/DiscoveryRequest.cs" line="18">

---

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DiscoveryRequest.cs" pos="18:5:5" line-data="        public DateTime Timestamp { get; }">`Timestamp`</SwmToken> property records the creation date and time of the discovery request.

```c#
        public DateTime Timestamp { get; }
```

---

</SwmSnippet>

## <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DiscoveryRequest.cs" pos="20:3:3" line-data="        public DiscoveryRequest(PatientEnquiry patient, string requestId, string transactionId, DateTime timestamp)">`DiscoveryRequest`</SwmToken> Constructor

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DiscoveryRequest.cs" pos="20:3:3" line-data="        public DiscoveryRequest(PatientEnquiry patient, string requestId, string transactionId, DateTime timestamp)">`DiscoveryRequest`</SwmToken> constructor initializes the properties, ensuring that all necessary information is provided when a new discovery request is created.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/DiscoveryRequest.cs" line="20">

---

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DiscoveryRequest.cs" pos="20:3:3" line-data="        public DiscoveryRequest(PatientEnquiry patient, string requestId, string transactionId, DateTime timestamp)">`DiscoveryRequest`</SwmToken> constructor initializes the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DiscoveryRequest.cs" pos="22:1:1" line-data="            Patient = patient;">`Patient`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DiscoveryRequest.cs" pos="23:1:1" line-data="            RequestId = requestId;">`RequestId`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DiscoveryRequest.cs" pos="24:1:1" line-data="            TransactionId = transactionId;">`TransactionId`</SwmToken>, and <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DiscoveryRequest.cs" pos="25:1:1" line-data="            Timestamp = timestamp;">`Timestamp`</SwmToken> properties.

```c#
        public DiscoveryRequest(PatientEnquiry patient, string requestId, string transactionId, DateTime timestamp)
        {
            Patient = patient;
            RequestId = requestId;
            TransactionId = transactionId;
            Timestamp = timestamp;
        }
```

---

</SwmSnippet>

## Usage in <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/IMatchingRepository.cs" pos="7:5:5" line-data="    public interface IMatchingRepository">`IMatchingRepository`</SwmToken>

The Discovery Request Model is used in the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/IMatchingRepository.cs" pos="9:8:8" line-data="        Task&lt;IQueryable&lt;Patient&gt;&gt; Where(DiscoveryRequest request);">`Where`</SwmToken> method of the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/IMatchingRepository.cs" pos="7:5:5" line-data="    public interface IMatchingRepository">`IMatchingRepository`</SwmToken> interface to filter patients based on the discovery request details.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Matcher/IMatchingRepository.cs" line="8">

---

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/IMatchingRepository.cs" pos="9:8:8" line-data="        Task&lt;IQueryable&lt;Patient&gt;&gt; Where(DiscoveryRequest request);">`Where`</SwmToken> method in the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/IMatchingRepository.cs" pos="7:5:5" line-data="    public interface IMatchingRepository">`IMatchingRepository`</SwmToken> interface uses the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/IMatchingRepository.cs" pos="9:10:10" line-data="        Task&lt;IQueryable&lt;Patient&gt;&gt; Where(DiscoveryRequest request);">`DiscoveryRequest`</SwmToken> to filter patients.

```c#
    {
        Task<IQueryable<Patient>> Where(DiscoveryRequest request);
    }
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
