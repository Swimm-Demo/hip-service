---
title: Overview of the CareBundle Model
---
# Basic Concepts of <SwmToken path="src/In.ProjectEKA.DefaultHip/DataFlow/Collect.cs" pos="29:11:11" line-data="            var bundles = new List&lt;CareBundle&gt;();">`CareBundle`</SwmToken> Model

The <SwmToken path="src/In.ProjectEKA.DefaultHip/DataFlow/Collect.cs" pos="29:11:11" line-data="            var bundles = new List&lt;CareBundle&gt;();">`CareBundle`</SwmToken> model is a class that represents a bundle of healthcare information related to a specific care context. It is designed to encapsulate and manage healthcare data bundles within the application.

## Properties of <SwmToken path="src/In.ProjectEKA.DefaultHip/DataFlow/Collect.cs" pos="29:11:11" line-data="            var bundles = new List&lt;CareBundle&gt;();">`CareBundle`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.DefaultHip/DataFlow/Collect.cs" pos="29:11:11" line-data="            var bundles = new List&lt;CareBundle&gt;();">`CareBundle`</SwmToken> class contains two main properties: <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/CareBundle.cs" pos="9:1:1" line-data="            CareContextReference = careContextReference;">`CareContextReference`</SwmToken> and <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/CareBundle.cs" pos="15:5:5" line-data="        public Bundle BundleForThisCcr { get; }">`BundleForThisCcr`</SwmToken>.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/CareBundle.cs" line="15">

---

### <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/CareBundle.cs" pos="15:5:5" line-data="        public Bundle BundleForThisCcr { get; }">`BundleForThisCcr`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/CareBundle.cs" pos="15:5:5" line-data="        public Bundle BundleForThisCcr { get; }">`BundleForThisCcr`</SwmToken> property holds the actual healthcare data bundle associated with the care context. It encapsulates the healthcare information related to the specific care context.

```c#
        public Bundle BundleForThisCcr { get; }
```

---

</SwmSnippet>

## Usage of <SwmToken path="src/In.ProjectEKA.DefaultHip/DataFlow/Collect.cs" pos="29:11:11" line-data="            var bundles = new List&lt;CareBundle&gt;();">`CareBundle`</SwmToken>

<SwmToken path="src/In.ProjectEKA.DefaultHip/DataFlow/Collect.cs" pos="29:11:11" line-data="            var bundles = new List&lt;CareBundle&gt;();">`CareBundle`</SwmToken> instances are created and utilized in different services to handle patient data requests and responses. They are used to encapsulate and manage healthcare data bundles in various parts of the application.

<SwmSnippet path="/src/In.ProjectEKA.DefaultHip/DataFlow/Collect.cs" line="28">

---

### Example of <SwmToken path="src/In.ProjectEKA.DefaultHip/DataFlow/Collect.cs" pos="29:11:11" line-data="            var bundles = new List&lt;CareBundle&gt;();">`CareBundle`</SwmToken> Usage

An example of <SwmToken path="src/In.ProjectEKA.DefaultHip/DataFlow/Collect.cs" pos="29:11:11" line-data="            var bundles = new List&lt;CareBundle&gt;();">`CareBundle`</SwmToken> usage is in the <SwmPath>[src/In.ProjectEKA.DefaultHip/DataFlow/Collect.cs](src/In.ProjectEKA.DefaultHip/DataFlow/Collect.cs)</SwmPath> file where it is used to add a new <SwmToken path="src/In.ProjectEKA.DefaultHip/DataFlow/Collect.cs" pos="29:11:11" line-data="            var bundles = new List&lt;CareBundle&gt;();">`CareBundle`</SwmToken> to a list of bundles.

```c#
        {
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

## Care Bundle Endpoints

The <SwmToken path="src/In.ProjectEKA.DefaultHip/DataFlow/Collect.cs" pos="29:11:11" line-data="            var bundles = new List&lt;CareBundle&gt;();">`CareBundle`</SwmToken> endpoint is used to manage healthcare data bundles related to specific care contexts. It allows for the retrieval and management of these data bundles, encapsulating the healthcare information associated with a care context.

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
