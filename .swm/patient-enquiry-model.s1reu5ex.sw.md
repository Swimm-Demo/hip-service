---
title: Patient Enquiry Model
---
# Properties of Patient Enquiry

# What is Patient Enquiry

Patient enquiry refers to a model class that encapsulates the details required to identify and validate a patient.

## Mandatory Properties

The class includes properties such as <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/PatientEnquiry.cs" pos="28:5:5" line-data="        public string Id { get; }">`Id`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/PatientEnquiry.cs" pos="7:5:5" line-data="    [AtLeastOneHasValueValidation(&quot;Name&quot;, &quot;Gender&quot;, ErrorMessage = &quot;Patient name or gender must be provided.&quot;)]">`Name`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/PatientEnquiry.cs" pos="7:10:10" line-data="    [AtLeastOneHasValueValidation(&quot;Name&quot;, &quot;Gender&quot;, ErrorMessage = &quot;Patient name or gender must be provided.&quot;)]">`Gender`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/PatientEnquiry.cs" pos="24:1:1" line-data="            YearOfBirth = yearOfBirth;">`YearOfBirth`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/PatientEnquiry.cs" pos="20:1:1" line-data="            VerifiedIdentifiers = verifiedIdentifiers;">`VerifiedIdentifiers`</SwmToken>, and <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/PatientEnquiry.cs" pos="21:1:1" line-data="            UnverifiedIdentifiers = unverifiedIdentifiers;">`UnverifiedIdentifiers`</SwmToken>.

## Optional Properties

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/PatientEnquiry.cs" pos="28:5:5" line-data="        public string Id { get; }">`Id`</SwmToken> property is mandatory and uniquely identifies the patient. The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/PatientEnquiry.cs" pos="7:5:5" line-data="    [AtLeastOneHasValueValidation(&quot;Name&quot;, &quot;Gender&quot;, ErrorMessage = &quot;Patient name or gender must be provided.&quot;)]">`Name`</SwmToken> and <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/PatientEnquiry.cs" pos="7:10:10" line-data="    [AtLeastOneHasValueValidation(&quot;Name&quot;, &quot;Gender&quot;, ErrorMessage = &quot;Patient name or gender must be provided.&quot;)]">`Gender`</SwmToken> properties are also required and are validated to ensure at least one of them is provided.

## Identifier Properties

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/PatientEnquiry.cs" pos="24:1:1" line-data="            YearOfBirth = yearOfBirth;">`YearOfBirth`</SwmToken> property is optional and may be used during patient discovery.

# Usage in <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DiscoveryRequest.cs" pos="20:3:3" line-data="        public DiscoveryRequest(PatientEnquiry patient, string requestId, string transactionId, DateTime timestamp)">`DiscoveryRequest`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/PatientEnquiry.cs" pos="20:1:1" line-data="            VerifiedIdentifiers = verifiedIdentifiers;">`VerifiedIdentifiers`</SwmToken> and <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/PatientEnquiry.cs" pos="21:1:1" line-data="            UnverifiedIdentifiers = unverifiedIdentifiers;">`UnverifiedIdentifiers`</SwmToken> properties hold collections of identifiers that have been verified or are yet to be verified, respectively.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/DiscoveryRequest.cs" line="20">

---

Patient enquiry is used in <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DiscoveryRequest.cs" pos="20:3:3" line-data="        public DiscoveryRequest(PatientEnquiry patient, string requestId, string transactionId, DateTime timestamp)">`DiscoveryRequest`</SwmToken> to encapsulate patient details for discovery requests.

```c#
        public DiscoveryRequest(PatientEnquiry patient, string requestId, string transactionId, DateTime timestamp)
        {
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Discovery/DiscoveryReqMap.cs" line="6">

---

# Usage in <SwmToken path="src/In.ProjectEKA.HipService/Discovery/DiscoveryReqMap.cs" pos="6:7:7" line-data="    public static class DiscoveryReqMap {">`DiscoveryReqMap`</SwmToken>

Patient enquiry is also used in <SwmToken path="src/In.ProjectEKA.HipService/Discovery/DiscoveryReqMap.cs" pos="6:7:7" line-data="    public static class DiscoveryReqMap {">`DiscoveryReqMap`</SwmToken> to map patient information.

```c#
    public static class DiscoveryReqMap {
        public static Dictionary<string, PatientEnquiry> PatientInfoMap = new Dictionary<string, PatientEnquiry>();
    }
```

---

</SwmSnippet>

## Id

# Main Functions

There are several main functions in this folder. Some of them are <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/PatientEnquiry.cs" pos="28:5:5" line-data="        public string Id { get; }">`Id`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/PatientEnquiry.cs" pos="7:5:5" line-data="    [AtLeastOneHasValueValidation(&quot;Name&quot;, &quot;Gender&quot;, ErrorMessage = &quot;Patient name or gender must be provided.&quot;)]">`Name`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/PatientEnquiry.cs" pos="7:10:10" line-data="    [AtLeastOneHasValueValidation(&quot;Name&quot;, &quot;Gender&quot;, ErrorMessage = &quot;Patient name or gender must be provided.&quot;)]">`Gender`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/PatientEnquiry.cs" pos="24:1:1" line-data="            YearOfBirth = yearOfBirth;">`YearOfBirth`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/PatientEnquiry.cs" pos="20:1:1" line-data="            VerifiedIdentifiers = verifiedIdentifiers;">`VerifiedIdentifiers`</SwmToken>, and <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/PatientEnquiry.cs" pos="21:1:1" line-data="            UnverifiedIdentifiers = unverifiedIdentifiers;">`UnverifiedIdentifiers`</SwmToken>. We will dive a little into <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/PatientEnquiry.cs" pos="28:5:5" line-data="        public string Id { get; }">`Id`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/PatientEnquiry.cs" pos="7:5:5" line-data="    [AtLeastOneHasValueValidation(&quot;Name&quot;, &quot;Gender&quot;, ErrorMessage = &quot;Patient name or gender must be provided.&quot;)]">`Name`</SwmToken>, and <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/PatientEnquiry.cs" pos="7:10:10" line-data="    [AtLeastOneHasValueValidation(&quot;Name&quot;, &quot;Gender&quot;, ErrorMessage = &quot;Patient name or gender must be provided.&quot;)]">`Gender`</SwmToken>.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/PatientEnquiry.cs" line="27">

---

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/PatientEnquiry.cs" pos="28:5:5" line-data="        public string Id { get; }">`Id`</SwmToken> property is mandatory and uniquely identifies the patient.

```c#
        [Required(ErrorMessage = "Patient id must be provided.")]
        public string Id { get; }
```

---

</SwmSnippet>

# Patient Enquiry Endpoints

The Patient enquiry endpoints are designed to handle requests related to patient identification and validation. These endpoints interact with the Patient enquiry model class, which includes properties such as <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/PatientEnquiry.cs" pos="28:5:5" line-data="        public string Id { get; }">`Id`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/PatientEnquiry.cs" pos="7:5:5" line-data="    [AtLeastOneHasValueValidation(&quot;Name&quot;, &quot;Gender&quot;, ErrorMessage = &quot;Patient name or gender must be provided.&quot;)]">`Name`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/PatientEnquiry.cs" pos="7:10:10" line-data="    [AtLeastOneHasValueValidation(&quot;Name&quot;, &quot;Gender&quot;, ErrorMessage = &quot;Patient name or gender must be provided.&quot;)]">`Gender`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/PatientEnquiry.cs" pos="24:1:1" line-data="            YearOfBirth = yearOfBirth;">`YearOfBirth`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/PatientEnquiry.cs" pos="20:1:1" line-data="            VerifiedIdentifiers = verifiedIdentifiers;">`VerifiedIdentifiers`</SwmToken>, and <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/PatientEnquiry.cs" pos="21:1:1" line-data="            UnverifiedIdentifiers = unverifiedIdentifiers;">`UnverifiedIdentifiers`</SwmToken>.

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
