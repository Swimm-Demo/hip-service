---
title: Introduction to Consent Mechanism
---
# Components of the Consent Mechanism

# Introduction to Consent Mechanism

Consent refers to the mechanism by which users grant permission for their data to be accessed and used within the Hip Service.

## <SwmToken path="src/In.ProjectEKA.HipService/Consent/ConsentRepository.cs" pos="11:5:5" line-data="    public class ConsentRepository : IConsentRepository">`ConsentRepository`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipService/Consent/ConsentRepository.cs" pos="20:9:9" line-data="        public async Task AddAsync(Consent consent)">`Consent`</SwmToken> namespace encompasses various components such as repositories, controllers, and models that manage the consent process.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Consent/ConsentRepository.cs" line="20">

---

The <SwmToken path="src/In.ProjectEKA.HipService/Consent/ConsentRepository.cs" pos="11:5:5" line-data="    public class ConsentRepository : IConsentRepository">`ConsentRepository`</SwmToken> is responsible for handling data operations related to consent, such as storing and retrieving consent records.

```c#
        public async Task AddAsync(Consent consent)
        {
            await consentContext.ConsentArtefact.AddAsync(consent);
            await consentContext.SaveChangesAsync();
        }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Consent/ConsentController.cs" line="10">

---

## <SwmToken path="src/In.ProjectEKA.HipService/Consent/ConsentController.cs" pos="13:5:5" line-data="    public class ConsentController : Controller">`ConsentController`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipService/Consent/ConsentController.cs" pos="13:5:5" line-data="    public class ConsentController : Controller">`ConsentController`</SwmToken> manages the API endpoints for consent-related operations, facilitating communication between the client and the server. It handles requests such as creating, updating, and retrieving consent records.

```c#
    [Obsolete]
    [Authorize]
    [Route("consent/notification")]
    public class ConsentController : Controller
    {
        private readonly IConsentRepository consentRepository;

        public ConsentController(IConsentRepository consentRepository)
        {
            this.consentRepository = consentRepository;
        }

        [HttpPost]
        public async Task<ActionResult> StoreConsent(
            [FromHeader(Name = "X-GatewayID ")] string consentManagerId,
            [FromBody] ConsentArtefactRequest consentArtefactRequest)
        {
            if (consentArtefactRequest.Status == ConsentStatus.GRANTED)
            {
                var consent = new Consent(consentArtefactRequest.ConsentDetail.ConsentId,
                    consentArtefactRequest.ConsentDetail,
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Consent/ConsentNotificationController.cs" line="15">

---

## <SwmToken path="src/In.ProjectEKA.HipService/Consent/ConsentNotificationController.cs" pos="19:5:5" line-data="    public class ConsentNotificationController : ControllerBase">`ConsentNotificationController`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipService/Consent/ConsentNotificationController.cs" pos="19:5:5" line-data="    public class ConsentNotificationController : ControllerBase">`ConsentNotificationController`</SwmToken> handles notifications related to consent, ensuring that relevant parties are informed about consent events. This includes endpoints for sending and receiving notifications about consent status changes.

```c#
    using Model;
    using static Common.Constants;

    [ApiController]
    public class ConsentNotificationController : ControllerBase
    {
        private readonly IBackgroundJobClient backgroundJob;
        private readonly IConsentRepository consentRepository;
        private readonly GatewayClient gatewayClient;

        public ConsentNotificationController(
            IConsentRepository consentRepository,
            IBackgroundJobClient backgroundJob,
            GatewayClient gatewayClient)
        {
            this.consentRepository = consentRepository;
            this.backgroundJob = backgroundJob;
            this.gatewayClient = gatewayClient;
        }

        [HttpPost(PATH_CONSENTS_HIP)]
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Consent/Model/Consent.cs" line="7">

---

# Consent Model

The <SwmToken path="src/In.ProjectEKA.HipService/Consent/Model/Consent.cs" pos="7:5:5" line-data="    public class Consent">`Consent`</SwmToken> model defines the structure of a consent record, including properties like <SwmToken path="src/In.ProjectEKA.HipService/Consent/Model/Consent.cs" pos="24:5:5" line-data="        public int Id { get; set; }">`Id`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/Consent/Model/Consent.cs" pos="15:1:1" line-data="            ConsentArtefactId = consentArtefactId;">`ConsentArtefactId`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/Consent/Model/Consent.cs" pos="10:1:1" line-data="            ConsentArtefact consentArtefact,">`ConsentArtefact`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/Consent/Model/Consent.cs" pos="17:1:1" line-data="            Signature = signature;">`Signature`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/Consent/Model/Consent.cs" pos="18:1:1" line-data="            Status = status;">`Status`</SwmToken>, and <SwmToken path="src/In.ProjectEKA.HipService/Consent/Model/Consent.cs" pos="19:1:1" line-data="            ConsentManagerId = consentManagerId;">`ConsentManagerId`</SwmToken>.

```c#
    public class Consent
    {
        public Consent(string consentArtefactId,
            ConsentArtefact consentArtefact,
            string signature,
            ConsentStatus status,
            string consentManagerId)
        {
            ConsentArtefactId = consentArtefactId;
            ConsentArtefact = consentArtefact;
            Signature = signature;
            Status = status;
            ConsentManagerId = consentManagerId;
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        public string ConsentArtefactId { get; set; }

```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Consent/ConsentArtefactRequest.cs" line="5">

---

# <SwmToken path="src/In.ProjectEKA.HipService/Consent/ConsentArtefactRequest.cs" pos="5:5:5" line-data="    public class ConsentArtefactRequest">`ConsentArtefactRequest`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipService/Consent/ConsentArtefactRequest.cs" pos="5:5:5" line-data="    public class ConsentArtefactRequest">`ConsentArtefactRequest`</SwmToken> class represents a request to create or manage a consent artefact, which is a digital document that encapsulates the details of the consent.

```c#
    public class ConsentArtefactRequest
    {
        public ConsentArtefactRequest(string signature, ConsentArtefact consentDetail, ConsentStatus status,
            string consentId)
        {
            Signature = signature;
            ConsentDetail = consentDetail;
            Status = status;
            ConsentId = consentId;
        }

        public string Signature { get; set; }
        public ConsentArtefact ConsentDetail { get; set; }
        public ConsentStatus Status { get; set; }
        public string ConsentId { get; set; }
    }
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
