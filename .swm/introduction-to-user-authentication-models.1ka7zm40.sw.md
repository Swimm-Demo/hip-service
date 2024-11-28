---
title: Introduction to User Authentication Models
---
## What is a User Authentication Model

# Introduction to User Authentication Models

User authentication models are essential components in any application that requires user verification and authorization. These models define the structure and data required for user authentication processes, ensuring secure and efficient handling of user credentials and authentication requests.

## Key Classes in User Authentication Models

In the context of user authentication, a <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/Model/AuthInitQuery.cs" pos="3:10:10" line-data="namespace In.ProjectEKA.HipService.UserAuth.Model">`Model`</SwmToken> refers to the classes and properties that define the structure and data required for user authentication processes. These models encapsulate the necessary information and behaviors to manage authentication requests and responses.

### <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/Model/AuthInitQuery.cs" pos="5:5:5" line-data="    public class AuthInitQuery">`AuthInitQuery`</SwmToken> Class

Several key classes are used to handle user authentication in the repository. These include <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/Model/AuthInitQuery.cs" pos="5:5:5" line-data="    public class AuthInitQuery">`AuthInitQuery`</SwmToken> and `AuthInitRequest`, among others. Each class contains specific properties that are crucial for the authentication process.

<SwmSnippet path="/src/In.ProjectEKA.HipService/UserAuth/Model/AuthInitQuery.cs" line="3">

---

The <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/Model/AuthInitQuery.cs" pos="5:5:5" line-data="    public class AuthInitQuery">`AuthInitQuery`</SwmToken> class is used to initialize an authentication request. It contains properties such as <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/Model/AuthInitQuery.cs" pos="7:5:5" line-data="        public string id { get; }">`id`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/Model/AuthInitQuery.cs" pos="8:5:5" line-data="        public string purpose { get; } = KYC_AND_LINK;">`purpose`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/Model/AuthInitQuery.cs" pos="9:5:5" line-data="        public string authMode { get; }">`authMode`</SwmToken>, and <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/Model/AuthInitQuery.cs" pos="10:5:5" line-data="        public Requester requester { get; }">`requester`</SwmToken>, which are essential for this process.

```c#
namespace In.ProjectEKA.HipService.UserAuth.Model
```

---

</SwmSnippet>

### AuthInitRequest Class

The <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/Model/AuthInitQuery.cs" pos="7:5:5" line-data="        public string id { get; }">`id`</SwmToken> property uniquely identifies the authentication request, while the <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/Model/AuthInitQuery.cs" pos="8:5:5" line-data="        public string purpose { get; } = KYC_AND_LINK;">`purpose`</SwmToken> property, which defaults to <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/Model/AuthInitQuery.cs" pos="8:16:16" line-data="        public string purpose { get; } = KYC_AND_LINK;">`KYC_AND_LINK`</SwmToken>, specifies the reason for the authentication. The <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/Model/AuthInitQuery.cs" pos="9:5:5" line-data="        public string authMode { get; }">`authMode`</SwmToken> property indicates the mode of authentication to be used, and the <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/Model/AuthInitQuery.cs" pos="10:5:5" line-data="        public Requester requester { get; }">`requester`</SwmToken> property holds information about the entity requesting the authentication.

Similarly, the `AuthInitRequest` class includes properties like `healthId`, <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/Model/AuthInitQuery.cs" pos="9:5:5" line-data="        public string authMode { get; }">`authMode`</SwmToken>, and <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/Model/AuthInitQuery.cs" pos="8:5:5" line-data="        public string purpose { get; } = KYC_AND_LINK;">`purpose`</SwmToken>, which are used to create an authentication request with specific details.

## Usage of User Authentication Models

User authentication models are used throughout the codebase to manage and process authentication requests. These models encapsulate the data and behavior related to user authentication, ensuring that the authentication process is handled consistently and securely.

## Example of Model Usage

For example, the <SwmToken path="src/In.ProjectEKA.HipService/UserAuth/Model/AuthInitQuery.cs" pos="5:5:5" line-data="    public class AuthInitQuery">`AuthInitQuery`</SwmToken> class is used to initialize an authentication request, while the `AuthInitRequest` class is used to create an authentication request with specific details. These models are utilized in various files such as <SwmPath>[src/In.ProjectEKA.HipService/UserAuth/Model/AuthConfirmPatient.cs](src/In.ProjectEKA.HipService/UserAuth/Model/AuthConfirmPatient.cs)</SwmPath>, <SwmPath>[src/In.ProjectEKA.HipService/UserAuth/Model/AuthOnNotifyAcknowledgement.cs](src/In.ProjectEKA.HipService/UserAuth/Model/AuthOnNotifyAcknowledgement.cs)</SwmPath>, <SwmPath>[src/In.ProjectEKA.HipService/UserAuth/Model/AuthOnNotifyResponse.cs](src/In.ProjectEKA.HipService/UserAuth/Model/AuthOnNotifyResponse.cs)</SwmPath>, and many others.

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
