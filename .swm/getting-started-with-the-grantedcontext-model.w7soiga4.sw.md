---
title: Getting Started with the GrantedContext Model
---
# Properties

# Introduction

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/GrantedContext.cs" pos="3:5:5" line-data="    public class GrantedContext">`GrantedContext`</SwmToken> model represents the context granted to a patient for accessing their health information. It is a crucial part of the HIP service, ensuring that patients can securely access their medical data.

# Constructor

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/GrantedContext.cs" pos="3:5:5" line-data="    public class GrantedContext">`GrantedContext`</SwmToken> model contains two main properties: <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/GrantedContext.cs" pos="7:1:1" line-data="            PatientReference = patientReference;">`PatientReference`</SwmToken> and <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/GrantedContext.cs" pos="8:1:1" line-data="            CareContextReference = careContextReference;">`CareContextReference`</SwmToken>. These properties store references to the patient and the specific care context, respectively.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/GrantedContext.cs" line="3">

---

The constructor of the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/GrantedContext.cs" pos="3:5:5" line-data="    public class GrantedContext">`GrantedContext`</SwmToken> class initializes the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/GrantedContext.cs" pos="7:1:1" line-data="            PatientReference = patientReference;">`PatientReference`</SwmToken> and <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/GrantedContext.cs" pos="8:1:1" line-data="            CareContextReference = careContextReference;">`CareContextReference`</SwmToken> properties with the provided patient and care context references.

```c#
    public class GrantedContext
    {
        public GrantedContext(string patientReference, string careContextReference)
        {
            PatientReference = patientReference;
            CareContextReference = careContextReference;
        }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/DataRequest.cs" line="8">

---

# Usage in <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DataRequest.cs" pos="8:3:3" line-data="        public DataRequest(">`DataRequest`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DataRequest.cs" pos="9:3:3" line-data="            IEnumerable&lt;GrantedContext&gt; careContexts,">`GrantedContext`</SwmToken> model is used in the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DataRequest.cs" pos="8:3:3" line-data="        public DataRequest(">`DataRequest`</SwmToken> class to manage care contexts and date ranges. This ensures that the data requests are properly scoped to the granted contexts.

```c#
        public DataRequest(
            IEnumerable<GrantedContext> careContexts,
            DateRange dateRange,
            string dataPushUrl,
            IEnumerable<HiType> hiType,
            string transactionId,
            KeyMaterial keyMaterial,
            string consentManagerId,
            string consentId,
            string cmSuffix)
        {
            CareContexts = careContexts;
            DateRange = dateRange;
            DataPushUrl = dataPushUrl;
            HiType = hiType;
            TransactionId = transactionId;
            KeyMaterial = keyMaterial;
            ConsentManagerId = consentManagerId;
            ConsentId = consentId;
            CmSuffix = cmSuffix;
        }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" line="35">

---

# Usage in <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" pos="6:5:5" line-data="    public class TraceableDataRequest">`TraceableDataRequest`</SwmToken>

Similarly, the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" pos="35:5:5" line-data="        public IEnumerable&lt;GrantedContext&gt; CareContexts { get; }">`GrantedContext`</SwmToken> model is used in the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" pos="6:5:5" line-data="    public class TraceableDataRequest">`TraceableDataRequest`</SwmToken> class to manage care contexts and date ranges, providing traceability for data requests.

```c#
        public IEnumerable<GrantedContext> CareContexts { get; }
        public DateRange DateRange { get; }
```

---

</SwmSnippet>

# Granted Context Endpoints

# Main Functions

The main functions of the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/GrantedContext.cs" pos="3:5:5" line-data="    public class GrantedContext">`GrantedContext`</SwmToken> class include the constructor, <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/GrantedContext.cs" pos="7:1:1" line-data="            PatientReference = patientReference;">`PatientReference`</SwmToken>, and <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/GrantedContext.cs" pos="8:1:1" line-data="            CareContextReference = careContextReference;">`CareContextReference`</SwmToken>. These functions are essential for initializing and managing the granted contexts.

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/GrantedContext.cs" pos="3:5:5" line-data="    public class GrantedContext">`GrantedContext`</SwmToken> model is used in various endpoints to represent the granted care contexts for a data request. This ensures that the endpoints can accurately reflect the granted contexts for patients.

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
