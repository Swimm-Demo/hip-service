---
title: Introduction to Discovery Request Model
---
## <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DiscoveryRequest.cs" pos="10:3:3" line-data="        public PatientEnquiry Patient { get; }">`PatientEnquiry`</SwmToken> Object

# Introduction to Discovery Request Model

The Discovery Request Model is essential for initiating a patient discovery process. It encapsulates all the necessary details required for this process.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/DiscoveryRequest.cs" line="10">

---

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DiscoveryRequest.cs" pos="10:3:3" line-data="        public PatientEnquiry Patient { get; }">`PatientEnquiry`</SwmToken> object holds the patient's details necessary for the discovery. This object is a crucial part of the Discovery Request Model as it provides the information needed to identify the patient.

```c#
        public PatientEnquiry Patient { get; }

```

---

</SwmSnippet>

## <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DiscoveryRequest.cs" pos="16:5:5" line-data="        public string TransactionId { get; }">`TransactionId`</SwmToken> Property

## <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DiscoveryRequest.cs" pos="13:5:5" line-data="        public string RequestId { get; }">`RequestId`</SwmToken> Property

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DiscoveryRequest.cs" pos="13:5:5" line-data="        public string RequestId { get; }">`RequestId`</SwmToken> property is required and must be provided. It uniquely identifies each discovery request.

## Timestamp Property

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DiscoveryRequest.cs" pos="16:5:5" line-data="        public string TransactionId { get; }">`TransactionId`</SwmToken> property is also required and has a maximum length of 50 characters. It is used to track the transaction associated with the discovery request.

## How to Use Discovery Request

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DiscoveryRequest.cs" pos="18:5:5" line-data="        public DateTime Timestamp { get; }">`Timestamp`</SwmToken> property records the date and time when the discovery request was created.

## Where Discovery Request is Used

To use a Discovery Request, you need to create an instance of it with the required details. This includes the patient's information encapsulated in a <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DiscoveryRequest.cs" pos="10:3:3" line-data="        public PatientEnquiry Patient { get; }">`PatientEnquiry`</SwmToken> object, a unique <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DiscoveryRequest.cs" pos="13:5:5" line-data="        public string RequestId { get; }">`RequestId`</SwmToken>, a <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DiscoveryRequest.cs" pos="16:5:5" line-data="        public string TransactionId { get; }">`TransactionId`</SwmToken> for tracking the transaction, and a <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DiscoveryRequest.cs" pos="18:5:5" line-data="        public DateTime Timestamp { get; }">`Timestamp`</SwmToken> indicating when the request was created.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Matcher/IMatchingRepository.cs" line="8">

---

Discovery Requests are used in the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/IMatchingRepository.cs" pos="9:8:8" line-data="        Task&lt;IQueryable&lt;Patient&gt;&gt; Where(DiscoveryRequest request);">`Where`</SwmToken> method of the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/IMatchingRepository.cs" pos="7:5:5" line-data="    public interface IMatchingRepository">`IMatchingRepository`</SwmToken> interface to filter patients based on the discovery request details.

```c#
    {
        Task<IQueryable<Patient>> Where(DiscoveryRequest request);
    }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Matcher/IMatchingRepository.cs" line="8">

---

## Example Usage

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/IMatchingRepository.cs" pos="9:8:8" line-data="        Task&lt;IQueryable&lt;Patient&gt;&gt; Where(DiscoveryRequest request);">`Where`</SwmToken> method in the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/IMatchingRepository.cs" pos="7:5:5" line-data="    public interface IMatchingRepository">`IMatchingRepository`</SwmToken> interface uses the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/IMatchingRepository.cs" pos="9:10:10" line-data="        Task&lt;IQueryable&lt;Patient&gt;&gt; Where(DiscoveryRequest request);">`DiscoveryRequest`</SwmToken> to filter patients. Here is an example of how it is defined:

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
