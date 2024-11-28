---
title: Basic Concepts of Health ID Matcher
---
# Core Functionality

# Overview of Health ID Matcher

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="18:9:9" line-data="                {IdentifierType.HEALTH_ID, new HealthIdMatcher()}">`HealthIdMatcher`</SwmToken> is a class that implements the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/HealthIdMatcher.cs" pos="6:9:9" line-data="    public class HealthIdMatcher : IIdentifierMatcher">`IIdentifierMatcher`</SwmToken> interface. It is specifically designed to match patients based on their health ID.

# The Of Method

The primary function of the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="18:9:9" line-data="                {IdentifierType.HEALTH_ID, new HealthIdMatcher()}">`HealthIdMatcher`</SwmToken> class is to facilitate the identification of patients by their health ID. This is achieved through the implementation of the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/HealthIdMatcher.cs" pos="8:17:17" line-data="        public Expression&lt;Func&lt;Patient.Model.Patient, bool&gt;&gt; Of(string value)">`Of`</SwmToken> method.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Matcher/HealthIdMatcher.cs" line="8">

---

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/HealthIdMatcher.cs" pos="8:17:17" line-data="        public Expression&lt;Func&lt;Patient.Model.Patient, bool&gt;&gt; Of(string value)">`Of`</SwmToken> method in the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="18:9:9" line-data="                {IdentifierType.HEALTH_ID, new HealthIdMatcher()}">`HealthIdMatcher`</SwmToken> class takes a string value as an argument and returns an expression. This expression checks if a patient's health ID matches the provided value, enabling efficient patient identification.

```c#
        public Expression<Func<Patient.Model.Patient, bool>> Of(string value)
        {
            return patientInfo => patientInfo.HealthId == value;
        }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" line="17">

---

# Usage in <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="10:5:5" line-data="    public class StrongMatcherFactory">`StrongMatcherFactory`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="18:9:9" line-data="                {IdentifierType.HEALTH_ID, new HealthIdMatcher()}">`HealthIdMatcher`</SwmToken> is utilized in the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="10:5:5" line-data="    public class StrongMatcherFactory">`StrongMatcherFactory`</SwmToken> class to create a mapping for the identifier type <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="18:4:4" line-data="                {IdentifierType.HEALTH_ID, new HealthIdMatcher()}">`HEALTH_ID`</SwmToken>.

```c#
                {IdentifierType.NDHM_HEALTH_NUMBER, new HealthNumberMatcher()},
                {IdentifierType.HEALTH_ID, new HealthIdMatcher()}
            };
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
