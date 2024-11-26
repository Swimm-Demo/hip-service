---
title: Basic Concepts of Health ID Matcher
---
# Basic Concepts of Health ID Matcher

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/HealthIdMatcher.cs" pos="6:5:5" line-data="    public class HealthIdMatcher : IIdentifierMatcher">`HealthIdMatcher`</SwmToken> class is a crucial component in the HIP service, responsible for matching patient records based on their Health ID. It implements the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/HealthIdMatcher.cs" pos="6:9:9" line-data="    public class HealthIdMatcher : IIdentifierMatcher">`IIdentifierMatcher`</SwmToken> interface and provides the functionality to create expressions that check if a patient's Health ID matches a given value.

## <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/HealthIdMatcher.cs" pos="6:5:5" line-data="    public class HealthIdMatcher : IIdentifierMatcher">`HealthIdMatcher`</SwmToken> Class

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/HealthIdMatcher.cs" pos="6:5:5" line-data="    public class HealthIdMatcher : IIdentifierMatcher">`HealthIdMatcher`</SwmToken> class implements the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/HealthIdMatcher.cs" pos="6:9:9" line-data="    public class HealthIdMatcher : IIdentifierMatcher">`IIdentifierMatcher`</SwmToken> interface. It contains the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/HealthIdMatcher.cs" pos="8:17:17" line-data="        public Expression&lt;Func&lt;Patient.Model.Patient, bool&gt;&gt; Of(string value)">`Of`</SwmToken> method, which takes a Health ID value as a parameter and returns an expression that checks if a patient's Health ID matches the given value.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Matcher/HealthIdMatcher.cs" line="6">

---

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/HealthIdMatcher.cs" pos="6:5:5" line-data="    public class HealthIdMatcher : IIdentifierMatcher">`HealthIdMatcher`</SwmToken> class definition and the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/HealthIdMatcher.cs" pos="8:17:17" line-data="        public Expression&lt;Func&lt;Patient.Model.Patient, bool&gt;&gt; Of(string value)">`Of`</SwmToken> method implementation.

```c#
    public class HealthIdMatcher : IIdentifierMatcher
    {
        public Expression<Func<Patient.Model.Patient, bool>> Of(string value)
        {
            return patientInfo => patientInfo.HealthId == value;
        }
    }
```

---

</SwmSnippet>

## Usage in <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="10:5:5" line-data="    public class StrongMatcherFactory">`StrongMatcherFactory`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/HealthIdMatcher.cs" pos="6:5:5" line-data="    public class HealthIdMatcher : IIdentifierMatcher">`HealthIdMatcher`</SwmToken> is used in the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="10:5:5" line-data="    public class StrongMatcherFactory">`StrongMatcherFactory`</SwmToken> to create matchers for different identifier types, including Health ID. This factory is responsible for providing the appropriate matcher based on the identifier type.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" line="17">

---

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="10:5:5" line-data="    public class StrongMatcherFactory">`StrongMatcherFactory`</SwmToken> uses the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="18:9:9" line-data="                {IdentifierType.HEALTH_ID, new HealthIdMatcher()}">`HealthIdMatcher`</SwmToken> to create matchers for Health ID.

```c#
                {IdentifierType.NDHM_HEALTH_NUMBER, new HealthNumberMatcher()},
                {IdentifierType.HEALTH_ID, new HealthIdMatcher()}
            };
```

---

</SwmSnippet>

## Main Functions

The primary function of the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/HealthIdMatcher.cs" pos="6:5:5" line-data="    public class HealthIdMatcher : IIdentifierMatcher">`HealthIdMatcher`</SwmToken> class is the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/HealthIdMatcher.cs" pos="8:17:17" line-data="        public Expression&lt;Func&lt;Patient.Model.Patient, bool&gt;&gt; Of(string value)">`Of`</SwmToken> method. This method is essential for creating expressions that match patient records based on their Health ID.

### Of Method

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/HealthIdMatcher.cs" pos="8:17:17" line-data="        public Expression&lt;Func&lt;Patient.Model.Patient, bool&gt;&gt; Of(string value)">`Of`</SwmToken> method in the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/HealthIdMatcher.cs" pos="6:5:5" line-data="    public class HealthIdMatcher : IIdentifierMatcher">`HealthIdMatcher`</SwmToken> class takes a Health ID value as a parameter and returns an expression that checks if a patient's Health ID matches the given value. This method is crucial for the matching process.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Matcher/HealthIdMatcher.cs" line="8">

---

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/HealthIdMatcher.cs" pos="8:17:17" line-data="        public Expression&lt;Func&lt;Patient.Model.Patient, bool&gt;&gt; Of(string value)">`Of`</SwmToken> method implementation in the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/HealthIdMatcher.cs" pos="6:5:5" line-data="    public class HealthIdMatcher : IIdentifierMatcher">`HealthIdMatcher`</SwmToken> class.

```c#
        public Expression<Func<Patient.Model.Patient, bool>> Of(string value)
        {
            return patientInfo => patientInfo.HealthId == value;
        }
```

---

</SwmSnippet>

## Health ID Matcher Endpoints

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/HealthIdMatcher.cs" pos="6:5:5" line-data="    public class HealthIdMatcher : IIdentifierMatcher">`HealthIdMatcher`</SwmToken> class is responsible for matching patient records based on their Health ID. The <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/HealthIdMatcher.cs" pos="8:17:17" line-data="        public Expression&lt;Func&lt;Patient.Model.Patient, bool&gt;&gt; Of(string value)">`Of`</SwmToken> method takes a Health ID value as a parameter and returns an expression that checks if a patient's Health ID matches the given value.

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
