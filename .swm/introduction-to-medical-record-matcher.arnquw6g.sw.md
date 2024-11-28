---
title: Introduction to Medical Record Matcher
---
# Introduction to Medical Record Matcher

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="16:9:9" line-data="                {IdentifierType.MR, new MedicalRecordMatcher()},">`MedicalRecordMatcher`</SwmToken> is a class designed to match medical records based on a specific identifier.

# Functionality

It implements the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="12:12:12" line-data="        private static readonly Dictionary&lt;IdentifierType, IIdentifierMatcher&gt; Matchers =">`IIdentifierMatcher`</SwmToken> interface, ensuring that it adheres to a specific contract for matching identifiers.

The primary method in this class is <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/MedicalRecordMatcher.cs" pos="9:13:13" line-data="        public Expression&lt;Func&lt;Patient, bool&gt;&gt; Of(string value)">`Of`</SwmToken>, which takes a string value as input and returns an expression that checks if a patient's identifier matches the given value.

# How to Use Medical Record Matcher

This functionality is essential for identifying and retrieving patient records accurately based on their unique identifiers.

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="16:9:9" line-data="                {IdentifierType.MR, new MedicalRecordMatcher()},">`MedicalRecordMatcher`</SwmToken> is used in <SwmPath>[src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs](src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs)</SwmPath>.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" line="15">

---

In <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="10:5:5" line-data="    public class StrongMatcherFactory">`StrongMatcherFactory`</SwmToken>, the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="16:9:9" line-data="                {IdentifierType.MR, new MedicalRecordMatcher()},">`MedicalRecordMatcher`</SwmToken> is instantiated and associated with the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="16:2:4" line-data="                {IdentifierType.MR, new MedicalRecordMatcher()},">`IdentifierType.MR`</SwmToken> key.

```c#
                {IdentifierType.MOBILE, new PhoneNumberMatcher()},
                {IdentifierType.MR, new MedicalRecordMatcher()},
                {IdentifierType.NDHM_HEALTH_NUMBER, new HealthNumberMatcher()},
```

---

</SwmSnippet>

## Of

# Main Functions

There are several main functions in this class. One of the key functions is <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/MedicalRecordMatcher.cs" pos="9:13:13" line-data="        public Expression&lt;Func&lt;Patient, bool&gt;&gt; Of(string value)">`Of`</SwmToken>.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Matcher/MedicalRecordMatcher.cs" line="9">

---

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/MedicalRecordMatcher.cs" pos="9:13:13" line-data="        public Expression&lt;Func&lt;Patient, bool&gt;&gt; Of(string value)">`Of`</SwmToken> function is used to create an expression that checks if a patient's identifier matches a given value.

```c#
        public Expression<Func<Patient, bool>> Of(string value)
        {
            return patient => patient.Identifier == value;
        }
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
