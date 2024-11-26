---
title: Overview of EmptyMatcher
---
# Overview of <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="29:6:6" line-data="                .ValueOr(new EmptyMatcher().Of(identifier.Value));">`EmptyMatcher`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="29:6:6" line-data="                .ValueOr(new EmptyMatcher().Of(identifier.Value));">`EmptyMatcher`</SwmToken> class is designed to implement the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/EmptyMatcher.cs" pos="7:9:9" line-data="    public class EmptyMatcher : IIdentifierMatcher">`IIdentifierMatcher`</SwmToken> interface. Its primary function is to provide a default matching behavior that always returns false. This ensures that no patient matches the given criteria when no other matcher is found.

# <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="29:6:6" line-data="                .ValueOr(new EmptyMatcher().Of(identifier.Value));">`EmptyMatcher`</SwmToken> Class

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="29:6:6" line-data="                .ValueOr(new EmptyMatcher().Of(identifier.Value));">`EmptyMatcher`</SwmToken> class implements the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/EmptyMatcher.cs" pos="7:9:9" line-data="    public class EmptyMatcher : IIdentifierMatcher">`IIdentifierMatcher`</SwmToken> interface. It serves as a fallback option in the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="10:5:5" line-data="    public class StrongMatcherFactory">`StrongMatcherFactory`</SwmToken> class, providing a default matching behavior that always returns false.

# Of Method

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/EmptyMatcher.cs" pos="9:13:13" line-data="        public Expression&lt;Func&lt;Patient, bool&gt;&gt; Of(string value)">`Of`</SwmToken> method in the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="29:6:6" line-data="                .ValueOr(new EmptyMatcher().Of(identifier.Value));">`EmptyMatcher`</SwmToken> class takes a string value as input and returns an expression that evaluates to false for any <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/EmptyMatcher.cs" pos="9:7:7" line-data="        public Expression&lt;Func&lt;Patient, bool&gt;&gt; Of(string value)">`Patient`</SwmToken> object. This method ensures that no patient matches the given criteria.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Matcher/EmptyMatcher.cs" line="9">

---

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/EmptyMatcher.cs" pos="9:13:13" line-data="        public Expression&lt;Func&lt;Patient, bool&gt;&gt; Of(string value)">`Of`</SwmToken> method in the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="29:6:6" line-data="                .ValueOr(new EmptyMatcher().Of(identifier.Value));">`EmptyMatcher`</SwmToken> class takes a string value as input and returns an expression that evaluates to false for any <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/EmptyMatcher.cs" pos="9:7:7" line-data="        public Expression&lt;Func&lt;Patient, bool&gt;&gt; Of(string value)">`Patient`</SwmToken> object.

```c#
        public Expression<Func<Patient, bool>> Of(string value)
        {
            return p => false;
        }
```

---

</SwmSnippet>

# Usage in <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="10:5:5" line-data="    public class StrongMatcherFactory">`StrongMatcherFactory`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="29:6:6" line-data="                .ValueOr(new EmptyMatcher().Of(identifier.Value));">`EmptyMatcher`</SwmToken> is used in the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="10:5:5" line-data="    public class StrongMatcherFactory">`StrongMatcherFactory`</SwmToken> class to provide a fallback option when no other matcher is found. This ensures that the system has a default behavior to fall back on.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" line="28">

---

In the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="10:5:5" line-data="    public class StrongMatcherFactory">`StrongMatcherFactory`</SwmToken> class, the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="29:6:6" line-data="                .ValueOr(new EmptyMatcher().Of(identifier.Value));">`EmptyMatcher`</SwmToken> is used to provide a fallback option when no other matcher is found.

```c#
                .Map(matcher => matcher.Of(identifier.Value))
                .ValueOr(new EmptyMatcher().Of(identifier.Value));
        }
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
