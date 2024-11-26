---
title: Getting Started with Link Enquiry Model
---
# Getting Started with Link Enquiry Model

The Link Enquiry model represents the details required to link a patient's care contexts with a consent manager.

## Properties of Link Enquiry

It includes properties such as <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/LinkEnquiry.cs" pos="13:1:1" line-data="            ConsentManagerId = consentManagerId;">`ConsentManagerId`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/LinkEnquiry.cs" pos="14:1:1" line-data="            ConsentManagerUserId = consentManagerUserId;">`ConsentManagerUserId`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/LinkEnquiry.cs" pos="15:1:1" line-data="            ReferenceNumber = referenceNumber;">`ReferenceNumber`</SwmToken>, and a collection of <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/LinkEnquiry.cs" pos="11:3:3" line-data="            IEnumerable&lt;CareContextEnquiry&gt; careContexts)">`CareContextEnquiry`</SwmToken> objects.

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/LinkEnquiry.cs" pos="13:1:1" line-data="            ConsentManagerId = consentManagerId;">`ConsentManagerId`</SwmToken> and <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/LinkEnquiry.cs" pos="14:1:1" line-data="            ConsentManagerUserId = consentManagerUserId;">`ConsentManagerUserId`</SwmToken> are identifiers for the consent manager and the user within the consent manager system.

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/LinkEnquiry.cs" pos="15:1:1" line-data="            ReferenceNumber = referenceNumber;">`ReferenceNumber`</SwmToken> is used to uniquely identify the link enquiry request.

## Usage of Link Enquiry

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/LinkEnquiry.cs" pos="16:1:1" line-data="            CareContexts = careContexts;">`CareContexts`</SwmToken> property holds a list of care contexts that are being linked.

Link enquiry is used to facilitate the linking of a patient's care contexts with a consent manager by providing necessary identifiers and reference numbers.

## Example Usage of Link Enquiry

It is instantiated with the consent manager ID, user ID, reference number, and a collection of care context enquiries.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/LinkController.cs" line="77">

---

An example of using Link enquiry is in the <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkController.cs" pos="24:5:5" line-data="    public class LinkController : ControllerBase">`LinkController`</SwmToken> where it is instantiated with the consent manager suffix, user ID, reference number, and care contexts.

```c#
            var cmSuffix = cmUserId.Substring(cmUserId.LastIndexOf("@", StringComparison.Ordinal) + 1);
            var patient = new LinkEnquiry(
                cmSuffix,
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/LinkEnquiry.cs" line="7">

---

## Link Enquiry Function

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/LinkEnquiry.cs" pos="7:3:3" line-data="        public LinkEnquiry(">`LinkEnquiry`</SwmToken> function is used to create a new link enquiry instance with the provided consent manager ID, user ID, reference number, and a collection of care context enquiries.

```c#
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
```

---

</SwmSnippet>

## Link Enquiry APIs

The Link Enquiry endpoint is used to facilitate the linking of a patient's care contexts with a consent manager. This endpoint requires details such as <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/LinkEnquiry.cs" pos="13:1:1" line-data="            ConsentManagerId = consentManagerId;">`ConsentManagerId`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/LinkEnquiry.cs" pos="14:1:1" line-data="            ConsentManagerUserId = consentManagerUserId;">`ConsentManagerUserId`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/LinkEnquiry.cs" pos="15:1:1" line-data="            ReferenceNumber = referenceNumber;">`ReferenceNumber`</SwmToken>, and a collection of <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/LinkEnquiry.cs" pos="11:3:3" line-data="            IEnumerable&lt;CareContextEnquiry&gt; careContexts)">`CareContextEnquiry`</SwmToken> objects. These details are necessary to uniquely identify the link enquiry request and the care contexts being linked.

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
