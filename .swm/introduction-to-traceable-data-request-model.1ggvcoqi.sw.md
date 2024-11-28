---
title: Introduction to Traceable Data Request Model
---
# Introduction to Traceable Data Request Model

The <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/CollectHipService.cs" pos="25:14:14" line-data="        public async Task&lt;Option&lt;Entries&gt;&gt; CollectData(TraceableDataRequest dataRequest)">`TraceableDataRequest`</SwmToken> class is designed to encapsulate all the necessary information for a data request that can be traced throughout its lifecycle.

It includes properties such as <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/CollectHipService.cs" pos="51:12:12" line-data="                foreach (var grantedContext in request.CareContexts)">`CareContexts`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/CollectHipService.cs" pos="48:9:9" line-data="                var toDate = request.DateRange.To;">`DateRange`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/CollectHipService.cs" pos="89:8:8" line-data="                            $&quot;CallbackUrl:{request.DataPushUrl}, &quot; +">`DataPushUrl`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/CollectHipService.cs" pos="54:12:12" line-data="                    foreach (var hiType in request.HiType) ">`HiType`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/CollectHipService.cs" pos="84:9:9" line-data="                            $&quot; transactionId:{request.TransactionId} , &quot; +">`TransactionId`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/DataFlowClient.cs" pos="33:1:1" line-data="            KeyMaterial keyMaterial)">`KeyMaterial`</SwmToken>, `ConsentManagerId`, <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/DataFlowClient.cs" pos="35:7:7" line-data="            await PostTo(dataRequest.ConsentId,">`ConsentId`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/DataFlowClient.cs" pos="39:3:3" line-data="                dataRequest.CmSuffix,">`CmSuffix`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/DataFlowClient.cs" pos="40:3:3" line-data="                dataRequest.CorrelationId).ConfigureAwait(false);">`CorrelationId`</SwmToken>, and <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/CollectHipService.cs" pos="58:6:6" line-data="                            .GetPatientData(request.PatientUuid, grantedContext.CareContextReference, toDate, fromDate,">`PatientUuid`</SwmToken>.

These properties ensure that all relevant details about the data request, including the contexts of care, the date range for the data, the URL to push data to, and various identifiers, are captured and can be referenced as needed.

## Usage in Codebase

The <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/CollectHipService.cs" pos="56:9:9" line-data="                        var hiTypeStr = hiType.ToString().ToLower();">`ToString`</SwmToken> method in this class provides a string representation of the data request, specifically listing the types of health information (<SwmToken path="src/In.ProjectEKA.HipService/DataFlow/CollectHipService.cs" pos="54:12:12" line-data="                    foreach (var hiType in request.HiType) ">`HiType`</SwmToken>) included in the request.

<SwmSnippet path="/src/In.ProjectEKA.HipService/DataFlow/CollectHipService.cs" line="25">

---

The <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/CollectHipService.cs" pos="25:14:14" line-data="        public async Task&lt;Option&lt;Entries&gt;&gt; CollectData(TraceableDataRequest dataRequest)">`TraceableDataRequest`</SwmToken> is used in various parts of the codebase. For instance, in <SwmPath>[src/In.ProjectEKA.HipService/DataFlow/CollectHipService.cs](src/In.ProjectEKA.HipService/DataFlow/CollectHipService.cs)</SwmPath>, the <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/CollectHipService.cs" pos="25:12:12" line-data="        public async Task&lt;Option&lt;Entries&gt;&gt; CollectData(TraceableDataRequest dataRequest)">`CollectData`</SwmToken> method uses <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/CollectHipService.cs" pos="25:14:14" line-data="        public async Task&lt;Option&lt;Entries&gt;&gt; CollectData(TraceableDataRequest dataRequest)">`TraceableDataRequest`</SwmToken> to handle data collection requests.

```c#
        public async Task<Option<Entries>> CollectData(TraceableDataRequest dataRequest)
        {
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.DefaultHip/DataFlow/Collect.cs" line="71">

---

Similarly, it is used in <SwmPath>[src/In.ProjectEKA.DefaultHip/DataFlow/Collect.cs](src/In.ProjectEKA.DefaultHip/DataFlow/Collect.cs)</SwmPath> within the <SwmToken path="src/In.ProjectEKA.DefaultHip/DataFlow/Collect.cs" pos="71:13:13" line-data="        private Dictionary&lt;string, List&lt;string&gt;&gt; FindPatientData(TraceableDataRequest request)">`FindPatientData`</SwmToken> method to find patient data based on the request.

```c#
        private Dictionary<string, List<string>> FindPatientData(TraceableDataRequest request)
        {
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/ICollect.cs" line="9">

---

In <SwmPath>[src/In.ProjectEKA.HipLibrary/Patient/ICollect.cs](src/In.ProjectEKA.HipLibrary/Patient/ICollect.cs)</SwmPath> and <SwmPath>[src/In.ProjectEKA.HipService/DataFlow/ICollectHipService.cs](src/In.ProjectEKA.HipService/DataFlow/ICollectHipService.cs)</SwmPath>, it is used as a parameter in the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/ICollect.cs" pos="9:8:8" line-data="        Task&lt;Option&lt;Entries&gt;&gt; CollectData(TraceableDataRequest dataRequest);">`CollectData`</SwmToken> method to collect data.

```c#
        Task<Option<Entries>> CollectData(TraceableDataRequest dataRequest);
    }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/DataFlow/MessagingQueueListener.cs" line="53">

---

Additionally, in <SwmPath>[src/In.ProjectEKA.HipService/DataFlow/MessagingQueueListener.cs](src/In.ProjectEKA.HipService/DataFlow/MessagingQueueListener.cs)</SwmPath>, it is deserialized from a JSON message and handled accordingly.

```c#
                var dataFlowMessage =
                    JsonConvert.DeserializeObject<HipLibrary.Patient.Model.TraceableDataRequest>(message);
                await dataFlowMessageHandler.HandleDataFlowMessage(dataFlowMessage);
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/DataFlow/DataFlowClient.cs" line="31">

---

In <SwmPath>[src/In.ProjectEKA.HipService/DataFlow/DataFlowClient.cs](src/In.ProjectEKA.HipService/DataFlow/DataFlowClient.cs)</SwmPath>, it is used in the <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/DataFlowClient.cs" pos="31:9:9" line-data="        public virtual async Task SendDataToHiu(TraceableDataRequest dataRequest,">`SendDataToHiu`</SwmToken> method to send data to the Health Information User (HIU).

```c#
        public virtual async Task SendDataToHiu(TraceableDataRequest dataRequest,
            IEnumerable<Entry> data,
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/DataFlow/DataFlowMessageHandler.cs" line="24">

---

Finally, in <SwmPath>[src/In.ProjectEKA.HipService/DataFlow/DataFlowMessageHandler.cs](src/In.ProjectEKA.HipService/DataFlow/DataFlowMessageHandler.cs)</SwmPath>, it is used in the <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/DataFlowMessageHandler.cs" pos="24:7:7" line-data="        public async Task HandleDataFlowMessage(TraceableDataRequest dataRequest)">`HandleDataFlowMessage`</SwmToken> method to handle data flow messages.

```c#
        public async Task HandleDataFlowMessage(TraceableDataRequest dataRequest)
        {
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
