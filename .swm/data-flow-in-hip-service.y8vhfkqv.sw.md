---
title: Data Flow in Hip Service
---
# Key Components

# Overview of Data Flow

Data flow in Hip Service refers to the process of collecting, processing, and transmitting health information data between different components of the system.

<SwmSnippet path="/src/In.ProjectEKA.HipService/DataFlow/DataFlowMessageHandler.cs" line="11">

---

The <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/DataFlowMessageHandler.cs" pos="14:3:3" line-data="        public DataFlowMessageHandler(">`DataFlowMessageHandler`</SwmToken> class plays a crucial role in this process by utilizing the <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/DataFlowMessageHandler.cs" pos="15:3:3" line-data="            ICollectHipService collectHipService,">`collectHipService`</SwmToken> to gather data based on a data request.

```c#
        private readonly DataEntryFactory dataEntryFactory;
        private readonly DataFlowClient dataFlowClient;

        public DataFlowMessageHandler(
            ICollectHipService collectHipService,
            DataFlowClient dataFlowClient,
            DataEntryFactory dataEntryFactory)
```

---

</SwmSnippet>

Once the data is collected, it is processed and encrypted before being sent to the client through the <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/DataFlowMessageHandler.cs" pos="12:7:7" line-data="        private readonly DataFlowClient dataFlowClient;">`dataFlowClient`</SwmToken>.

<SwmSnippet path="/src/In.ProjectEKA.HipService/DataFlow/DataFlowRepository.cs" line="11">

---

The <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/DataFlowRepository.cs" pos="14:3:3" line-data="        public DataFlowRepository(DataFlowContext dataFlowContext)">`DataFlowRepository`</SwmToken> and <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/DataFlowRepository.cs" pos="12:5:5" line-data="        private readonly DataFlowContext dataFlowContext;">`DataFlowContext`</SwmToken> classes are responsible for managing the data storage and retrieval operations, ensuring that the data is stored securely and can be accessed efficiently.

```c#
    {
        private readonly DataFlowContext dataFlowContext;

        public DataFlowRepository(DataFlowContext dataFlowContext)
        {
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/DataFlow/DataFlowConfiguration.cs" line="3">

---

Configuration settings, such as the data size limit, are managed by the <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/DataFlowConfiguration.cs" pos="3:5:5" line-data="    public class DataFlowConfiguration">`DataFlowConfiguration`</SwmToken> class, which helps in controlling the amount of data that can be processed at a time.

```c#
    public class DataFlowConfiguration
    {
        public int DataSizeLimitInMbs { get; set; }
        public int DataLinkTtlInMinutes { get; set; }
    }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/DataFlow/DataFlowController.cs" line="22">

---

The <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/DataFlowController.cs" pos="22:3:3" line-data="        public DataFlowController(IDataFlow dataFlow)">`DataFlowController`</SwmToken> class handles incoming requests and coordinates the data flow operations by interacting with other components like <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/DataFlowMessageHandler.cs" pos="12:5:5" line-data="        private readonly DataFlowClient dataFlowClient;">`DataFlowClient`</SwmToken> and <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/DataFlowMessageHandler.cs" pos="15:3:3" line-data="            ICollectHipService collectHipService,">`collectHipService`</SwmToken>.

```c#
        public DataFlowController(IDataFlow dataFlow)
        {
```

---

</SwmSnippet>

## <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/OpenMrsPatientData.cs" pos="57:12:12" line-data="        private async Task&lt;List&lt;string&gt;&gt; GetForVisits(string hiType, string consentId, string grantedContext,">`GetForVisits`</SwmToken>

# Data Flow Endpoints

Endpoints for Data Flow

<SwmSnippet path="/src/In.ProjectEKA.HipService/DataFlow/OpenMrsPatientData.cs" line="57">

---

The <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/OpenMrsPatientData.cs" pos="57:12:12" line-data="        private async Task&lt;List&lt;string&gt;&gt; GetForVisits(string hiType, string consentId, string grantedContext,">`GetForVisits`</SwmToken> function retrieves patient data for visits based on the provided parameters such as <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/OpenMrsPatientData.cs" pos="57:16:16" line-data="        private async Task&lt;List&lt;string&gt;&gt; GetForVisits(string hiType, string consentId, string grantedContext,">`hiType`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/OpenMrsPatientData.cs" pos="57:21:21" line-data="        private async Task&lt;List&lt;string&gt;&gt; GetForVisits(string hiType, string consentId, string grantedContext,">`consentId`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/OpenMrsPatientData.cs" pos="57:26:26" line-data="        private async Task&lt;List&lt;string&gt;&gt; GetForVisits(string hiType, string consentId, string grantedContext,">`grantedContext`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/OpenMrsPatientData.cs" pos="58:3:3" line-data="            string toDate,">`toDate`</SwmToken>, and <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/OpenMrsPatientData.cs" pos="59:3:3" line-data="            string fromDate)">`fromDate`</SwmToken>. It constructs the endpoint URL using these parameters and makes an asynchronous GET request to the OpenMRS client to fetch the data.

```c#
        private async Task<List<string>> GetForVisits(string hiType, string consentId, string grantedContext,
            string toDate,
            string fromDate)
        {
            var pathForVisit = $"{Constants.PATH_OPENMRS_HITYPE}{hiTypeToRootElement[hiType]}/visit/";
            var query = HttpUtility.ParseQueryString(string.Empty);
            if (
                !string.IsNullOrEmpty(consentId) &&
                !string.IsNullOrEmpty(grantedContext) &&
                !string.IsNullOrEmpty(toDate) &&
                !string.IsNullOrEmpty(fromDate)
            )
            {
                var careContexReference = grantedContext.Split(":");
                query["patientId"] = consentId;
                query["visitUuid"] = careContexReference[1];
                query["fromDate"] = DateTime.Parse(fromDate).ToString("yyyy-MM-dd");
                query["toDate"] = DateTime.Parse(toDate).AddDays(1).ToString("yyyy-MM-dd");
            }

            if (query.ToString() != "")
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/DataFlow/OpenMrsPatientData.cs" line="101">

---

## <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/OpenMrsPatientData.cs" pos="101:12:12" line-data="        private async Task&lt;List&lt;string&gt;&gt; GetForPrograms(string hiType, string consentId, string programName,">`GetForPrograms`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/OpenMrsPatientData.cs" pos="101:12:12" line-data="        private async Task&lt;List&lt;string&gt;&gt; GetForPrograms(string hiType, string consentId, string programName,">`GetForPrograms`</SwmToken> function retrieves patient data for programs based on parameters such as <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/OpenMrsPatientData.cs" pos="101:16:16" line-data="        private async Task&lt;List&lt;string&gt;&gt; GetForPrograms(string hiType, string consentId, string programName,">`hiType`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/OpenMrsPatientData.cs" pos="101:21:21" line-data="        private async Task&lt;List&lt;string&gt;&gt; GetForPrograms(string hiType, string consentId, string programName,">`consentId`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/OpenMrsPatientData.cs" pos="101:26:26" line-data="        private async Task&lt;List&lt;string&gt;&gt; GetForPrograms(string hiType, string consentId, string programName,">`programName`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/OpenMrsPatientData.cs" pos="102:3:3" line-data="            string programId,">`programId`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/OpenMrsPatientData.cs" pos="103:3:3" line-data="            string toDate,">`toDate`</SwmToken>, and <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/OpenMrsPatientData.cs" pos="104:3:3" line-data="            string fromDate)">`fromDate`</SwmToken>. It constructs the endpoint URL using these parameters and makes an asynchronous GET request to the OpenMRS client to fetch the data.

```c#
        private async Task<List<string>> GetForPrograms(string hiType, string consentId, string programName,
            string programId,
            string toDate,
            string fromDate)
        {
            var pathForProgram = $"{Constants.PATH_OPENMRS_HITYPE}{hiTypeToRootElement[hiType]}/program/";
            var query = HttpUtility.ParseQueryString(string.Empty);
            if (
                !string.IsNullOrEmpty(consentId) &&
                !string.IsNullOrEmpty(programName) &&
                !string.IsNullOrEmpty(toDate) &&
                !string.IsNullOrEmpty(fromDate)
            )
            {
                query["patientId"] = consentId;
                query["programName"] = programName;
                query["programEnrollmentId"] = programId;
                query["fromDate"] = fromDate;
                query["toDate"] = toDate;
            }

```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
