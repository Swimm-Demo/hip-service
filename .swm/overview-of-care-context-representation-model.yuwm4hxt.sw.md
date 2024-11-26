---
title: Overview of Care Context Representation Model
---
# Overview of Care Context Representation Model

The Care Context Representation Model encapsulates the details of a care context associated with a patient. It includes properties such as <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/CareContextRepresentation.cs" pos="10:1:1" line-data="            ReferenceNumber = referenceNumber;">`ReferenceNumber`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/CareContextRepresentation.cs" pos="11:1:1" line-data="            Display = display;">`Display`</SwmToken>, and <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/CareContextRepresentation.cs" pos="17:1:1" line-data="            Type = type;">`Type`</SwmToken> to uniquely identify and describe the care context.

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/CareContextRepresentation.cs" pos="10:1:1" line-data="            ReferenceNumber = referenceNumber;">`ReferenceNumber`</SwmToken> is a unique identifier for the care context, while <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/CareContextRepresentation.cs" pos="11:1:1" line-data="            Display = display;">`Display`</SwmToken> provides a human-readable description. The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/CareContextRepresentation.cs" pos="17:1:1" line-data="            Type = type;">`Type`</SwmToken> property categorizes the care context, providing additional context about its nature.

This model is used in various parts of the application, such as in patient enquiries, link confirmations, and care context repositories. It is essential for linking patient data across different systems and ensuring accurate and consistent data representation.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" line="25">

---

## Usage in Patient Enquiries

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="26:3:3" line-data="            IEnumerable&lt;CareContextRepresentation&gt; unlinkedCareContexts)">`CareContextRepresentation`</SwmToken> is used in the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="25:5:5" line-data="        public PatientEnquiryRepresentation ToPatientEnquiryRepresentation(">`ToPatientEnquiryRepresentation`</SwmToken> method to handle unlinked care contexts.

```c#
        public PatientEnquiryRepresentation ToPatientEnquiryRepresentation(
            IEnumerable<CareContextRepresentation> unlinkedCareContexts)
        {
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/LinkConfirmationRepresentation.cs" line="23">

---

## Usage in Link Confirmations

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/LinkConfirmationRepresentation.cs" pos="23:5:5" line-data="        public IEnumerable&lt;CareContextRepresentation&gt; CareContexts { get; }">`CareContextRepresentation`</SwmToken> is used in the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/LinkConfirmationRepresentation.cs" pos="5:5:5" line-data="    public class LinkConfirmationRepresentation">`LinkConfirmationRepresentation`</SwmToken> class to represent care contexts.

```c#
        public IEnumerable<CareContextRepresentation> CareContexts { get; }
    }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/PatientEnquiryRepresentation.cs" line="23">

---

## Usage in Patient Enquiry Representation

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/PatientEnquiryRepresentation.cs" pos="23:5:5" line-data="        public IEnumerable&lt;CareContextRepresentation&gt; CareContexts { get; }">`CareContextRepresentation`</SwmToken> is used in the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="25:3:3" line-data="        public PatientEnquiryRepresentation ToPatientEnquiryRepresentation(">`PatientEnquiryRepresentation`</SwmToken> class to represent care contexts.

```c#
        public IEnumerable<CareContextRepresentation> CareContexts { get; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/ICareContextRepository.cs" line="8">

---

## Usage in Care Context Repository

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/ICareContextRepository.cs" pos="9:5:5" line-data="        Task&lt;IEnumerable&lt;CareContextRepresentation&gt;&gt; GetCareContexts(string patientReferenceNumber);">`CareContextRepresentation`</SwmToken> is used in the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/ICareContextRepository.cs" pos="7:5:5" line-data="    public interface ICareContextRepository">`ICareContextRepository`</SwmToken> interface to retrieve care contexts for a patient.

```c#
    {
        Task<IEnumerable<CareContextRepresentation>> GetCareContexts(string patientReferenceNumber);
    }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/CareContextRepresentation.cs" line="5">

---

## <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/CareContextRepresentation.cs" pos="5:5:5" line-data="    public class CareContextRepresentation">`CareContextRepresentation`</SwmToken> Class

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/CareContextRepresentation.cs" pos="5:5:5" line-data="    public class CareContextRepresentation">`CareContextRepresentation`</SwmToken> class encapsulates the details of a care context associated with a patient. It includes properties such as <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/CareContextRepresentation.cs" pos="10:1:1" line-data="            ReferenceNumber = referenceNumber;">`ReferenceNumber`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/CareContextRepresentation.cs" pos="11:1:1" line-data="            Display = display;">`Display`</SwmToken>, and <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/CareContextRepresentation.cs" pos="17:1:1" line-data="            Type = type;">`Type`</SwmToken> to uniquely identify and describe the care context.

```c#
    public class CareContextRepresentation
    {
        [JsonConstructor]
        public CareContextRepresentation(string referenceNumber, string display)
        {
            ReferenceNumber = referenceNumber;
            Display = display;
        }
        public CareContextRepresentation(string referenceNumber, string display, string type)
        {
            ReferenceNumber = referenceNumber;
            Display = display;
            Type = type;
        }

        public string ReferenceNumber { get; }

        public string Display { get; }
        public string Type { get; }
    }
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
