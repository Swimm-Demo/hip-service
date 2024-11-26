---
title: Basic Concepts of PhoneNumberMatcher
---
# Basic Concepts of <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/PhoneNumberMatcher.cs" pos="7:5:5" line-data="    public class PhoneNumberMatcher : IIdentifierMatcher">`PhoneNumberMatcher`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/PhoneNumberMatcher.cs" pos="7:5:5" line-data="    public class PhoneNumberMatcher : IIdentifierMatcher">`PhoneNumberMatcher`</SwmToken> class is designed to match a patient's phone number with a given value.

## Implementation

It implements the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/PhoneNumberMatcher.cs" pos="7:9:9" line-data="    public class PhoneNumberMatcher : IIdentifierMatcher">`IIdentifierMatcher`</SwmToken> interface, ensuring that it adheres to a standard structure for matching identifiers.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Matcher/PhoneNumberMatcher.cs" line="9">

---

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/PhoneNumberMatcher.cs" pos="7:5:5" line-data="    public class PhoneNumberMatcher : IIdentifierMatcher">`PhoneNumberMatcher`</SwmToken> class contains the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/PhoneNumberMatcher.cs" pos="9:13:13" line-data="        public Expression&lt;Func&lt;Patient, bool&gt;&gt; Of(string value)">`Of`</SwmToken> method, which takes a string value as a parameter and returns an expression that checks if the patient's phone number matches the given value.

```c#
        public Expression<Func<Patient, bool>> Of(string value)
        {
            return patientInfo => patientInfo.PhoneNumber == value;
        }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" line="14">

---

## Usage

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="15:9:9" line-data="                {IdentifierType.MOBILE, new PhoneNumberMatcher()},">`PhoneNumberMatcher`</SwmToken> is used in the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="10:5:5" line-data="    public class StrongMatcherFactory">`StrongMatcherFactory`</SwmToken> class.

```c#
            {
                {IdentifierType.MOBILE, new PhoneNumberMatcher()},
                {IdentifierType.MR, new MedicalRecordMatcher()},
```

---

</SwmSnippet>

### <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/PhoneNumberMatcher.cs" pos="7:5:5" line-data="    public class PhoneNumberMatcher : IIdentifierMatcher">`PhoneNumberMatcher`</SwmToken> Class

## Main Functions

There are several main functions in this class. One of them is the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/PhoneNumberMatcher.cs" pos="9:13:13" line-data="        public Expression&lt;Func&lt;Patient, bool&gt;&gt; Of(string value)">`Of`</SwmToken> method, which we will explore in more detail.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Matcher/PhoneNumberMatcher.cs" line="7">

---

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/PhoneNumberMatcher.cs" pos="7:5:5" line-data="    public class PhoneNumberMatcher : IIdentifierMatcher">`PhoneNumberMatcher`</SwmToken> class is designed to match a patient's phone number with a given value. It implements the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/PhoneNumberMatcher.cs" pos="7:9:9" line-data="    public class PhoneNumberMatcher : IIdentifierMatcher">`IIdentifierMatcher`</SwmToken> interface, ensuring that it adheres to a standard structure for matching identifiers.

```c#
    public class PhoneNumberMatcher : IIdentifierMatcher
    {
```

---

</SwmSnippet>

## Phone Number Matcher Endpoints

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/PhoneNumberMatcher.cs" pos="7:5:5" line-data="    public class PhoneNumberMatcher : IIdentifierMatcher">`PhoneNumberMatcher`</SwmToken> class is designed to match a patient's phone number with a given value. It implements the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/PhoneNumberMatcher.cs" pos="7:9:9" line-data="    public class PhoneNumberMatcher : IIdentifierMatcher">`IIdentifierMatcher`</SwmToken> interface, ensuring that it adheres to a standard structure for matching identifiers. The <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/PhoneNumberMatcher.cs" pos="7:5:5" line-data="    public class PhoneNumberMatcher : IIdentifierMatcher">`PhoneNumberMatcher`</SwmToken> class contains the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/PhoneNumberMatcher.cs" pos="9:13:13" line-data="        public Expression&lt;Func&lt;Patient, bool&gt;&gt; Of(string value)">`Of`</SwmToken> method, which takes a string value as a parameter and returns an expression that checks if the patient's phone number matches the given value.

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
