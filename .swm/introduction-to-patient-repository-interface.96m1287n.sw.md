---
title: Introduction to Patient Repository Interface
---
## Methods in <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/IPatientRepository.cs" pos="10:5:5" line-data="    public interface IPatientRepository">`IPatientRepository`</SwmToken>

# Introduction to Patient Repository Interface

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/IPatientRepository.cs" pos="10:5:5" line-data="    public interface IPatientRepository">`IPatientRepository`</SwmToken> interface defines methods for accessing patient data. It serves as a contract for implementing classes to ensure consistent data retrieval operations related to patients.

### <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/IPatientRepository.cs" pos="12:8:8" line-data="        Task&lt;Option&lt;Patient&gt;&gt; PatientWithAsync(string patientIdentifier);">`PatientWithAsync`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/IPatientRepository.cs" pos="10:5:5" line-data="    public interface IPatientRepository">`IPatientRepository`</SwmToken> interface includes several methods to facilitate patient data access. Two primary methods are <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/IPatientRepository.cs" pos="12:8:8" line-data="        Task&lt;Option&lt;Patient&gt;&gt; PatientWithAsync(string patientIdentifier);">`PatientWithAsync`</SwmToken> and <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/IPatientRepository.cs" pos="14:8:8" line-data="        Task&lt;IQueryable&lt;Patient&gt;&gt; PatientsWithVerifiedId(string healthId);">`PatientsWithVerifiedId`</SwmToken>.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/IPatientRepository.cs" line="10">

---

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/IPatientRepository.cs" pos="12:8:8" line-data="        Task&lt;Option&lt;Patient&gt;&gt; PatientWithAsync(string patientIdentifier);">`PatientWithAsync`</SwmToken> method retrieves a patient based on a given patient identifier. This method is essential for fetching individual patient details asynchronously.

```c#
    public interface IPatientRepository
    {
        Task<Option<Patient>> PatientWithAsync(string patientIdentifier);

```

---

</SwmSnippet>

### <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/IPatientRepository.cs" pos="14:8:8" line-data="        Task&lt;IQueryable&lt;Patient&gt;&gt; PatientsWithVerifiedId(string healthId);">`PatientsWithVerifiedId`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/IPatientRepository.cs" pos="14:8:8" line-data="        Task&lt;IQueryable&lt;Patient&gt;&gt; PatientsWithVerifiedId(string healthId);">`PatientsWithVerifiedId`</SwmToken> method fetches patients who have a verified health ID. This method is crucial for obtaining a list of patients with verified identities.

## Example of <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/IPatientRepository.cs" pos="10:5:5" line-data="    public interface IPatientRepository">`IPatientRepository`</SwmToken> Usage

## Usage of <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/IPatientRepository.cs" pos="10:5:5" line-data="    public interface IPatientRepository">`IPatientRepository`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/IPatientRepository.cs" pos="10:5:5" line-data="    public interface IPatientRepository">`IPatientRepository`</SwmToken> interface is implemented in various parts of the codebase to ensure consistent access to patient data. For example, it is used in the file <SwmPath>[src/In.ProjectEKA.HipLibrary/Patient/IPatientRepository.cs](src/In.ProjectEKA.HipLibrary/Patient/IPatientRepository.cs)</SwmPath>.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/IPatientRepository.cs" line="12">

---

Here is an example of how the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/IPatientRepository.cs" pos="10:5:5" line-data="    public interface IPatientRepository">`IPatientRepository`</SwmToken> interface is used to retrieve patient information. The method <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/IPatientRepository.cs" pos="12:8:8" line-data="        Task&lt;Option&lt;Patient&gt;&gt; PatientWithAsync(string patientIdentifier);">`PatientWithAsync`</SwmToken> is called with a patient identifier to fetch the corresponding patient details.

```c#
        Task<Option<Patient>> PatientWithAsync(string patientIdentifier);

```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
