---
title: The DataFlow class
---
This document will cover the class <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/DataFlow.cs" pos="26:3:3" line-data="        public DataFlow(IDataFlowRepository dataFlowRepository,">`DataFlow`</SwmToken> in the file <SwmPath>[src/In.ProjectEKA.HipService/DataFlow/DataFlow.cs](src/In.ProjectEKA.HipService/DataFlow/DataFlow.cs)</SwmPath>. We will cover:

1. What is <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/DataFlow.cs" pos="26:3:3" line-data="        public DataFlow(IDataFlowRepository dataFlowRepository,">`DataFlow`</SwmToken>
2. Variables and functions

# Variables and functions

# What is <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/DataFlow.cs" pos="26:3:3" line-data="        public DataFlow(IDataFlowRepository dataFlowRepository,">`DataFlow`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/DataFlow.cs" pos="26:3:3" line-data="        public DataFlow(IDataFlowRepository dataFlowRepository,">`DataFlow`</SwmToken> class in <SwmPath>[src/In.ProjectEKA.HipService/DataFlow/DataFlow.cs](src/In.ProjectEKA.HipService/DataFlow/DataFlow.cs)</SwmPath> is a core component responsible for managing the flow of health information data. It handles requests for health information, processes consent artifacts, and interacts with various repositories to fetch and store data. The class also manages the publication of data requests to a messaging queue.

<SwmSnippet path="/src/In.ProjectEKA.HipService/DataFlow/DataFlow.cs" line="43">

---

The function <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/DataFlow.cs" pos="43:15:15" line-data="        public async Task&lt;Tuple&lt;HealthInformationTransactionResponse, ErrorRepresentation&gt;&gt; HealthInformationRequestFor(">`HealthInformationRequestFor`</SwmToken> handles requests for health information by validating the consent artifact, fetching the patient UUID, creating a data request, and publishing it to the messaging queue.

```c#
        public async Task<Tuple<HealthInformationTransactionResponse, ErrorRepresentation>> HealthInformationRequestFor(
            HealthInformationRequest request,
            string gatewayId,
            string correlationId)
        {
            var consent = await consentRepository.GetFor(request.Consent.Id);
            if (consent == null) return ConsentArtefactNotFound();
            var (patientUuid, _) =
                await linkPatientRepository.GetPatientUuid(consent.ConsentArtefact.Patient.Id);

            var dataRequest = new DataRequest(consent.ConsentArtefact.CareContexts,
                request.DateRange,
                request.DataPushUrl,
                consent.ConsentArtefact.HiTypes,
                request.TransactionId,
                request.KeyMaterial,
                gatewayId,
                consent.ConsentArtefactId,
                consent.ConsentArtefact.ConsentManager.Id,
                correlationId,
                patientUuid);
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/DataFlow/DataFlow.cs" line="97">

---

The function <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/DataFlow.cs" pos="97:10:10" line-data="        public async Task&lt;string&gt; GetPatientId(string consentId)">`GetPatientId`</SwmToken> retrieves the patient ID associated with a given consent ID by querying the consent repository.

```c#
        public async Task<string> GetPatientId(string consentId)
        {
            var consent = await consentRepository.GetFor(consentId);
            if (consent != null)
                return consent.ConsentArtefact.Patient.Id;
            logger.Log(LogLevel.Error, LogEvents.DataFlow, "Consent does not exist: {Consent}", consentId);
            // need to handle it better by returning optional
            return null;
        }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/DataFlow/DataFlow.cs" line="107">

---

The function <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/DataFlow.cs" pos="107:15:15" line-data="        public async Task&lt;Tuple&lt;HealthInformationResponse, ErrorRepresentation&gt;&gt; HealthInformationFor(">`HealthInformationFor`</SwmToken> fetches health information based on an information ID and token, and returns the information or an error representation.

```c#
        public async Task<Tuple<HealthInformationResponse, ErrorRepresentation>> HealthInformationFor(
            string informationId,
            string token)
        {
            var healthInformation = await healthInformationRepository.GetAsync(informationId);
            return healthInformation
                .Map(information => HealthInformation(token, information))
                .ValueOr(ErrorOf(ErrorResponse.HealthInformationNotFound));
        }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/DataFlow/DataFlow.cs" line="117">

---

The function <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/DataFlow.cs" pos="117:13:13" line-data="        private static Tuple&lt;HealthInformationTransactionResponse, ErrorRepresentation&gt; ConsentArtefactNotFound()">`ConsentArtefactNotFound`</SwmToken> returns a tuple indicating that the consent artifact was not found.

```c#
        private static Tuple<HealthInformationTransactionResponse, ErrorRepresentation> ConsentArtefactNotFound()
        {
            return new Tuple<HealthInformationTransactionResponse, ErrorRepresentation>(null,
                new ErrorRepresentation(new Error(ErrorCode.ContextArtefactIdNotFound,
                    ErrorMessage.ContextArtefactIdNotFound)));
        }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/DataFlow/DataFlow.cs" line="124">

---

The function <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/DataFlow.cs" pos="124:11:11" line-data="        private Tuple&lt;HealthInformationResponse, ErrorRepresentation&gt; HealthInformation(">`HealthInformation`</SwmToken> validates the token and checks if the link is expired before returning the health information.

```c#
        private Tuple<HealthInformationResponse, ErrorRepresentation> HealthInformation(
            string token,
            HealthInformation information)
        {
            if (information.Token != token) return ErrorOf(ErrorResponse.InvalidToken);
            if (IsLinkExpired(information.DateCreated)) return ErrorOf(ErrorResponse.LinkExpired);

            return new Tuple<HealthInformationResponse, ErrorRepresentation>(
                new HealthInformationResponse(information.Data.Content), null);
        }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/DataFlow/DataFlow.cs" line="135">

---

The function <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/DataFlow.cs" pos="135:5:5" line-data="        private bool IsLinkExpired(DateTime dateCreated)">`IsLinkExpired`</SwmToken> checks if a link has expired based on its creation date and the configured time-to-live (TTL).

```c#
        private bool IsLinkExpired(DateTime dateCreated)
        {
            var linkExpirationTtl = dataFlowConfiguration.Value.DataLinkTtlInMinutes;
            var linkExpirationDateTime = dateCreated.AddMinutes(linkExpirationTtl);
            return linkExpirationDateTime < DateTime.Now;
        }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/DataFlow/DataFlow.cs" line="142">

---

The function <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/DataFlow.cs" pos="142:13:13" line-data="        private static Tuple&lt;HealthInformationResponse, ErrorRepresentation&gt; ErrorOf(Error error)">`ErrorOf`</SwmToken> creates a tuple containing an error representation for a given error.

```c#
        private static Tuple<HealthInformationResponse, ErrorRepresentation> ErrorOf(Error error)
        {
            return new Tuple<HealthInformationResponse, ErrorRepresentation>(null, new ErrorRepresentation(error));
        }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/DataFlow/DataFlow.cs" line="147">

---

The function <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/DataFlow.cs" pos="147:5:5" line-data="        private bool IsExpired(string expiryDate)">`IsExpired`</SwmToken> checks if a given expiry date has passed by parsing the date and comparing it to the current date.

```c#
        private bool IsExpired(string expiryDate)
        {
            var formatStrings = new[]
            {
                "yyyy-MM-dd", "yyyy-MM-dd hh:mm:ss", "yyyy-MM-dd hh:mm:ss tt", "yyyy-MM-ddTHH:mm:ss.fffzzz",
                "yyyy-MM-dd'T'HH:mm:ss.fff", "yyyy-MM-dd'T'HH:mm:ss.ff", "yyyy-MM-dd'T'HH:mm:ss.f",
                "yyyy-MM-dd'T'HH:mm:ss.ffff", "yyyy-MM-dd'T'HH:mm:ss.fffff",
                "yyyy-MM-dd'T'HH:mm:ss", "dd/MM/yyyy", "dd/MM/yyyy hh:mm:ss", "dd/MM/yyyy hh:mm:ss tt",
                "dd/MM/yyyyTHH:mm:ss.fffzzz",
                "yyyy-MM-dd'T'HH:mm:ss.ffffff",
                "yyyy-MM-dd'T'HH:mm:ss.fff'Z'",
                "yyyy-MM-ddTHH:mm:ss.fffffffZ"
            };
            var tryParseExact = DateTime.TryParseExact(expiryDate,
                formatStrings,
                CultureInfo.CurrentCulture,
                DateTimeStyles.None,
                out var expiryDateTime);
            if (!tryParseExact)
                logger.Log(LogLevel.Error, LogEvents.DataFlow, "Error parsing date: {ExpiryDate}", expiryDate);

```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/DataFlow/DataFlow.cs" line="172">

---

The function <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/DataFlow.cs" pos="172:5:5" line-data="        private void PublishDataRequest(DataRequest dataRequest)">`PublishDataRequest`</SwmToken> publishes a data request to the messaging queue.

```c#
        private void PublishDataRequest(DataRequest dataRequest)
        {
            logger.Log(LogLevel.Information, LogEvents.DataFlow, "Publishing dataRequest: {@DataRequest}", dataRequest);
            messagingQueueManager.Publish(
                dataRequest,
                MessagingQueueConstants.DataRequestExchangeName,
                MessagingQueueConstants.DataRequestExchangeType,
                MessagingQueueConstants.DataRequestRoutingKey);
        }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/DataFlow/DataFlow.cs" line="26">

---

The constructor <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/DataFlow.cs" pos="26:3:3" line-data="        public DataFlow(IDataFlowRepository dataFlowRepository,">`DataFlow`</SwmToken> initializes the class with various repositories, configuration options, and a logger.

```c#
        public DataFlow(IDataFlowRepository dataFlowRepository,
            IMessagingQueueManager messagingQueueManager,
            IConsentRepository consentRepository,
            IHealthInformationRepository healthInformationRepository,
            IOptions<DataFlowConfiguration> dataFlowConfiguration,
            ILogger<DataFlow> logger,
            ILinkPatientRepository linkPatientRepository)
        {
            this.dataFlowRepository = dataFlowRepository;
            this.messagingQueueManager = messagingQueueManager;
            this.consentRepository = consentRepository;
            this.healthInformationRepository = healthInformationRepository;
            this.dataFlowConfiguration = dataFlowConfiguration;
            this.logger = logger;
            this.linkPatientRepository = linkPatientRepository;
        }
```

---

</SwmSnippet>

# Usage

<SwmSnippet path="/test/In.ProjectEKA.HipServiceTest/DataFlow/DataEntryFactoryTest.cs" line="1">

---

## <SwmToken path="test/In.ProjectEKA.HipServiceTest/DataFlow/DataEntryFactoryTest.cs" pos="20:5:5" line-data="    public class DataEntryFactoryTest">`DataEntryFactoryTest`</SwmToken>

The <SwmToken path="test/In.ProjectEKA.HipServiceTest/DataFlow/DataEntryFactoryTest.cs" pos="1:8:8" line-data="namespace In.ProjectEKA.HipServiceTest.DataFlow">`DataFlow`</SwmToken> class is utilized in the <SwmToken path="test/In.ProjectEKA.HipServiceTest/DataFlow/DataEntryFactoryTest.cs" pos="20:5:5" line-data="    public class DataEntryFactoryTest">`DataEntryFactoryTest`</SwmToken> file to test the functionalities related to data entry within the data flow process.

```c#
namespace In.ProjectEKA.HipServiceTest.DataFlow
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Builder;
    using FluentAssertions;
    using HipLibrary.Patient.Model;
    using HipService.Common;
    using HipService.DataFlow;
    using HipService.DataFlow.Encryptor;
    using Hl7.Fhir.Model;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Options;
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
