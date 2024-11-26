---
title: Exploring Patient Repository Interface
---
# Exploring Patient Repository Interface

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/IPatientRepository.cs" pos="10:5:5" line-data="    public interface IPatientRepository">`IPatientRepository`</SwmToken> interface defines the contract for accessing patient data within the system.

## Methods Overview

It includes methods for retrieving patient information based on different criteria, ensuring efficient and accurate data retrieval.

### <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/IPatientRepository.cs" pos="12:8:8" line-data="        Task&lt;Option&lt;Patient&gt;&gt; PatientWithAsync(string patientIdentifier);">`PatientWithAsync`</SwmToken>

The methods in the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/IPatientRepository.cs" pos="10:5:5" line-data="    public interface IPatientRepository">`IPatientRepository`</SwmToken> interface are essential for retrieving patient information efficiently and accurately.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/IPatientRepository.cs" line="10">

---

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/IPatientRepository.cs" pos="12:8:8" line-data="        Task&lt;Option&lt;Patient&gt;&gt; PatientWithAsync(string patientIdentifier);">`PatientWithAsync`</SwmToken> method retrieves patient information based on a patient identifier.

```c#
    public interface IPatientRepository
    {
        Task<Option<Patient>> PatientWithAsync(string patientIdentifier);
```

---

</SwmSnippet>

### <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/IPatientRepository.cs" pos="14:8:8" line-data="        Task&lt;IQueryable&lt;Patient&gt;&gt; PatientsWithVerifiedId(string healthId);">`PatientsWithVerifiedId`</SwmToken>

This method is crucial for fetching detailed patient data efficiently and accurately.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/IPatientRepository.cs" line="14">

---

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/IPatientRepository.cs" pos="14:8:8" line-data="        Task&lt;IQueryable&lt;Patient&gt;&gt; PatientsWithVerifiedId(string healthId);">`PatientsWithVerifiedId`</SwmToken> method retrieves patients based on a verified health ID.

```c#
        Task<IQueryable<Patient>> PatientsWithVerifiedId(string healthId);
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
