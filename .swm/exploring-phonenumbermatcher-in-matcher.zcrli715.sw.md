---
title: Exploring PhoneNumberMatcher in Matcher
---
# Functionality

# Overview of <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="15:9:9" line-data="                {IdentifierType.MOBILE, new PhoneNumberMatcher()},">`PhoneNumberMatcher`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="15:9:9" line-data="                {IdentifierType.MOBILE, new PhoneNumberMatcher()},">`PhoneNumberMatcher`</SwmToken> is a class that implements the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="12:12:12" line-data="        private static readonly Dictionary&lt;IdentifierType, IIdentifierMatcher&gt; Matchers =">`IIdentifierMatcher`</SwmToken> interface. It is designed to match patient records based on their phone numbers.

# Method: Of

The primary responsibility of the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="15:9:9" line-data="                {IdentifierType.MOBILE, new PhoneNumberMatcher()},">`PhoneNumberMatcher`</SwmToken> class is to filter patient records by matching the provided phone number with the records in the database.

# Usage in the Codebase

The class contains a method called <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="28:10:10" line-data="                .Map(matcher =&gt; matcher.Of(identifier.Value))">`Of`</SwmToken>, which takes a phone number as a parameter and returns an expression. This expression is used to filter patient records where the phone number matches the provided value.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" line="14">

---

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="15:9:9" line-data="                {IdentifierType.MOBILE, new PhoneNumberMatcher()},">`PhoneNumberMatcher`</SwmToken> class is used in the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="10:5:5" line-data="    public class StrongMatcherFactory">`StrongMatcherFactory`</SwmToken> class, located in <SwmPath>[src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs](src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs)</SwmPath>.

```c#
            {
                {IdentifierType.MOBILE, new PhoneNumberMatcher()},
                {IdentifierType.MR, new MedicalRecordMatcher()},
```

---

</SwmSnippet>

# Example Usage

In <SwmPath>[src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs](src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs)</SwmPath>, <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="15:9:9" line-data="                {IdentifierType.MOBILE, new PhoneNumberMatcher()},">`PhoneNumberMatcher`</SwmToken> is instantiated and associated with the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="15:2:4" line-data="                {IdentifierType.MOBILE, new PhoneNumberMatcher()},">`IdentifierType.MOBILE`</SwmToken> key in a dictionary.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" line="14">

---

Here is an example of how <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="15:9:9" line-data="                {IdentifierType.MOBILE, new PhoneNumberMatcher()},">`PhoneNumberMatcher`</SwmToken> is instantiated and used in the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="10:5:5" line-data="    public class StrongMatcherFactory">`StrongMatcherFactory`</SwmToken> class.

```c#
            {
                {IdentifierType.MOBILE, new PhoneNumberMatcher()},
                {IdentifierType.MR, new MedicalRecordMatcher()},
```

---

</SwmSnippet>

# Phone Number Matcher Endpoints

# Main Functions

The main functions of the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="15:9:9" line-data="                {IdentifierType.MOBILE, new PhoneNumberMatcher()},">`PhoneNumberMatcher`</SwmToken> class include the implementation of the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="12:12:12" line-data="        private static readonly Dictionary&lt;IdentifierType, IIdentifierMatcher&gt; Matchers =">`IIdentifierMatcher`</SwmToken> interface and the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="28:10:10" line-data="                .Map(matcher =&gt; matcher.Of(identifier.Value))">`Of`</SwmToken> method, which filters patient records based on phone numbers.

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="15:9:9" line-data="                {IdentifierType.MOBILE, new PhoneNumberMatcher()},">`PhoneNumberMatcher`</SwmToken> class implements the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="12:12:12" line-data="        private static readonly Dictionary&lt;IdentifierType, IIdentifierMatcher&gt; Matchers =">`IIdentifierMatcher`</SwmToken> interface and is responsible for matching patient records based on their phone numbers. The class contains a method called <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="28:10:10" line-data="                .Map(matcher =&gt; matcher.Of(identifier.Value))">`Of`</SwmToken>, which takes a phone number as a parameter and returns an expression. This expression is used to filter patient records where the phone number matches the provided value.

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
