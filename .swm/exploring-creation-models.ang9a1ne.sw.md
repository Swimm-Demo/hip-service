---
title: Exploring Creation Models
---
## What is a Model

A model refers to the classes and structures that represent the data and the business logic of the application. These models are used to handle the creation and management of various requests and responses.

## How Models are Used

In the Creation directory, models are specifically used to handle the creation of different types of requests and responses related to the Health Information Provider service. These include requests for generating OTPs, verifying Aadhaar, linking addresses, and creating ABHA profiles.

## Example of Model Usage

The <SwmToken path="src/In.ProjectEKA.HipService/Creation/Model/CreateABHARequest.cs" pos="7:5:5" line-data="    public class CreateABHARequest">`CreateABHARequest`</SwmToken> class is a model that represents a request to create an ABHA (Ayushman Bharat Health Account). It includes properties like <SwmToken path="src/In.ProjectEKA.HipService/Creation/Model/CreateABHARequest.cs" pos="9:5:5" line-data="        public string txnId;">`txnId`</SwmToken> to store the transaction ID associated with the request.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Creation/Model/CreateABHARequest.cs" line="3">

---

The <SwmToken path="src/In.ProjectEKA.HipService/Creation/Model/CreateABHARequest.cs" pos="7:5:5" line-data="    public class CreateABHARequest">`CreateABHARequest`</SwmToken> class is defined in the <SwmToken path="src/In.ProjectEKA.HipService/Creation/Model/CreateABHARequest.cs" pos="5:2:10" line-data="namespace In.ProjectEKA.HipService.Creation.Model">`In.ProjectEKA.HipService.Creation.Model`</SwmToken> namespace and uses the <SwmToken path="src/In.ProjectEKA.HipService/Creation/Model/CreateABHARequest.cs" pos="3:2:4" line-data="using Newtonsoft.Json;">`Newtonsoft.Json`</SwmToken> library for JSON serialization.

```c#
using Newtonsoft.Json;

namespace In.ProjectEKA.HipService.Creation.Model
```

---

</SwmSnippet>

## Model Endpoints

Model endpoints are used to interact with the models and perform various operations. Below are some examples of model endpoints.

### <SwmToken path="src/In.ProjectEKA.HipService/Creation/Model/CreateABHARequest.cs" pos="7:5:5" line-data="    public class CreateABHARequest">`CreateABHARequest`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipService/Creation/Model/CreateABHARequest.cs" pos="7:5:5" line-data="    public class CreateABHARequest">`CreateABHARequest`</SwmToken> class is a model that represents a request to create an ABHA (Ayushman Bharat Health Account). It includes properties like <SwmToken path="src/In.ProjectEKA.HipService/Creation/Model/CreateABHARequest.cs" pos="9:5:5" line-data="        public string txnId;">`txnId`</SwmToken> to store the transaction ID associated with the request. This model ensures that the data is correctly structured and validated before being processed by the service.

### VerifyAadhaarRequest

The `VerifyAadhaarRequest` class is a model that represents a request to verify an Aadhaar number. It includes properties like `aadhaarNumber` and `otp` to store the necessary information for verification. This model helps in structuring and validating the data before it is processed by the service.

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
