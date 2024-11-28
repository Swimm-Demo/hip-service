---
title: Exploring EmptyMatcher in Matcher
---
# Purpose

# Overview

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="29:6:6" line-data="                .ValueOr(new EmptyMatcher().Of(identifier.Value));">`EmptyMatcher`</SwmToken> class is a part of the Matcher module and implements the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/EmptyMatcher.cs" pos="7:9:9" line-data="    public class EmptyMatcher : IIdentifierMatcher">`IIdentifierMatcher`</SwmToken> interface. It is designed to always return a false condition, making it useful in scenarios where a match is not found or when a default false condition is needed.

# Method

The primary purpose of the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="29:6:6" line-data="                .ValueOr(new EmptyMatcher().Of(identifier.Value));">`EmptyMatcher`</SwmToken> class is to provide a consistent way to handle cases where no match is found. By always returning false, it ensures that the system can gracefully handle unmatched cases without errors.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Matcher/EmptyMatcher.cs" line="9">

---

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/EmptyMatcher.cs" pos="9:13:13" line-data="        public Expression&lt;Func&lt;Patient, bool&gt;&gt; Of(string value)">`Of`</SwmToken> method in the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="29:6:6" line-data="                .ValueOr(new EmptyMatcher().Of(identifier.Value));">`EmptyMatcher`</SwmToken> class takes a string value as input but does not use it. Instead, it returns an expression that always evaluates to false for any <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/EmptyMatcher.cs" pos="9:7:7" line-data="        public Expression&lt;Func&lt;Patient, bool&gt;&gt; Of(string value)">`Patient`</SwmToken> object.

```c#
        public Expression<Func<Patient, bool>> Of(string value)
        {
            return p => false;
        }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" line="28">

---

# Usage Example

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="29:6:6" line-data="                .ValueOr(new EmptyMatcher().Of(identifier.Value));">`EmptyMatcher`</SwmToken> is used in various parts of the codebase. For instance, it is utilized in the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="10:5:5" line-data="    public class StrongMatcherFactory">`StrongMatcherFactory`</SwmToken> class to handle cases where no strong match is found.

```c#
                .Map(matcher => matcher.Of(identifier.Value))
                .ValueOr(new EmptyMatcher().Of(identifier.Value));
```

---

</SwmSnippet>

# Implementation Details

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="29:6:6" line-data="                .ValueOr(new EmptyMatcher().Of(identifier.Value));">`EmptyMatcher`</SwmToken> class is implemented in the <SwmPath>[src/In.ProjectEKA.HipLibrary/Matcher/EmptyMatcher.cs](src/In.ProjectEKA.HipLibrary/Matcher/EmptyMatcher.cs)</SwmPath> file. It ensures that any call to its <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/EmptyMatcher.cs" pos="9:13:13" line-data="        public Expression&lt;Func&lt;Patient, bool&gt;&gt; Of(string value)">`Of`</SwmToken> method will result in a false condition, thus providing a reliable way to handle unmatched cases.

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
