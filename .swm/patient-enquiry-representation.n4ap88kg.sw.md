---
title: Patient Enquiry Representation
---
# Properties

# Overview

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/PatientEnquiryRepresentation.cs" pos="5:5:5" line-data="    public class PatientEnquiryRepresentation">`PatientEnquiryRepresentation`</SwmToken> class is a model that encapsulates the details of a patient's enquiry. This class is essential for managing and representing patient-related data within the system.

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/PatientEnquiryRepresentation.cs" pos="5:5:5" line-data="    public class PatientEnquiryRepresentation">`PatientEnquiryRepresentation`</SwmToken> class includes several properties that store various details about a patient's enquiry. These properties are crucial for identifying and describing the patient and their associated care contexts.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/PatientEnquiryRepresentation.cs" line="5">

---

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/PatientEnquiryRepresentation.cs" pos="13:1:1" line-data="            ReferenceNumber = referenceNumber;">`ReferenceNumber`</SwmToken> property holds a unique identifier for the patient enquiry. This identifier is used to distinguish each patient enquiry uniquely.

```c#
    public class PatientEnquiryRepresentation
    {
        public PatientEnquiryRepresentation(
            string referenceNumber,
            string display,
            IEnumerable<CareContextRepresentation> careContexts,
            IEnumerable<string> matchedBy)
        {
            ReferenceNumber = referenceNumber;
            Display = display;
            CareContexts = careContexts;
            MatchedBy = matchedBy;
        }

        public string ReferenceNumber { get; }

        public string Display { get; }

        public IEnumerable<CareContextRepresentation> CareContexts { get; }

        public IEnumerable<string> MatchedBy { get; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/PatientEnquiryRepresentation.cs" line="5">

---

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/PatientEnquiryRepresentation.cs" pos="14:1:1" line-data="            Display = display;">`Display`</SwmToken> property contains a display name or description for the patient. This property helps in providing a human-readable name or description for the patient.

```c#
    public class PatientEnquiryRepresentation
    {
        public PatientEnquiryRepresentation(
            string referenceNumber,
            string display,
            IEnumerable<CareContextRepresentation> careContexts,
            IEnumerable<string> matchedBy)
        {
            ReferenceNumber = referenceNumber;
            Display = display;
            CareContexts = careContexts;
            MatchedBy = matchedBy;
        }

        public string ReferenceNumber { get; }

        public string Display { get; }

        public IEnumerable<CareContextRepresentation> CareContexts { get; }

        public IEnumerable<string> MatchedBy { get; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/PatientEnquiryRepresentation.cs" line="5">

---

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/PatientEnquiryRepresentation.cs" pos="15:1:1" line-data="            CareContexts = careContexts;">`CareContexts`</SwmToken> property is a collection of <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/PatientEnquiryRepresentation.cs" pos="10:3:3" line-data="            IEnumerable&lt;CareContextRepresentation&gt; careContexts,">`CareContextRepresentation`</SwmToken> objects. These objects represent different care contexts associated with the patient, providing a comprehensive view of the patient's care history.

```c#
    public class PatientEnquiryRepresentation
    {
        public PatientEnquiryRepresentation(
            string referenceNumber,
            string display,
            IEnumerable<CareContextRepresentation> careContexts,
            IEnumerable<string> matchedBy)
        {
            ReferenceNumber = referenceNumber;
            Display = display;
            CareContexts = careContexts;
            MatchedBy = matchedBy;
        }

        public string ReferenceNumber { get; }

        public string Display { get; }

        public IEnumerable<CareContextRepresentation> CareContexts { get; }

        public IEnumerable<string> MatchedBy { get; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/PatientEnquiryRepresentation.cs" line="5">

---

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/PatientEnquiryRepresentation.cs" pos="16:1:1" line-data="            MatchedBy = matchedBy;">`MatchedBy`</SwmToken> property is a collection of strings that indicate the criteria by which the patient was matched. This property is useful for understanding how the patient enquiry was identified and matched within the system.

```c#
    public class PatientEnquiryRepresentation
    {
        public PatientEnquiryRepresentation(
            string referenceNumber,
            string display,
            IEnumerable<CareContextRepresentation> careContexts,
            IEnumerable<string> matchedBy)
        {
            ReferenceNumber = referenceNumber;
            Display = display;
            CareContexts = careContexts;
            MatchedBy = matchedBy;
        }

        public string ReferenceNumber { get; }

        public string Display { get; }

        public IEnumerable<CareContextRepresentation> CareContexts { get; }

        public IEnumerable<string> MatchedBy { get; }
```

---

</SwmSnippet>

# Usage

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/PatientEnquiryRepresentation.cs" pos="5:5:5" line-data="    public class PatientEnquiryRepresentation">`PatientEnquiryRepresentation`</SwmToken> class is used in various parts of the codebase to manage patient enquiries. It is instantiated with the required properties and utilized in different modules to handle patient data.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Discovery/Filter.cs" line="85">

---

An example usage of <SwmToken path="src/In.ProjectEKA.HipService/Discovery/Filter.cs" pos="85:5:5" line-data="                    return new PatientEnquiryRepresentation(">`PatientEnquiryRepresentation`</SwmToken> can be found in <SwmPath>[src/In.ProjectEKA.HipService/Discovery/Filter.cs](src/In.ProjectEKA.HipService/Discovery/Filter.cs)</SwmPath> where it is used to return a new instance with patient details.

```c#
                    return new PatientEnquiryRepresentation(
                        rankedPatient.Patient.Identifier,
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
