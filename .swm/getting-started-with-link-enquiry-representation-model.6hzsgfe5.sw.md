---
title: Getting Started with Link Enquiry Representation Model
---
# Getting Started with Link Enquiry Representation Model

The <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatient.cs" pos="106:3:3" line-data="                new LinkEnquiryRepresentation(linkRefNumber, &quot;MEDIATED&quot;, meta));">`LinkEnquiryRepresentation`</SwmToken> class encapsulates the details required for linking a patient's account. It includes properties such as the reference number, authentication type, and metadata.

## Usage in <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatient.cs" pos="22:5:5" line-data="    public class LinkPatient">`LinkPatient`</SwmToken> Class

This class is defined with its properties and constructors. The parameterless constructor initializes a new instance of the class without setting any properties, while the parameterized constructor initializes a new instance of the class with the specified reference number, authentication type, and metadata.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/LinkPatient.cs" line="105">

---

In the <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatient.cs" pos="22:5:5" line-data="    public class LinkPatient">`LinkPatient`</SwmToken> class, the <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatient.cs" pos="106:3:3" line-data="                new LinkEnquiryRepresentation(linkRefNumber, &quot;MEDIATED&quot;, meta));">`LinkEnquiryRepresentation`</SwmToken> is used to create a new link enquiry representation.

```c#
            var patientLinkReferenceResponse = new PatientLinkEnquiryRepresentation(
                new LinkEnquiryRepresentation(linkRefNumber, "MEDIATED", meta));
            return (patientLinkReferenceResponse, null);
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/LinkController.cs" line="103">

---

## Usage in <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkController.cs" pos="24:5:5" line-data="    public class LinkController : ControllerBase">`LinkController`</SwmToken> Class

In the <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkController.cs" pos="24:5:5" line-data="    public class LinkController : ControllerBase">`LinkController`</SwmToken> class, the <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkController.cs" pos="104:9:9" line-data="                var linkedPatientRepresentation = new LinkEnquiryRepresentation();">`LinkEnquiryRepresentation`</SwmToken> is used to handle link patient requests.

```c#
                    : await linkPatient.LinkPatients(patientReferenceRequest);
                var linkedPatientRepresentation = new LinkEnquiryRepresentation();
                if (linkReferenceResponse != null)
```

---

</SwmSnippet>

### Constructors

## Main Functions

The <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatient.cs" pos="106:3:3" line-data="                new LinkEnquiryRepresentation(linkRefNumber, &quot;MEDIATED&quot;, meta));">`LinkEnquiryRepresentation`</SwmToken> class includes several main functions, primarily its constructors and properties. We will explore these in more detail.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/LinkEnquiryRepresentation.cs" line="5">

---

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/LinkEnquiryRepresentation.cs" pos="5:3:3" line-data="        public LinkEnquiryRepresentation()">`LinkEnquiryRepresentation`</SwmToken> class includes two constructors. The parameterless constructor initializes a new instance of the class without setting any properties.

```c#
        public LinkEnquiryRepresentation()
        {
        }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/LinkEnquiryRepresentation.cs" line="1">

---

The parameterized constructor initializes a new instance of the class with the specified reference number, authentication type, and metadata.

```c#
namespace In.ProjectEKA.HipLibrary.Patient.Model
{
    public class LinkEnquiryRepresentation
    {
        public LinkEnquiryRepresentation()
        {
        }

        public LinkEnquiryRepresentation(string referenceNumber, string authenticationType, LinkReferenceMeta meta)
        {
            ReferenceNumber = referenceNumber;
            AuthenticationType = authenticationType;
            Meta = meta;
        }

        public string ReferenceNumber { get; }

        public string AuthenticationType { get; }

        public LinkReferenceMeta Meta { get; }
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
