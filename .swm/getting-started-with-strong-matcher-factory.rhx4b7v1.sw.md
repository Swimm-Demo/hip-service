---
title: Getting Started with Strong Matcher Factory
---
# Getting Started with Strong Matcher Factory

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="10:5:5" line-data="    public class StrongMatcherFactory">`StrongMatcherFactory`</SwmToken> is a class designed to handle the creation of matchers for different types of identifiers.

## Usage

It maintains a dictionary called <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="27:3:3" line-data="            return Matchers.GetValueOrNone(identifier.Type)">`Matchers`</SwmToken> that maps <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="12:9:9" line-data="        private static readonly Dictionary&lt;IdentifierType, IIdentifierMatcher&gt; Matchers =">`IdentifierType`</SwmToken> to their corresponding <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="12:12:12" line-data="        private static readonly Dictionary&lt;IdentifierType, IIdentifierMatcher&gt; Matchers =">`IIdentifierMatcher`</SwmToken> implementations, such as <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="15:9:9" line-data="                {IdentifierType.MOBILE, new PhoneNumberMatcher()},">`PhoneNumberMatcher`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="16:9:9" line-data="                {IdentifierType.MR, new MedicalRecordMatcher()},">`MedicalRecordMatcher`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="17:9:9" line-data="                {IdentifierType.NDHM_HEALTH_NUMBER, new HealthNumberMatcher()},">`HealthNumberMatcher`</SwmToken>, and <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="18:9:9" line-data="                {IdentifierType.HEALTH_ID, new HealthIdMatcher()}">`HealthIdMatcher`</SwmToken>.

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="10:5:5" line-data="    public class StrongMatcherFactory">`StrongMatcherFactory`</SwmToken> class provides methods to generate expressions for verifying and un-verifying patient identifiers.

## Main Functions

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="10:5:5" line-data="    public class StrongMatcherFactory">`StrongMatcherFactory`</SwmToken> is used in <SwmPath>[src/In.ProjectEKA.DefaultHip/Discovery/PatientMatchingRepository.cs](src/In.ProjectEKA.DefaultHip/Discovery/PatientMatchingRepository.cs)</SwmPath>.

### <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="25:15:15" line-data="        private static Expression&lt;Func&lt;Patient, bool&gt;&gt; ToExpression(Identifier identifier)">`ToExpression`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="10:5:5" line-data="    public class StrongMatcherFactory">`StrongMatcherFactory`</SwmToken> class includes several key methods that facilitate its functionality.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" line="25">

---

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="25:15:15" line-data="        private static Expression&lt;Func&lt;Patient, bool&gt;&gt; ToExpression(Identifier identifier)">`ToExpression`</SwmToken> method converts an <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="25:17:17" line-data="        private static Expression&lt;Func&lt;Patient, bool&gt;&gt; ToExpression(Identifier identifier)">`Identifier`</SwmToken> into an expression using the appropriate matcher from the <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="27:3:3" line-data="            return Matchers.GetValueOrNone(identifier.Type)">`Matchers`</SwmToken> dictionary.

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

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" line="32">

---

### <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="32:15:15" line-data="        private static Expression&lt;Func&lt;Patient, bool&gt;&gt; GetExpression(">`GetExpression`</SwmToken>

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
        }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" line="42">

---

### <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="42:15:15" line-data="        public static Expression&lt;Func&lt;Patient, bool&gt;&gt; GetVerifiedExpression(IEnumerable&lt;Identifier&gt; identifiers)">`GetVerifiedExpression`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="42:15:15" line-data="        public static Expression&lt;Func&lt;Patient, bool&gt;&gt; GetVerifiedExpression(IEnumerable&lt;Identifier&gt; identifiers)">`GetVerifiedExpression`</SwmToken> method generates an expression to verify patient identifiers by calling <SwmToken path="src/In.ProjectEKA.HipLibrary/Matcher/StrongMatcherFactory.cs" pos="44:3:3" line-data="            return GetExpression(identifiers, ExpressionBuilder.False&lt;Patient&gt;());">`GetExpression`</SwmToken> with a default false expression.

```c#
        public static Expression<Func<Patient, bool>> GetVerifiedExpression(IEnumerable<Identifier> identifiers)
        {
            return GetExpression(identifiers, ExpressionBuilder.False<Patient>());
        }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.DefaultHip/Discovery/PatientMatchingRepository.cs" line="20">

---

The <SwmToken path="src/In.ProjectEKA.DefaultHip/Discovery/PatientMatchingRepository.cs" pos="21:7:7" line-data="            var expression = GetVerifiedExpression(request.Patient.VerifiedIdentifiers);">`GetVerifiedExpression`</SwmToken> method is used within the <SwmToken path="src/In.ProjectEKA.DefaultHip/Discovery/PatientMatchingRepository.cs" pos="19:12:12" line-data="        public async Task&lt;IQueryable&lt;Patient&gt;&gt; Where(DiscoveryRequest request)">`Where`</SwmToken> clause in <SwmPath>[src/In.ProjectEKA.DefaultHip/Discovery/PatientMatchingRepository.cs](src/In.ProjectEKA.DefaultHip/Discovery/PatientMatchingRepository.cs)</SwmPath>.

```c#
        {
            var expression = GetVerifiedExpression(request.Patient.VerifiedIdentifiers);
            var patientsInfo = await FileReader.ReadJsonAsync(patientFilePath);
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
