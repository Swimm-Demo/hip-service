---
title: Exploring Data Flow
---
## <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/Database/DataFlowContext.cs" pos="7:5:5" line-data="    public class DataFlowContext : DbContext">`DataFlowContext`</SwmToken> Class

# Overview of Data Flow

Data flow in HIP Service involves the process of managing and transferring health information between different components of the system.

<SwmSnippet path="/src/In.ProjectEKA.HipService/DataFlow/Database/DataFlowContext.cs" line="7">

---

The <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/Database/DataFlowContext.cs" pos="7:5:5" line-data="    public class DataFlowContext : DbContext">`DataFlowContext`</SwmToken> class, which inherits from <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/Database/DataFlowContext.cs" pos="7:9:9" line-data="    public class DataFlowContext : DbContext">`DbContext`</SwmToken>, is the primary class responsible for interacting with the database. It contains <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/Database/DataFlowContext.cs" pos="13:3:3" line-data="        public DbSet&lt;DataFlowRequest&gt; DataFlowRequest { get; set; }">`DbSet`</SwmToken> properties for <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/Database/DataFlowContext.cs" pos="13:5:5" line-data="        public DbSet&lt;DataFlowRequest&gt; DataFlowRequest { get; set; }">`DataFlowRequest`</SwmToken> and <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/Database/DataFlowContext.cs" pos="14:5:5" line-data="        public DbSet&lt;HealthInformation&gt; HealthInformation { get; set; }">`HealthInformation`</SwmToken>, which represent tables in the database.

```c#
    public class DataFlowContext : DbContext
    {
        public DataFlowContext(DbContextOptions<DataFlowContext> options) : base(options)
        {
        }

        public DbSet<DataFlowRequest> DataFlowRequest { get; set; }
        public DbSet<HealthInformation> HealthInformation { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<DataFlowRequest>()
                .HasKey(d => new {d.TransactionId});
            modelBuilder.Entity<DataFlowRequest>()
                .Property(e => e.HealthInformationRequest)
                .HasConversion(
                    v => JsonConvert.SerializeObject(v,
                        new JsonSerializerSettings {NullValueHandling = NullValueHandling.Ignore}),
                    v => JsonConvert.DeserializeObject<HealthInformationRequest>(v,
                        new JsonSerializerSettings {NullValueHandling = NullValueHandling.Ignore}));
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/DataFlow/DataFlowMessageHandler.cs" line="11">

---

## <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/DataFlowMessageHandler.cs" pos="14:3:3" line-data="        public DataFlowMessageHandler(">`DataFlowMessageHandler`</SwmToken> Class

The <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/DataFlowMessageHandler.cs" pos="14:3:3" line-data="        public DataFlowMessageHandler(">`DataFlowMessageHandler`</SwmToken> class utilizes the <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/DataFlowMessageHandler.cs" pos="15:3:3" line-data="            ICollectHipService collectHipService,">`collectHipService`</SwmToken> to collect data based on the data request. This data is then processed and encrypted before being sent to the client.

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

<SwmSnippet path="/src/In.ProjectEKA.HipService/DataFlow/DataFlowClient.cs" line="16">

---

## <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/DataFlowClient.cs" pos="16:5:5" line-data="    public class DataFlowClient">`DataFlowClient`</SwmToken> Class

The <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/DataFlowClient.cs" pos="16:5:5" line-data="    public class DataFlowClient">`DataFlowClient`</SwmToken> class is responsible for handling the communication with external services, ensuring that the data flow requests and responses are properly managed.

```c#
    public class DataFlowClient
    {
        private readonly DataFlowNotificationClient dataFlowNotificationClient;
        private readonly GatewayConfiguration gatewayConfiguration;
        private readonly HttpClient httpClient;

        public DataFlowClient(HttpClient httpClient,
            DataFlowNotificationClient dataFlowNotificationClient,
            GatewayConfiguration gatewayConfiguration)
        {
            this.httpClient = httpClient;
            this.dataFlowNotificationClient = dataFlowNotificationClient;
            this.gatewayConfiguration = gatewayConfiguration;
        }

        public virtual async Task SendDataToHiu(TraceableDataRequest dataRequest,
            IEnumerable<Entry> data,
            KeyMaterial keyMaterial)
        {
            await PostTo(dataRequest.ConsentId,
                dataRequest.DataPushUrl,
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/DataFlow/DataFlowRepository.cs" line="10">

---

## <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/DataFlowRepository.cs" pos="10:5:5" line-data="    public class DataFlowRepository : IDataFlowRepository">`DataFlowRepository`</SwmToken> Class

The <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/DataFlowRepository.cs" pos="10:5:5" line-data="    public class DataFlowRepository : IDataFlowRepository">`DataFlowRepository`</SwmToken> class provides methods for accessing and manipulating data related to data flow requests and health information in the database.

```c#
    public class DataFlowRepository : IDataFlowRepository
    {
        private readonly DataFlowContext dataFlowContext;

        public DataFlowRepository(DataFlowContext dataFlowContext)
        {
            this.dataFlowContext = dataFlowContext;
        }

        public async Task<Option<Exception>> SaveRequest(
            string transactionId,
            HealthInformationRequest request)
        {
            var dataFlowRequest = new DataFlowRequest(transactionId, request);
            try
            {
                dataFlowContext.DataFlowRequest.Add(dataFlowRequest);
                await dataFlowContext.SaveChangesAsync();
                return Option.None<Exception>();
```

---

</SwmSnippet>

## <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/OpenMrsPatientData.cs" pos="57:12:12" line-data="        private async Task&lt;List&lt;string&gt;&gt; GetForVisits(string hiType, string consentId, string grantedContext,">`GetForVisits`</SwmToken>

# Data Flow Endpoints

Data Flow Endpoints are crucial for retrieving specific patient data based on various criteria.

<SwmSnippet path="/src/In.ProjectEKA.HipService/DataFlow/OpenMrsPatientData.cs" line="57">

---

The <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/OpenMrsPatientData.cs" pos="57:12:12" line-data="        private async Task&lt;List&lt;string&gt;&gt; GetForVisits(string hiType, string consentId, string grantedContext,">`GetForVisits`</SwmToken> method retrieves patient data for specific visits. It constructs a URL path using the <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/OpenMrsPatientData.cs" pos="61:15:15" line-data="            var pathForVisit = $&quot;{Constants.PATH_OPENMRS_HITYPE}{hiTypeToRootElement[hiType]}/visit/&quot;;">`hiTypeToRootElement`</SwmToken> dictionary to determine the type of health information being requested. The method then builds a query string with parameters such as <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/OpenMrsPatientData.cs" pos="71:4:4" line-data="                query[&quot;patientId&quot;] = consentId;">`patientId`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/OpenMrsPatientData.cs" pos="72:4:4" line-data="                query[&quot;visitUuid&quot;] = careContexReference[1];">`visitUuid`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/OpenMrsPatientData.cs" pos="59:3:3" line-data="            string fromDate)">`fromDate`</SwmToken>, and <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/OpenMrsPatientData.cs" pos="58:3:3" line-data="            string toDate,">`toDate`</SwmToken>. This query string is appended to the URL path, and the constructed endpoint is logged. The method sends an HTTP GET request to the constructed endpoint and processes the response to extract the relevant data.

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

The <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/OpenMrsPatientData.cs" pos="101:12:12" line-data="        private async Task&lt;List&lt;string&gt;&gt; GetForPrograms(string hiType, string consentId, string programName,">`GetForPrograms`</SwmToken> method retrieves patient data for specific programs. Similar to <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/OpenMrsPatientData.cs" pos="57:12:12" line-data="        private async Task&lt;List&lt;string&gt;&gt; GetForVisits(string hiType, string consentId, string grantedContext,">`GetForVisits`</SwmToken>, it constructs a URL path using the <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/OpenMrsPatientData.cs" pos="106:15:15" line-data="            var pathForProgram = $&quot;{Constants.PATH_OPENMRS_HITYPE}{hiTypeToRootElement[hiType]}/program/&quot;;">`hiTypeToRootElement`</SwmToken> dictionary. The method builds a query string with parameters such as <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/OpenMrsPatientData.cs" pos="115:4:4" line-data="                query[&quot;patientId&quot;] = consentId;">`patientId`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/OpenMrsPatientData.cs" pos="101:26:26" line-data="        private async Task&lt;List&lt;string&gt;&gt; GetForPrograms(string hiType, string consentId, string programName,">`programName`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/OpenMrsPatientData.cs" pos="117:4:4" line-data="                query[&quot;programEnrollmentId&quot;] = programId;">`programEnrollmentId`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/OpenMrsPatientData.cs" pos="104:3:3" line-data="            string fromDate)">`fromDate`</SwmToken>, and <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/OpenMrsPatientData.cs" pos="103:3:3" line-data="            string toDate,">`toDate`</SwmToken>. This query string is appended to the URL path, and the constructed endpoint is logged. An HTTP GET request is sent to the constructed endpoint, and the response is processed to extract the relevant data.

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
