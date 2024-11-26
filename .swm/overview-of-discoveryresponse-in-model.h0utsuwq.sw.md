---
title: Overview of DiscoveryResponse in Model
---
# What is <SwmToken path="src/In.ProjectEKA.HipService/Discovery/PatientController.cs" pos="96:3:3" line-data="                    new DiscoveryResponse(request.RequestId, HttpStatusCode.InternalServerError,">`DiscoveryResponse`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipService/Discovery/PatientController.cs" pos="96:3:3" line-data="                    new DiscoveryResponse(request.RequestId, HttpStatusCode.InternalServerError,">`DiscoveryResponse`</SwmToken> class is designed to encapsulate the response details of a discovery request.

## Properties

It inherits from the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DiscoveryResponse.cs" pos="5:8:8" line-data="    public class DiscoveryResponse: Resp">`Resp`</SwmToken> class and includes two main properties: <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DiscoveryResponse.cs" pos="7:5:5" line-data="        public HttpStatusCode StatusCode { get; }">`StatusCode`</SwmToken> and <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DiscoveryResponse.cs" pos="8:5:5" line-data="        public string Message { get; }">`Message`</SwmToken>.

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DiscoveryResponse.cs" pos="7:5:5" line-data="        public HttpStatusCode StatusCode { get; }">`StatusCode`</SwmToken> property holds the HTTP status code of the response, indicating the result of the discovery request.

## Usage Examples

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DiscoveryResponse.cs" pos="8:5:5" line-data="        public string Message { get; }">`Message`</SwmToken> property contains a message related to the discovery response, providing additional information about the result of the discovery request.

The <SwmToken path="src/In.ProjectEKA.HipService/Discovery/PatientController.cs" pos="96:3:3" line-data="                    new DiscoveryResponse(request.RequestId, HttpStatusCode.InternalServerError,">`DiscoveryResponse`</SwmToken> class is used in various parts of the codebase to handle discovery responses. Below are some examples of its usage:

<SwmSnippet path="/src/In.ProjectEKA.HipService/Discovery/PatientController.cs" line="95">

---

An example usage of <SwmToken path="src/In.ProjectEKA.HipService/Discovery/PatientController.cs" pos="96:3:3" line-data="                    new DiscoveryResponse(request.RequestId, HttpStatusCode.InternalServerError,">`DiscoveryResponse`</SwmToken> in `PatientController` to handle an error response.

```c#
                    new Error(ErrorCode.ServerInternalError, "Unreachable external service"),
                    new DiscoveryResponse(request.RequestId, HttpStatusCode.InternalServerError,
                        "Unreachable external service"));
```

---

</SwmSnippet>

### <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DiscoveryResponse.cs" pos="7:5:5" line-data="        public HttpStatusCode StatusCode { get; }">`StatusCode`</SwmToken>

## Main Functions

There are several main functions in the <SwmToken path="src/In.ProjectEKA.HipService/Discovery/PatientController.cs" pos="96:3:3" line-data="                    new DiscoveryResponse(request.RequestId, HttpStatusCode.InternalServerError,">`DiscoveryResponse`</SwmToken> class. Some of them are <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DiscoveryResponse.cs" pos="7:5:5" line-data="        public HttpStatusCode StatusCode { get; }">`StatusCode`</SwmToken> and <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DiscoveryResponse.cs" pos="8:5:5" line-data="        public string Message { get; }">`Message`</SwmToken>. We will dive a little into these functions.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/DiscoveryResponse.cs" line="7">

---

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DiscoveryResponse.cs" pos="7:5:5" line-data="        public HttpStatusCode StatusCode { get; }">`StatusCode`</SwmToken> property holds the HTTP status code of the response, indicating the result of the discovery request.

```c#
        public HttpStatusCode StatusCode { get; }
```

---

</SwmSnippet>

## Discovery Response Endpoints

The <SwmToken path="src/In.ProjectEKA.HipService/Discovery/PatientController.cs" pos="96:3:3" line-data="                    new DiscoveryResponse(request.RequestId, HttpStatusCode.InternalServerError,">`DiscoveryResponse`</SwmToken> class is designed to encapsulate the response details of a discovery request. It inherits from the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DiscoveryResponse.cs" pos="5:8:8" line-data="    public class DiscoveryResponse: Resp">`Resp`</SwmToken> class and includes two main properties: <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DiscoveryResponse.cs" pos="7:5:5" line-data="        public HttpStatusCode StatusCode { get; }">`StatusCode`</SwmToken> and <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DiscoveryResponse.cs" pos="8:5:5" line-data="        public string Message { get; }">`Message`</SwmToken>. The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DiscoveryResponse.cs" pos="7:5:5" line-data="        public HttpStatusCode StatusCode { get; }">`StatusCode`</SwmToken> property holds the HTTP status code of the response, indicating the result of the discovery request. The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DiscoveryResponse.cs" pos="8:5:5" line-data="        public string Message { get; }">`Message`</SwmToken> property contains a message related to the discovery response, providing additional information about the result of the discovery request.

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
