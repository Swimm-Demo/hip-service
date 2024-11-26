---
title: Overview of the Patient Model
---
# What is Patient Model

A model refers to the classes and structures that represent the data and the business logic of the application.

These models are used to handle the creation and management of various requests and responses.

In the Patient module, models are used to represent patient-related data and their attributes.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Patient/Model/OpenMrsPatient.cs" line="4">

---

For example, the <SwmToken path="src/In.ProjectEKA.HipService/Patient/Model/OpenMrsPatient.cs" pos="6:5:5" line-data="    public class OpenMrsPatient">`OpenMrsPatient`</SwmToken> class includes properties like <SwmToken path="src/In.ProjectEKA.HipService/Patient/Model/OpenMrsPatient.cs" pos="8:7:7" line-data="        public OpenMrsPatient(Person person, List&lt;object&gt; identifiers)">`person`</SwmToken> and <SwmToken path="src/In.ProjectEKA.HipService/Patient/Model/OpenMrsPatient.cs" pos="8:15:15" line-data="        public OpenMrsPatient(Person person, List&lt;object&gt; identifiers)">`identifiers`</SwmToken> to store patient information.

```c#
namespace In.ProjectEKA.HipService.Patient.Model
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Patient/Model/PatientProfileRequest.cs" line="3">

---

Similarly, the <SwmToken path="src/In.ProjectEKA.HipService/Patient/Model/PatientProfileRequest.cs" pos="5:5:5" line-data="    public class PatientProfileRequest">`PatientProfileRequest`</SwmToken> class contains a property <SwmToken path="src/In.ProjectEKA.HipService/Patient/Model/PatientProfileRequest.cs" pos="7:7:7" line-data="        public PatientProfileRequest(OpenMrsPatient patient, List&lt;object&gt; relationships)">`patient`</SwmToken> which is an instance of <SwmToken path="src/In.ProjectEKA.HipService/Patient/Model/OpenMrsPatient.cs" pos="6:5:5" line-data="    public class OpenMrsPatient">`OpenMrsPatient`</SwmToken>.

```c#
namespace In.ProjectEKA.HipService.Patient.Model
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Patient/Model/PatientAddress.cs" line="1">

---

Other models like <SwmToken path="src/In.ProjectEKA.HipService/Patient/Model/PatientAddress.cs" pos="3:5:5" line-data="    public class PatientAddress">`PatientAddress`</SwmToken> and `PatientName` are used to store address and name details of the patient respectively.

```c#
namespace In.ProjectEKA.HipService.Patient.Model
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
