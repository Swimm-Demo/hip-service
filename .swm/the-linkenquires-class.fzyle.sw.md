---
title: The LinkEnquires class
---
This document will cover the class <SwmToken path="src/In.ProjectEKA.HipService/Link/Model/LinkEnquires.cs" pos="12:3:3" line-data="        public LinkEnquires(">`LinkEnquires`</SwmToken> in detail. We will cover:

1. What <SwmToken path="src/In.ProjectEKA.HipService/Link/Model/LinkEnquires.cs" pos="12:3:3" line-data="        public LinkEnquires(">`LinkEnquires`</SwmToken> is.
2. Variables and functions defined in <SwmToken path="src/In.ProjectEKA.HipService/Link/Model/LinkEnquires.cs" pos="12:3:3" line-data="        public LinkEnquires(">`LinkEnquires`</SwmToken>.

# Variables and functions

# What is <SwmToken path="src/In.ProjectEKA.HipService/Link/Model/LinkEnquires.cs" pos="12:3:3" line-data="        public LinkEnquires(">`LinkEnquires`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipService/Link/Model/LinkEnquires.cs" pos="12:3:3" line-data="        public LinkEnquires(">`LinkEnquires`</SwmToken> class is a model used to facilitate the linking of a patient's care contexts with a consent manager by providing necessary identifiers and reference numbers. It is instantiated with the consent manager ID, user ID, reference number, and a collection of care context enquiries. This model is then used in various parts of the application to manage the linking process.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/Model/LinkEnquires.cs" line="12">

---

The <SwmToken path="src/In.ProjectEKA.HipService/Link/Model/LinkEnquires.cs" pos="12:3:3" line-data="        public LinkEnquires(">`LinkEnquires`</SwmToken> constructor initializes the properties <SwmToken path="src/In.ProjectEKA.HipService/Link/Model/LinkEnquires.cs" pos="20:1:1" line-data="            PatientReferenceNumber = patientReferenceNumber;">`PatientReferenceNumber`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/Link/Model/LinkEnquires.cs" pos="21:1:1" line-data="            LinkReferenceNumber = linkReferenceNumber;">`LinkReferenceNumber`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/Link/Model/LinkEnquires.cs" pos="22:1:1" line-data="            ConsentManagerId = consentManagerId;">`ConsentManagerId`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/Link/Model/LinkEnquires.cs" pos="23:1:1" line-data="            ConsentManagerUserId = consentManagerUserId;">`ConsentManagerUserId`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/Link/Model/LinkEnquires.cs" pos="24:1:1" line-data="            DateTimeStamp = dateTimeStamp;">`DateTimeStamp`</SwmToken>, and <SwmToken path="src/In.ProjectEKA.HipService/Link/Model/LinkEnquires.cs" pos="25:1:1" line-data="            CareContexts = careContexts;">`CareContexts`</SwmToken>.

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

The variable <SwmToken path="src/In.ProjectEKA.HipService/Link/Model/LinkEnquires.cs" pos="28:5:5" line-data="        public string PatientReferenceNumber { get; set; }">`PatientReferenceNumber`</SwmToken> is used to store the patient's reference number.

```c#
        public string PatientReferenceNumber { get; set; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/Model/LinkEnquires.cs" line="30">

---

The variable <SwmToken path="src/In.ProjectEKA.HipService/Link/Model/LinkEnquires.cs" pos="31:5:5" line-data="        public string LinkReferenceNumber { get; set; }">`LinkReferenceNumber`</SwmToken> is used to store the link reference number and is marked with the <SwmToken path="src/In.ProjectEKA.HipService/Link/Model/LinkEnquires.cs" pos="30:1:3" line-data="        [Key]">`[Key]`</SwmToken> attribute.

```c#
        [Key]
        public string LinkReferenceNumber { get; set; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/Model/LinkEnquires.cs" line="33">

---

The variable <SwmToken path="src/In.ProjectEKA.HipService/Link/Model/LinkEnquires.cs" pos="33:5:5" line-data="        public string ConsentManagerId { get; set; }">`ConsentManagerId`</SwmToken> is used to store the consent manager ID.

```c#
        public string ConsentManagerId { get; set; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/Model/LinkEnquires.cs" line="35">

---

The variable <SwmToken path="src/In.ProjectEKA.HipService/Link/Model/LinkEnquires.cs" pos="35:5:5" line-data="        public string ConsentManagerUserId { get; set; }">`ConsentManagerUserId`</SwmToken> is used to store the consent manager user ID.

```c#
        public string ConsentManagerUserId { get; set; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/Model/LinkEnquires.cs" line="37">

---

The variable <SwmToken path="src/In.ProjectEKA.HipService/Link/Model/LinkEnquires.cs" pos="37:5:5" line-data="        public string DateTimeStamp { get; set; }">`DateTimeStamp`</SwmToken> is used to store the date and time stamp.

```c#
        public string DateTimeStamp { get; set; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/Model/LinkEnquires.cs" line="39">

---

The variable <SwmToken path="src/In.ProjectEKA.HipService/Link/Model/LinkEnquires.cs" pos="39:10:10" line-data="        public virtual ICollection&lt;CareContext&gt; CareContexts { get; set; }">`CareContexts`</SwmToken> is used to store a collection of care contexts and is marked as virtual.

```c#
        public virtual ICollection<CareContext> CareContexts { get; set; }
```

---

</SwmSnippet>

# Usage

<SwmSnippet path="/test/In.ProjectEKA.HipServiceTest/Link/LinkPatientRepositoryTest.cs" line="67">

---

## <SwmToken path="test/In.ProjectEKA.HipServiceTest/Link/LinkPatientRepositoryTest.cs" pos="16:5:5" line-data="    public class LinkPatientRepositoryTest">`LinkPatientRepositoryTest`</SwmToken>

In <SwmToken path="test/In.ProjectEKA.HipServiceTest/Link/LinkPatientRepositoryTest.cs" pos="16:5:5" line-data="    public class LinkPatientRepositoryTest">`LinkPatientRepositoryTest`</SwmToken>, <SwmToken path="test/In.ProjectEKA.HipServiceTest/Link/LinkPatientRepositoryTest.cs" pos="67:9:9" line-data="            var linkRequest = new LinkEnquires(faker.Random.Hash(),">`LinkEnquires`</SwmToken> is used to create a new link request with random values for testing purposes.

```c#
            var linkRequest = new LinkEnquires(faker.Random.Hash(),
                linkReferenceNumber,
                faker.Random.Hash(),
                faker.Random.Hash(),
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
