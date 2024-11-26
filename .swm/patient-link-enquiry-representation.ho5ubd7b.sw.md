---
title: Patient Link Enquiry Representation
---
# What is Patient Link Enquiry Representation in Model

The <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatient.cs" pos="105:9:9" line-data="            var patientLinkReferenceResponse = new PatientLinkEnquiryRepresentation(">`PatientLinkEnquiryRepresentation`</SwmToken> class encapsulates the details of a patient's link enquiry.

It contains a property <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatient.cs" pos="7:8:8" line-data="namespace In.ProjectEKA.HipService.Link">`Link`</SwmToken> which holds an instance of <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatient.cs" pos="106:3:3" line-data="                new LinkEnquiryRepresentation(linkRefNumber, &quot;MEDIATED&quot;, meta));">`LinkEnquiryRepresentation`</SwmToken>.

## Constructors

This class is used in various parts of the application, such as in the <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatient.cs" pos="22:5:5" line-data="    public class LinkPatient">`LinkPatient`</SwmToken> and <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkController.cs" pos="24:5:5" line-data="    public class LinkController : ControllerBase">`LinkController`</SwmToken> classes.

The <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatient.cs" pos="105:9:9" line-data="            var patientLinkReferenceResponse = new PatientLinkEnquiryRepresentation(">`PatientLinkEnquiryRepresentation`</SwmToken> class has two constructors. The parameterless constructor initializes a new instance of the class without setting any properties.

## Usage in <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatient.cs" pos="22:5:5" line-data="    public class LinkPatient">`LinkPatient`</SwmToken>

The other constructor initializes the class with a <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatient.cs" pos="106:3:3" line-data="                new LinkEnquiryRepresentation(linkRefNumber, &quot;MEDIATED&quot;, meta));">`LinkEnquiryRepresentation`</SwmToken> instance.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/LinkPatient.cs" line="104">

---

In the <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatient.cs" pos="22:5:5" line-data="    public class LinkPatient">`LinkPatient`</SwmToken> class, <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatient.cs" pos="105:9:9" line-data="            var patientLinkReferenceResponse = new PatientLinkEnquiryRepresentation(">`PatientLinkEnquiryRepresentation`</SwmToken> is used to create an object with the necessary link enquiry details.

```c#
            var meta = new LinkReferenceMeta(nameof(CommunicationMode.MOBILE), patient.PhoneNumber, expiry);
            var patientLinkReferenceResponse = new PatientLinkEnquiryRepresentation(
                new LinkEnquiryRepresentation(linkRefNumber, "MEDIATED", meta));
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/LinkController.cs" line="15">

---

## Usage in <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkController.cs" pos="24:5:5" line-data="    public class LinkController : ControllerBase">`LinkController`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkController.cs" pos="24:5:5" line-data="    public class LinkController : ControllerBase">`LinkController`</SwmToken> class uses the <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatient.cs" pos="105:9:9" line-data="            var patientLinkReferenceResponse = new PatientLinkEnquiryRepresentation(">`PatientLinkEnquiryRepresentation`</SwmToken> to manage the endpoints related to patient link enquiries. It handles the incoming HTTP requests and processes them using the <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatient.cs" pos="22:5:5" line-data="    public class LinkPatient">`LinkPatient`</SwmToken> class.

```c#
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.ModelBinding;
    using static Common.Constants;
    using Model;

    [Authorize]
    [ApiController]
    [Consumes("application/json")]
    [Produces("application/json")]
    public class LinkController : ControllerBase
    {
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
