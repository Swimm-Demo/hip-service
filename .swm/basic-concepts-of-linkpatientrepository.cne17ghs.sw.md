---
title: Basic Concepts of LinkPatientRepository
---
# <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatientRepository.cs" pos="16:5:5" line-data="    public class LinkPatientRepository : ILinkPatientRepository">`LinkPatientRepository`</SwmToken> Class

The <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatientRepository.cs" pos="16:5:5" line-data="    public class LinkPatientRepository : ILinkPatientRepository">`LinkPatientRepository`</SwmToken> class is responsible for managing the linking of patient accounts with consent managers and care contexts. It provides methods to save and retrieve link requests, linked accounts, and care context mappings.

## <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatientRepository.cs" pos="25:15:15" line-data="        public async Task&lt;Tuple&lt;LinkEnquires, Exception&gt;&gt; SaveRequestWith(">`SaveRequestWith`</SwmToken> Method

The <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatientRepository.cs" pos="25:15:15" line-data="        public async Task&lt;Tuple&lt;LinkEnquires, Exception&gt;&gt; SaveRequestWith(">`SaveRequestWith`</SwmToken> method saves a link request with the provided details such as link reference number, consent manager ID, consent manager user ID, patient reference number, and care context reference numbers.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/LinkPatientRepository.cs" line="25">

---

This method creates a new <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatientRepository.cs" pos="25:9:9" line-data="        public async Task&lt;Tuple&lt;LinkEnquires, Exception&gt;&gt; SaveRequestWith(">`LinkEnquires`</SwmToken> object with the provided details and saves it to the database.

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

## <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatientRepository.cs" pos="55:15:15" line-data="        public async Task&lt;Tuple&lt;LinkEnquires, Exception&gt;&gt; GetPatientFor(string linkReferenceNumber)">`GetPatientFor`</SwmToken> Method

The <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatientRepository.cs" pos="55:15:15" line-data="        public async Task&lt;Tuple&lt;LinkEnquires, Exception&gt;&gt; GetPatientFor(string linkReferenceNumber)">`GetPatientFor`</SwmToken> method retrieves a link request for a given link reference number.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/LinkPatientRepository.cs" line="55">

---

This method fetches the <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatientRepository.cs" pos="55:9:9" line-data="        public async Task&lt;Tuple&lt;LinkEnquires, Exception&gt;&gt; GetPatientFor(string linkReferenceNumber)">`LinkEnquires`</SwmToken> object from the database based on the provided link reference number.

```c#
        public async Task<Tuple<LinkEnquires, Exception>> GetPatientFor(string linkReferenceNumber)
        {
            try
            {
                var linkRequest = await linkPatientContext.LinkEnquires.Include("CareContexts")
                    .FirstAsync(request => request.LinkReferenceNumber == linkReferenceNumber)
                    .ConfigureAwait(false);
                return new Tuple<LinkEnquires, Exception>(linkRequest, null);
            }
            catch (Exception exception)
            {
                Log.Error("Can't find patient for the given reference number");
                // Log.Fatal(exception, exception.StackTrace);
                return new Tuple<LinkEnquires, Exception>(null, exception);
            }
        }
```

---

</SwmSnippet>

## Save Method

The <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatientRepository.cs" pos="72:12:12" line-data="        public async Task&lt;Option&lt;LinkedAccounts&gt;&gt; Save(string consentManagerUserId,">`Save`</SwmToken> method saves linked accounts with details like consent manager user ID, patient reference number, link reference number, care context reference numbers, and patient UUID.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/LinkPatientRepository.cs" line="72">

---

This method creates a new <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatientRepository.cs" pos="72:9:9" line-data="        public async Task&lt;Option&lt;LinkedAccounts&gt;&gt; Save(string consentManagerUserId,">`LinkedAccounts`</SwmToken> object with the provided details and saves it to the database.

```c#
        public async Task<Option<LinkedAccounts>> Save(string consentManagerUserId,
            string patientReferenceNumber,
            string linkReferenceNumber,
            IEnumerable<string> careContextReferenceNumbers,
            Guid patientUuid
        )
        {
            var linkedAccounts = new LinkedAccounts(patientReferenceNumber,
                linkReferenceNumber,
                consentManagerUserId,
                DateTime.Now.ToUniversalTime().ToString(Constants.DateTimeFormat),
                careContextReferenceNumbers.ToList(),
                patientUuid);
            try
            {
                await linkPatientContext.LinkedAccounts.AddAsync(linkedAccounts).ConfigureAwait(false);
                await linkPatientContext.SaveChangesAsync().ConfigureAwait(false);
                return Option.Some(linkedAccounts);
            }
            catch (Exception exception)
            {
```

---

</SwmSnippet>

## <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatientRepository.cs" pos="98:17:17" line-data="        public async Task&lt;Tuple&lt;IEnumerable&lt;LinkedAccounts&gt;, Exception&gt;&gt; GetLinkedCareContexts(">`GetLinkedCareContexts`</SwmToken> Method

The <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatientRepository.cs" pos="98:17:17" line-data="        public async Task&lt;Tuple&lt;IEnumerable&lt;LinkedAccounts&gt;, Exception&gt;&gt; GetLinkedCareContexts(">`GetLinkedCareContexts`</SwmToken> method retrieves linked care contexts for a given consent manager user ID.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/LinkPatientRepository.cs" line="98">

---

This method fetches the <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatientRepository.cs" pos="98:11:11" line-data="        public async Task&lt;Tuple&lt;IEnumerable&lt;LinkedAccounts&gt;, Exception&gt;&gt; GetLinkedCareContexts(">`LinkedAccounts`</SwmToken> objects from the database based on the provided consent manager user ID.

```c#
        public async Task<Tuple<IEnumerable<LinkedAccounts>, Exception>> GetLinkedCareContexts(
            string consentManagerUserId)
        {
            try
            {
                var linkRequest = await linkPatientContext.LinkedAccounts
                    .Where(request => request.ConsentManagerUserId.Equals(consentManagerUserId))
                    .ToListAsync()
                    .ConfigureAwait(false);
                return new Tuple<IEnumerable<LinkedAccounts>, Exception>(linkRequest, null);
            }
            catch (Exception exception)
            {
                Log.Fatal(exception, exception.StackTrace);
                return new Tuple<IEnumerable<LinkedAccounts>, Exception>(null, exception);
            }
        }
```

---

</SwmSnippet>

## <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatientRepository.cs" pos="139:7:7" line-data="        public async Task DeleteLinkedAccounts(string healthId)">`DeleteLinkedAccounts`</SwmToken> Method

The <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatientRepository.cs" pos="139:7:7" line-data="        public async Task DeleteLinkedAccounts(string healthId)">`DeleteLinkedAccounts`</SwmToken> method deletes linked accounts for a given health ID.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/LinkPatientRepository.cs" line="139">

---

This method removes the <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatientRepository.cs" pos="141:9:9" line-data="            var linkedAccounts = linkPatientContext.LinkedAccounts">`LinkedAccounts`</SwmToken> objects from the database based on the provided health ID.

```c#
        public async Task DeleteLinkedAccounts(string healthId)
        {
            var linkedAccounts = linkPatientContext.LinkedAccounts
                .Where(request =>
                    request.ConsentManagerUserId == healthId);
            foreach (var linkedAccount in linkedAccounts)
            {
                linkPatientContext.Remove(linkedAccount);
            }

            await linkPatientContext.SaveChangesAsync();
        }
```

---

</SwmSnippet>

## <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatientRepository.cs" pos="152:7:7" line-data="        public async Task DeleteLinkEnquires(string healthId)">`DeleteLinkEnquires`</SwmToken> Method

The <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatientRepository.cs" pos="152:7:7" line-data="        public async Task DeleteLinkEnquires(string healthId)">`DeleteLinkEnquires`</SwmToken> method deletes link enquiries for a given health ID.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/LinkPatientRepository.cs" line="152">

---

This method removes the <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatientRepository.cs" pos="154:9:9" line-data="            var linkEnquires = linkPatientContext.LinkEnquires.Include(&quot;CareContexts&quot;)">`LinkEnquires`</SwmToken> objects from the database based on the provided health ID.

```c#
        public async Task DeleteLinkEnquires(string healthId)
        {
            var linkEnquires = linkPatientContext.LinkEnquires.Include("CareContexts")
                .Where(request =>
                    request.ConsentManagerUserId == healthId);
            foreach (var linkEnquire in linkEnquires)
            {
                linkPatientContext.Remove(linkEnquire);
            }

            await linkPatientContext.SaveChangesAsync();
        }
```

---

</SwmSnippet>

## Update Method

The <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatientRepository.cs" pos="264:5:5" line-data="        public bool Update(InitiatedLinkRequest linkRequest)">`Update`</SwmToken> method updates an initiated link request.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/LinkPatientRepository.cs" line="264">

---

This method updates the <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatientRepository.cs" pos="264:7:7" line-data="        public bool Update(InitiatedLinkRequest linkRequest)">`InitiatedLinkRequest`</SwmToken> object in the database.

```c#
        public bool Update(InitiatedLinkRequest linkRequest)
        {
            try
            {
                linkPatientContext.InitiatedLinkRequest.Update(linkRequest);
                linkPatientContext.SaveChanges();
                return true;
            }
            catch (Exception exception)
            {
                Log.Fatal(exception, exception.StackTrace);
                return false;
            }
        }
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
