---
title: Understanding Resp Class
---
## Overview

<SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Resp.cs" pos="5:3:3" line-data="        public Resp(string requestId)">`Resp`</SwmToken> is a class in the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Resp.cs" pos="1:10:10" line-data="namespace In.ProjectEKA.HipLibrary.Patient.Model">`Model`</SwmToken> directory. It serves as a base class for other response-related classes, providing a common structure for handling request identifiers.

## Constructor

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Resp.cs" pos="5:3:3" line-data="        public Resp(string requestId)">`Resp`</SwmToken> constructor initializes the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Resp.cs" pos="7:1:1" line-data="            RequestId = requestId;">`RequestId`</SwmToken> property. It takes a string parameter <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Resp.cs" pos="5:7:7" line-data="        public Resp(string requestId)">`requestId`</SwmToken> and assigns it to the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Resp.cs" pos="7:1:1" line-data="            RequestId = requestId;">`RequestId`</SwmToken> property.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/Resp.cs" line="5">

---

The constructor initializes the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Resp.cs" pos="7:1:1" line-data="            RequestId = requestId;">`RequestId`</SwmToken> property with the provided <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Resp.cs" pos="5:7:7" line-data="        public Resp(string requestId)">`requestId`</SwmToken> parameter.

```c#
        public Resp(string requestId)
        {
            RequestId = requestId;
        }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/Resp.cs" line="10">

---

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Resp.cs" pos="10:5:5" line-data="        public string RequestId { get; }">`RequestId`</SwmToken> property is read-only and stores the request identifier.

```c#
        public string RequestId { get; }
    }
```

---

</SwmSnippet>

## Usage

Resp is used to encapsulate the request identifier in a response object. It is used by creating an instance of the class and passing the request identifier to its constructor. This initializes the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Resp.cs" pos="7:1:1" line-data="            RequestId = requestId;">`RequestId`</SwmToken> property, which can then be accessed as a read-only property. Other response-related classes can inherit from <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Resp.cs" pos="5:3:3" line-data="        public Resp(string requestId)">`Resp`</SwmToken> to utilize this common structure.

## Example

Resp is used in <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DiscoveryResponse.cs" pos="5:5:5" line-data="    public class DiscoveryResponse: Resp">`DiscoveryResponse`</SwmToken> to inherit the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Resp.cs" pos="7:1:1" line-data="            RequestId = requestId;">`RequestId`</SwmToken> property and structure.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/DiscoveryResponse.cs" line="4">

---

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DiscoveryResponse.cs" pos="5:5:5" line-data="    public class DiscoveryResponse: Resp">`DiscoveryResponse`</SwmToken> class inherits from <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DiscoveryResponse.cs" pos="5:8:8" line-data="    public class DiscoveryResponse: Resp">`Resp`</SwmToken> to utilize the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Resp.cs" pos="7:1:1" line-data="            RequestId = requestId;">`RequestId`</SwmToken> property.

```c#
{
    public class DiscoveryResponse: Resp
    {
```

---

</SwmSnippet>

## Endpoints

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Resp.cs" pos="5:3:3" line-data="        public Resp(string requestId)">`Resp`</SwmToken> class includes several endpoints such as `getDocument` and `getPlaylist`.

### getDocument

The `getDocument` function is used to get a document by its ID.

### getPlaylist

The `getPlaylist` function is used to get a playlist by its ID.

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
