---
title: Basic Concepts of Key Structure in Model
---
# Key Structure Overview

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyStructure.cs" pos="5:3:3" line-data="        public KeyStructure(string expiry, string parameters, string keyValue)">`KeyStructure`</SwmToken> class is a model that encapsulates key-related information. It contains three properties: <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyStructure.cs" pos="7:1:1" line-data="            Expiry = expiry;">`Expiry`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyStructure.cs" pos="8:1:1" line-data="            Parameters = parameters;">`Parameters`</SwmToken>, and <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyStructure.cs" pos="9:1:1" line-data="            KeyValue = keyValue;">`KeyValue`</SwmToken>, which are initialized through its constructor. This class is used in other models, such as <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyMaterial.cs" pos="5:3:3" line-data="        public KeyMaterial(string cryptoAlg, string curve, KeyStructure dhPublicKey, string nonce)">`KeyMaterial`</SwmToken>, to represent the public key information.

# Properties of <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyStructure.cs" pos="5:3:3" line-data="        public KeyStructure(string expiry, string parameters, string keyValue)">`KeyStructure`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyStructure.cs" pos="5:3:3" line-data="        public KeyStructure(string expiry, string parameters, string keyValue)">`KeyStructure`</SwmToken> class has three main properties: <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyStructure.cs" pos="7:1:1" line-data="            Expiry = expiry;">`Expiry`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyStructure.cs" pos="8:1:1" line-data="            Parameters = parameters;">`Parameters`</SwmToken>, and <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyStructure.cs" pos="9:1:1" line-data="            KeyValue = keyValue;">`KeyValue`</SwmToken>. Each of these properties serves a specific purpose in the context of key management.

## Expiry

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyStructure.cs" pos="7:1:1" line-data="            Expiry = expiry;">`Expiry`</SwmToken> property holds the expiration date of the key. This is important for determining the validity period of the key.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/KeyStructure.cs" line="13">

---

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyStructure.cs" pos="13:5:5" line-data="        public string Expiry { get; }">`Expiry`</SwmToken> property is defined as a string in the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyStructure.cs" pos="5:3:3" line-data="        public KeyStructure(string expiry, string parameters, string keyValue)">`KeyStructure`</SwmToken> class.

```c#
        public string Expiry { get; }
```

---

</SwmSnippet>

## Parameters

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyStructure.cs" pos="8:1:1" line-data="            Parameters = parameters;">`Parameters`</SwmToken> property stores additional parameters related to the key. These parameters can include various metadata or configuration details necessary for the key's usage.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/KeyStructure.cs" line="14">

---

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyStructure.cs" pos="14:5:5" line-data="        public string Parameters { get; }">`Parameters`</SwmToken> property is defined as a string in the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyStructure.cs" pos="5:3:3" line-data="        public KeyStructure(string expiry, string parameters, string keyValue)">`KeyStructure`</SwmToken> class.

```c#
        public string Parameters { get; }
```

---

</SwmSnippet>

## <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyStructure.cs" pos="9:1:1" line-data="            KeyValue = keyValue;">`KeyValue`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyStructure.cs" pos="9:1:1" line-data="            KeyValue = keyValue;">`KeyValue`</SwmToken> property contains the actual value of the key. This is the core piece of information that the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyStructure.cs" pos="5:3:3" line-data="        public KeyStructure(string expiry, string parameters, string keyValue)">`KeyStructure`</SwmToken> class is designed to encapsulate.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/KeyStructure.cs" line="16">

---

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyStructure.cs" pos="16:5:5" line-data="        public string KeyValue { get; }">`KeyValue`</SwmToken> property is defined as a string in the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyStructure.cs" pos="5:3:3" line-data="        public KeyStructure(string expiry, string parameters, string keyValue)">`KeyStructure`</SwmToken> class.

```c#
        public string KeyValue { get; }
```

---

</SwmSnippet>

# Constructor of <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyStructure.cs" pos="5:3:3" line-data="        public KeyStructure(string expiry, string parameters, string keyValue)">`KeyStructure`</SwmToken>

The constructor of the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyStructure.cs" pos="5:3:3" line-data="        public KeyStructure(string expiry, string parameters, string keyValue)">`KeyStructure`</SwmToken> class initializes the properties <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyStructure.cs" pos="7:1:1" line-data="            Expiry = expiry;">`Expiry`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyStructure.cs" pos="8:1:1" line-data="            Parameters = parameters;">`Parameters`</SwmToken>, and <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyStructure.cs" pos="9:1:1" line-data="            KeyValue = keyValue;">`KeyValue`</SwmToken> with the provided values. This is essential for creating instances of the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyStructure.cs" pos="5:3:3" line-data="        public KeyStructure(string expiry, string parameters, string keyValue)">`KeyStructure`</SwmToken> class with specific key-related information.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/KeyStructure.cs" line="5">

---

The constructor of the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyStructure.cs" pos="5:3:3" line-data="        public KeyStructure(string expiry, string parameters, string keyValue)">`KeyStructure`</SwmToken> class initializes the properties with the provided values.

```c#
        public KeyStructure(string expiry, string parameters, string keyValue)
        {
            Expiry = expiry;
            Parameters = parameters;
            KeyValue = keyValue;
        }
```

---

</SwmSnippet>

# Usage in <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyMaterial.cs" pos="5:3:3" line-data="        public KeyMaterial(string cryptoAlg, string curve, KeyStructure dhPublicKey, string nonce)">`KeyMaterial`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyStructure.cs" pos="5:3:3" line-data="        public KeyStructure(string expiry, string parameters, string keyValue)">`KeyStructure`</SwmToken> class is used in the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyMaterial.cs" pos="5:3:3" line-data="        public KeyMaterial(string cryptoAlg, string curve, KeyStructure dhPublicKey, string nonce)">`KeyMaterial`</SwmToken> class to represent the public key information. This integration allows the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyMaterial.cs" pos="5:3:3" line-data="        public KeyMaterial(string cryptoAlg, string curve, KeyStructure dhPublicKey, string nonce)">`KeyMaterial`</SwmToken> class to manage cryptographic details effectively.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/KeyMaterial.cs" line="4">

---

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyMaterial.cs" pos="5:3:3" line-data="        public KeyMaterial(string cryptoAlg, string curve, KeyStructure dhPublicKey, string nonce)">`KeyMaterial`</SwmToken> class uses the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyMaterial.cs" pos="5:15:15" line-data="        public KeyMaterial(string cryptoAlg, string curve, KeyStructure dhPublicKey, string nonce)">`KeyStructure`</SwmToken> class to represent the public key information.

```c#
    {
        public KeyMaterial(string cryptoAlg, string curve, KeyStructure dhPublicKey, string nonce)
        {
            CryptoAlg = cryptoAlg;
            Curve = curve;
            DhPublicKey = dhPublicKey;
            Nonce = nonce;
        }

        public string CryptoAlg { get; }
        public string Curve { get; }
        public KeyStructure DhPublicKey { get; }
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
