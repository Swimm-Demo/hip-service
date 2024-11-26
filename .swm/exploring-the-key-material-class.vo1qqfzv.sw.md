---
title: Exploring the Key Material Class
---
<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/KeyMaterial.cs" line="3">

---

# Key Material Class

The Key Material class encapsulates cryptographic information necessary for secure communication. It includes several properties that define the cryptographic parameters used in the process.

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

One of the key properties is <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyMaterial.cs" pos="7:1:1" line-data="            CryptoAlg = cryptoAlg;">`CryptoAlg`</SwmToken>, which specifies the cryptographic algorithm used. This property ensures that the correct algorithm is applied for encryption and decryption processes.

Another important property is <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyMaterial.cs" pos="8:1:1" line-data="            Curve = curve;">`Curve`</SwmToken>, which indicates the elliptic curve used in the cryptographic process. Elliptic curves are essential for generating secure keys in modern cryptography.

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyMaterial.cs" pos="9:1:1" line-data="            DhPublicKey = dhPublicKey;">`DhPublicKey`</SwmToken> property holds the Diffie-Hellman public key structure. This key is used in the Diffie-Hellman key exchange protocol to securely exchange cryptographic keys over a public channel.

# Key Material Constructor

Additionally, the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyMaterial.cs" pos="10:1:1" line-data="            Nonce = nonce;">`Nonce`</SwmToken> property is a unique value used to ensure the security of cryptographic operations by preventing replay attacks.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/KeyMaterial.cs" line="5">

---

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyMaterial.cs" pos="5:3:3" line-data="        public KeyMaterial(string cryptoAlg, string curve, KeyStructure dhPublicKey, string nonce)">`KeyMaterial`</SwmToken> constructor initializes the class with the specified cryptographic algorithm, elliptic curve, Diffie-Hellman public key, and nonce. This ensures that all necessary cryptographic parameters are set up correctly.

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

## <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyMaterial.cs" pos="7:1:1" line-data="            CryptoAlg = cryptoAlg;">`CryptoAlg`</SwmToken>

# Main Functions

The Key Material class includes several main functions and properties that are essential for its operation. These include the constructor, <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyMaterial.cs" pos="7:1:1" line-data="            CryptoAlg = cryptoAlg;">`CryptoAlg`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyMaterial.cs" pos="8:1:1" line-data="            Curve = curve;">`Curve`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyMaterial.cs" pos="9:1:1" line-data="            DhPublicKey = dhPublicKey;">`DhPublicKey`</SwmToken>, and <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyMaterial.cs" pos="10:1:1" line-data="            Nonce = nonce;">`Nonce`</SwmToken>.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/KeyMaterial.cs" line="13">

---

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/KeyMaterial.cs" pos="13:5:5" line-data="        public string CryptoAlg { get; }">`CryptoAlg`</SwmToken> property specifies the cryptographic algorithm used. This property is crucial for determining the type of encryption and decryption processes that will be applied.

```c#
        public string CryptoAlg { get; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/appsettings.json" line="77">

---

# Key Material Endpoints

Key material endpoints are used to manage cryptographic information necessary for secure communication. These endpoints handle operations related to cryptographic algorithms, elliptic curves, and Diffie-Hellman public keys.

```json
  "Jwt": {
    "Authority": "$AUTHORITY",
    "Audience": "$AUDIENCE",
    "Cert": "$CERT"
  }
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
