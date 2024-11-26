---
title: Overview of StrongMatcherFactory
---
# What is <SwmToken path="src/In.ProjectEKA.DefaultHip/Discovery/PatientMatchingRepository.cs" pos="8:9:9" line-data="    using static HipLibrary.Matcher.StrongMatcherFactory;">`StrongMatcherFactory`</SwmToken>

<SwmToken path="src/In.ProjectEKA.DefaultHip/Discovery/PatientMatchingRepository.cs" pos="8:9:9" line-data="    using static HipLibrary.Matcher.StrongMatcherFactory;">`StrongMatcherFactory`</SwmToken> is a class responsible for creating expressions to match patient identifiers against stored patient data.

# Usage in <SwmToken path="src/In.ProjectEKA.DefaultHip/Discovery/PatientMatchingRepository.cs" pos="10:5:5" line-data="    public class PatientMatchingRepository : IMatchingRepository">`PatientMatchingRepository`</SwmToken>

It maintains a dictionary of matchers, each corresponding to a specific type of identifier such as mobile number, medical record, health number, and health ID.

<SwmSnippet path="/src/In.ProjectEKA.DefaultHip/Discovery/PatientMatchingRepository.cs" line="20">

---

The <SwmToken path="src/In.ProjectEKA.DefaultHip/Discovery/PatientMatchingRepository.cs" pos="8:9:9" line-data="    using static HipLibrary.Matcher.StrongMatcherFactory;">`StrongMatcherFactory`</SwmToken> is used in the <SwmToken path="src/In.ProjectEKA.DefaultHip/Discovery/PatientMatchingRepository.cs" pos="10:5:5" line-data="    public class PatientMatchingRepository : IMatchingRepository">`PatientMatchingRepository`</SwmToken> class to facilitate the matching process.

```c#
        {
            var expression = GetVerifiedExpression(request.Patient.VerifiedIdentifiers);
            var patientsInfo = await FileReader.ReadJsonAsync(patientFilePath);
```

---

</SwmSnippet>

## <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="25:15:15" line-data="        private static Expression&lt;Func&lt;Patient, bool&gt;&gt; ToExpression(Identifier identifier)">`ToExpression`</SwmToken>

# Main Functions

The main functions of the <SwmToken path="src/In.ProjectEKA.DefaultHip/Discovery/PatientMatchingRepository.cs" pos="8:9:9" line-data="    using static HipLibrary.Matcher.StrongMatcherFactory;">`StrongMatcherFactory`</SwmToken> include <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="25:15:15" line-data="        private static Expression&lt;Func&lt;Patient, bool&gt;&gt; ToExpression(Identifier identifier)">`ToExpression`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="32:15:15" line-data="        private static Expression&lt;Func&lt;Patient, bool&gt;&gt; GetExpression(">`GetExpression`</SwmToken>, <SwmToken path="src/In.ProjectEKA.DefaultHip/Discovery/PatientMatchingRepository.cs" pos="21:7:7" line-data="            var expression = GetVerifiedExpression(request.Patient.VerifiedIdentifiers);">`GetVerifiedExpression`</SwmToken>, and <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="47:15:15" line-data="        public static Expression&lt;Func&lt;Patient, bool&gt;&gt; GetUnVerifiedExpression(IEnumerable&lt;Identifier&gt; identifiers)">`GetUnVerifiedExpression`</SwmToken>.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" line="25">

---

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="25:15:15" line-data="        private static Expression&lt;Func&lt;Patient, bool&gt;&gt; ToExpression(Identifier identifier)">`ToExpression`</SwmToken> function is responsible for converting an identifier into an expression that can be used to match patient data. It retrieves the appropriate matcher from the dictionary based on the identifier type and applies it to the identifier value.

```c#
        private static Expression<Func<Patient, bool>> ToExpression(Identifier identifier)
        {
            return Matchers.GetValueOrNone(identifier.Type)
                .Map(matcher => matcher.Of(identifier.Value))
                .ValueOr(new EmptyMatcher().Of(identifier.Value));
        }
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
