---
title: Creation Models Overview
---
# Overview of Creation Models

The models in the Creation directory are responsible for defining the structure and data representation of various requests and responses related to the creation process.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Creation/Model/CreateABHARequest.cs" line="5">

---

For instance, the <SwmToken path="src/In.ProjectEKA.HipService/Creation/Model/CreateABHARequest.cs" pos="7:5:5" line-data="    public class CreateABHARequest">`CreateABHARequest`</SwmToken> class is used to create a request for an Ayushman Bharat Health Account (ABHA) with a specific transaction ID.

```c#
namespace In.ProjectEKA.HipService.Creation.Model
```

---

</SwmSnippet>

This class includes a constructor that initializes the transaction ID, ensuring that each request is uniquely identifiable.

# Usage of Models

Other models in this directory, such as `PhrAddressLinkRequest`, `OTPVerifyRequest`, and `TransactionResponse`, serve similar purposes for different types of requests and responses.

The models are used in various files such as <SwmToken path="src/In.ProjectEKA.HipService/Creation/Model/CreateABHARequest.cs" pos="7:5:5" line-data="    public class CreateABHARequest">`CreateABHARequest`</SwmToken>, `PhrAddressLinkRequest`, `OTPVerifyRequest`, and `TransactionResponse`.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Creation/Model/CreateABHARequest.cs" line="5">

---

For example, the <SwmToken path="src/In.ProjectEKA.HipService/Creation/Model/CreateABHARequest.cs" pos="7:5:5" line-data="    public class CreateABHARequest">`CreateABHARequest`</SwmToken> class is used to create a request for ABHA with a specific transaction ID.

```c#
namespace In.ProjectEKA.HipService.Creation.Model
```

---

</SwmSnippet>

## <SwmToken path="src/In.ProjectEKA.HipService/Creation/Model/CreateABHARequest.cs" pos="7:5:5" line-data="    public class CreateABHARequest">`CreateABHARequest`</SwmToken>

# Model Endpoints

The endpoints for these models handle the requests and responses defined by the models.

The <SwmToken path="src/In.ProjectEKA.HipService/Creation/Model/CreateABHARequest.cs" pos="7:5:5" line-data="    public class CreateABHARequest">`CreateABHARequest`</SwmToken> endpoint is used to create a request for an Ayushman Bharat Health Account (ABHA) with a specific transaction ID. This ensures that each request is uniquely identifiable.

## OTPVerifyRequest

The `OTPVerifyRequest` endpoint is used to verify a one-time password (OTP) for a specific transaction. This is crucial for ensuring the security and validity of the transaction.

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
