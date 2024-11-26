---
title: Introduction to Link Patient Process
---
# Introduction to Link Patient Process

The <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatient.cs" pos="33:3:3" line-data="        public LinkPatient(">`LinkPatient`</SwmToken> class is responsible for managing the process of linking patient accounts with consent managers and care contexts.

## <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatient.cs" pos="52:17:17" line-data="        public virtual async Task&lt;ValueTuple&lt;PatientLinkEnquiryRepresentation, ErrorRepresentation&gt;&gt; LinkPatients(">`LinkPatients`</SwmToken> Method

It utilizes various repositories and services such as <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatient.cs" pos="34:1:1" line-data="            ILinkPatientRepository linkPatientRepository,">`ILinkPatientRepository`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatient.cs" pos="35:1:1" line-data="            IPatientRepository patientRepository,">`IPatientRepository`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatient.cs" pos="36:1:1" line-data="            IPatientVerification patientVerification,">`IPatientVerification`</SwmToken>, and <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatient.cs" pos="30:5:5" line-data="        private readonly IOpenMrsClient openMrsClient;">`IOpenMrsClient`</SwmToken> to handle different aspects of the linking process.

The <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatient.cs" pos="52:17:17" line-data="        public virtual async Task&lt;ValueTuple&lt;PatientLinkEnquiryRepresentation, ErrorRepresentation&gt;&gt; LinkPatients(">`LinkPatients`</SwmToken> method initiates the linking process by validating the patient and care context information, generating a link reference number, and saving the link request details.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/LinkPatient.cs" line="52">

---

Additionally, it handles the generation and sending of OTPs for patient verification and deletes the discovery request once the linking process is completed.

```c#
        public virtual async Task<ValueTuple<PatientLinkEnquiryRepresentation, ErrorRepresentation>> LinkPatients(
            PatientLinkEnquiry request)
        {
            var (patient, error) = await PatientAndCareContextValidation(request);
            if (error != null)
            {
                Log.Error(error.Error.Message);
                return (null, error);
            }

            var linkRefNumber = referenceNumberGenerator.NewGuid();
            using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                if (!await SaveInitiatedLinkRequest(request.RequestId, request.TransactionId, linkRefNumber)
                    .ConfigureAwait(false))
                    return (null,
                        new ErrorRepresentation(new Error(ErrorCode.DuplicateRequestId, ErrorMessage.DuplicateRequestId))
                        );

                var careContextReferenceNumbers = request.Patient.CareContexts
                    .Select(context => context.ReferenceNumber)
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/LinkPatient.cs" line="132">

---

## <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatient.cs" pos="133:1:1" line-data="            VerifyAndLinkCareContext(">`VerifyAndLinkCareContext`</SwmToken> Method

The <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatient.cs" pos="133:1:1" line-data="            VerifyAndLinkCareContext(">`VerifyAndLinkCareContext`</SwmToken> method verifies the OTP provided by the patient and updates the link request status if the verification is successful.

```c#
        public virtual async Task<ValueTuple<PatientLinkConfirmationRepresentation, string, ErrorRepresentation>>
            VerifyAndLinkCareContext(
            LinkConfirmationRequest request)
        {
            var (linkEnquires, exception) =
                await linkPatientRepository.GetPatientFor(request.LinkReferenceNumber);
            var cmId = "";
            if (exception != null)
                return (null,cmId,
                    new ErrorRepresentation(new Error(ErrorCode.NoLinkRequestFound, ErrorMessage.NoLinkRequestFound)));
            cmId = linkEnquires.ConsentManagerId;

            var errorResponse = await patientVerification.Verify(request.LinkReferenceNumber, request.Token);
            if (errorResponse != null)
                return (null,cmId, new ErrorRepresentation(errorResponse.toError()));

            var patient = await patientRepository.PatientWithAsync(linkEnquires.PatientReferenceNumber);
            return await patient.Map( async patient =>
                {
                    var savedLinkRequests = await linkPatientRepository.Get(request.LinkReferenceNumber);
                    savedLinkRequests.MatchSome(linkRequests =>
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/LinkPatient.cs" line="104">

---

## Usage Example

An example of using <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatient.cs" pos="33:3:3" line-data="        public LinkPatient(">`LinkPatient`</SwmToken> is in the <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatient.cs" pos="33:3:3" line-data="        public LinkPatient(">`LinkPatient`</SwmToken> class where it is used to create a <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatient.cs" pos="105:9:9" line-data="            var patientLinkReferenceResponse = new PatientLinkEnquiryRepresentation(">`PatientLinkEnquiryRepresentation`</SwmToken> object with the necessary link enquiry details.

```c#
            var meta = new LinkReferenceMeta(nameof(CommunicationMode.MOBILE), patient.PhoneNumber, expiry);
            var patientLinkReferenceResponse = new PatientLinkEnquiryRepresentation(
                new LinkEnquiryRepresentation(linkRefNumber, "MEDIATED", meta));
            return (patientLinkReferenceResponse, null);
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/LinkPatient.cs" line="10">

---

# Link Patient Endpoints

The <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatient.cs" pos="52:17:17" line-data="        public virtual async Task&lt;ValueTuple&lt;PatientLinkEnquiryRepresentation, ErrorRepresentation&gt;&gt; LinkPatients(">`LinkPatients`</SwmToken> endpoint initiates the process of linking patient accounts with consent managers and care contexts. It validates the patient and care context information, generates a link reference number, and saves the link request details. Additionally, it handles the generation and sending of OTPs for patient verification and deletes the discovery request once the linking process is completed.

```c#
    using System.Linq;
    using System.Threading.Tasks;
    using System.Transactions;
    using Common;
    using Discovery;
    using HipLibrary.Patient;
    using HipLibrary.Patient.Model;
    using Logger;
    using Microsoft.Extensions.Options;
    using Model;
    using static In.ProjectEKA.HipService.Discovery.DiscoveryReqMap;
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/LinkPatient.cs" line="30">

---

The <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatient.cs" pos="133:1:1" line-data="            VerifyAndLinkCareContext(">`VerifyAndLinkCareContext`</SwmToken> endpoint verifies the OTP provided by the patient and updates the link request status if the verification is successful. This ensures that the linking process is secure and that only verified patients can link their care contexts.

```c#
        private readonly IOpenMrsClient openMrsClient;
        private readonly IUserAuthService userAuthService;

        public LinkPatient(
            ILinkPatientRepository linkPatientRepository,
            IPatientRepository patientRepository,
            IPatientVerification patientVerification,
            ReferenceNumberGenerator referenceNumberGenerator,
            IDiscoveryRequestRepository discoveryRequestRepository,
            IOptions<OtpServiceConfiguration> otpService,
            IOpenMrsClient openMrsClient, IUserAuthService userAuthService)
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
