---
title: Basic Concepts of CareContextEnquiry Model
---
# Overview of <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/CareContextEnquiry.cs" pos="3:5:5" line-data="    public class CareContextEnquiry">`CareContextEnquiry`</SwmToken> Model

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/CareContextEnquiry.cs" pos="3:5:5" line-data="    public class CareContextEnquiry">`CareContextEnquiry`</SwmToken> model class represents an enquiry about a specific care context using a reference number.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/CareContextEnquiry.cs" line="3">

---

It contains a constructor that initializes the reference number for the care context enquiry and has a single property, <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/CareContextEnquiry.cs" pos="7:1:1" line-data="            ReferenceNumber = referenceNumber;">`ReferenceNumber`</SwmToken>, which is a string that holds the reference number for the care context enquiry.

```c#
    public class CareContextEnquiry
    {
        public CareContextEnquiry(string referenceNumber)
        {
            ReferenceNumber = referenceNumber;
        }

        public string ReferenceNumber { get; }
    }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/LinkEnquiry.cs" line="5">

---

# Usage in <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/LinkEnquiry.cs" pos="5:5:5" line-data="    public class LinkEnquiry">`LinkEnquiry`</SwmToken>

In the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/LinkEnquiry.cs" pos="5:5:5" line-data="    public class LinkEnquiry">`LinkEnquiry`</SwmToken> class, care context enquiry is used to manage multiple care context enquiries associated with a link enquiry. The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/LinkEnquiry.cs" pos="5:5:5" line-data="    public class LinkEnquiry">`LinkEnquiry`</SwmToken> class initializes the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/LinkEnquiry.cs" pos="11:3:3" line-data="            IEnumerable&lt;CareContextEnquiry&gt; careContexts)">`CareContextEnquiry`</SwmToken> instances and stores them in the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/LinkEnquiry.cs" pos="16:1:1" line-data="            CareContexts = careContexts;">`CareContexts`</SwmToken> property.

```c#
    public class LinkEnquiry
    {
        public LinkEnquiry(
            string consentManagerId,
            string consentManagerUserId,
            string referenceNumber,
            IEnumerable<CareContextEnquiry> careContexts)
        {
            ConsentManagerId = consentManagerId;
            ConsentManagerUserId = consentManagerUserId;
            ReferenceNumber = referenceNumber;
            CareContexts = careContexts;
        }

        public string ConsentManagerId { get; }

        public string ConsentManagerUserId { get; }

        public string ReferenceNumber { get; }

        public IEnumerable<CareContextEnquiry> CareContexts { get; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/PatientLinkReference.cs" line="8">

---

# Usage in <SwmToken path="src/In.ProjectEKA.HipService/Link/PatientLinkReference.cs" pos="8:3:3" line-data="        public PatientLinkReference(string id, string referenceNumber, IEnumerable&lt;CareContextEnquiry&gt; careContexts)">`PatientLinkReference`</SwmToken>

In the <SwmToken path="src/In.ProjectEKA.HipService/Link/PatientLinkReference.cs" pos="8:3:3" line-data="        public PatientLinkReference(string id, string referenceNumber, IEnumerable&lt;CareContextEnquiry&gt; careContexts)">`PatientLinkReference`</SwmToken> class, care context enquiry is used to manage care context enquiries associated with a patient link reference. The <SwmToken path="src/In.ProjectEKA.HipService/Link/PatientLinkReference.cs" pos="8:3:3" line-data="        public PatientLinkReference(string id, string referenceNumber, IEnumerable&lt;CareContextEnquiry&gt; careContexts)">`PatientLinkReference`</SwmToken> class initializes the <SwmToken path="src/In.ProjectEKA.HipService/Link/PatientLinkReference.cs" pos="8:17:17" line-data="        public PatientLinkReference(string id, string referenceNumber, IEnumerable&lt;CareContextEnquiry&gt; careContexts)">`CareContextEnquiry`</SwmToken> instances and stores them in the <SwmToken path="src/In.ProjectEKA.HipService/Link/PatientLinkReference.cs" pos="12:1:1" line-data="            CareContexts = careContexts;">`CareContexts`</SwmToken> property.

```c#
        public PatientLinkReference(string id, string referenceNumber, IEnumerable<CareContextEnquiry> careContexts)
        {
            Id = id;
            ReferenceNumber = referenceNumber;
            CareContexts = careContexts;
        }

        public string Id { get; }

        public string ReferenceNumber { get; }

        public IEnumerable<CareContextEnquiry> CareContexts { get; }
    }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/LinkReference.cs" line="22">

---

# Usage in <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkReference.cs" pos="8:5:5" line-data="    public class LinkReference">`LinkReference`</SwmToken>

In the <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkReference.cs" pos="8:5:5" line-data="    public class LinkReference">`LinkReference`</SwmToken> class, care context enquiry is used to manage care context enquiries associated with a link reference. The <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkReference.cs" pos="8:5:5" line-data="    public class LinkReference">`LinkReference`</SwmToken> class initializes the <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkReference.cs" pos="22:5:5" line-data="        public IEnumerable&lt;CareContextEnquiry&gt; CareContexts { get; }">`CareContextEnquiry`</SwmToken> instances and stores them in the <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkReference.cs" pos="22:8:8" line-data="        public IEnumerable&lt;CareContextEnquiry&gt; CareContexts { get; }">`CareContexts`</SwmToken> property.

```c#
        public IEnumerable<CareContextEnquiry> CareContexts { get; }
    }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/LinkController.cs" line="24">

---

# Care Context Enquiry Endpoint

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/CareContextEnquiry.cs" pos="3:5:5" line-data="    public class CareContextEnquiry">`CareContextEnquiry`</SwmToken> endpoint in the <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkController.cs" pos="24:5:5" line-data="    public class LinkController : ControllerBase">`LinkController`</SwmToken> class handles enquiries about specific care contexts. It accepts a POST request with the care context enquiry details and processes it to provide the necessary information.

```c#
    public class LinkController : ControllerBase
    {
        private readonly IDiscoveryRequestRepository discoveryRequestRepository;
        private readonly IBackgroundJobClient backgroundJob;
        private readonly LinkPatient linkPatient;
        private readonly GatewayClient gatewayClient;
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/LinkController.cs" line="50">

---

# Care Context Enquiry APIs

The care context enquiry APIs provide endpoints to handle enquiries about specific care contexts using a reference number. These endpoints accept POST requests with the care context enquiry details and process them to provide the necessary information.

```c#

        /// <summary>
        /// Link patient's care contexts
        /// </summary>
        /// <remarks>
        /// Links care contexts associated with only one patient
        ///
        /// 1. Validate account reference number and care context reference number
        /// 2. Validate transactionId in the request with discovery request entry to check whether there was a discovery and were these care contexts discovered or not for a given patient
        /// 3. Before linking, HIP needs to authenticate the request with the patient(Ex: OTP verification)
        /// 4. Communicate the mode of authentication of a successful request with Consent Manager
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
