---
title: EmptyMatcher in Matcher
---
# Purpose of <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="29:6:6" line-data="                .ValueOr(new EmptyMatcher().Of(identifier.Value));">`EmptyMatcher`</SwmToken>

# What is <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="29:6:6" line-data="                .ValueOr(new EmptyMatcher().Of(identifier.Value));">`EmptyMatcher`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="29:6:6" line-data="                .ValueOr(new EmptyMatcher().Of(identifier.Value));">`EmptyMatcher`</SwmToken> class is designed to implement the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/EmptyMatcher.cs" pos="7:9:9" line-data="    public class EmptyMatcher : IIdentifierMatcher">`IIdentifierMatcher`</SwmToken> interface. Its primary function is to provide a default matching behavior that always returns false. This ensures that no patient matches the given criteria when no other matcher is found.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" line="28">

---

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="29:6:6" line-data="                .ValueOr(new EmptyMatcher().Of(identifier.Value));">`EmptyMatcher`</SwmToken> serves as a fallback option in the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="10:5:5" line-data="    public class StrongMatcherFactory">`StrongMatcherFactory`</SwmToken> class. When no other matcher is found, the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="29:6:6" line-data="                .ValueOr(new EmptyMatcher().Of(identifier.Value));">`EmptyMatcher`</SwmToken> is used to ensure that no patient matches the given criteria.

```c#
                .Map(matcher => matcher.Of(identifier.Value))
                .ValueOr(new EmptyMatcher().Of(identifier.Value));
        }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" line="28">

---

# Example of <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="29:6:6" line-data="                .ValueOr(new EmptyMatcher().Of(identifier.Value));">`EmptyMatcher`</SwmToken> Usage

In the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="10:5:5" line-data="    public class StrongMatcherFactory">`StrongMatcherFactory`</SwmToken> class, the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="29:6:6" line-data="                .ValueOr(new EmptyMatcher().Of(identifier.Value));">`EmptyMatcher`</SwmToken> is used as a fallback option. The following code snippet demonstrates how the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="29:6:6" line-data="                .ValueOr(new EmptyMatcher().Of(identifier.Value));">`EmptyMatcher`</SwmToken> is used:

```c#
                .Map(matcher => matcher.Of(identifier.Value))
                .ValueOr(new EmptyMatcher().Of(identifier.Value));
        }
```

---

</SwmSnippet>

## <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="29:6:6" line-data="                .ValueOr(new EmptyMatcher().Of(identifier.Value));">`EmptyMatcher`</SwmToken> Class

# Main Functions

There are several main functions in this class. Some of them are the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="29:6:6" line-data="                .ValueOr(new EmptyMatcher().Of(identifier.Value));">`EmptyMatcher`</SwmToken> class and the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="28:10:10" line-data="                .Map(matcher =&gt; matcher.Of(identifier.Value))">`Of`</SwmToken> method. We will dive a little into both.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Matcher/EmptyMatcher.cs" line="7">

---

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/EmptyMatcher.cs" pos="7:5:5" line-data="    public class EmptyMatcher : IIdentifierMatcher">`EmptyMatcher`</SwmToken> class implements the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/EmptyMatcher.cs" pos="7:9:9" line-data="    public class EmptyMatcher : IIdentifierMatcher">`IIdentifierMatcher`</SwmToken> interface. Its primary function is to provide a default matching behavior that always returns false. This ensures that no patient matches the given criteria when no other matcher is found. It serves as a fallback option in the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="10:5:5" line-data="    public class StrongMatcherFactory">`StrongMatcherFactory`</SwmToken> class.

```c#
    public class EmptyMatcher : IIdentifierMatcher
    {
        public Expression<Func<Patient, bool>> Of(string value)
        {
            return p => false;
        }
    }
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
