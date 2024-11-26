---
title: Introduction to Resp Class
---
# Introduction to Resp Class

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Resp.cs" pos="5:3:3" line-data="        public Resp(string requestId)">`Resp`</SwmToken> class is located in the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Resp.cs" pos="1:10:10" line-data="namespace In.ProjectEKA.HipLibrary.Patient.Model">`Model`</SwmToken> directory and serves as a base class for other response-related classes. It provides a common structure for handling request identifiers.

The primary purpose of the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Resp.cs" pos="5:3:3" line-data="        public Resp(string requestId)">`Resp`</SwmToken> class is to encapsulate the request identifier in a response object. This is achieved by creating an instance of the class and passing the request identifier to its constructor.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/Resp.cs" line="5">

---

Upon instantiation, the constructor initializes the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Resp.cs" pos="7:1:1" line-data="            RequestId = requestId;">`RequestId`</SwmToken> property, which is a read-only property. This ensures that every instance of the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Resp.cs" pos="5:3:3" line-data="        public Resp(string requestId)">`Resp`</SwmToken> class has a unique request identifier.

```c#
        public Resp(string requestId)
        {
            RequestId = requestId;
        }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/DiscoveryResponse.cs" line="4">

---

Other response-related classes can inherit from the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DiscoveryResponse.cs" pos="5:8:8" line-data="    public class DiscoveryResponse: Resp">`Resp`</SwmToken> class to utilize this common structure. For example, the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DiscoveryResponse.cs" pos="5:5:5" line-data="    public class DiscoveryResponse: Resp">`DiscoveryResponse`</SwmToken> class inherits from <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DiscoveryResponse.cs" pos="5:8:8" line-data="    public class DiscoveryResponse: Resp">`Resp`</SwmToken> to make use of the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Resp.cs" pos="7:1:1" line-data="            RequestId = requestId;">`RequestId`</SwmToken> property and structure.

```c#
{
    public class DiscoveryResponse: Resp
    {
```

---

</SwmSnippet>

## <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Resp.cs" pos="7:1:1" line-data="            RequestId = requestId;">`RequestId`</SwmToken>

## Constructor

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Resp.cs" pos="5:3:3" line-data="        public Resp(string requestId)">`Resp`</SwmToken> class has a constructor that takes a request identifier as a parameter. This constructor initializes the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Resp.cs" pos="7:1:1" line-data="            RequestId = requestId;">`RequestId`</SwmToken> property, ensuring that each instance of the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Resp.cs" pos="5:3:3" line-data="        public Resp(string requestId)">`Resp`</SwmToken> class has a unique request identifier.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/Resp.cs" line="10">

---

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Resp.cs" pos="10:5:5" line-data="        public string RequestId { get; }">`RequestId`</SwmToken> property is a read-only property that stores the request identifier passed to the constructor. This property is used to uniquely identify each response object. Other response-related classes can inherit from the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Resp.cs" pos="5:3:3" line-data="        public Resp(string requestId)">`Resp`</SwmToken> class to utilize this common structure.

```c#
        public string RequestId { get; }
    }
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
