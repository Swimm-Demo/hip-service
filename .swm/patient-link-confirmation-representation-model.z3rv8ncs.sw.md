---
title: Patient Link Confirmation Representation Model
---
# Overview of Patient Link Confirmation Representation Model

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/PatientLinkConfirmationRepresentation.cs" pos="5:3:3" line-data="        public PatientLinkConfirmationRepresentation(LinkConfirmationRepresentation patient)">`PatientLinkConfirmationRepresentation`</SwmToken> class is a model that represents the confirmation of a patient's link.

It contains a single property, <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/PatientLinkConfirmationRepresentation.cs" pos="7:1:1" line-data="            Patient = patient;">`Patient`</SwmToken>, which holds an instance of <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/PatientLinkConfirmationRepresentation.cs" pos="5:5:5" line-data="        public PatientLinkConfirmationRepresentation(LinkConfirmationRepresentation patient)">`LinkConfirmationRepresentation`</SwmToken>.

## Constructor

This class is used to encapsulate the confirmation details of a patient's link, ensuring that the necessary information is passed and stored in a structured manner.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/PatientLinkConfirmationRepresentation.cs" line="5">

---

The constructor of the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/PatientLinkConfirmationRepresentation.cs" pos="5:3:3" line-data="        public PatientLinkConfirmationRepresentation(LinkConfirmationRepresentation patient)">`PatientLinkConfirmationRepresentation`</SwmToken> class initializes the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/PatientLinkConfirmationRepresentation.cs" pos="7:1:1" line-data="            Patient = patient;">`Patient`</SwmToken> property with the provided <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/PatientLinkConfirmationRepresentation.cs" pos="5:5:5" line-data="        public PatientLinkConfirmationRepresentation(LinkConfirmationRepresentation patient)">`LinkConfirmationRepresentation`</SwmToken> instance.

```c#
        public PatientLinkConfirmationRepresentation(LinkConfirmationRepresentation patient)
        {
            Patient = patient;
        }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/LinkPatient.cs" line="132">

---

## Usage in Verification and Linking

The <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatient.cs" pos="132:11:11" line-data="        public virtual async Task&lt;ValueTuple&lt;PatientLinkConfirmationRepresentation, string, ErrorRepresentation&gt;&gt;">`PatientLinkConfirmationRepresentation`</SwmToken> class is used in methods that handle the verification and linking of a patient's care context. For example, the <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatient.cs" pos="133:1:1" line-data="            VerifyAndLinkCareContext(">`VerifyAndLinkCareContext`</SwmToken> method in the <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkController.cs" pos="24:5:5" line-data="    public class LinkController : ControllerBase">`LinkController`</SwmToken> class is responsible for verifying and linking a patient's care context. This method uses the <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatient.cs" pos="132:11:11" line-data="        public virtual async Task&lt;ValueTuple&lt;PatientLinkConfirmationRepresentation, string, ErrorRepresentation&gt;&gt;">`PatientLinkConfirmationRepresentation`</SwmToken> to return the result of the verification and linking process.

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

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/LinkPatient.cs" line="132">

---

## Example Usage

In the <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatient.cs" pos="133:1:1" line-data="            VerifyAndLinkCareContext(">`VerifyAndLinkCareContext`</SwmToken> method, the <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatient.cs" pos="132:11:11" line-data="        public virtual async Task&lt;ValueTuple&lt;PatientLinkConfirmationRepresentation, string, ErrorRepresentation&gt;&gt;">`PatientLinkConfirmationRepresentation`</SwmToken> is used to return the result of the verification and linking process. This method validates the account reference number and care context reference number, verifies the transaction ID, authenticates the request with the patient, and communicates the mode of authentication of a successful request with the Consent Manager.

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

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/LinkController.cs" line="10">

---

## Patient Link Confirmation Endpoints

The <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatient.cs" pos="133:1:1" line-data="            VerifyAndLinkCareContext(">`VerifyAndLinkCareContext`</SwmToken> method in the <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkController.cs" pos="24:5:5" line-data="    public class LinkController : ControllerBase">`LinkController`</SwmToken> class is responsible for verifying and linking a patient's care context. This endpoint ensures that the patient's care context is correctly linked by verifying the provided information.

```c#
    using Hangfire;
    using HipLibrary.Patient.Model;
    using Logger;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.ModelBinding;
    using static Common.Constants;
    using Model;

    [Authorize]
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
