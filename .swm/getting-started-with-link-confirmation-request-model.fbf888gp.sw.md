---
title: Getting Started with Link Confirmation Request Model
---
## Overview

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/LinkConfirmationRequest.cs" pos="3:5:5" line-data="    public class LinkConfirmationRequest">`LinkConfirmationRequest`</SwmToken> is a model class that encapsulates the data required for confirming a link between a patient's health information and a consent manager. It contains two properties: <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/LinkConfirmationRequest.cs" pos="7:1:1" line-data="            Token = token;">`Token`</SwmToken> and <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/LinkConfirmationRequest.cs" pos="8:1:1" line-data="            LinkReferenceNumber = linkReferenceNumber;">`LinkReferenceNumber`</SwmToken>, which are initialized through its constructor.

## Properties

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/LinkConfirmationRequest.cs" pos="3:5:5" line-data="    public class LinkConfirmationRequest">`LinkConfirmationRequest`</SwmToken> class has two main properties:

- <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/LinkConfirmationRequest.cs" pos="7:1:1" line-data="            Token = token;">`Token`</SwmToken>: Holds a string value representing the token used for the link confirmation.
- <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/LinkConfirmationRequest.cs" pos="8:1:1" line-data="            LinkReferenceNumber = linkReferenceNumber;">`LinkReferenceNumber`</SwmToken>: Holds a string value representing the reference number associated with the link.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/LinkConfirmationRequest.cs" line="3">

---

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/LinkConfirmationRequest.cs" pos="3:5:5" line-data="    public class LinkConfirmationRequest">`LinkConfirmationRequest`</SwmToken> class is defined with its properties and constructor.

```c#
    public class LinkConfirmationRequest
    {
        public LinkConfirmationRequest(string token, string linkReferenceNumber)
        {
            Token = token;
            LinkReferenceNumber = linkReferenceNumber;
        }

        public string Token { get; }

        public string LinkReferenceNumber { get; }
    }
```

---

</SwmSnippet>

## Usage in <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkController.cs" pos="24:5:5" line-data="    public class LinkController : ControllerBase">`LinkController`</SwmToken>

In the <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkController.cs" pos="24:5:5" line-data="    public class LinkController : ControllerBase">`LinkController`</SwmToken>, the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/LinkConfirmationRequest.cs" pos="3:5:5" line-data="    public class LinkConfirmationRequest">`LinkConfirmationRequest`</SwmToken> is used to create a new instance with the token and link reference number from the request, which is then passed to the <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkController.cs" pos="133:2:2" line-data="                    .VerifyAndLinkCareContext(new LinkConfirmationRequest(request.Confirmation.Token,">`VerifyAndLinkCareContext`</SwmToken> method.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/LinkController.cs" line="132">

---

The <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkController.cs" pos="133:6:6" line-data="                    .VerifyAndLinkCareContext(new LinkConfirmationRequest(request.Confirmation.Token,">`LinkConfirmationRequest`</SwmToken> is instantiated and used in the <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkController.cs" pos="133:2:2" line-data="                    .VerifyAndLinkCareContext(new LinkConfirmationRequest(request.Confirmation.Token,">`VerifyAndLinkCareContext`</SwmToken> method.

```c#
                var (patientLinkResponse, cmId, error) = await linkPatient
                    .VerifyAndLinkCareContext(new LinkConfirmationRequest(request.Confirmation.Token,
                        request.Confirmation.LinkRefNumber));
```

---

</SwmSnippet>

## Example

Here is an example of how the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/LinkConfirmationRequest.cs" pos="3:5:5" line-data="    public class LinkConfirmationRequest">`LinkConfirmationRequest`</SwmToken> is used in the <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkController.cs" pos="24:5:5" line-data="    public class LinkController : ControllerBase">`LinkController`</SwmToken>:

```csharp
var (patientLinkResponse, cmId, error) = await linkPatient
    .VerifyAndLinkCareContext(new LinkConfirmationRequest(request.Confirmation.Token,
    request.Confirmation.LinkRefNumber));
```

## Conclusion

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/LinkConfirmationRequest.cs" pos="3:5:5" line-data="    public class LinkConfirmationRequest">`LinkConfirmationRequest`</SwmToken> model is essential for confirming links between a patient's health information and a consent manager. It is primarily used in the <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkController.cs" pos="24:5:5" line-data="    public class LinkController : ControllerBase">`LinkController`</SwmToken> to facilitate the verification and linking of care contexts.

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
