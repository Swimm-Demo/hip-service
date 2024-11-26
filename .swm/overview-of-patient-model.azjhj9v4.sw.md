---
title: Overview of Patient Model
---
## Properties of Patient Class

# Overview of Patient Model

The <SwmToken path="src/In.ProjectEKA.HipService/Discovery/PatientDiscovery.cs" pos="10:5:5" line-data="    using HipLibrary.Patient;">`Patient`</SwmToken> class represents a patient in the system and is defined in the <SwmToken path="src/In.ProjectEKA.HipService/Discovery/PatientDiscovery.cs" pos="11:7:7" line-data="    using HipLibrary.Patient.Model;">`Model`</SwmToken> directory. It includes various properties to store patient information.

The properties of the <SwmToken path="src/In.ProjectEKA.HipService/Discovery/PatientDiscovery.cs" pos="10:5:5" line-data="    using HipLibrary.Patient;">`Patient`</SwmToken> class include <SwmToken path="src/In.ProjectEKA.HipService/Discovery/PatientDiscovery.cs" pos="86:3:3" line-data="                            patient.Identifier));">`Identifier`</SwmToken>, `HealthNumber`, `HealthId`, <SwmToken path="src/In.ProjectEKA.HipService/Discovery/PatientDiscovery.cs" pos="147:15:15" line-data="                    var careContexts = await careContextRepository.GetCareContexts(patient.Uuid);">`Uuid`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/Discovery/PatientDiscovery.cs" pos="124:23:23" line-data="                    Log.Information(request.Patient?.Name + &quot; &quot; + request.Patient?.Gender.ToOpenMrsGender() + &quot; &quot; + request.Patient?.YearOfBirth?.ToString() + &quot; &quot; + phoneNumber);">`Gender`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/Discovery/PatientDiscovery.cs" pos="117:19:19" line-data="                        Log.Information(&quot;Phone Number&quot; + patients.First().PhoneNumber);">`PhoneNumber`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/Discovery/PatientDiscovery.cs" pos="106:20:20" line-data="                    Log.Information(&quot;User name -&gt; &quot; + request.Patient?.Name + &quot; healthId found -&gt; &quot; + healthId);">`Name`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/Discovery/PatientDiscovery.cs" pos="124:41:41" line-data="                    Log.Information(request.Patient?.Name + &quot; &quot; + request.Patient?.Gender.ToOpenMrsGender() + &quot; &quot; + request.Patient?.YearOfBirth?.ToString() + &quot; &quot; + phoneNumber);">`YearOfBirth`</SwmToken>, and <SwmToken path="src/In.ProjectEKA.HipService/Discovery/PatientDiscovery.cs" pos="155:3:3" line-data="                    patient.CareContexts = careContexts;">`CareContexts`</SwmToken>. These properties encapsulate all the necessary information about a patient, which is used in various operations such as patient discovery, linking care contexts, and managing patient data.

The <SwmToken path="src/In.ProjectEKA.HipService/Discovery/PatientDiscovery.cs" pos="86:3:3" line-data="                            patient.Identifier));">`Identifier`</SwmToken> property is used to uniquely identify a patient.

The `HealthNumber` and `HealthId` properties store the patient's health number and health ID, respectively.

The <SwmToken path="src/In.ProjectEKA.HipService/Discovery/PatientDiscovery.cs" pos="147:15:15" line-data="                    var careContexts = await careContextRepository.GetCareContexts(patient.Uuid);">`Uuid`</SwmToken> property is another unique identifier for the patient.

The <SwmToken path="src/In.ProjectEKA.HipService/Discovery/PatientDiscovery.cs" pos="124:23:23" line-data="                    Log.Information(request.Patient?.Name + &quot; &quot; + request.Patient?.Gender.ToOpenMrsGender() + &quot; &quot; + request.Patient?.YearOfBirth?.ToString() + &quot; &quot; + phoneNumber);">`Gender`</SwmToken> property stores the gender of the patient.

The <SwmToken path="src/In.ProjectEKA.HipService/Discovery/PatientDiscovery.cs" pos="117:19:19" line-data="                        Log.Information(&quot;Phone Number&quot; + patients.First().PhoneNumber);">`PhoneNumber`</SwmToken> property stores the patient's phone number.

The <SwmToken path="src/In.ProjectEKA.HipService/Discovery/PatientDiscovery.cs" pos="106:20:20" line-data="                    Log.Information(&quot;User name -&gt; &quot; + request.Patient?.Name + &quot; healthId found -&gt; &quot; + healthId);">`Name`</SwmToken> property stores the name of the patient.

The <SwmToken path="src/In.ProjectEKA.HipService/Discovery/PatientDiscovery.cs" pos="124:41:41" line-data="                    Log.Information(request.Patient?.Name + &quot; &quot; + request.Patient?.Gender.ToOpenMrsGender() + &quot; &quot; + request.Patient?.YearOfBirth?.ToString() + &quot; &quot; + phoneNumber);">`YearOfBirth`</SwmToken> property stores the year of birth of the patient.

## Usage Example in <SwmToken path="src/In.ProjectEKA.HipService/Discovery/PatientDiscovery.cs" pos="20:5:5" line-data="    public class PatientDiscovery : IPatientDiscovery">`PatientDiscovery`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipService/Discovery/PatientDiscovery.cs" pos="155:3:3" line-data="                    patient.CareContexts = careContexts;">`CareContexts`</SwmToken> property is a collection of <SwmToken path="src/In.ProjectEKA.HipService/Discovery/PatientDiscovery.cs" pos="198:7:7" line-data="        private static IEnumerable&lt;CareContextRepresentation&gt; GetUnlinkedCareContexts(">`CareContextRepresentation`</SwmToken> objects, representing the different care contexts associated with the patient.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Discovery/PatientDiscovery.cs" line="86">

---

The <SwmToken path="src/In.ProjectEKA.HipService/Discovery/PatientDiscovery.cs" pos="87:10:10" line-data="                        return (new DiscoveryRepresentation(patient.ToPatientEnquiryRepresentation(">`ToPatientEnquiryRepresentation`</SwmToken> method in the <SwmToken path="src/In.ProjectEKA.HipService/Discovery/PatientDiscovery.cs" pos="10:5:5" line-data="    using HipLibrary.Patient;">`Patient`</SwmToken> class is used within the <SwmToken path="src/In.ProjectEKA.HipService/Discovery/PatientDiscovery.cs" pos="51:17:17" line-data="        public virtual async Task&lt;ValueTuple&lt;DiscoveryRepresentation, ErrorRepresentation&gt;&gt; PatientFor(">`PatientFor`</SwmToken> method in <SwmPath>[src/In.ProjectEKA.HipService/Discovery/PatientDiscovery.cs](src/In.ProjectEKA.HipService/Discovery/PatientDiscovery.cs)</SwmPath> to create a <SwmToken path="src/In.ProjectEKA.HipService/Discovery/PatientDiscovery.cs" pos="87:6:6" line-data="                        return (new DiscoveryRepresentation(patient.ToPatientEnquiryRepresentation(">`DiscoveryRepresentation`</SwmToken> object. This demonstrates how patient information is transformed and utilized in the patient discovery process.

```c#
                            patient.Identifier));
                        return (new DiscoveryRepresentation(patient.ToPatientEnquiryRepresentation(
                                GetUnlinkedCareContexts(linkedCareContexts, patient))),
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
