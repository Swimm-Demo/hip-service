---
title: Patient Link Enquiry Model Overview
---
## <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/PatientLinkEnquiry.cs" pos="3:5:5" line-data="    public class PatientLinkEnquiry">`PatientLinkEnquiry`</SwmToken> Class

# Basic Concepts of Patient Link Enquiry Model

The Patient Link Enquiry Model encapsulates the details required for linking a patient account. It includes a transaction ID, request ID, and patient information.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/PatientLinkEnquiry.cs" line="3">

---

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/PatientLinkEnquiry.cs" pos="3:5:5" line-data="    public class PatientLinkEnquiry">`PatientLinkEnquiry`</SwmToken> class is used to create an object with the necessary link enquiry details, such as the transaction ID, request ID, and patient information.

```c#
    public class PatientLinkEnquiry
    {
        public PatientLinkEnquiry(string transactionId, string requestId, LinkEnquiry patient)
        {
            TransactionId = transactionId;
            Patient = patient;
            RequestId = requestId;
        }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/LinkPatient.cs" line="52">

---

## Usage in Application

This class is utilized in various parts of the application, including the <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkController.cs" pos="28:5:5" line-data="        private readonly LinkPatient linkPatient;">`LinkPatient`</SwmToken> and <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkController.cs" pos="31:3:3" line-data="        public LinkController(">`LinkController`</SwmToken> classes, to handle patient link enquiries.

```c#
        public virtual async Task<ValueTuple<PatientLinkEnquiryRepresentation, ErrorRepresentation>> LinkPatients(
            PatientLinkEnquiry request)
        {
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/PatientLinkEnquiryRepresentation.cs" line="5">

---

## <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/PatientLinkEnquiryRepresentation.cs" pos="5:3:3" line-data="        public PatientLinkEnquiryRepresentation()">`PatientLinkEnquiryRepresentation`</SwmToken> Class

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/PatientLinkEnquiryRepresentation.cs" pos="5:3:3" line-data="        public PatientLinkEnquiryRepresentation()">`PatientLinkEnquiryRepresentation`</SwmToken> class encapsulates the details of a patient's link enquiry and contains a property <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/PatientLinkEnquiryRepresentation.cs" pos="11:1:1" line-data="            Link = link;">`Link`</SwmToken> which holds an instance of <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/PatientLinkEnquiryRepresentation.cs" pos="9:5:5" line-data="        public PatientLinkEnquiryRepresentation(LinkEnquiryRepresentation link)">`LinkEnquiryRepresentation`</SwmToken>.

```c#
        public PatientLinkEnquiryRepresentation()
        {
        }

        public PatientLinkEnquiryRepresentation(LinkEnquiryRepresentation link)
        {
            Link = link;
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/LinkController.cs" line="25">

---

## Endpoint for Patient Link Enquiry

The `/patients/link` endpoint is used to handle patient link enquiries. This endpoint accepts a POST request with the necessary details encapsulated in the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/PatientLinkEnquiry.cs" pos="3:5:5" line-data="    public class PatientLinkEnquiry">`PatientLinkEnquiry`</SwmToken> model, such as the transaction ID, request ID, and patient information. The endpoint processes the request and links the patient account accordingly.

```c#
    {
        private readonly IDiscoveryRequestRepository discoveryRequestRepository;
        private readonly IBackgroundJobClient backgroundJob;
        private readonly LinkPatient linkPatient;
        private readonly GatewayClient gatewayClient;

        public LinkController(
            IDiscoveryRequestRepository discoveryRequestRepository,
            IBackgroundJobClient backgroundJob,
            LinkPatient linkPatient, GatewayClient gatewayClient)
        {
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
