---
title: Introduction to Entries Model
---
## Structure of Entries

# Introduction to Entries Model

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Entries.cs" pos="7:3:3" line-data="        public Entries(IEnumerable&lt;CareBundle&gt; careBundles)">`Entries`</SwmToken> model is a class that represents a collection of care bundles. It is designed to encapsulate and manage these bundles efficiently.

## Constructor

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Entries.cs" pos="7:3:3" line-data="        public Entries(IEnumerable&lt;CareBundle&gt; careBundles)">`Entries`</SwmToken> class has a constructor that initializes the collection of care bundles and a property to access them. This structure ensures that the care bundles are properly managed and accessible when needed.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/Entries.cs" line="7">

---

The constructor of the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Entries.cs" pos="7:3:3" line-data="        public Entries(IEnumerable&lt;CareBundle&gt; careBundles)">`Entries`</SwmToken> class initializes the collection of care bundles. It takes an <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Entries.cs" pos="7:5:8" line-data="        public Entries(IEnumerable&lt;CareBundle&gt; careBundles)">`IEnumerable<CareBundle>`</SwmToken> as a parameter and assigns it to the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/Entries.cs" pos="9:1:1" line-data="            CareBundles = careBundles;">`CareBundles`</SwmToken> property.

```c#
        public Entries(IEnumerable<CareBundle> careBundles)
        {
            CareBundles = careBundles;
        }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/ICollect.cs" line="8">

---

## Usage of Entries

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/ICollect.cs" pos="9:5:5" line-data="        Task&lt;Option&lt;Entries&gt;&gt; CollectData(TraceableDataRequest dataRequest);">`Entries`</SwmToken> class is used in the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/ICollect.cs" pos="7:5:5" line-data="    public interface ICollect">`ICollect`</SwmToken> interface to collect data based on a <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/ICollect.cs" pos="9:10:10" line-data="        Task&lt;Option&lt;Entries&gt;&gt; CollectData(TraceableDataRequest dataRequest);">`TraceableDataRequest`</SwmToken>. This interface defines the method <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/ICollect.cs" pos="9:8:8" line-data="        Task&lt;Option&lt;Entries&gt;&gt; CollectData(TraceableDataRequest dataRequest);">`CollectData`</SwmToken> which returns an `Option<Entries>` based on the request.

```c#
    {
        Task<Option<Entries>> CollectData(TraceableDataRequest dataRequest);
    }
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
