---
title: Getting Started with Patient Model
---
## Overview

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="1:8:8" line-data="namespace In.ProjectEKA.HipLibrary.Patient.Model">`Patient`</SwmToken> class represents a patient entity with various properties such as <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="7:5:5" line-data="        public string Identifier { get; set; }">`Identifier`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="9:5:5" line-data="        public string HealthNumber { get; set; }">`HealthNumber`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="11:5:5" line-data="        public string HealthId { get; set; }">`HealthId`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="13:5:5" line-data="        public string Uuid { get; set; }">`Uuid`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="15:3:3" line-data="        public Gender? Gender { get; set; }">`Gender`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="17:5:5" line-data="        public string PhoneNumber { get; set; }">`PhoneNumber`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="19:5:5" line-data="        public string Name { get; set; }">`Name`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="21:6:6" line-data="        public ushort? YearOfBirth { get; set; }">`YearOfBirth`</SwmToken>, and <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="23:8:8" line-data="        public IEnumerable&lt;CareContextRepresentation&gt; CareContexts { get; set; }">`CareContexts`</SwmToken>. This class is essential for encapsulating all the necessary information about a patient, which is used in various operations such as patient discovery, linking care contexts, and managing patient data.

## Properties of Patient Class

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="1:8:8" line-data="namespace In.ProjectEKA.HipLibrary.Patient.Model">`Patient`</SwmToken> class includes several properties that store different pieces of information about a patient. These properties are crucial for identifying and managing patient data.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" line="7">

---

### Identifier

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="7:5:5" line-data="        public string Identifier { get; set; }">`Identifier`</SwmToken> property is a unique identifier for the patient.

```c#
        public string Identifier { get; set; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" line="9">

---

### <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="9:5:5" line-data="        public string HealthNumber { get; set; }">`HealthNumber`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="9:5:5" line-data="        public string HealthNumber { get; set; }">`HealthNumber`</SwmToken> property stores the patient's health number.

```c#
        public string HealthNumber { get; set; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" line="11">

---

### <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="11:5:5" line-data="        public string HealthId { get; set; }">`HealthId`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="11:5:5" line-data="        public string HealthId { get; set; }">`HealthId`</SwmToken> property holds the patient's health ID.

```c#
        public string HealthId { get; set; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" line="13">

---

### Uuid

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="13:5:5" line-data="        public string Uuid { get; set; }">`Uuid`</SwmToken> property is a universally unique identifier for the patient.

```c#
        public string Uuid { get; set; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" line="15">

---

### Gender

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="15:3:3" line-data="        public Gender? Gender { get; set; }">`Gender`</SwmToken> property indicates the gender of the patient.

```c#
        public Gender? Gender { get; set; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" line="17">

---

### <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="17:5:5" line-data="        public string PhoneNumber { get; set; }">`PhoneNumber`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="17:5:5" line-data="        public string PhoneNumber { get; set; }">`PhoneNumber`</SwmToken> property contains the patient's phone number.

```c#
        public string PhoneNumber { get; set; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" line="19">

---

### Name

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="19:5:5" line-data="        public string Name { get; set; }">`Name`</SwmToken> property stores the name of the patient.

```c#
        public string Name { get; set; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" line="21">

---

### <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="21:6:6" line-data="        public ushort? YearOfBirth { get; set; }">`YearOfBirth`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="21:6:6" line-data="        public ushort? YearOfBirth { get; set; }">`YearOfBirth`</SwmToken> property indicates the year of birth of the patient.

```c#
        public ushort? YearOfBirth { get; set; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" line="23">

---

### <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="23:8:8" line-data="        public IEnumerable&lt;CareContextRepresentation&gt; CareContexts { get; set; }">`CareContexts`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="23:8:8" line-data="        public IEnumerable&lt;CareContextRepresentation&gt; CareContexts { get; set; }">`CareContexts`</SwmToken> property is a collection of <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="23:5:5" line-data="        public IEnumerable&lt;CareContextRepresentation&gt; CareContexts { get; set; }">`CareContextRepresentation`</SwmToken> objects associated with the patient.

```c#
        public IEnumerable<CareContextRepresentation> CareContexts { get; set; }
```

---

</SwmSnippet>

## Method: <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="25:5:5" line-data="        public PatientEnquiryRepresentation ToPatientEnquiryRepresentation(">`ToPatientEnquiryRepresentation`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="25:5:5" line-data="        public PatientEnquiryRepresentation ToPatientEnquiryRepresentation(">`ToPatientEnquiryRepresentation`</SwmToken> method converts the patient information into a <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="25:3:3" line-data="        public PatientEnquiryRepresentation ToPatientEnquiryRepresentation(">`PatientEnquiryRepresentation`</SwmToken> object. This method includes unlinked care contexts and a consent manager user ID, which are essential for patient discovery processes.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" line="25">

---

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="25:5:5" line-data="        public PatientEnquiryRepresentation ToPatientEnquiryRepresentation(">`ToPatientEnquiryRepresentation`</SwmToken> method in the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="1:8:8" line-data="namespace In.ProjectEKA.HipLibrary.Patient.Model">`Patient`</SwmToken> class converts the patient information into a <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="25:3:3" line-data="        public PatientEnquiryRepresentation ToPatientEnquiryRepresentation(">`PatientEnquiryRepresentation`</SwmToken> object, including unlinked care contexts and a consent manager user ID.

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

## Usage Example in PatientDiscovery

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Patient.cs" pos="25:5:5" line-data="        public PatientEnquiryRepresentation ToPatientEnquiryRepresentation(">`ToPatientEnquiryRepresentation`</SwmToken> method is used within the `PatientFor` method in <SwmPath>[src/In.ProjectEKA.HipService/Discovery/PatientDiscovery.cs](src/In.ProjectEKA.HipService/Discovery/PatientDiscovery.cs)</SwmPath> to create a `DiscoveryRepresentation` object. This demonstrates how patient information is transformed and utilized in the patient discovery process.

## Patient APIs

The <SwmToken path="src/In.ProjectEKA.HipService/Patient/PatientController.cs" pos="14:5:5" line-data="    public class PatientController : ControllerBase">`PatientController`</SwmToken> class defines endpoints for managing patient information. For example, the `GetPatient` endpoint retrieves patient details based on the provided identifier.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Patient/PatientController.cs" line="10">

---

The <SwmToken path="src/In.ProjectEKA.HipService/Patient/PatientController.cs" pos="14:5:5" line-data="    public class PatientController : ControllerBase">`PatientController`</SwmToken> class defines endpoints for managing patient information.

```c#
    using Model;
    using static Common.Constants;

    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly GatewayClient _gatewayClient;
        private readonly IPatientNotificationService _patientNotificationService;
        private readonly GatewayConfiguration _gatewayConfiguration;
        private readonly IPatientProfileService _patientProfileService;
```

---

</SwmSnippet>

### GetPatient Endpoint

The `GetPatient` endpoint in the <SwmToken path="src/In.ProjectEKA.HipService/Patient/PatientController.cs" pos="14:5:5" line-data="    public class PatientController : ControllerBase">`PatientController`</SwmToken> class is used to retrieve patient details. It takes an identifier as a parameter and returns the corresponding patient information.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Patient/PatientController.cs" line="22">

---

The `GetPatient` endpoint in the <SwmToken path="src/In.ProjectEKA.HipService/Patient/PatientController.cs" pos="22:3:3" line-data="        public PatientController(GatewayClient gatewayClient, IPatientNotificationService patientNotificationService,">`PatientController`</SwmToken> class is used to retrieve patient details.

```c#
        public PatientController(GatewayClient gatewayClient, IPatientNotificationService patientNotificationService,
            GatewayConfiguration gatewayConfiguration, IPatientProfileService patientProfileService)
        {
            _gatewayClient = gatewayClient;
            _patientNotificationService = patientNotificationService;
            _gatewayConfiguration = gatewayConfiguration;
            _patientProfileService = patientProfileService;
        }
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
