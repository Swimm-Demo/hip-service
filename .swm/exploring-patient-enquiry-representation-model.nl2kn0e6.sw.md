---
title: Exploring Patient Enquiry Representation Model
---
# Properties

# Overview

The Patient Enquiry Representation Model encapsulates the details of a patient's enquiry. It includes properties such as the reference number, display name, care contexts, and matched criteria.

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/PatientEnquiryRepresentation.cs" pos="19:5:5" line-data="        public string ReferenceNumber { get; }">`ReferenceNumber`</SwmToken> property holds a unique identifier for the patient enquiry, ensuring that each enquiry can be distinctly referenced.

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/PatientEnquiryRepresentation.cs" pos="14:1:1" line-data="            Display = display;">`Display`</SwmToken> property provides a human-readable name or description for the patient enquiry, making it easier to identify and understand.

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/PatientEnquiryRepresentation.cs" pos="15:1:1" line-data="            CareContexts = careContexts;">`CareContexts`</SwmToken> property is a collection of care context representations associated with the patient. These care contexts represent different healthcare settings or episodes of care related to the patient.

# Usage

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/PatientEnquiryRepresentation.cs" pos="16:1:1" line-data="            MatchedBy = matchedBy;">`MatchedBy`</SwmToken> property is a collection of strings that indicate the criteria by which the patient enquiry was matched. This could include demographic details, health IDs, or other identifiers.

The <SwmToken path="src/In.ProjectEKA.HipService/Discovery/DiscoveryUseCase.cs" pos="11:7:7" line-data="        public static ValueTuple&lt;PatientEnquiryRepresentation, ErrorRepresentation&gt; DiscoverPatient(">`PatientEnquiryRepresentation`</SwmToken> class is utilized in various parts of the codebase to represent and handle patient enquiries during the discovery process.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Discovery/DiscoveryUseCase.cs" line="11">

---

For example, the <SwmToken path="src/In.ProjectEKA.HipService/Discovery/DiscoveryUseCase.cs" pos="11:13:13" line-data="        public static ValueTuple&lt;PatientEnquiryRepresentation, ErrorRepresentation&gt; DiscoverPatient(">`DiscoverPatient`</SwmToken> method in the <SwmToken path="src/In.ProjectEKA.HipService/Discovery/DiscoveryUseCase.cs" pos="9:7:7" line-data="    public static class DiscoveryUseCase">`DiscoveryUseCase`</SwmToken> class uses <SwmToken path="src/In.ProjectEKA.HipService/Discovery/DiscoveryUseCase.cs" pos="11:7:7" line-data="        public static ValueTuple&lt;PatientEnquiryRepresentation, ErrorRepresentation&gt; DiscoverPatient(">`PatientEnquiryRepresentation`</SwmToken> to discover patient details and handle errors if no patient is found.

```c#
        public static ValueTuple<PatientEnquiryRepresentation, ErrorRepresentation> DiscoverPatient(
            IEnumerable<PatientEnquiryRepresentation> patients)
        {
```

---

</SwmSnippet>

## <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/PatientEnquiryRepresentation.cs" pos="19:5:5" line-data="        public string ReferenceNumber { get; }">`ReferenceNumber`</SwmToken>

# Main Functions

There are several main functions in this class. Some of them are <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/PatientEnquiryRepresentation.cs" pos="19:5:5" line-data="        public string ReferenceNumber { get; }">`ReferenceNumber`</SwmToken>, Display, <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/PatientEnquiryRepresentation.cs" pos="15:1:1" line-data="            CareContexts = careContexts;">`CareContexts`</SwmToken>, and <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/PatientEnquiryRepresentation.cs" pos="16:1:1" line-data="            MatchedBy = matchedBy;">`MatchedBy`</SwmToken>. We will dive a little into each of them.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/PatientEnquiryRepresentation.cs" line="19">

---

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/PatientEnquiryRepresentation.cs" pos="19:5:5" line-data="        public string ReferenceNumber { get; }">`ReferenceNumber`</SwmToken> property holds a unique identifier for the patient enquiry, ensuring that each enquiry can be distinctly referenced.

```c#
        public string ReferenceNumber { get; }
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
