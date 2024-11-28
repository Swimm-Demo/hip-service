---
title: Health Number Matcher Overview
---
## Implementation

# Health Number Matcher

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="17:9:9" line-data="                {IdentifierType.NDHM_HEALTH_NUMBER, new HealthNumberMatcher()},">`HealthNumberMatcher`</SwmToken> class is designed to match patients based on their health number.

## Primary Method: Of

It implements the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/HealthNumberMatcher.cs" pos="7:9:9" line-data="    public class HealthNumberMatcher : IIdentifierMatcher">`IIdentifierMatcher`</SwmToken> interface, ensuring that it adheres to a specific contract for matching identifiers.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Matcher/HealthNumberMatcher.cs" line="9">

---

The primary method in this class is <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/HealthNumberMatcher.cs" pos="9:13:13" line-data="        public Expression&lt;Func&lt;Patient, bool&gt;&gt; Of(string value)">`Of`</SwmToken>, which takes a health number as input and returns an expression that can be used to filter patients by their health number.

```c#
        public Expression<Func<Patient, bool>> Of(string value)
        {
            return patientInfo => patientInfo.HealthNumber == value;
        }
```

---

</SwmSnippet>

## Usage in <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="10:5:5" line-data="    public class StrongMatcherFactory">`StrongMatcherFactory`</SwmToken>

This expression is essentially a lambda function that checks if a patient's health number matches the provided value.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" line="16">

---

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="17:9:9" line-data="                {IdentifierType.NDHM_HEALTH_NUMBER, new HealthNumberMatcher()},">`HealthNumberMatcher`</SwmToken> is utilized in the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="10:5:5" line-data="    public class StrongMatcherFactory">`StrongMatcherFactory`</SwmToken> class, where it is associated with the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="17:4:4" line-data="                {IdentifierType.NDHM_HEALTH_NUMBER, new HealthNumberMatcher()},">`NDHM_HEALTH_NUMBER`</SwmToken> identifier type.

```c#
                {IdentifierType.MR, new MedicalRecordMatcher()},
                {IdentifierType.NDHM_HEALTH_NUMBER, new HealthNumberMatcher()},
                {IdentifierType.HEALTH_ID, new HealthIdMatcher()}
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
