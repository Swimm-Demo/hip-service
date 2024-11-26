---
title: Introduction to Common Models
---
## What is a Model

# Introduction to Common Models

Common Models in the application refer to a collection of classes that represent various entities and configurations used throughout the application. These models provide a standardized way to handle and manipulate data related to health information, consent management, and authentication.

## Usage of Models

A model refers to the classes and structures that represent the data and the business logic of the application. These models are used to handle the creation and management of various requests and responses.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/Model/LinkEnquires.cs" line="6">

---

Models are used to manage the state and identification of link requests, store information about the link request, and ensure the correct flow of data between the patient and the Consent Manager. For example, the <SwmToken path="src/In.ProjectEKA.HipService/Link/Model/LinkEnquires.cs" pos="6:5:5" line-data="    public class LinkEnquires">`LinkEnquires`</SwmToken> class includes properties such as <SwmToken path="src/In.ProjectEKA.HipService/Link/Model/LinkEnquires.cs" pos="21:1:1" line-data="            LinkReferenceNumber = linkReferenceNumber;">`LinkReferenceNumber`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/Link/Model/LinkEnquires.cs" pos="22:1:1" line-data="            ConsentManagerId = consentManagerId;">`ConsentManagerId`</SwmToken>, and <SwmToken path="src/In.ProjectEKA.HipService/Link/Model/LinkEnquires.cs" pos="23:1:1" line-data="            ConsentManagerUserId = consentManagerUserId;">`ConsentManagerUserId`</SwmToken> to store information about the link request.

```c#
    public class LinkEnquires
    {
        public LinkEnquires()
        {
        }

        public LinkEnquires(
            string patientReferenceNumber,
            string linkReferenceNumber,
            string consentManagerId,
            string consentManagerUserId,
            string dateTimeStamp,
            ICollection<CareContext> careContexts)
        {
            PatientReferenceNumber = patientReferenceNumber;
            LinkReferenceNumber = linkReferenceNumber;
            ConsentManagerId = consentManagerId;
            ConsentManagerUserId = consentManagerUserId;
```

---

</SwmSnippet>

### <SwmToken path="src/In.ProjectEKA.HipService/appsettings.Development.json" pos="29:2:2" line-data="  &quot;OtpService&quot;: {">`OtpService`</SwmToken>

## Model Endpoints

Model endpoints are specific configurations that define how different services interact with the models. These endpoints ensure that the models can communicate effectively with external services.

<SwmSnippet path="/src/In.ProjectEKA.HipService/appsettings.Development.json" line="29">

---

The <SwmToken path="src/In.ProjectEKA.HipService/appsettings.Development.json" pos="29:2:2" line-data="  &quot;OtpService&quot;: {">`OtpService`</SwmToken> endpoint is configured to handle OTP (One-Time Password) related operations. It includes a base URL and a sender system name, which are used to interact with the OTP service.

```json
  "OtpService": {
    "BaseUrl": "$OTPSERVICE_URL",
    "SenderSystemName": "Project-Eka HIP"
  },
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/appsettings.Development.json" line="49">

---

### Gateway

The <SwmToken path="src/In.ProjectEKA.HipService/appsettings.Development.json" pos="49:2:2" line-data="  &quot;Gateway&quot;: {">`Gateway`</SwmToken> endpoint is used for communication with the ABDM (Ayushman Bharat Digital Mission) gateway. It includes configurations such as the URL, timeout settings, and service URLs for ABHA number and address services.

```json
  "Gateway": {
    "url": "$GATEWAY_URL",
    "cmSuffix": "$GATEWAY_CMSUFFIX",
    "timeout": 3,
    "abhaNumberServiceUrl": "https://healthidsbx.abdm.gov.in/api",
    "abhaAddressServiceUrl": "https://phrsbx.abdm.gov.in/api",
    "benefitName": "$BENEFIT_NAME"
  },
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
