---
title: The Patient class
---
This document will cover the class <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" pos="1:8:8" line-data="namespace In.ProjectEKA.HipLibrary.Patient.Model">`Patient`</SwmToken> in the codebase. We will cover:

1. What is Patient
2. Variables and functions

## Variables and functions

## What is Patient

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" pos="1:8:8" line-data="namespace In.ProjectEKA.HipLibrary.Patient.Model">`Patient`</SwmToken> class in <SwmPath>[src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs](src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs)</SwmPath> represents a patient entity in the system. It is used to store and manage patient-related information such as identifiers, health details, contact information, and care contexts.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" line="25">

---

The function <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="25:5:5" line-data="        public PatientEnquiryRepresentation ToPatientEnquiryRepresentation(">`ToPatientEnquiryRepresentation`</SwmToken> is used to convert the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" pos="1:8:8" line-data="namespace In.ProjectEKA.HipLibrary.Patient.Model">`Patient`</SwmToken> object into a <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="25:3:3" line-data="        public PatientEnquiryRepresentation ToPatientEnquiryRepresentation(">`PatientEnquiryRepresentation`</SwmToken> object. This function takes an enumerable of unlinked care contexts as a parameter and returns a new <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="25:3:3" line-data="        public PatientEnquiryRepresentation ToPatientEnquiryRepresentation(">`PatientEnquiryRepresentation`</SwmToken> object.

```c#
        public PatientEnquiryRepresentation ToPatientEnquiryRepresentation(
            IEnumerable<CareContextRepresentation> unlinkedCareContexts)
        {
            return new PatientEnquiryRepresentation(
                Identifier,
                Name,
                unlinkedCareContexts,
                new[] {Match.ConsentManagerUserId.ToString()});
        }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" line="7">

---

The variable <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="7:5:5" line-data="        public string Identifier { get; set; }">`Identifier`</SwmToken> is used to store the unique identifier of the patient.

```c#
        public string Identifier { get; set; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" line="9">

---

The variable <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="9:5:5" line-data="        public string HealthNumber { get; set; }">`HealthNumber`</SwmToken> is used to store the health number of the patient.

```c#
        public string HealthNumber { get; set; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" line="11">

---

The variable <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="11:5:5" line-data="        public string HealthId { get; set; }">`HealthId`</SwmToken> is used to store the health ID of the patient.

```c#
        public string HealthId { get; set; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" line="13">

---

The variable <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="13:5:5" line-data="        public string Uuid { get; set; }">`Uuid`</SwmToken> is used to store the UUID of the patient.

```c#
        public string Uuid { get; set; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" line="15">

---

The variable <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="15:3:3" line-data="        public Gender? Gender { get; set; }">`Gender`</SwmToken> is used to store the gender of the patient. It is of type <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="15:3:4" line-data="        public Gender? Gender { get; set; }">`Gender?`</SwmToken>, indicating that it is a nullable type.

```c#
        public Gender? Gender { get; set; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" line="17">

---

The variable <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="17:5:5" line-data="        public string PhoneNumber { get; set; }">`PhoneNumber`</SwmToken> is used to store the phone number of the patient.

```c#
        public string PhoneNumber { get; set; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" line="19">

---

The variable <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="19:5:5" line-data="        public string Name { get; set; }">`Name`</SwmToken> is used to store the name of the patient.

```c#
        public string Name { get; set; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" line="21">

---

The variable <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="21:6:6" line-data="        public ushort? YearOfBirth { get; set; }">`YearOfBirth`</SwmToken> is used to store the year of birth of the patient. It is of type <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="21:3:4" line-data="        public ushort? YearOfBirth { get; set; }">`ushort?`</SwmToken>, indicating that it is a nullable type.

```c#
        public ushort? YearOfBirth { get; set; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" line="23">

---

The variable <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="23:8:8" line-data="        public IEnumerable&lt;CareContextRepresentation&gt; CareContexts { get; set; }">`CareContexts`</SwmToken> is used to store an enumerable of <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="23:5:5" line-data="        public IEnumerable&lt;CareContextRepresentation&gt; CareContexts { get; set; }">`CareContextRepresentation`</SwmToken> objects, representing the care contexts associated with the patient.

```c#
        public IEnumerable<CareContextRepresentation> CareContexts { get; set; }
```

---

</SwmSnippet>

# Usage

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" line="1">

---

## <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" pos="6:5:5" line-data="    public class TraceableDataRequest">`TraceableDataRequest`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" pos="1:8:8" line-data="namespace In.ProjectEKA.HipLibrary.Patient.Model">`Patient`</SwmToken> class is used in the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" pos="6:5:5" line-data="    public class TraceableDataRequest">`TraceableDataRequest`</SwmToken> class, which is part of the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" pos="1:2:10" line-data="namespace In.ProjectEKA.HipLibrary.Patient.Model">`In.ProjectEKA.HipLibrary.Patient.Model`</SwmToken> namespace. This class likely handles requests for traceable data related to patients.

```c#
namespace In.ProjectEKA.HipLibrary.Patient.Model
{
    using System.Collections.Generic;
    using System.Linq;
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
