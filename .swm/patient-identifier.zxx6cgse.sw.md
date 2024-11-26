---
title: Patient Identifier
---
# What is Patient Identifier

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/PatientEnquiry.cs" pos="13:3:3" line-data="            IEnumerable&lt;Identifier&gt; verifiedIdentifiers,">`Identifier`</SwmToken> class represents a unique identifier for a patient. It consists of two properties: <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Identifier.cs" pos="7:1:1" line-data="            Type = type;">`Type`</SwmToken> and <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Identifier.cs" pos="8:1:1" line-data="            Value = value;">`Value`</SwmToken>. The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Identifier.cs" pos="7:1:1" line-data="            Type = type;">`Type`</SwmToken> property indicates the type of identifier, such as a national ID or a health ID. The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Identifier.cs" pos="8:1:1" line-data="            Value = value;">`Value`</SwmToken> property holds the actual identifier value as a string.

# Where Identifier is used

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/PatientEnquiry.cs" pos="13:3:3" line-data="            IEnumerable&lt;Identifier&gt; verifiedIdentifiers,">`Identifier`</SwmToken> class is used in patient enquiries and matching processes. Specifically, it is used in the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/PatientEnquiry.cs" pos="8:5:5" line-data="    public class PatientEnquiry">`PatientEnquiry`</SwmToken> class to represent verified and unverified identifiers, and in the `StrongMatcherFactory` and `MedicalRecordMatcher` classes to create expressions for verifying patient identities.

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
            Gender = gender;
            YearOfBirth = yearOfBirth;
        }

        [Required(ErrorMessage = "Patient id must be provided.")]
        public string Id { get; }

        public IEnumerable<Identifier> VerifiedIdentifiers { get; }

        public IEnumerable<Identifier> UnverifiedIdentifiers { get; }
```

---

</SwmSnippet>

# Main functions

There are several main functions in the Identifier class. Some of them are the Identifier constructor, Type property, and Value property. We will dive a little into these functions.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/Identifier.cs" line="5">

---

## Identifier Constructor

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Identifier.cs" pos="5:3:3" line-data="        public Identifier(IdentifierType type, string value)">`Identifier`</SwmToken> constructor initializes a new instance of the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Identifier.cs" pos="5:3:3" line-data="        public Identifier(IdentifierType type, string value)">`Identifier`</SwmToken> class with a specified type and value. This is essential for creating unique identifiers for patients.

```c#
        public Identifier(IdentifierType type, string value)
        {
            Type = type;
            Value = value;
        }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/Identifier.cs" line="11">

---

## Type Property

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Identifier.cs" pos="11:5:5" line-data="        public IdentifierType Type { get; }">`Type`</SwmToken> property indicates the type of identifier, such as a national ID or a health ID. It helps in categorizing the identifier.

```c#
        public IdentifierType Type { get; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/Identifier.cs" line="13">

---

## Value Property

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Identifier.cs" pos="13:5:5" line-data="        public string Value { get; }">`Value`</SwmToken> property holds the actual identifier value as a string. This is the unique value that identifies the patient.

```c#
        public string Value { get; }
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
