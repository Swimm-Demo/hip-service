---
title: Getting Started with Patient Identifier
---
# Getting Started with Patient Identifier

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/PatientEnquiry.cs" pos="13:3:3" line-data="            IEnumerable&lt;Identifier&gt; verifiedIdentifiers,">`Identifier`</SwmToken> class is a fundamental component in the HIP service, representing a unique identifier for a patient. It consists of two main properties: <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Identifier.cs" pos="7:1:1" line-data="            Type = type;">`Type`</SwmToken> and <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Identifier.cs" pos="8:1:1" line-data="            Value = value;">`Value`</SwmToken>.

# Usage of Identifier

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Identifier.cs" pos="7:1:1" line-data="            Type = type;">`Type`</SwmToken> property indicates the type of identifier, such as a national ID or a health ID, while the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Identifier.cs" pos="8:1:1" line-data="            Value = value;">`Value`</SwmToken> property holds the actual identifier value as a string.

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/PatientEnquiry.cs" pos="13:3:3" line-data="            IEnumerable&lt;Identifier&gt; verifiedIdentifiers,">`Identifier`</SwmToken> class is used extensively in patient enquiries and matching processes. Specifically, it is utilized in the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/PatientEnquiry.cs" pos="8:5:5" line-data="    public class PatientEnquiry">`PatientEnquiry`</SwmToken> class to represent both verified and unverified identifiers.

Additionally, the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/PatientEnquiry.cs" pos="13:3:3" line-data="            IEnumerable&lt;Identifier&gt; verifiedIdentifiers,">`Identifier`</SwmToken> class is employed in the `StrongMatcherFactory` and `MedicalRecordMatcher` classes to create expressions for verifying patient identities.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/PatientEnquiry.cs" line="12">

---

In the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/PatientEnquiry.cs" pos="8:5:5" line-data="    public class PatientEnquiry">`PatientEnquiry`</SwmToken> class, <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/PatientEnquiry.cs" pos="13:3:3" line-data="            IEnumerable&lt;Identifier&gt; verifiedIdentifiers,">`Identifier`</SwmToken> objects are used to represent both verified and unverified identifiers.

```c#
            string id,
            IEnumerable<Identifier> verifiedIdentifiers,
            IEnumerable<Identifier> unverifiedIdentifiers,
            string name,
            Gender? gender,
            ushort? yearOfBirth)
        {
            Id = id;
            VerifiedIdentifiers = verifiedIdentifiers;
            UnverifiedIdentifiers = unverifiedIdentifiers;
            Name = name;
```

---

</SwmSnippet>

## Identifier Constructor

# Main Functions of Identifier

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/PatientEnquiry.cs" pos="13:3:3" line-data="            IEnumerable&lt;Identifier&gt; verifiedIdentifiers,">`Identifier`</SwmToken> class includes several key functions, such as the constructor, <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Identifier.cs" pos="7:1:1" line-data="            Type = type;">`Type`</SwmToken> property, and <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Identifier.cs" pos="8:1:1" line-data="            Value = value;">`Value`</SwmToken> property.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/Identifier.cs" line="5">

---

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Identifier.cs" pos="5:3:3" line-data="        public Identifier(IdentifierType type, string value)">`Identifier`</SwmToken> constructor initializes a new instance of the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Identifier.cs" pos="5:3:3" line-data="        public Identifier(IdentifierType type, string value)">`Identifier`</SwmToken> class. It takes two parameters: <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Identifier.cs" pos="5:7:7" line-data="        public Identifier(IdentifierType type, string value)">`type`</SwmToken> and <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Identifier.cs" pos="5:12:12" line-data="        public Identifier(IdentifierType type, string value)">`value`</SwmToken>. The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Identifier.cs" pos="5:7:7" line-data="        public Identifier(IdentifierType type, string value)">`type`</SwmToken> parameter specifies the type of identifier, while the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Identifier.cs" pos="5:12:12" line-data="        public Identifier(IdentifierType type, string value)">`value`</SwmToken> parameter holds the actual identifier value as a string.

```c#
        public Identifier(IdentifierType type, string value)
        {
            Type = type;
            Value = value;
        }
```

---

</SwmSnippet>

## getDocument

# Identifier Endpoints

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/PatientEnquiry.cs" pos="13:3:3" line-data="            IEnumerable&lt;Identifier&gt; verifiedIdentifiers,">`Identifier`</SwmToken> class also interacts with various endpoints to retrieve documents and playlists by their IDs.

The `getDocument` function is used to get a document by its ID.

## getPlaylist

The `getPlaylist` function is used to get a playlist by its ID.

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
