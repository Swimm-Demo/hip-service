---
title: Overview of the Resp Model
---
## Purpose of Resp

# What is Resp Model

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DiscoveryResponse.cs" pos="5:8:8" line-data="    public class DiscoveryResponse: Resp">`Resp`</SwmToken> class is a model located in the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DiscoveryResponse.cs" pos="3:2:10" line-data="namespace In.ProjectEKA.HipLibrary.Patient.Model">`In.ProjectEKA.HipLibrary.Patient.Model`</SwmToken> namespace.

## Functionality of Resp

The primary purpose of the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DiscoveryResponse.cs" pos="5:8:8" line-data="    public class DiscoveryResponse: Resp">`Resp`</SwmToken> class is to serve as a model that encapsulates the request identifier within the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DiscoveryResponse.cs" pos="3:2:10" line-data="namespace In.ProjectEKA.HipLibrary.Patient.Model">`In.ProjectEKA.HipLibrary.Patient.Model`</SwmToken> namespace.

## Usage of Resp

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DiscoveryResponse.cs" pos="5:8:8" line-data="    public class DiscoveryResponse: Resp">`Resp`</SwmToken> class contains a constructor that initializes the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Resp.cs" pos="7:1:1" line-data="            RequestId = requestId;">`RequestId`</SwmToken> property with a given string value. This property is a read-only string that stores the request identifier.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/DiscoveryResponse.cs" line="4">

---

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DiscoveryResponse.cs" pos="5:8:8" line-data="    public class DiscoveryResponse: Resp">`Resp`</SwmToken> class is used in various parts of the codebase, such as in the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DiscoveryResponse.cs" pos="5:5:5" line-data="    public class DiscoveryResponse: Resp">`DiscoveryResponse`</SwmToken> class.

```c#
{
    public class DiscoveryResponse: Resp
    {
```

---

</SwmSnippet>

### Constructor

## Main Functions

The main functions of the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DiscoveryResponse.cs" pos="5:8:8" line-data="    public class DiscoveryResponse: Resp">`Resp`</SwmToken> class include its constructor and the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Resp.cs" pos="7:1:1" line-data="            RequestId = requestId;">`RequestId`</SwmToken> property. The constructor initializes the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Resp.cs" pos="7:1:1" line-data="            RequestId = requestId;">`RequestId`</SwmToken> property with a given string value.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/Resp.cs" line="5">

---

The constructor of the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Resp.cs" pos="5:3:3" line-data="        public Resp(string requestId)">`Resp`</SwmToken> class initializes the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Resp.cs" pos="7:1:1" line-data="            RequestId = requestId;">`RequestId`</SwmToken> property with a given string value.

```c#
        public Resp(string requestId)
        {
            RequestId = requestId;
        }
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
