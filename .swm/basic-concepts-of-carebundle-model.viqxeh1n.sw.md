---
title: Basic Concepts of CareBundle Model
---
## Properties of <SwmToken path="src/In.ProjectEKA.DefaultHip/DataFlow/Collect.cs" pos="29:11:11" line-data="            var bundles = new List&lt;CareBundle&gt;();">`CareBundle`</SwmToken>

# Basic Concepts of <SwmToken path="src/In.ProjectEKA.DefaultHip/DataFlow/Collect.cs" pos="29:11:11" line-data="            var bundles = new List&lt;CareBundle&gt;();">`CareBundle`</SwmToken> Model

The <SwmToken path="src/In.ProjectEKA.DefaultHip/DataFlow/Collect.cs" pos="29:11:11" line-data="            var bundles = new List&lt;CareBundle&gt;();">`CareBundle`</SwmToken> model is a class that represents a bundle of healthcare information related to a specific care context. It is designed to encapsulate and manage healthcare data bundles within the application.

The <SwmToken path="src/In.ProjectEKA.DefaultHip/DataFlow/Collect.cs" pos="29:11:11" line-data="            var bundles = new List&lt;CareBundle&gt;();">`CareBundle`</SwmToken> class contains two main properties: <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/CareBundle.cs" pos="13:5:5" line-data="        public string CareContextReference { get; }">`CareContextReference`</SwmToken> and <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/CareBundle.cs" pos="10:1:1" line-data="            BundleForThisCcr = bundleForThisCcr;">`BundleForThisCcr`</SwmToken>.

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/CareBundle.cs" pos="13:5:5" line-data="        public string CareContextReference { get; }">`CareContextReference`</SwmToken> property holds a reference to the specific care context associated with the healthcare data bundle.

## Usage of <SwmToken path="src/In.ProjectEKA.DefaultHip/DataFlow/Collect.cs" pos="29:11:11" line-data="            var bundles = new List&lt;CareBundle&gt;();">`CareBundle`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/CareBundle.cs" pos="10:1:1" line-data="            BundleForThisCcr = bundleForThisCcr;">`BundleForThisCcr`</SwmToken> property holds the actual healthcare data bundle associated with the care context. It encapsulates the healthcare information related to the specific care context.

Instances of <SwmToken path="src/In.ProjectEKA.DefaultHip/DataFlow/Collect.cs" pos="29:11:11" line-data="            var bundles = new List&lt;CareBundle&gt;();">`CareBundle`</SwmToken> are created and utilized in different services to handle patient data requests and responses. They are used to encapsulate and manage healthcare data bundles in various parts of the application.

<SwmSnippet path="/src/In.ProjectEKA.DefaultHip/DataFlow/Collect.cs" line="29">

---

An example of <SwmToken path="src/In.ProjectEKA.DefaultHip/DataFlow/Collect.cs" pos="29:11:11" line-data="            var bundles = new List&lt;CareBundle&gt;();">`CareBundle`</SwmToken> usage is in the <SwmPath>[src/In.ProjectEKA.DefaultHip/DataFlow/Collect.cs](src/In.ProjectEKA.DefaultHip/DataFlow/Collect.cs)</SwmPath> file where it is used to add a new <SwmToken path="src/In.ProjectEKA.DefaultHip/DataFlow/Collect.cs" pos="29:11:11" line-data="            var bundles = new List&lt;CareBundle&gt;();">`CareBundle`</SwmToken> to a list of bundles.

```c#
            var bundles = new List<CareBundle>();
            var patientData = FindPatientData(dataRequest);
            var careContextReferences = patientData.Keys.ToList();
            foreach (var careContextReference in careContextReferences)
                foreach (var result in patientData.GetOrDefault(careContextReference))
                {
                    Log.Information($"Returning file: {result}");
                    bundles.Add(new CareBundle(careContextReference, await FileReader.ReadJsonAsync<Bundle>(result)));
                }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/CareBundle.cs" line="13">

---

## <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/CareBundle.cs" pos="13:5:5" line-data="        public string CareContextReference { get; }">`CareContextReference`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/CareBundle.cs" pos="13:5:5" line-data="        public string CareContextReference { get; }">`CareContextReference`</SwmToken> property holds a reference to the specific care context associated with the healthcare data bundle.

```c#
        public string CareContextReference { get; }
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
