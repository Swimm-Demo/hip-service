---
title: Verifying and Linking Patient Care Contexts
---
This document explains the process of verifying and linking patient care contexts. The process involves verifying the patient's information, retrieving patient details, checking care contexts, and updating the link request status.

The flow starts with verifying the patient's information using a link reference number and a token to ensure the patient is authenticated. Then, the patient's details, including care contexts and phone number, are retrieved. The retrieved care contexts are checked against the patient's profile, and if they match, the link request status is updated to indicate successful linking. Finally, the linked accounts are saved, and a confirmation response is returned. If any errors occur, appropriate error messages are provided.

# Where is this flow used?

This flow is used multiple times in the codebase as represented in the following diagram:

```mermaid
graph TD;
      subgraph srcInProjectEKAHipServiceLink["src/In.ProjectEKA.HipService/Link"]
5bbe856ddbdd926f524e220f69c760512fb1d552b4fed316ae335b68c568a032(ShouldEnqueueLinkConfirmationRequestAndReturnAccepted):::rootsStyle --> 1b9740d202069a115c6fd6444e2130da171933970aabe3adcfe76e27ae65f175(LinkPatientFor)
end

subgraph srcInProjectEKAHipServiceLink["src/In.ProjectEKA.HipService/Link"]
1b9740d202069a115c6fd6444e2130da171933970aabe3adcfe76e27ae65f175(LinkPatientFor) --> 782c888258accc1792e6c356e3cd5d8030348a1efb3d6af745c5aaa2470ade77(LinkPatientCareContextFor)
end

subgraph srcInProjectEKAHipServiceLink["src/In.ProjectEKA.HipService/Link"]
782c888258accc1792e6c356e3cd5d8030348a1efb3d6af745c5aaa2470ade77(LinkPatientCareContextFor) --> f477db14b047ebf26d8300e5c406766cb5b10380b4b4b656d405cb37748dfad1(VerifyAndLinkCareContext)
end

subgraph srcInProjectEKAHipServiceLink["src/In.ProjectEKA.HipService/Link"]
1ef6150bac2238e8a5457050711de603f836b74389df58934dca434c700d55da(SuccessLinkPatientForValidOtp):::rootsStyle --> f477db14b047ebf26d8300e5c406766cb5b10380b4b4b656d405cb37748dfad1(VerifyAndLinkCareContext)
end

subgraph srcInProjectEKAHipServiceLink["src/In.ProjectEKA.HipService/Link"]
80dc5e6e2f707e0bf0928b6fea271ef594d4d90ec368f2c20dfe70855047f3c5(ReturnOtpInvalidOnWrongOtp):::rootsStyle --> f477db14b047ebf26d8300e5c406766cb5b10380b4b4b656d405cb37748dfad1(VerifyAndLinkCareContext)
end

subgraph srcInProjectEKAHipServiceLink["src/In.ProjectEKA.HipService/Link"]
dcd95d8e3a98421459a3d283ef9e5d46219d26876523c492c9dfbc946709296b(ReturnOtpExpired):::rootsStyle --> f477db14b047ebf26d8300e5c406766cb5b10380b4b4b656d405cb37748dfad1(VerifyAndLinkCareContext)
end

subgraph srcInProjectEKAHipServiceLink["src/In.ProjectEKA.HipService/Link"]
bcfebe6ae8d74c61e460ae6d5bf0251b4b365fd82d45abe6744a25b9e67f90fd(ErrorOnInvalidLinkReferenceNumber):::rootsStyle --> f477db14b047ebf26d8300e5c406766cb5b10380b4b4b656d405cb37748dfad1(VerifyAndLinkCareContext)
end


      classDef mainFlowStyle color:#000000,fill:#7CB9F4
classDef rootsStyle color:#000000,fill:#00FFF4
classDef Style1 color:#000000,fill:#00FFAA
classDef Style2 color:#000000,fill:#FFFF00
classDef Style3 color:#000000,fill:#AA7CB9
```

# Flow drill down

```mermaid
graph TD;
      subgraph srcInProjectEKAHipServiceOpenMrs["src/In.ProjectEKA.HipService/OpenMrs"]
f477db14b047ebf26d8300e5c406766cb5b10380b4b4b656d405cb37748dfad1(VerifyAndLinkCareContext) --> dd70669797c818b313d9a11e817dc9ed83b93f37739339c86521cb905bd3dcae(PatientWithAsync)
end

subgraph srcInProjectEKAHipServiceOpenMrs["src/In.ProjectEKA.HipService/OpenMrs"]
dd70669797c818b313d9a11e817dc9ed83b93f37739339c86521cb905bd3dcae(PatientWithAsync) --> bc8341f884da0777a1cb7088037bd750965dfa48508b07c3fef1dafb683bb701(GetCareContexts)
end


      classDef mainFlowStyle color:#000000,fill:#7CB9F4
classDef rootsStyle color:#000000,fill:#00FFF4
classDef Style1 color:#000000,fill:#00FFAA
classDef Style2 color:#000000,fill:#FFFF00
classDef Style3 color:#000000,fill:#AA7CB9
```

## Verifying and Linking Care Contexts

First, the <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatient.cs" pos="133:1:1" line-data="            VerifyAndLinkCareContext(">`VerifyAndLinkCareContext`</SwmToken> function is responsible for verifying the patient's information using a link reference number and a token. This step ensures that the patient requesting the link is authenticated and authorized.

Next, the function retrieves the patient's information using the <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatient.cs" pos="148:11:11" line-data="            var patient = await patientRepository.PatientWithAsync(linkEnquires.PatientReferenceNumber);">`PatientWithAsync`</SwmToken> method. This method fetches the patient's details, including care contexts and phone number, based on the patient's identifier.

Then, the function checks if the retrieved care contexts match the ones in the patient's profile. If they match, it updates the link request status to true, indicating that the care contexts have been successfully linked.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/LinkPatient.cs" line="132">

---

Finally, the function saves the linked accounts and returns a confirmation response. If any errors occur during the process, appropriate error messages are returned to inform the user.

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

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
