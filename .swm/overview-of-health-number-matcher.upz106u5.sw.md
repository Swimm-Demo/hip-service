---
title: Overview of Health Number Matcher
---
## Of Method

# Overview of Health Number Matcher

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="17:9:9" line-data="                {IdentifierType.NDHM_HEALTH_NUMBER, new HealthNumberMatcher()},">`HealthNumberMatcher`</SwmToken> class is designed to match patients based on their health number. It implements the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/HealthNumberMatcher.cs" pos="7:9:9" line-data="    public class HealthNumberMatcher : IIdentifierMatcher">`IIdentifierMatcher`</SwmToken> interface and plays a vital role in the patient identification process using the NDHM health number.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Matcher/HealthNumberMatcher.cs" line="9">

---

The primary function in the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="17:9:9" line-data="                {IdentifierType.NDHM_HEALTH_NUMBER, new HealthNumberMatcher()},">`HealthNumberMatcher`</SwmToken> class is the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/HealthNumberMatcher.cs" pos="9:13:13" line-data="        public Expression&lt;Func&lt;Patient, bool&gt;&gt; Of(string value)">`Of`</SwmToken> method. This method is essential for identifying patients based on their health number. It takes a health number as input and returns an expression that checks if a patient's health number matches the input value.

```c#
        public Expression<Func<Patient, bool>> Of(string value)
        {
            return patientInfo => patientInfo.HealthNumber == value;
        }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" line="17">

---

## Usage in <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="10:5:5" line-data="    public class StrongMatcherFactory">`StrongMatcherFactory`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="17:9:9" line-data="                {IdentifierType.NDHM_HEALTH_NUMBER, new HealthNumberMatcher()},">`HealthNumberMatcher`</SwmToken> is used in the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="10:5:5" line-data="    public class StrongMatcherFactory">`StrongMatcherFactory`</SwmToken> class to match patients based on their health number.

```c#
                {IdentifierType.NDHM_HEALTH_NUMBER, new HealthNumberMatcher()},
```

---

</SwmSnippet>

## Health Number Matcher Endpoints

The `matchHealthNumber` endpoint is used to match patients based on their health number. It utilizes the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="17:9:9" line-data="                {IdentifierType.NDHM_HEALTH_NUMBER, new HealthNumberMatcher()},">`HealthNumberMatcher`</SwmToken> class which implements the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/HealthNumberMatcher.cs" pos="7:9:9" line-data="    public class HealthNumberMatcher : IIdentifierMatcher">`IIdentifierMatcher`</SwmToken> interface. This endpoint takes a health number as input and returns an expression that checks if a patient's health number matches the input value.

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
