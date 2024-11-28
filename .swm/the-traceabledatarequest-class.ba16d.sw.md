---
title: The TraceableDataRequest class
---
This document will cover the class <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" pos="8:3:3" line-data="        public TraceableDataRequest(">`TraceableDataRequest`</SwmToken> in detail. We will discuss:

1. What <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" pos="8:3:3" line-data="        public TraceableDataRequest(">`TraceableDataRequest`</SwmToken> is.
2. The variables and functions defined in <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" pos="8:3:3" line-data="        public TraceableDataRequest(">`TraceableDataRequest`</SwmToken>.

# Variables and functions

# What is <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" pos="8:3:3" line-data="        public TraceableDataRequest(">`TraceableDataRequest`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" pos="8:3:3" line-data="        public TraceableDataRequest(">`TraceableDataRequest`</SwmToken> class is a model used to encapsulate data requests that need to be traceable. It is used to store various details about the data request, such as care contexts, date range, data push URL, health information types, transaction ID, key material, consent manager ID, consent ID, CM suffix, correlation ID, and patient UUID.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" line="8">

---

The constructor <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" pos="8:3:3" line-data="        public TraceableDataRequest(">`TraceableDataRequest`</SwmToken> initializes all the properties of the class with the provided parameters.

```c#
        public TraceableDataRequest(
            IEnumerable<GrantedContext> careContexts,
            DateRange dateRange,
            string dataPushUrl,
            IEnumerable<HiType> hiType,
            string transactionId,
            KeyMaterial keyMaterial,
            string consentManagerId,
            string consentId,
            string cmSuffix,
            string correlationId,
            string patientUuid
            )
        {
            CareContexts = careContexts;
            DateRange = dateRange;
            DataPushUrl = dataPushUrl;
            HiType = hiType;
            TransactionId = transactionId;
            KeyMaterial = keyMaterial;
            ConsentManagerId = consentManagerId;
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" line="47">

---

The function <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" pos="47:7:7" line-data="        public override string ToString()">`ToString`</SwmToken> overrides the default <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" pos="47:7:7" line-data="        public override string ToString()">`ToString`</SwmToken> method to provide a string representation of the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" pos="8:3:3" line-data="        public TraceableDataRequest(">`TraceableDataRequest`</SwmToken> object, including the health information types.

```c#
        public override string ToString()
        {
            var hiTypes = HiType
                .Select(hiType => hiType.ToString())
                .Aggregate("", (source, value) => source + " " + value);
            return $"Data Request with {hiTypes}";
        }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" line="35">

---

The variable <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" pos="35:8:8" line-data="        public IEnumerable&lt;GrantedContext&gt; CareContexts { get; }">`CareContexts`</SwmToken> is used to store the care contexts associated with the data request.

```c#
        public IEnumerable<GrantedContext> CareContexts { get; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" line="36">

---

The variable <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" pos="36:3:3" line-data="        public DateRange DateRange { get; }">`DateRange`</SwmToken> is used to store the date range for which the data is requested.

```c#
        public DateRange DateRange { get; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" line="37">

---

The variable <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" pos="37:5:5" line-data="        public string DataPushUrl { get; }">`DataPushUrl`</SwmToken> is used to store the URL to which the data should be pushed.

```c#
        public string DataPushUrl { get; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" line="38">

---

The variable <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" pos="38:5:5" line-data="        public IEnumerable&lt;HiType&gt; HiType { get; }">`HiType`</SwmToken> is used to store the types of health information being requested.

```c#
        public IEnumerable<HiType> HiType { get; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" line="39">

---

The variable <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" pos="39:5:5" line-data="        public string TransactionId { get; }">`TransactionId`</SwmToken> is used to store the transaction ID associated with the data request.

```c#
        public string TransactionId { get; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" line="40">

---

The variable <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" pos="40:3:3" line-data="        public KeyMaterial KeyMaterial { get; }">`KeyMaterial`</SwmToken> is used to store the key material required for the data request.

```c#
        public KeyMaterial KeyMaterial { get; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" line="41">

---

The variable <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" pos="41:5:5" line-data="        public string ConsentManagerId { get; }">`ConsentManagerId`</SwmToken> is used to store the ID of the consent manager.

```c#
        public string ConsentManagerId { get; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" line="42">

---

The variable <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" pos="42:5:5" line-data="        public string ConsentId { get; }">`ConsentId`</SwmToken> is used to store the consent ID associated with the data request.

```c#
        public string ConsentId { get; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" line="43">

---

The variable <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" pos="43:5:5" line-data="        public string CmSuffix { get; }">`CmSuffix`</SwmToken> is used to store the suffix of the consent manager.

```c#
        public string CmSuffix { get; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" line="44">

---

The variable <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" pos="44:5:5" line-data="        public string CorrelationId { get; }">`CorrelationId`</SwmToken> is used to store the correlation ID for the data request.

```c#
        public string CorrelationId { get; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" line="45">

---

The variable <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/TraceableDataRequest.cs" pos="45:5:5" line-data="        public string PatientUuid { get; }">`PatientUuid`</SwmToken> is used to store the UUID of the patient associated with the data request.

```c#
        public string PatientUuid { get; }
```

---

</SwmSnippet>

# Usage

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/ICollect.cs" line="7">

---

## <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/ICollect.cs" pos="7:5:5" line-data="    public interface ICollect">`ICollect`</SwmToken> Interface

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/ICollect.cs" pos="9:10:10" line-data="        Task&lt;Option&lt;Entries&gt;&gt; CollectData(TraceableDataRequest dataRequest);">`TraceableDataRequest`</SwmToken> class is used in the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/ICollect.cs" pos="7:5:5" line-data="    public interface ICollect">`ICollect`</SwmToken> interface, where it is passed as a parameter to the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/ICollect.cs" pos="9:8:8" line-data="        Task&lt;Option&lt;Entries&gt;&gt; CollectData(TraceableDataRequest dataRequest);">`CollectData`</SwmToken> method. This method is responsible for collecting data based on the provided <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/ICollect.cs" pos="9:10:10" line-data="        Task&lt;Option&lt;Entries&gt;&gt; CollectData(TraceableDataRequest dataRequest);">`TraceableDataRequest`</SwmToken>.

```c#
    public interface ICollect
    {
        Task<Option<Entries>> CollectData(TraceableDataRequest dataRequest);
    }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.DefaultHip/DataFlow/Collect.cs" line="27">

---

## Collect Class

In the <SwmToken path="src/In.ProjectEKA.DefaultHip/DataFlow/Collect.cs" pos="18:5:5" line-data="    public class Collect : ICollect">`Collect`</SwmToken> class, the <SwmToken path="src/In.ProjectEKA.DefaultHip/DataFlow/Collect.cs" pos="27:14:14" line-data="        public async Task&lt;Option&lt;Entries&gt;&gt; CollectData(TraceableDataRequest dataRequest)">`TraceableDataRequest`</SwmToken> is used in multiple methods. The <SwmToken path="src/In.ProjectEKA.DefaultHip/DataFlow/Collect.cs" pos="27:12:12" line-data="        public async Task&lt;Option&lt;Entries&gt;&gt; CollectData(TraceableDataRequest dataRequest)">`CollectData`</SwmToken> method uses it to find patient data and create care bundles. Additionally, the <SwmToken path="src/In.ProjectEKA.DefaultHip/DataFlow/Collect.cs" pos="30:7:7" line-data="            var patientData = FindPatientData(dataRequest);">`FindPatientData`</SwmToken> method and <SwmToken path="src/In.ProjectEKA.DefaultHip/DataFlow/Collect.cs" pos="114:7:7" line-data="        private static void LogDataRequest(TraceableDataRequest request)">`LogDataRequest`</SwmToken> method also utilize <SwmToken path="src/In.ProjectEKA.DefaultHip/DataFlow/Collect.cs" pos="27:14:14" line-data="        public async Task&lt;Option&lt;Entries&gt;&gt; CollectData(TraceableDataRequest dataRequest)">`TraceableDataRequest`</SwmToken> to process and log the data request details.

```c#
        public async Task<Option<Entries>> CollectData(TraceableDataRequest dataRequest)
        {
            var bundles = new List<CareBundle>();
            var patientData = FindPatientData(dataRequest);
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.DefaultHip/DataFlow/Collect.cs" line="71">

---

&nbsp;

```c#
        private Dictionary<string, List<string>> FindPatientData(TraceableDataRequest request)
        {
            try
            {
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.DefaultHip/DataFlow/Collect.cs" line="114">

---

&nbsp;

```c#
        private static void LogDataRequest(TraceableDataRequest request)
        {
            var ccList = JsonConvert.SerializeObject(request.CareContexts);
            var requestedHiTypes = string.Join(", ", request.HiType.Select(hiType => hiType.ToString()));
```

---

</SwmSnippet>

<SwmSnippet path="/test/In.ProjectEKA.HipServiceTest/DataFlow/Builder/TestBuilder.cs" line="69">

---

## <SwmToken path="test/In.ProjectEKA.HipServiceTest/DataFlow/DataFlowClientTest.cs" pos="39:7:7" line-data="            var dataRequest = TestBuilder.TraceableDataRequest(transactionId);">`TestBuilder`</SwmToken> Class

In the <SwmToken path="test/In.ProjectEKA.HipServiceTest/DataFlow/DataFlowClientTest.cs" pos="39:7:7" line-data="            var dataRequest = TestBuilder.TraceableDataRequest(transactionId);">`TestBuilder`</SwmToken> class, the <SwmToken path="test/In.ProjectEKA.HipServiceTest/DataFlow/Builder/TestBuilder.cs" pos="69:11:11" line-data="        internal static HipLibrary.Patient.Model.TraceableDataRequest TraceableDataRequest(string transactionId)">`TraceableDataRequest`</SwmToken> is used to create instances of data requests for testing purposes. This helps in simulating various scenarios and ensuring the robustness of the data flow logic.

```c#
        internal static HipLibrary.Patient.Model.TraceableDataRequest TraceableDataRequest(string transactionId)
        {
            const string consentManagerId = "ConsentManagerId";
            const string consentId = "ConsentId";
```

---

</SwmSnippet>

<SwmSnippet path="/test/In.ProjectEKA.HipServiceTest/DataFlow/Builder/TestBuilder.cs" line="78">

---

&nbsp;

```c#
            return new HipLibrary.Patient.Model.TraceableDataRequest(new List<GrantedContext>(),
                dateRange,
                callBackUrl,
                new List<HiType>(),
```

---

</SwmSnippet>

<SwmSnippet path="/test/In.ProjectEKA.HipServiceTest/DataFlow/CollectHipServiceTest.cs" line="34">

---

## <SwmToken path="test/In.ProjectEKA.HipServiceTest/DataFlow/CollectHipServiceTest.cs" pos="15:5:5" line-data="    public class CollectHipServiceTest">`CollectHipServiceTest`</SwmToken> Class

In the <SwmToken path="test/In.ProjectEKA.HipServiceTest/DataFlow/CollectHipServiceTest.cs" pos="15:5:5" line-data="    public class CollectHipServiceTest">`CollectHipServiceTest`</SwmToken> class, <SwmToken path="test/In.ProjectEKA.HipServiceTest/DataFlow/CollectHipServiceTest.cs" pos="34:9:9" line-data="            var traceableDataRequest = new TraceableDataRequest(grantedContexts,">`TraceableDataRequest`</SwmToken> is used to create test instances for validating the data collection functionality. This ensures that the data collection process works as expected under different conditions.

```c#
            var traceableDataRequest = new TraceableDataRequest(grantedContexts,
                dateRange,
                "/someUrl",
                hiTypes,
```

---

</SwmSnippet>

<SwmSnippet path="/test/In.ProjectEKA.HipServiceTest/DataFlow/CollectHipServiceTest.cs" line="76">

---

&nbsp;

```c#
            var traceableDataRequest = new TraceableDataRequest(grantedContexts,
                dateRange,
                "/someUrl",
                hiTypes,
```

---

</SwmSnippet>

<SwmSnippet path="/test/In.ProjectEKA.HipServiceTest/DataFlow/DataFlowClientTest.cs" line="39">

---

## <SwmToken path="test/In.ProjectEKA.HipServiceTest/DataFlow/DataFlowClientTest.cs" pos="23:5:5" line-data="    public class DataFlowClientTest">`DataFlowClientTest`</SwmToken> Class

In the <SwmToken path="test/In.ProjectEKA.HipServiceTest/DataFlow/DataFlowClientTest.cs" pos="23:5:5" line-data="    public class DataFlowClientTest">`DataFlowClientTest`</SwmToken> class, <SwmToken path="test/In.ProjectEKA.HipServiceTest/DataFlow/DataFlowClientTest.cs" pos="39:9:9" line-data="            var dataRequest = TestBuilder.TraceableDataRequest(transactionId);">`TraceableDataRequest`</SwmToken> is used to create mock data requests for testing the data flow client. This helps in verifying the interactions and data handling within the data flow client.

```c#
            var dataRequest = TestBuilder.TraceableDataRequest(transactionId);
            var content = TestBuilder.Faker().Random.String();
            var checksum = TestBuilder.Faker().Random.Hash();
            var dataNotificationRequest = TestBuilder.DataNotificationRequest(transactionId);
```

---

</SwmSnippet>

<SwmSnippet path="/test/In.ProjectEKA.HipServiceTest/DataFlow/DataFlowClientTest.cs" line="96">

---

&nbsp;

```c#
            var dataRequest = TestBuilder.TraceableDataRequest(TestBuilder.Faker().Random.Hash());
            var entries = new List<Entry>().AsEnumerable();
            var dataFlowClient = new DataFlowClient(httpClient, dataFlowNotificationClient.Object, configuration);
            var correlationId = Uuid.Generate().ToString();
```

---

</SwmSnippet>

<SwmSnippet path="/test/In.ProjectEKA.HipServiceTest/DataFlow/DataFlowMessageHandlerTest.cs" line="25">

---

## <SwmToken path="test/In.ProjectEKA.HipServiceTest/DataFlow/DataFlowMessageHandlerTest.cs" pos="14:5:5" line-data="    public class DataFlowMessageHandlerTest">`DataFlowMessageHandlerTest`</SwmToken> Class

In the <SwmToken path="test/In.ProjectEKA.HipServiceTest/DataFlow/DataFlowMessageHandlerTest.cs" pos="14:5:5" line-data="    public class DataFlowMessageHandlerTest">`DataFlowMessageHandlerTest`</SwmToken> class, <SwmToken path="test/In.ProjectEKA.HipServiceTest/DataFlow/DataFlowMessageHandlerTest.cs" pos="25:9:9" line-data="            var dataRequest = TestBuilder.TraceableDataRequest(transactionId);">`TraceableDataRequest`</SwmToken> is used to create test instances for handling data flow messages. This ensures that the message handling logic correctly processes the data requests.

```c#
            var dataRequest = TestBuilder.TraceableDataRequest(transactionId);
            var careBundles = new List<CareBundle> {new CareBundle("careContextReference", new Bundle())};
            var entries = new Entries(careBundles);
            var data = Option.Some(entries);
```

---

</SwmSnippet>

<SwmSnippet path="/test/In.ProjectEKA.DefaultHipTest/DataFlow/CollectTest.cs" line="39">

---

## <SwmToken path="test/In.ProjectEKA.DefaultHipTest/DataFlow/CollectTest.cs" pos="16:5:5" line-data="    public class CollectTest">`CollectTest`</SwmToken> Class

In the <SwmToken path="test/In.ProjectEKA.DefaultHipTest/DataFlow/CollectTest.cs" pos="16:5:5" line-data="    public class CollectTest">`CollectTest`</SwmToken> class, <SwmToken path="test/In.ProjectEKA.DefaultHipTest/DataFlow/CollectTest.cs" pos="39:9:9" line-data="            var traceableDataRequest = new TraceableDataRequest(grantedContexts,">`TraceableDataRequest`</SwmToken> is used to create test instances for validating the data collection logic. This helps in ensuring that the data collection process is accurate and reliable.

```c#
            var traceableDataRequest = new TraceableDataRequest(grantedContexts,
                dateRange,
                "/someUrl",
                hiTypes,
```

---

</SwmSnippet>

<SwmSnippet path="/test/In.ProjectEKA.DefaultHipTest/DataFlow/CollectTest.cs" line="72">

---

&nbsp;

```c#
            var traceableDataRequest = new TraceableDataRequest(grantedContexts,
                dateRange,
                "/someUrl",
                hiTypes,
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/DataFlow/DataFlowMessageHandler.cs" line="24">

---

## <SwmToken path="test/In.ProjectEKA.HipServiceTest/DataFlow/DataFlowMessageHandlerTest.cs" pos="23:3:3" line-data="                new DataFlowMessageHandler(collect.Object, dataFlowClient.Object, dataEntryFactory.Object);">`DataFlowMessageHandler`</SwmToken> Class

In the <SwmToken path="test/In.ProjectEKA.HipServiceTest/DataFlow/DataFlowMessageHandlerTest.cs" pos="23:3:3" line-data="                new DataFlowMessageHandler(collect.Object, dataFlowClient.Object, dataEntryFactory.Object);">`DataFlowMessageHandler`</SwmToken> class, <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/DataFlowMessageHandler.cs" pos="24:9:9" line-data="        public async Task HandleDataFlowMessage(TraceableDataRequest dataRequest)">`TraceableDataRequest`</SwmToken> is used in the <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/DataFlowMessageHandler.cs" pos="24:7:7" line-data="        public async Task HandleDataFlowMessage(TraceableDataRequest dataRequest)">`HandleDataFlowMessage`</SwmToken> method to handle incoming data flow messages. This method processes the data request and collects the necessary data.

```c#
        public async Task HandleDataFlowMessage(TraceableDataRequest dataRequest)
        {
            var sentKeyMaterial = dataRequest.KeyMaterial;
            var data = await collectHipService.CollectData(dataRequest).ConfigureAwait(false);
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/DataFlow/DataFlowClient.cs" line="31">

---

## <SwmToken path="test/In.ProjectEKA.HipServiceTest/DataFlow/DataFlowClientTest.cs" pos="98:9:9" line-data="            var dataFlowClient = new DataFlowClient(httpClient, dataFlowNotificationClient.Object, configuration);">`DataFlowClient`</SwmToken> Class

In the <SwmToken path="test/In.ProjectEKA.HipServiceTest/DataFlow/DataFlowClientTest.cs" pos="98:9:9" line-data="            var dataFlowClient = new DataFlowClient(httpClient, dataFlowNotificationClient.Object, configuration);">`DataFlowClient`</SwmToken> class, <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/DataFlowClient.cs" pos="31:11:11" line-data="        public virtual async Task SendDataToHiu(TraceableDataRequest dataRequest,">`TraceableDataRequest`</SwmToken> is used in the <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/DataFlowClient.cs" pos="31:9:9" line-data="        public virtual async Task SendDataToHiu(TraceableDataRequest dataRequest,">`SendDataToHiu`</SwmToken> method to send collected data to the Health Information User (HIU). This method ensures that the data is transmitted securely and accurately.

```c#
        public virtual async Task SendDataToHiu(TraceableDataRequest dataRequest,
            IEnumerable<Entry> data,
            KeyMaterial keyMaterial)
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/DataFlow/MessagingQueueListener.cs" line="54">

---

## <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/MessagingQueueListener.cs" pos="13:5:5" line-data="    public class MessagingQueueListener : BackgroundService">`MessagingQueueListener`</SwmToken> Class

In the <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/MessagingQueueListener.cs" pos="13:5:5" line-data="    public class MessagingQueueListener : BackgroundService">`MessagingQueueListener`</SwmToken> class, <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/MessagingQueueListener.cs" pos="54:11:11" line-data="                    JsonConvert.DeserializeObject&lt;HipLibrary.Patient.Model.TraceableDataRequest&gt;(message);">`TraceableDataRequest`</SwmToken> is used to deserialize incoming messages from the messaging queue. This allows the system to handle data flow messages and process data requests accordingly.

```c#
                    JsonConvert.DeserializeObject<HipLibrary.Patient.Model.TraceableDataRequest>(message);
                await dataFlowMessageHandler.HandleDataFlowMessage(dataFlowMessage);
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/DataFlow/CollectHipService.cs" line="25">

---

## <SwmToken path="test/In.ProjectEKA.HipServiceTest/DataFlow/CollectHipServiceTest.cs" pos="21:9:9" line-data="            var collectHipService = new CollectHipService(openMrsPatientData.Object);">`CollectHipService`</SwmToken> Class

In the <SwmToken path="test/In.ProjectEKA.HipServiceTest/DataFlow/CollectHipServiceTest.cs" pos="21:9:9" line-data="            var collectHipService = new CollectHipService(openMrsPatientData.Object);">`CollectHipService`</SwmToken> class, <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/CollectHipService.cs" pos="25:14:14" line-data="        public async Task&lt;Option&lt;Entries&gt;&gt; CollectData(TraceableDataRequest dataRequest)">`TraceableDataRequest`</SwmToken> is used in the <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/CollectHipService.cs" pos="25:12:12" line-data="        public async Task&lt;Option&lt;Entries&gt;&gt; CollectData(TraceableDataRequest dataRequest)">`CollectData`</SwmToken> method to collect patient data. The <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/CollectHipService.cs" pos="28:9:9" line-data="            var patientData = await FindPatientData(dataRequest);">`FindPatientData`</SwmToken> and <SwmToken path="src/In.ProjectEKA.DefaultHip/DataFlow/Collect.cs" pos="114:7:7" line-data="        private static void LogDataRequest(TraceableDataRequest request)">`LogDataRequest`</SwmToken> methods also utilize <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/CollectHipService.cs" pos="25:14:14" line-data="        public async Task&lt;Option&lt;Entries&gt;&gt; CollectData(TraceableDataRequest dataRequest)">`TraceableDataRequest`</SwmToken> to process and log the data request details.

```c#
        public async Task<Option<Entries>> CollectData(TraceableDataRequest dataRequest)
        {
            var bundles = new List<CareBundle>();
            var patientData = await FindPatientData(dataRequest);
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/DataFlow/CollectHipService.cs" line="43">

---

&nbsp;

```c#
        private async Task<Dictionary<string, List<string>>> FindPatientData(TraceableDataRequest request)
        {
            try
            {
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/DataFlow/CollectHipService.cs" line="79">

---

&nbsp;

```c#
        private static void LogDataRequest(TraceableDataRequest request)
        {
            var ccList = JsonConvert.SerializeObject(request.CareContexts);
            var requestedHiTypes = string.Join(", ", request.HiType.Select(hiType => hiType.ToString()));
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/DataFlow/ICollectHipService.cs" line="10">

---

## <SwmToken path="test/In.ProjectEKA.HipServiceTest/DataFlow/DataFlowMessageHandlerTest.cs" pos="19:11:11" line-data="            var collect = new Mock&lt;ICollectHipService&gt;();">`ICollectHipService`</SwmToken> Interface

The <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/ICollectHipService.cs" pos="10:10:10" line-data="          Task&lt;Option&lt;Entries&gt;&gt; CollectData(TraceableDataRequest dataRequest);">`TraceableDataRequest`</SwmToken> class is used in the <SwmToken path="test/In.ProjectEKA.HipServiceTest/DataFlow/DataFlowMessageHandlerTest.cs" pos="19:11:11" line-data="            var collect = new Mock&lt;ICollectHipService&gt;();">`ICollectHipService`</SwmToken> interface, where it is passed as a parameter to the <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/ICollectHipService.cs" pos="10:8:8" line-data="          Task&lt;Option&lt;Entries&gt;&gt; CollectData(TraceableDataRequest dataRequest);">`CollectData`</SwmToken> method. This method is responsible for collecting data based on the provided <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/ICollectHipService.cs" pos="10:10:10" line-data="          Task&lt;Option&lt;Entries&gt;&gt; CollectData(TraceableDataRequest dataRequest);">`TraceableDataRequest`</SwmToken>.

```c#
          Task<Option<Entries>> CollectData(TraceableDataRequest dataRequest);
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
