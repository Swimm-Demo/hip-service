---
title: The Patient class
---
This document will cover the class <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="1:8:8" line-data="namespace In.ProjectEKA.HipLibrary.Patient.Model">`Patient`</SwmToken> in the file <SwmPath>[src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs](src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs)</SwmPath>. We will cover:

1. What is Patient
2. Variables and functions

# Variables and functions

# What is Patient

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="1:8:8" line-data="namespace In.ProjectEKA.HipLibrary.Patient.Model">`Patient`</SwmToken> class in <SwmPath>[src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs](src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs)</SwmPath> represents a patient entity with various properties. It is used to encapsulate all the necessary information about a patient, which is utilized in various operations such as patient discovery, linking care contexts, and managing patient data.

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

The variable <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="15:3:3" line-data="        public Gender? Gender { get; set; }">`Gender`</SwmToken> is used to store the gender of the patient.

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

The variable <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="21:6:6" line-data="        public ushort? YearOfBirth { get; set; }">`YearOfBirth`</SwmToken> is used to store the year of birth of the patient.

```c#
        public ushort? YearOfBirth { get; set; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" line="23">

---

The variable <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="23:8:8" line-data="        public IEnumerable&lt;CareContextRepresentation&gt; CareContexts { get; set; }">`CareContexts`</SwmToken> is used to store the care contexts associated with the patient.

```c#
        public IEnumerable<CareContextRepresentation> CareContexts { get; set; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" line="25">

---

# Function: <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="25:5:5" line-data="        public PatientEnquiryRepresentation ToPatientEnquiryRepresentation(">`ToPatientEnquiryRepresentation`</SwmToken>

The function <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="25:5:5" line-data="        public PatientEnquiryRepresentation ToPatientEnquiryRepresentation(">`ToPatientEnquiryRepresentation`</SwmToken> is used to convert the patient information into a <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="25:3:3" line-data="        public PatientEnquiryRepresentation ToPatientEnquiryRepresentation(">`PatientEnquiryRepresentation`</SwmToken> object. This function takes an enumerable of unlinked care contexts as a parameter and returns a new <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="25:3:3" line-data="        public PatientEnquiryRepresentation ToPatientEnquiryRepresentation(">`PatientEnquiryRepresentation`</SwmToken> object.

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

# Usage

## DiscoveryResponse

## TraceableDataRequest

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="1:8:8" line-data="namespace In.ProjectEKA.HipLibrary.Patient.Model">`Patient`</SwmToken> class is used in the `TraceableDataRequest` class, which is part of the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="1:2:10" line-data="namespace In.ProjectEKA.HipLibrary.Patient.Model">`In.ProjectEKA.HipLibrary.Patient.Model`</SwmToken> namespace. This indicates that <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="1:8:8" line-data="namespace In.ProjectEKA.HipLibrary.Patient.Model">`Patient`</SwmToken> is involved in handling data requests that need to be traceable.

## ErrorRepresentation

In the `DiscoveryResponse` class, also within the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="1:2:10" line-data="namespace In.ProjectEKA.HipLibrary.Patient.Model">`In.ProjectEKA.HipLibrary.Patient.Model`</SwmToken> namespace, <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="1:8:8" line-data="namespace In.ProjectEKA.HipLibrary.Patient.Model">`Patient`</SwmToken> is used to manage responses related to patient discovery. This suggests that <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="1:8:8" line-data="namespace In.ProjectEKA.HipLibrary.Patient.Model">`Patient`</SwmToken> plays a role in the discovery process of patient information.

## <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="23:5:5" line-data="        public IEnumerable&lt;CareContextRepresentation&gt; CareContexts { get; set; }">`CareContextRepresentation`</SwmToken>

The `ErrorRepresentation` class utilizes <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="1:8:8" line-data="namespace In.ProjectEKA.HipLibrary.Patient.Model">`Patient`</SwmToken> to represent errors that may occur during patient-related operations. This usage highlights the importance of <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="1:8:8" line-data="namespace In.ProjectEKA.HipLibrary.Patient.Model">`Patient`</SwmToken> in error handling and representation.

## IdentifierType

In the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="23:5:5" line-data="        public IEnumerable&lt;CareContextRepresentation&gt; CareContexts { get; set; }">`CareContextRepresentation`</SwmToken> class, <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="1:8:8" line-data="namespace In.ProjectEKA.HipLibrary.Patient.Model">`Patient`</SwmToken> is used to represent the care context of a patient. This shows that <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="1:8:8" line-data="namespace In.ProjectEKA.HipLibrary.Patient.Model">`Patient`</SwmToken> is integral to managing and representing the care contexts associated with patients.

## GrantedContext

The `IdentifierType` enum, within the same namespace, uses <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="1:8:8" line-data="namespace In.ProjectEKA.HipLibrary.Patient.Model">`Patient`</SwmToken> to define various types of identifiers that can be associated with a patient. This indicates that <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="1:8:8" line-data="namespace In.ProjectEKA.HipLibrary.Patient.Model">`Patient`</SwmToken> is crucial for managing patient identifiers.

## Match

The `GrantedContext` class uses <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="1:8:8" line-data="namespace In.ProjectEKA.HipLibrary.Patient.Model">`Patient`</SwmToken> to manage contexts that have been granted to a patient. This usage underscores the role of <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="1:8:8" line-data="namespace In.ProjectEKA.HipLibrary.Patient.Model">`Patient`</SwmToken> in handling granted contexts.

## LinkEnquiry

In the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="32:6:6" line-data="                new[] {Match.ConsentManagerUserId.ToString()});">`Match`</SwmToken> enum, <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="1:8:8" line-data="namespace In.ProjectEKA.HipLibrary.Patient.Model">`Patient`</SwmToken> is used to define matching criteria for patients. This highlights the role of <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="1:8:8" line-data="namespace In.ProjectEKA.HipLibrary.Patient.Model">`Patient`</SwmToken> in patient matching processes.

## KeyMaterial

The `LinkEnquiry` class uses <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="1:8:8" line-data="namespace In.ProjectEKA.HipLibrary.Patient.Model">`Patient`</SwmToken> to handle enquiries related to linking patient information. This shows that <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="1:8:8" line-data="namespace In.ProjectEKA.HipLibrary.Patient.Model">`Patient`</SwmToken> is essential for managing link enquiries.

## ErrorCode

In the `KeyMaterial` class, <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="1:8:8" line-data="namespace In.ProjectEKA.HipLibrary.Patient.Model">`Patient`</SwmToken> is used to manage key materials associated with patients. This indicates that <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="1:8:8" line-data="namespace In.ProjectEKA.HipLibrary.Patient.Model">`Patient`</SwmToken> is important for handling cryptographic key materials.

## <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="25:3:3" line-data="        public PatientEnquiryRepresentation ToPatientEnquiryRepresentation(">`PatientEnquiryRepresentation`</SwmToken>

The `ErrorCode` enum uses <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="1:8:8" line-data="namespace In.ProjectEKA.HipLibrary.Patient.Model">`Patient`</SwmToken> to define error codes related to patient operations. This highlights the role of <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="1:8:8" line-data="namespace In.ProjectEKA.HipLibrary.Patient.Model">`Patient`</SwmToken> in error code management.

## Entries

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="25:3:3" line-data="        public PatientEnquiryRepresentation ToPatientEnquiryRepresentation(">`PatientEnquiryRepresentation`</SwmToken> class uses <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="1:8:8" line-data="namespace In.ProjectEKA.HipLibrary.Patient.Model">`Patient`</SwmToken> to represent patient enquiries. This shows that <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="1:8:8" line-data="namespace In.ProjectEKA.HipLibrary.Patient.Model">`Patient`</SwmToken> is crucial for managing and representing patient enquiries.

## Identifier

In the `Entries` class, <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="1:8:8" line-data="namespace In.ProjectEKA.HipLibrary.Patient.Model">`Patient`</SwmToken> is used to manage entries related to patients. This indicates that <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="1:8:8" line-data="namespace In.ProjectEKA.HipLibrary.Patient.Model">`Patient`</SwmToken> is important for handling patient entries.

## LinkEnquiryRepresentation

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="7:5:5" line-data="        public string Identifier { get; set; }">`Identifier`</SwmToken> class uses <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="1:8:8" line-data="namespace In.ProjectEKA.HipLibrary.Patient.Model">`Patient`</SwmToken> to manage identifiers associated with patients. This highlights the role of <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="1:8:8" line-data="namespace In.ProjectEKA.HipLibrary.Patient.Model">`Patient`</SwmToken> in identifier management.

## CareContextEnquiry

The `LinkEnquiryRepresentation` class uses <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="1:8:8" line-data="namespace In.ProjectEKA.HipLibrary.Patient.Model">`Patient`</SwmToken> to represent link enquiries related to patients. This shows that <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="1:8:8" line-data="namespace In.ProjectEKA.HipLibrary.Patient.Model">`Patient`</SwmToken> is essential for managing and representing link enquiries.

## PatientLinkEnquiryRepresentation

In the `CareContextEnquiry` class, <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="1:8:8" line-data="namespace In.ProjectEKA.HipLibrary.Patient.Model">`Patient`</SwmToken> is used to handle enquiries related to patient care contexts. This indicates that <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="1:8:8" line-data="namespace In.ProjectEKA.HipLibrary.Patient.Model">`Patient`</SwmToken> is crucial for managing care context enquiries.

## LinkConfirmationRepresentation

The `PatientLinkEnquiryRepresentation` class uses <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="1:8:8" line-data="namespace In.ProjectEKA.HipLibrary.Patient.Model">`Patient`</SwmToken> to represent patient link enquiries. This highlights the role of <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="1:8:8" line-data="namespace In.ProjectEKA.HipLibrary.Patient.Model">`Patient`</SwmToken> in managing and representing link enquiries.

## PatientEnquiry

In the `LinkConfirmationRepresentation` class, <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="1:8:8" line-data="namespace In.ProjectEKA.HipLibrary.Patient.Model">`Patient`</SwmToken> is used to manage link confirmations related to patients. This shows that <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="1:8:8" line-data="namespace In.ProjectEKA.HipLibrary.Patient.Model">`Patient`</SwmToken> is important for handling link confirmations.

## Gender

The `PatientEnquiry` class uses <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="1:8:8" line-data="namespace In.ProjectEKA.HipLibrary.Patient.Model">`Patient`</SwmToken> to handle patient enquiries, including validation of patient information such as name, gender, and identifiers. This indicates that <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="1:8:8" line-data="namespace In.ProjectEKA.HipLibrary.Patient.Model">`Patient`</SwmToken> is crucial for managing and validating patient enquiries.

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
