---
title: Overview of Error Class in Model
---
## Properties of Error

# Overview of Error Class in Model

The <SwmToken path="src/In.ProjectEKA.HipService/Discovery/PatientDiscovery.cs" pos="48:13:13" line-data="            return (null, new ErrorRepresentation(new Error(errorCode, errorMessage)));">`Error`</SwmToken> class represents an error that occurs within the system. It encapsulates error details and provides meaningful error information to the user or calling system.

The <SwmToken path="src/In.ProjectEKA.HipService/Discovery/PatientDiscovery.cs" pos="48:13:13" line-data="            return (null, new ErrorRepresentation(new Error(errorCode, errorMessage)));">`Error`</SwmToken> class contains two properties: <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Error.cs" pos="7:1:1" line-data="            Code = code;">`Code`</SwmToken> and <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Error.cs" pos="8:1:1" line-data="            Message = message;">`Message`</SwmToken>.

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Error.cs" pos="7:1:1" line-data="            Code = code;">`Code`</SwmToken> property holds the error code, which categorizes the type of error that occurred.

## Usage in Services and Controllers

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Error.cs" pos="8:1:1" line-data="            Message = message;">`Message`</SwmToken> property provides a descriptive message about the error, giving more context and information about what went wrong.

The <SwmToken path="src/In.ProjectEKA.HipService/Discovery/PatientDiscovery.cs" pos="48:13:13" line-data="            return (null, new ErrorRepresentation(new Error(errorCode, errorMessage)));">`Error`</SwmToken> class is used in various services and controllers such as `DataFlow`, <SwmToken path="src/In.ProjectEKA.HipService/Discovery/PatientDiscovery.cs" pos="12:9:9" line-data="    using In.ProjectEKA.HipService.Link.Model;">`Link`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/Discovery/PatientDiscovery.cs" pos="10:5:5" line-data="    using HipLibrary.Patient;">`Patient`</SwmToken>` `<SwmToken path="src/In.ProjectEKA.HipService/Discovery/PatientDiscovery.cs" pos="3:8:8" line-data="namespace In.ProjectEKA.HipService.Discovery">`Discovery`</SwmToken>, and <SwmToken path="src/In.ProjectEKA.HipService/Discovery/PatientDiscovery.cs" pos="78:3:3" line-data="                    $&quot;User has already linked care contexts: {request.TransactionId}&quot;);">`User`</SwmToken>` Authentication` to handle and represent errors consistently across the application.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Discovery/PatientDiscovery.cs" line="45">

---

For example, the <SwmToken path="src/In.ProjectEKA.HipService/Discovery/PatientDiscovery.cs" pos="45:11:11" line-data="        private ValueTuple&lt;DiscoveryRepresentation, ErrorRepresentation&gt; GetError(ErrorCode errorCode,">`GetError`</SwmToken> function in <SwmToken path="src/In.ProjectEKA.HipService/Discovery/PatientDiscovery.cs" pos="20:5:5" line-data="    public class PatientDiscovery : IPatientDiscovery">`PatientDiscovery`</SwmToken> generates an error representation with a specific error code and message.

```c#
        private ValueTuple<DiscoveryRepresentation, ErrorRepresentation> GetError(ErrorCode errorCode,
            string errorMessage)
        {
            return (null, new ErrorRepresentation(new Error(errorCode, errorMessage)));
        }

        public virtual async Task<ValueTuple<DiscoveryRepresentation, ErrorRepresentation>> PatientFor(
```

---

</SwmSnippet>

### Error Constructor

## Main Functions

There are several main functions in this class. Some of them are the Error constructor, Code property, and Message property. We will dive a little into each of these.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/Error.cs" line="5">

---

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Error.cs" pos="5:3:3" line-data="        public Error(ErrorCode code, string message)">`Error`</SwmToken> constructor initializes a new instance of the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Error.cs" pos="5:3:3" line-data="        public Error(ErrorCode code, string message)">`Error`</SwmToken> class. It takes an error code and a message as parameters, setting the respective properties to encapsulate the error details.

```c#
        public Error(ErrorCode code, string message)
        {
            Code = code;
            Message = message;
        }
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
