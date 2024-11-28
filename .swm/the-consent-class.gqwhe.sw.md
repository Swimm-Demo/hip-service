---
title: The Consent class
---
This document will cover the class <SwmToken path="src/In.ProjectEKA.HipService/Consent/Model/Consent.cs" pos="9:3:3" line-data="        public Consent(string consentArtefactId,">`Consent`</SwmToken> in the file <SwmPath>[src/In.ProjectEKA.HipService/Consent/Model/Consent.cs](src/In.ProjectEKA.HipService/Consent/Model/Consent.cs)</SwmPath>. We will discuss:

1. What is Consent
2. Variables and functions in Consent

# Variables and functions

# What is Consent

The <SwmToken path="src/In.ProjectEKA.HipService/Consent/Model/Consent.cs" pos="9:3:3" line-data="        public Consent(string consentArtefactId,">`Consent`</SwmToken> class in <SwmPath>[src/In.ProjectEKA.HipService/Consent/Model/Consent.cs](src/In.ProjectEKA.HipService/Consent/Model/Consent.cs)</SwmPath> is used to represent a consent artefact in the system. It encapsulates details such as the consent artefact ID, the consent artefact itself, a signature, the status of the consent, and the ID of the consent manager.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Consent/Model/Consent.cs" line="9">

---

The constructor <SwmToken path="src/In.ProjectEKA.HipService/Consent/Model/Consent.cs" pos="9:3:3" line-data="        public Consent(string consentArtefactId,">`Consent`</SwmToken> initializes the <SwmToken path="src/In.ProjectEKA.HipService/Consent/Model/Consent.cs" pos="9:3:3" line-data="        public Consent(string consentArtefactId,">`Consent`</SwmToken> object with the provided parameters: <SwmToken path="src/In.ProjectEKA.HipService/Consent/Model/Consent.cs" pos="9:7:7" line-data="        public Consent(string consentArtefactId,">`consentArtefactId`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/Consent/Model/Consent.cs" pos="10:3:3" line-data="            ConsentArtefact consentArtefact,">`consentArtefact`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/Consent/Model/Consent.cs" pos="11:3:3" line-data="            string signature,">`signature`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/Consent/Model/Consent.cs" pos="12:3:3" line-data="            ConsentStatus status,">`status`</SwmToken>, and <SwmToken path="src/In.ProjectEKA.HipService/Consent/Model/Consent.cs" pos="13:3:3" line-data="            string consentManagerId)">`consentManagerId`</SwmToken>.

```c#
        public Consent(string consentArtefactId,
            ConsentArtefact consentArtefact,
            string signature,
            ConsentStatus status,
            string consentManagerId)
        {
            ConsentArtefactId = consentArtefactId;
            ConsentArtefact = consentArtefact;
            Signature = signature;
            Status = status;
            ConsentManagerId = consentManagerId;
        }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Consent/Model/Consent.cs" line="22">

---

The variable <SwmToken path="src/In.ProjectEKA.HipService/Consent/Model/Consent.cs" pos="24:5:5" line-data="        public int Id { get; set; }">`Id`</SwmToken> is an integer that serves as the primary key for the <SwmToken path="src/In.ProjectEKA.HipService/Consent/Model/Consent.cs" pos="9:3:3" line-data="        public Consent(string consentArtefactId,">`Consent`</SwmToken> entity. It is decorated with the <SwmToken path="src/In.ProjectEKA.HipService/Consent/Model/Consent.cs" pos="22:1:8" line-data="        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]">`[DatabaseGenerated(DatabaseGeneratedOption.Identity)]`</SwmToken> and <SwmToken path="src/In.ProjectEKA.HipService/Consent/Model/Consent.cs" pos="23:1:3" line-data="        [Key]">`[Key]`</SwmToken> attributes to indicate that it is an identity column and the primary key.

```c#
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Consent/Model/Consent.cs" line="26">

---

The variable <SwmToken path="src/In.ProjectEKA.HipService/Consent/Model/Consent.cs" pos="26:5:5" line-data="        public string ConsentArtefactId { get; set; }">`ConsentArtefactId`</SwmToken> is a string that stores the ID of the consent artefact associated with this consent.

```c#
        public string ConsentArtefactId { get; set; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Consent/Model/Consent.cs" line="28">

---

The variable <SwmToken path="src/In.ProjectEKA.HipService/Consent/Model/Consent.cs" pos="28:3:3" line-data="        public ConsentArtefact ConsentArtefact { get; set; }">`ConsentArtefact`</SwmToken> is an instance of the <SwmToken path="src/In.ProjectEKA.HipService/Consent/Model/Consent.cs" pos="28:3:3" line-data="        public ConsentArtefact ConsentArtefact { get; set; }">`ConsentArtefact`</SwmToken> class that represents the actual consent artefact.

```c#
        public ConsentArtefact ConsentArtefact { get; set; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Consent/Model/Consent.cs" line="30">

---

The variable <SwmToken path="src/In.ProjectEKA.HipService/Consent/Model/Consent.cs" pos="30:5:5" line-data="        public string Signature { get; set; }">`Signature`</SwmToken> is a string that stores the signature associated with the consent.

```c#
        public string Signature { get; set; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Consent/Model/Consent.cs" line="32">

---

The variable <SwmToken path="src/In.ProjectEKA.HipService/Consent/Model/Consent.cs" pos="32:5:5" line-data="        public ConsentStatus Status { get; set; }">`Status`</SwmToken> is an instance of the <SwmToken path="src/In.ProjectEKA.HipService/Consent/Model/Consent.cs" pos="32:3:3" line-data="        public ConsentStatus Status { get; set; }">`ConsentStatus`</SwmToken> enum that indicates the current status of the consent.

```c#
        public ConsentStatus Status { get; set; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Consent/Model/Consent.cs" line="34">

---

The variable <SwmToken path="src/In.ProjectEKA.HipService/Consent/Model/Consent.cs" pos="34:5:5" line-data="        public string ConsentManagerId { get; set; }">`ConsentManagerId`</SwmToken> is a string that stores the ID of the consent manager responsible for this consent.

```c#
        public string ConsentManagerId { get; set; }
```

---

</SwmSnippet>

# Usage

<SwmSnippet path="/src/In.ProjectEKA.HipService/Consent/ConsentArtefactRequest.cs" line="1">

---

## <SwmToken path="src/In.ProjectEKA.HipService/Consent/ConsentArtefactRequest.cs" pos="5:5:5" line-data="    public class ConsentArtefactRequest">`ConsentArtefactRequest`</SwmToken>

The class Consent is used in the file <SwmPath>[src/In.ProjectEKA.HipService/Consent/ConsentArtefactRequest.cs](src/In.ProjectEKA.HipService/Consent/ConsentArtefactRequest.cs)</SwmPath> to handle requests related to consent artefacts.

```c#
namespace In.ProjectEKA.HipService.Consent
{
    using Common.Model;
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
