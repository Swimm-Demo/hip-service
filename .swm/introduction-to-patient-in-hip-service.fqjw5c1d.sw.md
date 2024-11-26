---
title: Introduction to Patient in HIP Service
---
# Introduction to Patient in HIP Service

Patient refers to an individual whose health information is managed and processed by the HIP service. The HIP service handles various patient-related functionalities such as account discovery, linking with a Consent Manager, and managing consent artifacts.

## Patient Data Management

Patient data is stored and managed using the `PatientContext` class, which interacts with the database to retrieve and store patient information. The `PatientProfileService` class is responsible for handling patient profile-related operations, including fetching and updating patient demographics. The <SwmToken path="src/In.ProjectEKA.HipService/Patient/PatientNotificationService.cs" pos="16:5:5" line-data="    public class PatientNotificationService : IPatientNotificationService">`PatientNotificationService`</SwmToken> class manages notifications related to patient status and actions, ensuring that relevant updates are communicated effectively.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Patient/PatientController.cs" line="13">

---

The <SwmToken path="src/In.ProjectEKA.HipService/Patient/PatientController.cs" pos="14:5:5" line-data="    public class PatientController : ControllerBase">`PatientController`</SwmToken> class manages patient notifications and profile details, ensuring that relevant updates are communicated effectively.

```c#
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly GatewayClient _gatewayClient;
        private readonly IPatientNotificationService _patientNotificationService;
        private readonly GatewayConfiguration _gatewayConfiguration;
        private readonly IPatientProfileService _patientProfileService;


        public PatientController(GatewayClient gatewayClient, IPatientNotificationService patientNotificationService,
            GatewayConfiguration gatewayConfiguration, IPatientProfileService patientProfileService)
        {
            _gatewayClient = gatewayClient;
            _patientNotificationService = patientNotificationService;
            _gatewayConfiguration = gatewayConfiguration;
            _patientProfileService = patientProfileService;
        }

        [Route(PATH_PATIENT_NOTIFY)]
        public async Task<AcceptedResult> NotifyHip([FromHeader(Name = CORRELATION_ID)] string correlationId,
            [FromBody] HipPatientStatusNotification hipPatientStatusNotification)
```

---

</SwmSnippet>

## Patient Models

Various models under the <SwmToken path="src/In.ProjectEKA.HipService/Patient/Model/Person.cs" pos="4:2:10" line-data="namespace In.ProjectEKA.HipService.Patient.Model">`In.ProjectEKA.HipService.Patient.Model`</SwmToken> namespace represent different aspects of patient information, such as <SwmToken path="src/In.ProjectEKA.HipService/Patient/Model/Person.cs" pos="8:15:15" line-data="        public Person(List&lt;PatientName&gt; names, List&lt;PatientAddress&gt; addresses, DateTime birthdate, string gender, List&lt;PatientAttribute&gt; attributes)">`PatientAddress`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/Patient/Model/Person.cs" pos="8:3:3" line-data="        public Person(List&lt;PatientName&gt; names, List&lt;PatientAddress&gt; addresses, DateTime birthdate, string gender, List&lt;PatientAttribute&gt; attributes)">`Person`</SwmToken>, and `PatientNotification`. These models are used to structure and manage patient data, ensuring consistency and ease of access across the HIP service.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Patient/Model/Person.cs" line="7">

---

The <SwmToken path="src/In.ProjectEKA.HipService/Patient/Model/Person.cs" pos="8:3:3" line-data="        public Person(List&lt;PatientName&gt; names, List&lt;PatientAddress&gt; addresses, DateTime birthdate, string gender, List&lt;PatientAttribute&gt; attributes)">`Person`</SwmToken> class represents a patient's personal information, including names, addresses, birthdate, gender, and attributes.

```c#
    {
        public Person(List<PatientName> names, List<PatientAddress> addresses, DateTime birthdate, string gender, List<PatientAttribute> attributes)
        {
            this.names = names;
            this.addresses = addresses;
            this.birthdate = birthdate;
            this.gender = gender;
            this.attributes = attributes;
        }
        public List<PatientName> names { get; set; }
        public List<PatientAddress> addresses { get; set; }
        public DateTime birthdate { get; set; }
        public string gender { get; set; }
        public List<PatientAttribute> attributes { get; set; }
    }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Patient/PatientQueue.cs" line="7">

---

The <SwmToken path="src/In.ProjectEKA.HipService/Patient/PatientQueue.cs" pos="7:5:5" line-data="    public class PatientQueue">`PatientQueue`</SwmToken> class manages the queue of patient requests, including their demographics and request details.

```c#
    public class PatientQueue
    {
        public string DateTimeStamp { get; }
        public string HipCode { get; }
        public PatientDemographics Profile { get; }
        [Key] public string RequestId { get; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TokenNumber { get; set; }

        public PatientQueue(string requestId, string dateTimeStamp, PatientDemographics profile, string hipCode)
        {
            RequestId = requestId;
            DateTimeStamp = dateTimeStamp;
            Profile = profile;
            HipCode = hipCode;
        }
    }
```

---

</SwmSnippet>

## Patient APIs

The <SwmToken path="src/In.ProjectEKA.HipService/Patient/PatientNotificationService.cs" pos="34:7:7" line-data="        public async Task Perform(HipPatientStatusNotification hipPatientStatusNotification)">`Perform`</SwmToken> method in the <SwmToken path="src/In.ProjectEKA.HipService/Patient/PatientNotificationService.cs" pos="16:5:5" line-data="    public class PatientNotificationService : IPatientNotificationService">`PatientNotificationService`</SwmToken> class handles the notification of patient status changes. It checks the status of the patient and performs actions such as deleting the health ID in HIP and removing the health ID in OpenMRS.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Patient/PatientNotificationService.cs" line="34">

---

The <SwmToken path="src/In.ProjectEKA.HipService/Patient/PatientNotificationService.cs" pos="34:7:7" line-data="        public async Task Perform(HipPatientStatusNotification hipPatientStatusNotification)">`Perform`</SwmToken> method handles the notification of patient status changes, checking the status of the patient and performing actions accordingly.

```c#
        public async Task Perform(HipPatientStatusNotification hipPatientStatusNotification)
        {
            var healthId = hipPatientStatusNotification.notification.patient.id;
            var status = hipPatientStatusNotification.notification.status.ToString();
            if (Enum.IsDefined(typeof(Action), status))
            {
                if (status.Equals(Action.DELETED.ToString())) DeleteHealthIdInHip(healthId);
                await RemoveHealthIdInOpenMrs(healthId, status);
            }
```

---

</SwmSnippet>

## <SwmToken path="src/In.ProjectEKA.HipService/Patient/PatientNotificationService.cs" pos="40:18:18" line-data="                if (status.Equals(Action.DELETED.ToString())) DeleteHealthIdInHip(healthId);">`DeleteHealthIdInHip`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipService/Patient/PatientNotificationService.cs" pos="40:18:18" line-data="                if (status.Equals(Action.DELETED.ToString())) DeleteHealthIdInHip(healthId);">`DeleteHealthIdInHip`</SwmToken> method is responsible for deleting the health ID in the HIP system. It removes discovery requests, linked accounts, link enquiries, user authentication details, and consent artifacts associated with the health ID.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Patient/PatientNotificationService.cs" line="45">

---

The <SwmToken path="src/In.ProjectEKA.HipService/Patient/PatientNotificationService.cs" pos="45:5:5" line-data="        private void DeleteHealthIdInHip(string healthId)">`DeleteHealthIdInHip`</SwmToken> method removes discovery requests, linked accounts, link enquiries, user authentication details, and consent artifacts associated with the health ID.

```c#
        private void DeleteHealthIdInHip(string healthId)
        {
            discoveryRequestRepository.DeleteDiscoveryRequest(healthId);
            linkPatientRepository.DeleteLinkedAccounts(healthId);
            linkPatientRepository.DeleteLinkEnquires(healthId);
            userAuthRepository.Delete(healthId);
            userAuthRepository.DeleteDemographics(healthId);
            consentRepository.DeleteConsentArtefact(healthId);
        }
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
