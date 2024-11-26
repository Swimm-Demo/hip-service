---
title: Getting Started with Health Number Matcher
---
# Getting Started with Health Number Matcher

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="17:9:9" line-data="                {IdentifierType.NDHM_HEALTH_NUMBER, new HealthNumberMatcher()},">`HealthNumberMatcher`</SwmToken> class is designed to match patients based on their health number. It implements the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="12:12:12" line-data="        private static readonly Dictionary&lt;IdentifierType, IIdentifierMatcher&gt; Matchers =">`IIdentifierMatcher`</SwmToken> interface and is a crucial component in the patient identification process using the NDHM health number.

# Implementation Overview

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="17:9:9" line-data="                {IdentifierType.NDHM_HEALTH_NUMBER, new HealthNumberMatcher()},">`HealthNumberMatcher`</SwmToken> class contains a method called <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/HealthNumberMatcher.cs" pos="9:13:13" line-data="        public Expression&lt;Func&lt;Patient, bool&gt;&gt; Of(string value)">`Of`</SwmToken> which takes a health number as input and returns an expression that checks if a patient's health number matches the input value. This matcher is utilized in the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="10:5:5" line-data="    public class StrongMatcherFactory">`StrongMatcherFactory`</SwmToken> to handle patient identification.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" line="16">

---

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="17:9:9" line-data="                {IdentifierType.NDHM_HEALTH_NUMBER, new HealthNumberMatcher()},">`HealthNumberMatcher`</SwmToken> is used in the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="10:5:5" line-data="    public class StrongMatcherFactory">`StrongMatcherFactory`</SwmToken> to handle patient identification using the NDHM health number.

```c#
                {IdentifierType.MR, new MedicalRecordMatcher()},
                {IdentifierType.NDHM_HEALTH_NUMBER, new HealthNumberMatcher()},
                {IdentifierType.HEALTH_ID, new HealthIdMatcher()}
```

---

</SwmSnippet>

# Main Functions

The primary function in the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="17:9:9" line-data="                {IdentifierType.NDHM_HEALTH_NUMBER, new HealthNumberMatcher()},">`HealthNumberMatcher`</SwmToken> class is <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/HealthNumberMatcher.cs" pos="9:13:13" line-data="        public Expression&lt;Func&lt;Patient, bool&gt;&gt; Of(string value)">`Of`</SwmToken>. This method is essential for identifying patients based on their health number.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Matcher/HealthNumberMatcher.cs" line="9">

---

## Of Method

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/HealthNumberMatcher.cs" pos="9:13:13" line-data="        public Expression&lt;Func&lt;Patient, bool&gt;&gt; Of(string value)">`Of`</SwmToken> method in the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="17:9:9" line-data="                {IdentifierType.NDHM_HEALTH_NUMBER, new HealthNumberMatcher()},">`HealthNumberMatcher`</SwmToken> class takes a health number as input and returns an expression that checks if a patient's health number matches the input value.

```c#
        public Expression<Func<Patient, bool>> Of(string value)
        {
            return patientInfo => patientInfo.HealthNumber == value;
        }
```

---

</SwmSnippet>

# Health Number Matcher Endpoints

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="17:9:9" line-data="                {IdentifierType.NDHM_HEALTH_NUMBER, new HealthNumberMatcher()},">`HealthNumberMatcher`</SwmToken> class implements the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="12:12:12" line-data="        private static readonly Dictionary&lt;IdentifierType, IIdentifierMatcher&gt; Matchers =">`IIdentifierMatcher`</SwmToken> interface and is used to match patients based on their health number. The method <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/HealthNumberMatcher.cs" pos="9:13:13" line-data="        public Expression&lt;Func&lt;Patient, bool&gt;&gt; Of(string value)">`Of`</SwmToken> takes a health number as input and returns an expression that checks if a patient's health number matches the input value.

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
