---
title: Basic Concepts of Link Reference Metadata
---
# Basic Concepts of Link Reference Metadata

Link reference metadata is encapsulated in the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/LinkReferenceMeta.cs" pos="5:3:3" line-data="        public LinkReferenceMeta(string communicationMedium, string communicationHint, string communicationExpiry)">`LinkReferenceMeta`</SwmToken> class. This class contains metadata related to the communication medium used for linking a patient's account.

## Properties

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/LinkReferenceMeta.cs" pos="5:3:3" line-data="        public LinkReferenceMeta(string communicationMedium, string communicationHint, string communicationExpiry)">`LinkReferenceMeta`</SwmToken> class includes details such as the medium of communication, a hint for the communication, and the expiry time for the communication.

## Constructor

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/LinkReferenceMeta.cs" pos="5:3:3" line-data="        public LinkReferenceMeta(string communicationMedium, string communicationHint, string communicationExpiry)">`LinkReferenceMeta`</SwmToken> class has three main properties: <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/LinkReferenceMeta.cs" pos="7:1:1" line-data="            CommunicationMedium = communicationMedium;">`CommunicationMedium`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/LinkReferenceMeta.cs" pos="8:1:1" line-data="            CommunicationHint = communicationHint;">`CommunicationHint`</SwmToken>, and <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/LinkReferenceMeta.cs" pos="9:1:1" line-data="            CommunicationExpiry = communicationExpiry;">`CommunicationExpiry`</SwmToken>.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/LinkReferenceMeta.cs" line="5">

---

The constructor of the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/LinkReferenceMeta.cs" pos="5:3:3" line-data="        public LinkReferenceMeta(string communicationMedium, string communicationHint, string communicationExpiry)">`LinkReferenceMeta`</SwmToken> class initializes these properties with the provided values.

```c#
        public LinkReferenceMeta(string communicationMedium, string communicationHint, string communicationExpiry)
        {
            CommunicationMedium = communicationMedium;
            CommunicationHint = communicationHint;
            CommunicationExpiry = communicationExpiry;
        }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/LinkPatient.cs" line="103">

---

## Usage

The <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatient.cs" pos="104:9:9" line-data="            var meta = new LinkReferenceMeta(nameof(CommunicationMode.MOBILE), patient.PhoneNumber, expiry);">`LinkReferenceMeta`</SwmToken> class is used in the <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatient.cs" pos="106:3:3" line-data="                new LinkEnquiryRepresentation(linkRefNumber, &quot;MEDIATED&quot;, meta));">`LinkEnquiryRepresentation`</SwmToken> and <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatient.cs" pos="22:5:5" line-data="    public class LinkPatient">`LinkPatient`</SwmToken> classes to provide metadata about the communication medium during the linking process.

```c#
            var expiry = DateTime.Now.Add(time).ToUniversalTime().ToString(Constants.DateTimeFormat);
            var meta = new LinkReferenceMeta(nameof(CommunicationMode.MOBILE), patient.PhoneNumber, expiry);
            var patientLinkReferenceResponse = new PatientLinkEnquiryRepresentation(
```

---

</SwmSnippet>

## Link Reference Meta Endpoints

The `/link/reference/meta` endpoint is used to retrieve metadata related to the communication medium for linking a patient's account. This endpoint provides details such as the medium of communication, a hint for the communication, and the expiry time for the communication.

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
