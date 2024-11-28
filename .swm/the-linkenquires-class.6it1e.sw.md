---
title: The LinkEnquires class
---
This document will cover the class <SwmToken path="src/In.ProjectEKA.HipService/Link/Model/LinkEnquires.cs" pos="8:3:3" line-data="        public LinkEnquires()">`LinkEnquires`</SwmToken> in the file <SwmPath>[src/In.ProjectEKA.HipService/Link/Model/LinkEnquires.cs](src/In.ProjectEKA.HipService/Link/Model/LinkEnquires.cs)</SwmPath>. We will cover:

1. What <SwmToken path="src/In.ProjectEKA.HipService/Link/Model/LinkEnquires.cs" pos="8:3:3" line-data="        public LinkEnquires()">`LinkEnquires`</SwmToken> is and its purpose.
2. The variables and functions defined in <SwmToken path="src/In.ProjectEKA.HipService/Link/Model/LinkEnquires.cs" pos="8:3:3" line-data="        public LinkEnquires()">`LinkEnquires`</SwmToken>.

# Variables and functions

# What is <SwmToken path="src/In.ProjectEKA.HipService/Link/Model/LinkEnquires.cs" pos="8:3:3" line-data="        public LinkEnquires()">`LinkEnquires`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipService/Link/Model/LinkEnquires.cs" pos="8:3:3" line-data="        public LinkEnquires()">`LinkEnquires`</SwmToken> class is a model used in the <SwmToken path="src/In.ProjectEKA.HipService/Link/Model/LinkEnquires.cs" pos="1:2:10" line-data="namespace In.ProjectEKA.HipService.Link.Model">`In.ProjectEKA.HipService.Link.Model`</SwmToken> namespace. It represents the details of a link enquiry, which includes information about the patient, the consent manager, and the care contexts associated with the link.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/Model/LinkEnquires.cs" line="8">

---

The <SwmToken path="src/In.ProjectEKA.HipService/Link/Model/LinkEnquires.cs" pos="8:3:3" line-data="        public LinkEnquires()">`LinkEnquires`</SwmToken> class has a default constructor which initializes an empty instance of the class.

```c#
        public LinkEnquires()
        {
        }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/Model/LinkEnquires.cs" line="12">

---

The <SwmToken path="src/In.ProjectEKA.HipService/Link/Model/LinkEnquires.cs" pos="12:3:3" line-data="        public LinkEnquires(">`LinkEnquires`</SwmToken> class also has a parameterized constructor which initializes an instance with the provided values for <SwmToken path="src/In.ProjectEKA.HipService/Link/Model/LinkEnquires.cs" pos="13:3:3" line-data="            string patientReferenceNumber,">`patientReferenceNumber`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/Link/Model/LinkEnquires.cs" pos="14:3:3" line-data="            string linkReferenceNumber,">`linkReferenceNumber`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/Link/Model/LinkEnquires.cs" pos="15:3:3" line-data="            string consentManagerId,">`consentManagerId`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/Link/Model/LinkEnquires.cs" pos="16:3:3" line-data="            string consentManagerUserId,">`consentManagerUserId`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/Link/Model/LinkEnquires.cs" pos="17:3:3" line-data="            string dateTimeStamp,">`dateTimeStamp`</SwmToken>, and <SwmToken path="src/In.ProjectEKA.HipService/Link/Model/LinkEnquires.cs" pos="18:6:6" line-data="            ICollection&lt;CareContext&gt; careContexts)">`careContexts`</SwmToken>.

```c#
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
            DateTimeStamp = dateTimeStamp;
            CareContexts = careContexts;
        }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/Model/LinkEnquires.cs" line="28">

---

The variable <SwmToken path="src/In.ProjectEKA.HipService/Link/Model/LinkEnquires.cs" pos="28:5:5" line-data="        public string PatientReferenceNumber { get; set; }">`PatientReferenceNumber`</SwmToken> is used to store the reference number of the patient.

```c#
        public string PatientReferenceNumber { get; set; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/Model/LinkEnquires.cs" line="30">

---

The variable <SwmToken path="src/In.ProjectEKA.HipService/Link/Model/LinkEnquires.cs" pos="31:5:5" line-data="        public string LinkReferenceNumber { get; set; }">`LinkReferenceNumber`</SwmToken> is used to store the reference number of the link. It is marked with the <SwmToken path="src/In.ProjectEKA.HipService/Link/Model/LinkEnquires.cs" pos="30:1:3" line-data="        [Key]">`[Key]`</SwmToken> attribute, indicating it is the primary key.

```c#
        [Key]
        public string LinkReferenceNumber { get; set; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/Model/LinkEnquires.cs" line="33">

---

The variable <SwmToken path="src/In.ProjectEKA.HipService/Link/Model/LinkEnquires.cs" pos="33:5:5" line-data="        public string ConsentManagerId { get; set; }">`ConsentManagerId`</SwmToken> is used to store the ID of the consent manager.

```c#
        public string ConsentManagerId { get; set; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/Model/LinkEnquires.cs" line="35">

---

The variable <SwmToken path="src/In.ProjectEKA.HipService/Link/Model/LinkEnquires.cs" pos="35:5:5" line-data="        public string ConsentManagerUserId { get; set; }">`ConsentManagerUserId`</SwmToken> is used to store the user ID of the consent manager.

```c#
        public string ConsentManagerUserId { get; set; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/Model/LinkEnquires.cs" line="37">

---

The variable <SwmToken path="src/In.ProjectEKA.HipService/Link/Model/LinkEnquires.cs" pos="37:5:5" line-data="        public string DateTimeStamp { get; set; }">`DateTimeStamp`</SwmToken> is used to store the timestamp of the link enquiry.

```c#
        public string DateTimeStamp { get; set; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/Model/LinkEnquires.cs" line="39">

---

The variable <SwmToken path="src/In.ProjectEKA.HipService/Link/Model/LinkEnquires.cs" pos="39:10:10" line-data="        public virtual ICollection&lt;CareContext&gt; CareContexts { get; set; }">`CareContexts`</SwmToken> is used to store a collection of care contexts associated with the link enquiry. It is marked as <SwmToken path="src/In.ProjectEKA.HipService/Link/Model/LinkEnquires.cs" pos="39:3:3" line-data="        public virtual ICollection&lt;CareContext&gt; CareContexts { get; set; }">`virtual`</SwmToken> to support lazy loading.

```c#
        public virtual ICollection<CareContext> CareContexts { get; set; }
```

---

</SwmSnippet>

# Usage

<SwmSnippet path="/test/In.ProjectEKA.HipServiceTest/Link/LinkPatientRepositoryTest.cs" line="64">

---

## <SwmToken path="test/In.ProjectEKA.HipServiceTest/Link/LinkPatientRepositoryTest.cs" pos="16:5:5" line-data="    public class LinkPatientRepositoryTest">`LinkPatientRepositoryTest`</SwmToken>

In <SwmToken path="test/In.ProjectEKA.HipServiceTest/Link/LinkPatientRepositoryTest.cs" pos="16:5:5" line-data="    public class LinkPatientRepositoryTest">`LinkPatientRepositoryTest`</SwmToken>, <SwmToken path="test/In.ProjectEKA.HipServiceTest/Link/LinkPatientRepositoryTest.cs" pos="67:9:9" line-data="            var linkRequest = new LinkEnquires(faker.Random.Hash(),">`LinkEnquires`</SwmToken> is instantiated with random hash values and a list of <SwmToken path="test/In.ProjectEKA.HipServiceTest/Link/LinkPatientRepositoryTest.cs" pos="66:11:11" line-data="            var linkedCareContext = new List&lt;CareContext&gt; {new CareContext(faker.Random.Word())};">`CareContext`</SwmToken> objects. This instance is used to test the functionality of the <SwmToken path="test/In.ProjectEKA.HipServiceTest/Link/LinkPatientRepositoryTest.cs" pos="65:9:9" line-data="            var linkPatientRepository = new LinkPatientRepository(dbContext);">`LinkPatientRepository`</SwmToken> class.

```c#
            var dbContext = PatientContext();
            var linkPatientRepository = new LinkPatientRepository(dbContext);
            var linkedCareContext = new List<CareContext> {new CareContext(faker.Random.Word())};
            var linkRequest = new LinkEnquires(faker.Random.Hash(),
                linkReferenceNumber,
                faker.Random.Hash(),
                faker.Random.Hash(),
```

---

</SwmSnippet>

<SwmSnippet path="/test/In.ProjectEKA.HipServiceTest/Link/LinkPatientTest.cs" line="147">

---

## <SwmToken path="test/In.ProjectEKA.HipServiceTest/Link/LinkPatientTest.cs" pos="28:5:5" line-data="    public class LinkPatientTest">`LinkPatientTest`</SwmToken>

In <SwmToken path="test/In.ProjectEKA.HipServiceTest/Link/LinkPatientTest.cs" pos="28:5:5" line-data="    public class LinkPatientTest">`LinkPatientTest`</SwmToken>, <SwmToken path="test/In.ProjectEKA.HipServiceTest/Link/LinkPatientTest.cs" pos="150:9:9" line-data="            var linkEnquires = new LinkEnquires(&quot;&quot;,&quot;&quot;,&quot;ncg&quot;,&quot;&quot;,">`LinkEnquires`</SwmToken> is used in multiple test cases. It is instantiated with various parameters including consent manager IDs and timestamps. These instances are used to simulate different scenarios such as invalid OTP and expired OTP during patient linking.

```c#
            var dateTimeStamp = DateTime.Now.ToUniversalTime().ToString(Constants.DateTimeFormat);
            var testOtpMessage = new OtpMessage(ResponseType.OtpInvalid, "Invalid Otp");
            var patientLinkRequest = new LinkConfirmationRequest(otpToken, sessionId);
            var linkEnquires = new LinkEnquires("","","ncg","",
               dateTimeStamp,new List<CareContext>());
            linkRepository.Setup(e => e.GetPatientFor(sessionId))
                .ReturnsAsync(new Tuple<LinkEnquires, Exception>(linkEnquires, null));
            
            var expectedErrorResponse =
                new ErrorRepresentation(new Error(ErrorCode.OtpInValid, testOtpMessage.Message));
            patientVerification.Setup(e => e.Verify(sessionId, otpToken))
                .ReturnsAsync(testOtpMessage);

            var (_,cmId, error) = await linkPatient.VerifyAndLinkCareContext(patientLinkRequest);

            patientVerification.Verify();
            error.Should().BeEquivalentTo(expectedErrorResponse);
        }

        [Fact]
        private async void ReturnOtpExpired()
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/LinkPatient.cs" line="187">

---

## <SwmToken path="test/In.ProjectEKA.HipServiceTest/Link/LinkPatientTest.cs" pos="25:3:3" line-data="    using LinkPatient = HipService.Link.LinkPatient;">`LinkPatient`</SwmToken>

In the <SwmToken path="test/In.ProjectEKA.HipServiceTest/Link/LinkPatientTest.cs" pos="25:3:3" line-data="    using LinkPatient = HipService.Link.LinkPatient;">`LinkPatient`</SwmToken> class, <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatient.cs" pos="187:12:12" line-data="        private async Task&lt;bool&gt; SaveLinkedAccounts(LinkEnquires linkEnquires,string patientUuid)">`LinkEnquires`</SwmToken> is used in the <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatient.cs" pos="187:10:10" line-data="        private async Task&lt;bool&gt; SaveLinkedAccounts(LinkEnquires linkEnquires,string patientUuid)">`SaveLinkedAccounts`</SwmToken> method. This method saves the linked accounts using the details provided in the <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatient.cs" pos="187:12:12" line-data="        private async Task&lt;bool&gt; SaveLinkedAccounts(LinkEnquires linkEnquires,string patientUuid)">`LinkEnquires`</SwmToken> instance.

```c#
        private async Task<bool> SaveLinkedAccounts(LinkEnquires linkEnquires,string patientUuid)
        {
            var linkedAccount = await linkPatientRepository.Save(
                linkEnquires.ConsentManagerUserId,
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/ILinkPatientRepository.cs" line="13">

---

## <SwmToken path="test/In.ProjectEKA.HipServiceTest/Link/LinkPatientTest.cs" pos="44:7:7" line-data="        private readonly Mock&lt;ILinkPatientRepository&gt; linkRepository = new Mock&lt;ILinkPatientRepository&gt;();">`ILinkPatientRepository`</SwmToken>

In the <SwmToken path="test/In.ProjectEKA.HipServiceTest/Link/LinkPatientTest.cs" pos="44:7:7" line-data="        private readonly Mock&lt;ILinkPatientRepository&gt; linkRepository = new Mock&lt;ILinkPatientRepository&gt;();">`ILinkPatientRepository`</SwmToken> interface, <SwmToken path="src/In.ProjectEKA.HipService/Link/ILinkPatientRepository.cs" pos="13:5:5" line-data="        Task&lt;Tuple&lt;LinkEnquires, Exception&gt;&gt; SaveRequestWith(">`LinkEnquires`</SwmToken> is used as a return type for methods like <SwmToken path="src/In.ProjectEKA.HipService/Link/ILinkPatientRepository.cs" pos="13:11:11" line-data="        Task&lt;Tuple&lt;LinkEnquires, Exception&gt;&gt; SaveRequestWith(">`SaveRequestWith`</SwmToken> and <SwmToken path="src/In.ProjectEKA.HipService/Link/ILinkPatientRepository.cs" pos="21:11:11" line-data="        Task&lt;Tuple&lt;LinkEnquires, Exception&gt;&gt; GetPatientFor(string linkReferenceNumber);">`GetPatientFor`</SwmToken>. These methods handle the saving and retrieval of patient link requests.

```c#
        Task<Tuple<LinkEnquires, Exception>> SaveRequestWith(
            string linkReferenceNumber,
            string consentManagerId,
            string consentManagerUserId,
            string patientReferenceNumber,
            IEnumerable<string> careContextReferenceNumbers
        );

        Task<Tuple<LinkEnquires, Exception>> GetPatientFor(string linkReferenceNumber);
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/LinkPatientRepository.cs" line="25">

---

## <SwmToken path="test/In.ProjectEKA.HipServiceTest/Link/LinkPatientRepositoryTest.cs" pos="65:9:9" line-data="            var linkPatientRepository = new LinkPatientRepository(dbContext);">`LinkPatientRepository`</SwmToken>

In the <SwmToken path="test/In.ProjectEKA.HipServiceTest/Link/LinkPatientRepositoryTest.cs" pos="65:9:9" line-data="            var linkPatientRepository = new LinkPatientRepository(dbContext);">`LinkPatientRepository`</SwmToken> class, <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatientRepository.cs" pos="25:9:9" line-data="        public async Task&lt;Tuple&lt;LinkEnquires, Exception&gt;&gt; SaveRequestWith(">`LinkEnquires`</SwmToken> is used to create link requests with patient reference numbers, consent manager IDs, and care context reference numbers. These link requests are then saved to the database.

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

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
