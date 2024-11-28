---
title: Overview of Patient Model
---
## Properties of the Patient Class

# Overview of Patient Model

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="1:8:8" line-data="namespace In.ProjectEKA.HipLibrary.Patient.Model">`Patient`</SwmToken> class represents a patient entity with various properties that store patient-related information.

### Identifier

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="1:8:8" line-data="namespace In.ProjectEKA.HipLibrary.Patient.Model">`Patient`</SwmToken> class includes several properties such as <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="29:1:1" line-data="                Identifier,">`Identifier`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="9:5:5" line-data="        public string HealthNumber { get; set; }">`HealthNumber`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="11:5:5" line-data="        public string HealthId { get; set; }">`HealthId`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="13:5:5" line-data="        public string Uuid { get; set; }">`Uuid`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="15:3:3" line-data="        public Gender? Gender { get; set; }">`Gender`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="17:5:5" line-data="        public string PhoneNumber { get; set; }">`PhoneNumber`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="30:1:1" line-data="                Name,">`Name`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="21:6:6" line-data="        public ushort? YearOfBirth { get; set; }">`YearOfBirth`</SwmToken>, and <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="23:8:8" line-data="        public IEnumerable&lt;CareContextRepresentation&gt; CareContexts { get; set; }">`CareContexts`</SwmToken>.

### <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="9:5:5" line-data="        public string HealthNumber { get; set; }">`HealthNumber`</SwmToken> and <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="11:5:5" line-data="        public string HealthId { get; set; }">`HealthId`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="29:1:1" line-data="                Identifier,">`Identifier`</SwmToken> property is used to uniquely identify a patient.

### Uuid

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="9:5:5" line-data="        public string HealthNumber { get; set; }">`HealthNumber`</SwmToken> and <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="11:5:5" line-data="        public string HealthId { get; set; }">`HealthId`</SwmToken> properties store the patient's health number and health ID, respectively.

### Gender and <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="17:5:5" line-data="        public string PhoneNumber { get; set; }">`PhoneNumber`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="13:5:5" line-data="        public string Uuid { get; set; }">`Uuid`</SwmToken> property holds the universally unique identifier for the patient.

### Name and <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="21:6:6" line-data="        public ushort? YearOfBirth { get; set; }">`YearOfBirth`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="15:3:3" line-data="        public Gender? Gender { get; set; }">`Gender`</SwmToken> property indicates the gender of the patient, while the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="17:5:5" line-data="        public string PhoneNumber { get; set; }">`PhoneNumber`</SwmToken> property stores the patient's contact number.

### <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="23:8:8" line-data="        public IEnumerable&lt;CareContextRepresentation&gt; CareContexts { get; set; }">`CareContexts`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="30:1:1" line-data="                Name,">`Name`</SwmToken> property contains the patient's name, and the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="21:6:6" line-data="        public ushort? YearOfBirth { get; set; }">`YearOfBirth`</SwmToken> property records the patient's year of birth.

## Usage of the Patient Class

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="23:8:8" line-data="        public IEnumerable&lt;CareContextRepresentation&gt; CareContexts { get; set; }">`CareContexts`</SwmToken> property is a collection of <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="26:3:3" line-data="            IEnumerable&lt;CareContextRepresentation&gt; unlinkedCareContexts)">`CareContextRepresentation`</SwmToken> objects, representing the different care contexts associated with the patient.

## Example Usage

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="1:8:8" line-data="namespace In.ProjectEKA.HipLibrary.Patient.Model">`Patient`</SwmToken> class is used in various files such as <SwmPath>[src/In.ProjectEKA.HipLibrary/Patient/Model/PatientEnquiry.cs](src/In.ProjectEKA.HipLibrary/Patient/Model/PatientEnquiry.cs)</SwmPath>, <SwmPath>[src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs](src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs)</SwmPath>, <SwmPath>[src/In.ProjectEKA.HipLibrary/Patient/IPatientRepository.cs](src/In.ProjectEKA.HipLibrary/Patient/IPatientRepository.cs)</SwmPath>, <SwmPath>[src/In.ProjectEKA.HipLibrary/Patient/ICareContextRepository.cs](src/In.ProjectEKA.HipLibrary/Patient/ICareContextRepository.cs)</SwmPath>, <SwmPath>[src/In.ProjectEKA.HipLibrary/Matcher/IMatchingRepository.cs](src/In.ProjectEKA.HipLibrary/Matcher/IMatchingRepository.cs)</SwmPath>, <SwmPath>[src/In.ProjectEKA.HipLibrary/Matcher/IIdentifierMatcher.cs](src/In.ProjectEKA.HipLibrary/Matcher/IIdentifierMatcher.cs)</SwmPath>, <SwmPath>[src/In.ProjectEKA.HipLibrary/Matcher/MedicalRecordMatcher.cs](src/In.ProjectEKA.HipLibrary/Matcher/MedicalRecordMatcher.cs)</SwmPath>, <SwmPath>[src/In.ProjectEKA.HipLibrary/Matcher/HealthNumberMatcher.cs](src/In.ProjectEKA.HipLibrary/Matcher/HealthNumberMatcher.cs)</SwmPath>, <SwmPath>[src/In.ProjectEKA.HipLibrary/Matcher/EmptyMatcher.cs](src/In.ProjectEKA.HipLibrary/Matcher/EmptyMatcher.cs)</SwmPath>, <SwmPath>[src/In.ProjectEKA.HipLibrary/Matcher/PhoneNumberMatcher.cs](src/In.ProjectEKA.HipLibrary/Matcher/PhoneNumberMatcher.cs)</SwmPath>, <SwmPath>[src/In.ProjectEKA.HipLibrary/Patient/Model/LinkReferenceMeta.cs](src/In.ProjectEKA.HipLibrary/Patient/Model/LinkReferenceMeta.cs)</SwmPath>, <SwmPath>[src/In.ProjectEKA.HipLibrary/Patient/Model/CareBundle.cs](src/In.ProjectEKA.HipLibrary/Patient/Model/CareBundle.cs)</SwmPath>, <SwmPath>[src/In.ProjectEKA.HipLibrary/Patient/Model/DataRequest.cs](src/In.ProjectEKA.HipLibrary/Patient/Model/DataRequest.cs)</SwmPath>, <SwmPath>[src/In.ProjectEKA.HipLibrary/Patient/Model/Resp.cs](src/In.ProjectEKA.HipLibrary/Patient/Model/Resp.cs)</SwmPath>, <SwmPath>[src/In.ProjectEKA.HipLibrary/Patient/Model/DateRange.cs](src/In.ProjectEKA.HipLibrary/Patient/Model/DateRange.cs)</SwmPath>, <SwmPath>[src/In.ProjectEKA.HipLibrary/Patient/Model/LinkConfirmationRequest.cs](src/In.ProjectEKA.HipLibrary/Patient/Model/LinkConfirmationRequest.cs)</SwmPath>, <SwmPath>[src/In.ProjectEKA.HipLibrary/Patient/Model/KeyStructure.cs](src/In.ProjectEKA.HipLibrary/Patient/Model/KeyStructure.cs)</SwmPath>, <SwmPath>[src/In.ProjectEKA.HipLibrary/Patient/Model/HiType.cs](src/In.ProjectEKA.HipLibrary/Patient/Model/HiType.cs)</SwmPath>, and <SwmPath>[src/In.ProjectEKA.HipLibrary/Patient/Model/Error.cs](src/In.ProjectEKA.HipLibrary/Patient/Model/Error.cs)</SwmPath>.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" line="25">

---

An example usage of the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="1:8:8" line-data="namespace In.ProjectEKA.HipLibrary.Patient.Model">`Patient`</SwmToken> class is in the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="25:5:5" line-data="        public PatientEnquiryRepresentation ToPatientEnquiryRepresentation(">`ToPatientEnquiryRepresentation`</SwmToken> method, which converts a <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="1:8:8" line-data="namespace In.ProjectEKA.HipLibrary.Patient.Model">`Patient`</SwmToken> object into a <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="25:3:3" line-data="        public PatientEnquiryRepresentation ToPatientEnquiryRepresentation(">`PatientEnquiryRepresentation`</SwmToken> object.

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

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
