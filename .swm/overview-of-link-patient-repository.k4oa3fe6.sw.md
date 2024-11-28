---
title: Overview of Link Patient Repository
---
# Overview of Link Patient Repository

The <SwmToken path="src/In.ProjectEKA.HipService/Startup.cs" pos="118:7:7" line-data="                .AddScoped&lt;ILinkPatientRepository, LinkPatientRepository&gt;()">`LinkPatientRepository`</SwmToken> class is responsible for managing the linking of patient data within the system. It interacts with the <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatientRepository.cs" pos="18:5:5" line-data="        private readonly LinkPatientContext linkPatientContext;">`LinkPatientContext`</SwmToken> to perform various database operations related to patient linking.

The repository provides methods to save and retrieve link requests, which include patient reference numbers and care context reference numbers. It also handles the saving and retrieval of linked accounts, which store information about the consent manager and the patient's care contexts.

## Usage Example

Additionally, the repository includes methods to delete linked accounts and link enquiries based on the consent manager's user ID.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Startup.cs" line="117">

---

The <SwmToken path="src/In.ProjectEKA.HipService/Startup.cs" pos="118:7:7" line-data="                .AddScoped&lt;ILinkPatientRepository, LinkPatientRepository&gt;()">`LinkPatientRepository`</SwmToken> is used in <SwmPath>[src/In.ProjectEKA.HipService/Startup.cs](src/In.ProjectEKA.HipService/Startup.cs)</SwmPath>.

```c#
                .Configure<HipConfiguration>(Configuration.GetSection("hip"))
                .AddScoped<ILinkPatientRepository, LinkPatientRepository>()
                .AddScoped<IPatientRepository, OpenMrsPatientRepository>()
```

---

</SwmSnippet>

## <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatientRepository.cs" pos="25:15:15" line-data="        public async Task&lt;Tuple&lt;LinkEnquires, Exception&gt;&gt; SaveRequestWith(">`SaveRequestWith`</SwmToken>

# Main Functions

There are several main functions in this repository. Some of them are <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatientRepository.cs" pos="25:15:15" line-data="        public async Task&lt;Tuple&lt;LinkEnquires, Exception&gt;&gt; SaveRequestWith(">`SaveRequestWith`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatientRepository.cs" pos="55:15:15" line-data="        public async Task&lt;Tuple&lt;LinkEnquires, Exception&gt;&gt; GetPatientFor(string linkReferenceNumber)">`GetPatientFor`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatientRepository.cs" pos="72:12:12" line-data="        public async Task&lt;Option&lt;LinkedAccounts&gt;&gt; Save(string consentManagerUserId,">`Save`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatientRepository.cs" pos="98:17:17" line-data="        public async Task&lt;Tuple&lt;IEnumerable&lt;LinkedAccounts&gt;, Exception&gt;&gt; GetLinkedCareContexts(">`GetLinkedCareContexts`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatientRepository.cs" pos="139:7:7" line-data="        public async Task DeleteLinkedAccounts(string healthId)">`DeleteLinkedAccounts`</SwmToken>, and <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatientRepository.cs" pos="152:7:7" line-data="        public async Task DeleteLinkEnquires(string healthId)">`DeleteLinkEnquires`</SwmToken>. We will dive a little into <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatientRepository.cs" pos="25:15:15" line-data="        public async Task&lt;Tuple&lt;LinkEnquires, Exception&gt;&gt; SaveRequestWith(">`SaveRequestWith`</SwmToken> and <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatientRepository.cs" pos="55:15:15" line-data="        public async Task&lt;Tuple&lt;LinkEnquires, Exception&gt;&gt; GetPatientFor(string linkReferenceNumber)">`GetPatientFor`</SwmToken>.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/LinkPatientRepository.cs" line="25">

---

The <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatientRepository.cs" pos="25:15:15" line-data="        public async Task&lt;Tuple&lt;LinkEnquires, Exception&gt;&gt; SaveRequestWith(">`SaveRequestWith`</SwmToken> function is used to save a link request with the provided details such as link reference number, consent manager ID, consent manager user ID, patient reference number, and care context reference numbers. It creates a new <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatientRepository.cs" pos="25:9:9" line-data="        public async Task&lt;Tuple&lt;LinkEnquires, Exception&gt;&gt; SaveRequestWith(">`LinkEnquires`</SwmToken> object and adds it to the <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatientRepository.cs" pos="25:9:9" line-data="        public async Task&lt;Tuple&lt;LinkEnquires, Exception&gt;&gt; SaveRequestWith(">`LinkEnquires`</SwmToken> table in the database.

```c#
        public async Task<Tuple<LinkEnquires, Exception>> SaveRequestWith(
            string linkReferenceNumber,
            string consentManagerId,
            string consentManagerUserId,
            string patientReferenceNumber,
            IEnumerable<string> careContextReferenceNumbers)
        {
            var dateTimeStamp = DateTime.Now.ToUniversalTime().ToString(Constants.DateTimeFormat);
            var linkedCareContexts = careContextReferenceNumbers
                .Select(referenceNumber => new CareContext(referenceNumber)).ToList();
            var linkRequest = new LinkEnquires(
                patientReferenceNumber,
                linkReferenceNumber,
                consentManagerId,
                consentManagerUserId,
                dateTimeStamp,
                linkedCareContexts);
            try
            {
                await linkPatientContext.LinkEnquires.AddAsync(linkRequest).ConfigureAwait(false);
                await linkPatientContext.SaveChangesAsync().ConfigureAwait(false);
```

---

</SwmSnippet>

## saveLinkRequest

# Link Patient Repository Endpoints

The <SwmToken path="src/In.ProjectEKA.HipService/Startup.cs" pos="118:7:7" line-data="                .AddScoped&lt;ILinkPatientRepository, LinkPatientRepository&gt;()">`LinkPatientRepository`</SwmToken> class includes several endpoints to manage patient linking operations.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/LinkPatientRepository.cs" line="10">

---

The `saveLinkRequest` method in the <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatientRepository.cs" pos="16:5:5" line-data="    public class LinkPatientRepository : ILinkPatientRepository">`LinkPatientRepository`</SwmToken> class is responsible for saving link requests that include patient reference numbers and care context reference numbers. This method interacts with the <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatientRepository.cs" pos="18:5:5" line-data="        private readonly LinkPatientContext linkPatientContext;">`LinkPatientContext`</SwmToken> to perform the necessary database operations.

```c#
    using Database;
    using Logger;
    using Microsoft.EntityFrameworkCore;
    using Model;
    using Optional;

    public class LinkPatientRepository : ILinkPatientRepository
    {
        private readonly LinkPatientContext linkPatientContext;

        public LinkPatientRepository(LinkPatientContext linkPatientContext)
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/LinkPatientRepository.cs" line="30">

---

## getLinkedAccounts

The `getLinkedAccounts` method retrieves linked accounts that store information about the consent manager and the patient's care contexts. This method also interacts with the <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatientRepository.cs" pos="18:5:5" line-data="        private readonly LinkPatientContext linkPatientContext;">`LinkPatientContext`</SwmToken> to fetch the required data from the database.

```c#
            IEnumerable<string> careContextReferenceNumbers)
        {
            var dateTimeStamp = DateTime.Now.ToUniversalTime().ToString(Constants.DateTimeFormat);
            var linkedCareContexts = careContextReferenceNumbers
                .Select(referenceNumber => new CareContext(referenceNumber)).ToList();
            var linkRequest = new LinkEnquires(
                patientReferenceNumber,
                linkReferenceNumber,
                consentManagerId,
                consentManagerUserId,
                dateTimeStamp,
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
