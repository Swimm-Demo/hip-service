---
title: Overview of StrongMatcherFactory
---
# Overview of <SwmToken path="src/In.ProjectEKA.DefaultHip/Discovery/PatientMatchingRepository.cs" pos="8:9:9" line-data="    using static HipLibrary.Matcher.StrongMatcherFactory;">`StrongMatcherFactory`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.DefaultHip/Discovery/PatientMatchingRepository.cs" pos="8:9:9" line-data="    using static HipLibrary.Matcher.StrongMatcherFactory;">`StrongMatcherFactory`</SwmToken> is a class responsible for creating expressions to match patient identifiers against stored patient data. It maintains a dictionary of matchers, each corresponding to a specific type of identifier such as mobile number, medical record, health number, and health ID.

# Why <SwmToken path="src/In.ProjectEKA.DefaultHip/Discovery/PatientMatchingRepository.cs" pos="8:9:9" line-data="    using static HipLibrary.Matcher.StrongMatcherFactory;">`StrongMatcherFactory`</SwmToken> is used

The <SwmToken path="src/In.ProjectEKA.DefaultHip/Discovery/PatientMatchingRepository.cs" pos="8:9:9" line-data="    using static HipLibrary.Matcher.StrongMatcherFactory;">`StrongMatcherFactory`</SwmToken> is used to create expressions that match patient identifiers against stored patient data. This is essential for identifying and linking patient records accurately.

# How to use <SwmToken path="src/In.ProjectEKA.DefaultHip/Discovery/PatientMatchingRepository.cs" pos="8:9:9" line-data="    using static HipLibrary.Matcher.StrongMatcherFactory;">`StrongMatcherFactory`</SwmToken>

To use the <SwmToken path="src/In.ProjectEKA.DefaultHip/Discovery/PatientMatchingRepository.cs" pos="8:9:9" line-data="    using static HipLibrary.Matcher.StrongMatcherFactory;">`StrongMatcherFactory`</SwmToken>, you can call its static methods <SwmToken path="src/In.ProjectEKA.DefaultHip/Discovery/PatientMatchingRepository.cs" pos="21:7:7" line-data="            var expression = GetVerifiedExpression(request.Patient.VerifiedIdentifiers);">`GetVerifiedExpression`</SwmToken> or <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="47:15:15" line-data="        public static Expression&lt;Func&lt;Patient, bool&gt;&gt; GetUnVerifiedExpression(IEnumerable&lt;Identifier&gt; identifiers)">`GetUnVerifiedExpression`</SwmToken> with a collection of identifiers. These methods will return an expression that can be used to query patient data.

# Where <SwmToken path="src/In.ProjectEKA.DefaultHip/Discovery/PatientMatchingRepository.cs" pos="8:9:9" line-data="    using static HipLibrary.Matcher.StrongMatcherFactory;">`StrongMatcherFactory`</SwmToken> is used

The <SwmToken path="src/In.ProjectEKA.DefaultHip/Discovery/PatientMatchingRepository.cs" pos="8:9:9" line-data="    using static HipLibrary.Matcher.StrongMatcherFactory;">`StrongMatcherFactory`</SwmToken> is used in the <SwmToken path="src/In.ProjectEKA.DefaultHip/Discovery/PatientMatchingRepository.cs" pos="10:5:5" line-data="    public class PatientMatchingRepository : IMatchingRepository">`PatientMatchingRepository`</SwmToken> class.

# Example usage of <SwmToken path="src/In.ProjectEKA.DefaultHip/Discovery/PatientMatchingRepository.cs" pos="8:9:9" line-data="    using static HipLibrary.Matcher.StrongMatcherFactory;">`StrongMatcherFactory`</SwmToken>

An example usage of <SwmToken path="src/In.ProjectEKA.DefaultHip/Discovery/PatientMatchingRepository.cs" pos="8:9:9" line-data="    using static HipLibrary.Matcher.StrongMatcherFactory;">`StrongMatcherFactory`</SwmToken> is in the <SwmToken path="src/In.ProjectEKA.DefaultHip/Discovery/PatientMatchingRepository.cs" pos="10:5:5" line-data="    public class PatientMatchingRepository : IMatchingRepository">`PatientMatchingRepository`</SwmToken> class where the <SwmToken path="src/In.ProjectEKA.DefaultHip/Discovery/PatientMatchingRepository.cs" pos="21:7:7" line-data="            var expression = GetVerifiedExpression(request.Patient.VerifiedIdentifiers);">`GetVerifiedExpression`</SwmToken> method is called to generate an expression for matching verified patient identifiers.

<SwmSnippet path="/src/In.ProjectEKA.DefaultHip/Discovery/PatientMatchingRepository.cs" line="20">

---

In the <SwmToken path="src/In.ProjectEKA.DefaultHip/Discovery/PatientMatchingRepository.cs" pos="10:5:5" line-data="    public class PatientMatchingRepository : IMatchingRepository">`PatientMatchingRepository`</SwmToken> class, the <SwmToken path="src/In.ProjectEKA.DefaultHip/Discovery/PatientMatchingRepository.cs" pos="21:7:7" line-data="            var expression = GetVerifiedExpression(request.Patient.VerifiedIdentifiers);">`GetVerifiedExpression`</SwmToken> method is called to generate an expression for matching verified patient identifiers.

```c#
        {
            var expression = GetVerifiedExpression(request.Patient.VerifiedIdentifiers);
            var patientsInfo = await FileReader.ReadJsonAsync(patientFilePath);
```

---

</SwmSnippet>

# Main functions

The main functions of the <SwmToken path="src/In.ProjectEKA.DefaultHip/Discovery/PatientMatchingRepository.cs" pos="8:9:9" line-data="    using static HipLibrary.Matcher.StrongMatcherFactory;">`StrongMatcherFactory`</SwmToken> include <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="25:15:15" line-data="        private static Expression&lt;Func&lt;Patient, bool&gt;&gt; ToExpression(Identifier identifier)">`ToExpression`</SwmToken> and <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="32:15:15" line-data="        private static Expression&lt;Func&lt;Patient, bool&gt;&gt; GetExpression(">`GetExpression`</SwmToken>.

## <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="25:15:15" line-data="        private static Expression&lt;Func&lt;Patient, bool&gt;&gt; ToExpression(Identifier identifier)">`ToExpression`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="25:15:15" line-data="        private static Expression&lt;Func&lt;Patient, bool&gt;&gt; ToExpression(Identifier identifier)">`ToExpression`</SwmToken> method converts an identifier into a matching expression using the appropriate matcher from the dictionary. It retrieves the matcher based on the identifier type and creates an expression to match the identifier value.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" line="25">

---

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="25:15:15" line-data="        private static Expression&lt;Func&lt;Patient, bool&gt;&gt; ToExpression(Identifier identifier)">`ToExpression`</SwmToken> method converts an identifier into a matching expression using the appropriate matcher from the dictionary.

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

## <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="32:15:15" line-data="        private static Expression&lt;Func&lt;Patient, bool&gt;&gt; GetExpression(">`GetExpression`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="32:15:15" line-data="        private static Expression&lt;Func&lt;Patient, bool&gt;&gt; GetExpression(">`GetExpression`</SwmToken> method aggregates multiple identifier expressions into a single expression using logical OR operations. It takes a collection of identifiers and a default expression, converts each identifier to an expression using <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="25:15:15" line-data="        private static Expression&lt;Func&lt;Patient, bool&gt;&gt; ToExpression(Identifier identifier)">`ToExpression`</SwmToken>, and combines them into a single expression.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" line="32">

---

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="32:15:15" line-data="        private static Expression&lt;Func&lt;Patient, bool&gt;&gt; GetExpression(">`GetExpression`</SwmToken> method aggregates multiple identifier expressions into a single expression using logical OR operations.

```c#
        private static Expression<Func<Patient, bool>> GetExpression(
            IEnumerable<Identifier> identifiers,
            Expression<Func<Patient, bool>> @default)
        {
            return identifiers
                .Select(ToExpression)
                .DefaultIfEmpty(@default)
                .Aggregate((accumulate, next) => accumulate.Or(next));
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
