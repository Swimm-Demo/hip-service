---
title: Exploring Patient Model
---
## Overview

The <SwmToken path="src/In.ProjectEKA.HipService/Patient/Model/OpenMrsPatient.cs" pos="4:8:8" line-data="namespace In.ProjectEKA.HipService.Patient.Model">`Patient`</SwmToken> directory contains various classes that represent the structure and attributes of a patient in the system. These classes are essential for managing patient information, including personal details, addresses, names, and additional attributes.

## <SwmToken path="src/In.ProjectEKA.HipService/Patient/Model/OpenMrsPatient.cs" pos="6:5:5" line-data="    public class OpenMrsPatient">`OpenMrsPatient`</SwmToken> Class

The <SwmToken path="src/In.ProjectEKA.HipService/Patient/Model/OpenMrsPatient.cs" pos="6:5:5" line-data="    public class OpenMrsPatient">`OpenMrsPatient`</SwmToken> class includes properties such as <SwmToken path="src/In.ProjectEKA.HipService/Patient/Model/OpenMrsPatient.cs" pos="8:7:7" line-data="        public OpenMrsPatient(Person person, List&lt;object&gt; identifiers)">`person`</SwmToken> and <SwmToken path="src/In.ProjectEKA.HipService/Patient/Model/OpenMrsPatient.cs" pos="8:15:15" line-data="        public OpenMrsPatient(Person person, List&lt;object&gt; identifiers)">`identifiers`</SwmToken>, which store information about the patient and their identifiers respectively. This class is crucial for linking patient data with the OpenMRS system.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Patient/Model/OpenMrsPatient.cs" line="1">

---

The <SwmToken path="src/In.ProjectEKA.HipService/Patient/Model/OpenMrsPatient.cs" pos="6:5:5" line-data="    public class OpenMrsPatient">`OpenMrsPatient`</SwmToken> class defines the structure for patient information and identifiers.

```c#
using System;
using System.Collections.Generic;

namespace In.ProjectEKA.HipService.Patient.Model
{
    public class OpenMrsPatient
    {
        public OpenMrsPatient(Person person, List<object> identifiers)
        {
            this.person = person;
```

---

</SwmSnippet>

## <SwmToken path="src/In.ProjectEKA.HipService/Patient/Model/PatientProfileRequest.cs" pos="5:5:5" line-data="    public class PatientProfileRequest">`PatientProfileRequest`</SwmToken> Class

The <SwmToken path="src/In.ProjectEKA.HipService/Patient/Model/PatientProfileRequest.cs" pos="5:5:5" line-data="    public class PatientProfileRequest">`PatientProfileRequest`</SwmToken> class has a property called <SwmToken path="src/In.ProjectEKA.HipService/Patient/Model/PatientProfileRequest.cs" pos="7:7:7" line-data="        public PatientProfileRequest(OpenMrsPatient patient, List&lt;object&gt; relationships)">`patient`</SwmToken>, which is an instance of the <SwmToken path="src/In.ProjectEKA.HipService/Patient/Model/OpenMrsPatient.cs" pos="6:5:5" line-data="    public class OpenMrsPatient">`OpenMrsPatient`</SwmToken> class. It also includes a list of relationships, which helps in managing patient connections and interactions.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Patient/Model/PatientProfileRequest.cs" line="1">

---

The <SwmToken path="src/In.ProjectEKA.HipService/Patient/Model/PatientProfileRequest.cs" pos="5:5:5" line-data="    public class PatientProfileRequest">`PatientProfileRequest`</SwmToken> class includes patient information and relationships.

```c#
using System.Collections.Generic;

namespace In.ProjectEKA.HipService.Patient.Model
{
    public class PatientProfileRequest
    {
        public PatientProfileRequest(OpenMrsPatient patient, List<object> relationships)
        {
            this.patient = patient;
            this.relationships = relationships;
```

---

</SwmSnippet>

## <SwmToken path="src/In.ProjectEKA.HipService/Patient/Model/PatientAddress.cs" pos="3:5:5" line-data="    public class PatientAddress">`PatientAddress`</SwmToken> Class

The <SwmToken path="src/In.ProjectEKA.HipService/Patient/Model/PatientAddress.cs" pos="3:5:5" line-data="    public class PatientAddress">`PatientAddress`</SwmToken> class includes properties like <SwmToken path="src/In.ProjectEKA.HipService/Patient/Model/PatientAddress.cs" pos="5:7:7" line-data="        public PatientAddress(string address1, string countyDistrict, string stateProvince)">`address1`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/Patient/Model/PatientAddress.cs" pos="5:12:12" line-data="        public PatientAddress(string address1, string countyDistrict, string stateProvince)">`countyDistrict`</SwmToken>, and <SwmToken path="src/In.ProjectEKA.HipService/Patient/Model/PatientAddress.cs" pos="5:17:17" line-data="        public PatientAddress(string address1, string countyDistrict, string stateProvince)">`stateProvince`</SwmToken>, which store the address details of a patient. This class is used to manage and store patient address information.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Patient/Model/PatientAddress.cs" line="1">

---

The <SwmToken path="src/In.ProjectEKA.HipService/Patient/Model/PatientAddress.cs" pos="3:5:5" line-data="    public class PatientAddress">`PatientAddress`</SwmToken> class defines the structure for storing patient address details.

```c#
namespace In.ProjectEKA.HipService.Patient.Model
{
    public class PatientAddress
    {
        public PatientAddress(string address1, string countyDistrict, string stateProvince)
        {
            this.address1 = address1;
            this.countyDistrict = countyDistrict;
            this.stateProvince = stateProvince;
        }
```

---

</SwmSnippet>

## <SwmToken path="src/In.ProjectEKA.HipService/Patient/Model/PatientName.cs" pos="3:5:5" line-data="    public class PatientName">`PatientName`</SwmToken> Class

The <SwmToken path="src/In.ProjectEKA.HipService/Patient/Model/PatientName.cs" pos="3:5:5" line-data="    public class PatientName">`PatientName`</SwmToken> class contains properties such as <SwmToken path="src/In.ProjectEKA.HipService/Patient/Model/PatientName.cs" pos="5:7:7" line-data="        public PatientName(string givenName,string middleName, string familyName)">`givenName`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/Patient/Model/PatientName.cs" pos="5:11:11" line-data="        public PatientName(string givenName,string middleName, string familyName)">`middleName`</SwmToken>, and <SwmToken path="src/In.ProjectEKA.HipService/Patient/Model/PatientName.cs" pos="5:16:16" line-data="        public PatientName(string givenName,string middleName, string familyName)">`familyName`</SwmToken>, which store the different parts of a patient's name. This class is essential for managing patient name information.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Patient/Model/PatientName.cs" line="1">

---

The <SwmToken path="src/In.ProjectEKA.HipService/Patient/Model/PatientName.cs" pos="3:5:5" line-data="    public class PatientName">`PatientName`</SwmToken> class defines the structure for storing patient name details.

```c#
namespace In.ProjectEKA.HipService.Patient.Model
{
    public class PatientName
    {
        public PatientName(string givenName,string middleName, string familyName)
        {
            this.givenName = givenName;
            this.familyName = familyName;
            this.middleName = middleName;
        }
```

---

</SwmSnippet>

## <SwmToken path="src/In.ProjectEKA.HipService/Patient/Model/PatientAttribute.cs" pos="3:5:5" line-data="    public class PatientAttribute">`PatientAttribute`</SwmToken> Class

The <SwmToken path="src/In.ProjectEKA.HipService/Patient/Model/PatientAttribute.cs" pos="3:5:5" line-data="    public class PatientAttribute">`PatientAttribute`</SwmToken> class represents additional attributes of a patient, with properties like <SwmToken path="src/In.ProjectEKA.HipService/Patient/Model/PatientAttribute.cs" pos="5:7:7" line-data="        public PatientAttribute(AttributeType attributeType, string value)">`attributeType`</SwmToken> and <SwmToken path="src/In.ProjectEKA.HipService/Patient/Model/PatientAttribute.cs" pos="5:12:12" line-data="        public PatientAttribute(AttributeType attributeType, string value)">`value`</SwmToken>. This class is used to store extra information about a patient that does not fit into other categories.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Patient/Model/PatientAttribute.cs" line="1">

---

The <SwmToken path="src/In.ProjectEKA.HipService/Patient/Model/PatientAttribute.cs" pos="3:5:5" line-data="    public class PatientAttribute">`PatientAttribute`</SwmToken> class defines the structure for storing additional patient attributes.

```c#
namespace In.ProjectEKA.HipService.Patient.Model
{
    public class PatientAttribute
    {
        public PatientAttribute(AttributeType attributeType, string value)
        {
            this.attributeType = attributeType;
            this.value = value;
        }
        public AttributeType attributeType { get; }
```

---

</SwmSnippet>

## Person Class

The <SwmToken path="src/In.ProjectEKA.HipService/Patient/Model/OpenMrsPatient.cs" pos="8:5:5" line-data="        public OpenMrsPatient(Person person, List&lt;object&gt; identifiers)">`Person`</SwmToken> class uses <SwmToken path="src/In.ProjectEKA.HipService/Patient/Model/PatientAttribute.cs" pos="3:5:5" line-data="    public class PatientAttribute">`PatientAttribute`</SwmToken> to store a list of attributes, along with other properties like <SwmToken path="src/In.ProjectEKA.HipService/Patient/Model/Person.cs" pos="8:10:10" line-data="        public Person(List&lt;PatientName&gt; names, List&lt;PatientAddress&gt; addresses, DateTime birthdate, string gender, List&lt;PatientAttribute&gt; attributes)">`names`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/Patient/Model/Person.cs" pos="8:18:18" line-data="        public Person(List&lt;PatientName&gt; names, List&lt;PatientAddress&gt; addresses, DateTime birthdate, string gender, List&lt;PatientAttribute&gt; attributes)">`addresses`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/Patient/Model/Person.cs" pos="8:23:23" line-data="        public Person(List&lt;PatientName&gt; names, List&lt;PatientAddress&gt; addresses, DateTime birthdate, string gender, List&lt;PatientAttribute&gt; attributes)">`birthdate`</SwmToken>, and <SwmToken path="src/In.ProjectEKA.HipService/Patient/Model/Person.cs" pos="8:28:28" line-data="        public Person(List&lt;PatientName&gt; names, List&lt;PatientAddress&gt; addresses, DateTime birthdate, string gender, List&lt;PatientAttribute&gt; attributes)">`gender`</SwmToken>. This class is a comprehensive representation of a person in the system.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Patient/Model/Person.cs" line="1">

---

The <SwmToken path="src/In.ProjectEKA.HipService/Patient/Model/Person.cs" pos="6:5:5" line-data="    public class Person">`Person`</SwmToken> class defines the structure for storing comprehensive person details, including attributes, names, addresses, birthdate, and gender.

```c#
using System;
using System.Collections.Generic;

namespace In.ProjectEKA.HipService.Patient.Model
{
    public class Person
    {
        public Person(List<PatientName> names, List<PatientAddress> addresses, DateTime birthdate, string gender, List<PatientAttribute> attributes)
        {
            this.names = names;
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
