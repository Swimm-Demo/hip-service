---
title: Basic Concepts of Key Material
---
# Basic Concepts of Key Material

Key material is a class that encapsulates cryptographic information necessary for secure communication. It includes properties such as <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyMaterial.cs" pos="7:1:1" line-data="            CryptoAlg = cryptoAlg;">`CryptoAlg`</SwmToken>, which specifies the cryptographic algorithm used, <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyMaterial.cs" pos="8:1:1" line-data="            Curve = curve;">`Curve`</SwmToken>, which indicates the elliptic curve used in the cryptographic process, <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyMaterial.cs" pos="9:1:1" line-data="            DhPublicKey = dhPublicKey;">`DhPublicKey`</SwmToken>, which holds the Diffie-Hellman public key structure, and <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyMaterial.cs" pos="10:1:1" line-data="            Nonce = nonce;">`Nonce`</SwmToken>, a unique value used to ensure the security of the cryptographic operations.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/KeyMaterial.cs" line="3">

---

# Key Material Class

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyMaterial.cs" pos="3:5:5" line-data="    public class KeyMaterial">`KeyMaterial`</SwmToken> class encapsulates cryptographic information necessary for secure communication. It includes properties such as <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyMaterial.cs" pos="7:1:1" line-data="            CryptoAlg = cryptoAlg;">`CryptoAlg`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyMaterial.cs" pos="8:1:1" line-data="            Curve = curve;">`Curve`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyMaterial.cs" pos="9:1:1" line-data="            DhPublicKey = dhPublicKey;">`DhPublicKey`</SwmToken>, and <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyMaterial.cs" pos="10:1:1" line-data="            Nonce = nonce;">`Nonce`</SwmToken>.

```c#
    public class KeyMaterial
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
    }
```

---

</SwmSnippet>

# Main Functions

There are several main functions in this class. Some of them are the constructor, <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyMaterial.cs" pos="7:1:1" line-data="            CryptoAlg = cryptoAlg;">`CryptoAlg`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyMaterial.cs" pos="8:1:1" line-data="            Curve = curve;">`Curve`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyMaterial.cs" pos="9:1:1" line-data="            DhPublicKey = dhPublicKey;">`DhPublicKey`</SwmToken>, and <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyMaterial.cs" pos="10:1:1" line-data="            Nonce = nonce;">`Nonce`</SwmToken>. We will dive a little into each of these.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/KeyMaterial.cs" line="5">

---

## <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyMaterial.cs" pos="5:3:3" line-data="        public KeyMaterial(string cryptoAlg, string curve, KeyStructure dhPublicKey, string nonce)">`KeyMaterial`</SwmToken> Constructor

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyMaterial.cs" pos="5:3:3" line-data="        public KeyMaterial(string cryptoAlg, string curve, KeyStructure dhPublicKey, string nonce)">`KeyMaterial`</SwmToken> constructor initializes the class with the cryptographic algorithm, elliptic curve, Diffie-Hellman public key, and nonce.

```c#
        public KeyMaterial(string cryptoAlg, string curve, KeyStructure dhPublicKey, string nonce)
        {
            CryptoAlg = cryptoAlg;
            Curve = curve;
            DhPublicKey = dhPublicKey;
            Nonce = nonce;
        }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/KeyMaterial.cs" line="13">

---

## <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyMaterial.cs" pos="13:5:5" line-data="        public string CryptoAlg { get; }">`CryptoAlg`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyMaterial.cs" pos="13:5:5" line-data="        public string CryptoAlg { get; }">`CryptoAlg`</SwmToken> property specifies the cryptographic algorithm used.

```c#
        public string CryptoAlg { get; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/KeyMaterial.cs" line="14">

---

## Curve

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyMaterial.cs" pos="14:5:5" line-data="        public string Curve { get; }">`Curve`</SwmToken> property indicates the elliptic curve used in the cryptographic process.

```c#
        public string Curve { get; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/KeyMaterial.cs" line="15">

---

## <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyMaterial.cs" pos="15:5:5" line-data="        public KeyStructure DhPublicKey { get; }">`DhPublicKey`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyMaterial.cs" pos="15:5:5" line-data="        public KeyStructure DhPublicKey { get; }">`DhPublicKey`</SwmToken> property holds the Diffie-Hellman public key structure.

```c#
        public KeyStructure DhPublicKey { get; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/KeyMaterial.cs" line="16">

---

## Nonce

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyMaterial.cs" pos="16:5:5" line-data="        public string Nonce { get; }">`Nonce`</SwmToken> property is a unique value used to ensure the security of the cryptographic operations.

```c#
        public string Nonce { get; }
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
