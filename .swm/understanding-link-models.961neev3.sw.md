---
title: Understanding Link Models
---
## LinkEnquires Class

# Understanding Link Models

The <SwmToken path="src/In.ProjectEKA.HipService/Link/Model/InitiatedLinkRequest.cs" pos="1:10:10" line-data="namespace In.ProjectEKA.HipService.Link.Model">`Model`</SwmToken> in the <SwmToken path="src/In.ProjectEKA.HipService/Link/Model/InitiatedLinkRequest.cs" pos="1:8:8" line-data="namespace In.ProjectEKA.HipService.Link.Model">`Link`</SwmToken> directory contains classes that represent the data structures used for linking patient information.

## <SwmToken path="src/In.ProjectEKA.HipService/Link/Model/InitiatedLinkRequest.cs" pos="5:5:5" line-data="    public class InitiatedLinkRequest">`InitiatedLinkRequest`</SwmToken> Class

The `LinkEnquires` class includes properties such as <SwmToken path="src/In.ProjectEKA.HipService/Link/Model/InitiatedLinkRequest.cs" pos="15:1:1" line-data="            LinkReferenceNumber = linkReferenceNumber;">`LinkReferenceNumber`</SwmToken>, `ConsentManagerId`, and `PatientReferenceNumber`, which are essential for managing link requests.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/Model/InitiatedLinkRequest.cs" line="1">

---

The <SwmToken path="src/In.ProjectEKA.HipService/Link/Model/InitiatedLinkRequest.cs" pos="5:5:5" line-data="    public class InitiatedLinkRequest">`InitiatedLinkRequest`</SwmToken> class has properties like <SwmToken path="src/In.ProjectEKA.HipService/Link/Model/InitiatedLinkRequest.cs" pos="13:1:1" line-data="            RequestId = requestId;">`RequestId`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/Link/Model/InitiatedLinkRequest.cs" pos="14:1:1" line-data="            TransactionId = transactionId;">`TransactionId`</SwmToken>, and <SwmToken path="src/In.ProjectEKA.HipService/Link/Model/InitiatedLinkRequest.cs" pos="16:1:1" line-data="            Status = status;">`Status`</SwmToken>, which are used to track the status and details of a link request.

```c#
namespace In.ProjectEKA.HipService.Link.Model
{
    using System.ComponentModel.DataAnnotations;

    public class InitiatedLinkRequest
    {
        public InitiatedLinkRequest(string requestId,
            string transactionId,
            string linkReferenceNumber,
            bool status,
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
