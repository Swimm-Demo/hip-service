---
title: Overview of Health ID Matcher
---
# What is Health ID Matcher

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="18:9:9" line-data="                {IdentifierType.HEALTH_ID, new HealthIdMatcher()}">`HealthIdMatcher`</SwmToken> class is a key component in the HIP service, responsible for matching patient records based on their Health ID.

## Usage in <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="10:5:5" line-data="    public class StrongMatcherFactory">`StrongMatcherFactory`</SwmToken>

It implements the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="12:12:12" line-data="        private static readonly Dictionary&lt;IdentifierType, IIdentifierMatcher&gt; Matchers =">`IIdentifierMatcher`</SwmToken> interface and provides the functionality to create expressions that check if a patient's Health ID matches a given value.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" line="17">

---

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="18:9:9" line-data="                {IdentifierType.HEALTH_ID, new HealthIdMatcher()}">`HealthIdMatcher`</SwmToken> class is used in the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="10:5:5" line-data="    public class StrongMatcherFactory">`StrongMatcherFactory`</SwmToken> class to facilitate the matching process.

```c#
                {IdentifierType.NDHM_HEALTH_NUMBER, new HealthNumberMatcher()},
                {IdentifierType.HEALTH_ID, new HealthIdMatcher()}
            };
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Matcher/HealthIdMatcher.cs" line="8">

---

## Of Method

The primary function of the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="18:9:9" line-data="                {IdentifierType.HEALTH_ID, new HealthIdMatcher()}">`HealthIdMatcher`</SwmToken> class is the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/HealthIdMatcher.cs" pos="8:17:17" line-data="        public Expression&lt;Func&lt;Patient.Model.Patient, bool&gt;&gt; Of(string value)">`Of`</SwmToken> method. This method takes a Health ID value as a parameter and returns an expression that checks if a patient's Health ID matches the given value.

```c#
        public Expression<Func<Patient.Model.Patient, bool>> Of(string value)
        {
            return patientInfo => patientInfo.HealthId == value;
        }
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
