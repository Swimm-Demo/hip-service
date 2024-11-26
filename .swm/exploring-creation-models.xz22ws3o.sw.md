---
title: Exploring Creation Models
---
# Why Models are Used

# What is a Model

A model refers to the classes and structures that represent the data and the business logic of the application.

# How Models are Used

These models are used to handle the creation and management of various requests and responses.

# Example of Model Usage

In the Creation directory, models are specifically designed to manage the creation of health information requests and responses.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Creation/Model/CreateABHARequest.cs" line="1">

---

For example, the <SwmToken path="src/In.ProjectEKA.HipService/Creation/Model/CreateABHARequest.cs" pos="7:5:5" line-data="    public class CreateABHARequest">`CreateABHARequest`</SwmToken> class is used to create a request for generating an ABHA (Ayushman Bharat Health Account) ID.

```c#


using Newtonsoft.Json;

namespace In.ProjectEKA.HipService.Creation.Model
```

---

</SwmSnippet>

# Model Endpoints

The <SwmToken path="src/In.ProjectEKA.HipService/Creation/Model/CreateABHARequest.cs" pos="7:5:5" line-data="    public class CreateABHARequest">`CreateABHARequest`</SwmToken> class is used to create a request for generating an ABHA (Ayushman Bharat Health Account) ID. This model handles the necessary data and business logic required to initiate the creation of an ABHA ID.

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
