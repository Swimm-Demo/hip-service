---
title: The CareContextRepresentation class
---
This document will cover the class <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/CareContextRepresentation.cs" pos="8:3:3" line-data="        public CareContextRepresentation(string referenceNumber, string display)">`CareContextRepresentation`</SwmToken>. We'll cover:

1. What is <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/CareContextRepresentation.cs" pos="8:3:3" line-data="        public CareContextRepresentation(string referenceNumber, string display)">`CareContextRepresentation`</SwmToken>
2. Variables and functions in <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/CareContextRepresentation.cs" pos="8:3:3" line-data="        public CareContextRepresentation(string referenceNumber, string display)">`CareContextRepresentation`</SwmToken>

# Variables and functions

# What is <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/CareContextRepresentation.cs" pos="8:3:3" line-data="        public CareContextRepresentation(string referenceNumber, string display)">`CareContextRepresentation`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/CareContextRepresentation.cs" pos="8:3:3" line-data="        public CareContextRepresentation(string referenceNumber, string display)">`CareContextRepresentation`</SwmToken> class is a model that encapsulates the details of a care context associated with a patient. It is used to uniquely identify and describe the care context within the healthcare system. This class is part of the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/CareContextRepresentation.cs" pos="3:2:10" line-data="namespace In.ProjectEKA.HipLibrary.Patient.Model">`In.ProjectEKA.HipLibrary.Patient.Model`</SwmToken> namespace and is utilized in various parts of the system to handle patient care contexts.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/CareContextRepresentation.cs" line="8">

---

The constructor <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/CareContextRepresentation.cs" pos="8:3:3" line-data="        public CareContextRepresentation(string referenceNumber, string display)">`CareContextRepresentation`</SwmToken> initializes the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/CareContextRepresentation.cs" pos="8:7:7" line-data="        public CareContextRepresentation(string referenceNumber, string display)">`referenceNumber`</SwmToken> and <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/CareContextRepresentation.cs" pos="8:12:12" line-data="        public CareContextRepresentation(string referenceNumber, string display)">`display`</SwmToken> properties.

```c#
        public CareContextRepresentation(string referenceNumber, string display)
        {
            ReferenceNumber = referenceNumber;
            Display = display;
        }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/CareContextRepresentation.cs" line="13">

---

The constructor <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/CareContextRepresentation.cs" pos="13:3:3" line-data="        public CareContextRepresentation(string referenceNumber, string display, string type)">`CareContextRepresentation`</SwmToken> initializes the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/CareContextRepresentation.cs" pos="13:7:7" line-data="        public CareContextRepresentation(string referenceNumber, string display, string type)">`referenceNumber`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/CareContextRepresentation.cs" pos="13:12:12" line-data="        public CareContextRepresentation(string referenceNumber, string display, string type)">`display`</SwmToken>, and <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/CareContextRepresentation.cs" pos="13:17:17" line-data="        public CareContextRepresentation(string referenceNumber, string display, string type)">`type`</SwmToken> properties.

```c#
        public CareContextRepresentation(string referenceNumber, string display, string type)
        {
            ReferenceNumber = referenceNumber;
            Display = display;
            Type = type;
        }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/CareContextRepresentation.cs" line="20">

---

The variable <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/CareContextRepresentation.cs" pos="20:5:5" line-data="        public string ReferenceNumber { get; }">`ReferenceNumber`</SwmToken> is used to store the reference number of the care context.

```c#
        public string ReferenceNumber { get; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/CareContextRepresentation.cs" line="22">

---

The variable <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/CareContextRepresentation.cs" pos="22:5:5" line-data="        public string Display { get; }">`Display`</SwmToken> is used to store the display name of the care context.

```c#
        public string Display { get; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/CareContextRepresentation.cs" line="23">

---

The variable <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/CareContextRepresentation.cs" pos="23:5:5" line-data="        public string Type { get; }">`Type`</SwmToken> is used to store the type of the care context.

```c#
        public string Type { get; }
```

---

</SwmSnippet>

# Usage

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/ICareContextRepository.cs" line="6">

---

## <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/ICareContextRepository.cs" pos="7:5:5" line-data="    public interface ICareContextRepository">`ICareContextRepository`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/ICareContextRepository.cs" pos="9:5:5" line-data="        Task&lt;IEnumerable&lt;CareContextRepresentation&gt;&gt; GetCareContexts(string patientReferenceNumber);">`CareContextRepresentation`</SwmToken> class is used in the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/ICareContextRepository.cs" pos="7:5:5" line-data="    public interface ICareContextRepository">`ICareContextRepository`</SwmToken> interface, where it is returned as a collection from the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/ICareContextRepository.cs" pos="9:8:8" line-data="        Task&lt;IEnumerable&lt;CareContextRepresentation&gt;&gt; GetCareContexts(string patientReferenceNumber);">`GetCareContexts`</SwmToken> method. This method retrieves care contexts associated with a specific patient reference number.

```c#
{
    public interface ICareContextRepository
    {
        Task<IEnumerable<CareContextRepresentation>> GetCareContexts(string patientReferenceNumber);
    }
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
