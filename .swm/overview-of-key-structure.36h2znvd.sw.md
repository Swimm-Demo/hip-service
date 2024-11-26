---
title: Overview of Key Structure
---
## Expiry

# Overview of Key Structure

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyMaterial.cs" pos="5:15:15" line-data="        public KeyMaterial(string cryptoAlg, string curve, KeyStructure dhPublicKey, string nonce)">`KeyStructure`</SwmToken> class is a model that encapsulates key-related information. It contains three properties: <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyStructure.cs" pos="13:5:5" line-data="        public string Expiry { get; }">`Expiry`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyStructure.cs" pos="8:1:1" line-data="            Parameters = parameters;">`Parameters`</SwmToken>, and <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyStructure.cs" pos="9:1:1" line-data="            KeyValue = keyValue;">`KeyValue`</SwmToken>, which are initialized through its constructor.

## Parameters

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyStructure.cs" pos="13:5:5" line-data="        public string Expiry { get; }">`Expiry`</SwmToken> property represents the expiration date of the key, ensuring that keys are only valid for a specific period.

## <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyStructure.cs" pos="9:1:1" line-data="            KeyValue = keyValue;">`KeyValue`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyStructure.cs" pos="8:1:1" line-data="            Parameters = parameters;">`Parameters`</SwmToken> property holds additional parameters related to the key, which may include algorithm details or other cryptographic parameters.

# Usage in <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyMaterial.cs" pos="5:3:3" line-data="        public KeyMaterial(string cryptoAlg, string curve, KeyStructure dhPublicKey, string nonce)">`KeyMaterial`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyStructure.cs" pos="9:1:1" line-data="            KeyValue = keyValue;">`KeyValue`</SwmToken> property stores the actual key value, which is used in cryptographic operations.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/KeyMaterial.cs" line="4">

---

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyMaterial.cs" pos="5:15:15" line-data="        public KeyMaterial(string cryptoAlg, string curve, KeyStructure dhPublicKey, string nonce)">`KeyStructure`</SwmToken> class is used in the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyMaterial.cs" pos="5:3:3" line-data="        public KeyMaterial(string cryptoAlg, string curve, KeyStructure dhPublicKey, string nonce)">`KeyMaterial`</SwmToken> class to represent the public key information. This integration allows the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyMaterial.cs" pos="5:3:3" line-data="        public KeyMaterial(string cryptoAlg, string curve, KeyStructure dhPublicKey, string nonce)">`KeyMaterial`</SwmToken> class to manage cryptographic details effectively.

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
        public string Nonce { get; }
```

---

</SwmSnippet>

## Expiry

# Main Functions

There are several main functions in this class. Some of them are Expiry, Parameters, and <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyStructure.cs" pos="9:1:1" line-data="            KeyValue = keyValue;">`KeyValue`</SwmToken>. We will dive a little into each of them.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/KeyStructure.cs" line="13">

---

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyStructure.cs" pos="13:5:5" line-data="        public string Expiry { get; }">`Expiry`</SwmToken> property represents the expiration date of the key, ensuring that keys are only valid for a specific period.

```c#
        public string Expiry { get; }
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
