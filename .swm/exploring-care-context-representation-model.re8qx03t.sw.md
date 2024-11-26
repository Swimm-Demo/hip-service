---
title: Exploring Care Context Representation Model
---
# Care Context Representation Model

The Care Context Representation Model encapsulates the details of a care context associated with a patient.

It includes properties such as `ReferenceNumber`, `Display`, and `Type` to uniquely identify and describe the care context.

## Usage in Patient Enquiries

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="26:3:3" line-data="            IEnumerable&lt;CareContextRepresentation&gt; unlinkedCareContexts)">`CareContextRepresentation`</SwmToken> class is used in various parts of the system, including patient enquiries and link confirmations.

In patient enquiries, the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="26:3:3" line-data="            IEnumerable&lt;CareContextRepresentation&gt; unlinkedCareContexts)">`CareContextRepresentation`</SwmToken> class handles unlinked care contexts by representing them in the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="25:3:3" line-data="        public PatientEnquiryRepresentation ToPatientEnquiryRepresentation(">`PatientEnquiryRepresentation`</SwmToken> class.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" line="25">

---

For example, in the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="25:5:5" line-data="        public PatientEnquiryRepresentation ToPatientEnquiryRepresentation(">`ToPatientEnquiryRepresentation`</SwmToken> method, <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="26:3:3" line-data="            IEnumerable&lt;CareContextRepresentation&gt; unlinkedCareContexts)">`CareContextRepresentation`</SwmToken> is used to handle unlinked care contexts.

```c#
        public PatientEnquiryRepresentation ToPatientEnquiryRepresentation(
            IEnumerable<CareContextRepresentation> unlinkedCareContexts)
        {
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
