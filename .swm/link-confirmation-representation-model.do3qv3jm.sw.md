---
title: Link Confirmation Representation Model
---
# Understanding Link Confirmation Representation Model

The <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatient.cs" pos="168:3:3" line-data="                        new LinkConfirmationRepresentation(">`LinkConfirmationRepresentation`</SwmToken> class is a model that encapsulates the details required for confirming a link between a patient's health information and a consent manager.

This class contains properties such as <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatient.cs" pos="72:10:10" line-data="                    .Select(context =&gt; context.ReferenceNumber)">`ReferenceNumber`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatient.cs" pos="121:2:2" line-data="                                    .Display)).ToList();">`Display`</SwmToken>, and <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatient.cs" pos="71:11:11" line-data="                var careContextReferenceNumbers = request.Patient.CareContexts">`CareContexts`</SwmToken>, which store the reference number of the link, a display string, and a collection of care contexts respectively.

The <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatient.cs" pos="168:3:3" line-data="                        new LinkConfirmationRepresentation(">`LinkConfirmationRepresentation`</SwmToken> class is used in various parts of the codebase to ensure that the necessary information for link confirmation is passed and stored in a structured manner.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/LinkPatient.cs" line="132">

---

For instance, it is utilized in the <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatient.cs" pos="132:11:11" line-data="        public virtual async Task&lt;ValueTuple&lt;PatientLinkConfirmationRepresentation, string, ErrorRepresentation&gt;&gt;">`PatientLinkConfirmationRepresentation`</SwmToken> class to represent the confirmation details of a patient's link.

```c#
        public virtual async Task<ValueTuple<PatientLinkConfirmationRepresentation, string, ErrorRepresentation>>
```

---

</SwmSnippet>

## Usage Example

The <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatient.cs" pos="168:3:3" line-data="                        new LinkConfirmationRepresentation(">`LinkConfirmationRepresentation`</SwmToken> class is used in various parts of the codebase to ensure that the necessary information for link confirmation is passed and stored in a structured manner.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/LinkPatient.cs" line="132">

---

For instance, it is utilized in the <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatient.cs" pos="132:11:11" line-data="        public virtual async Task&lt;ValueTuple&lt;PatientLinkConfirmationRepresentation, string, ErrorRepresentation&gt;&gt;">`PatientLinkConfirmationRepresentation`</SwmToken> class to represent the confirmation details of a patient's link.

```c#
        public virtual async Task<ValueTuple<PatientLinkConfirmationRepresentation, string, ErrorRepresentation>>
```

---

</SwmSnippet>

## Main Functions

The main functions of the <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatient.cs" pos="168:3:3" line-data="                        new LinkConfirmationRepresentation(">`LinkConfirmationRepresentation`</SwmToken> class include verifying and linking a patient's care context.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/LinkPatient.cs" line="132">

---

The <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatient.cs" pos="133:1:1" line-data="            VerifyAndLinkCareContext(">`VerifyAndLinkCareContext`</SwmToken> function is used to verify and link a patient's care context. It returns a tuple containing <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatient.cs" pos="132:11:11" line-data="        public virtual async Task&lt;ValueTuple&lt;PatientLinkConfirmationRepresentation, string, ErrorRepresentation&gt;&gt;">`PatientLinkConfirmationRepresentation`</SwmToken>, a string, and <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatient.cs" pos="132:17:17" line-data="        public virtual async Task&lt;ValueTuple&lt;PatientLinkConfirmationRepresentation, string, ErrorRepresentation&gt;&gt;">`ErrorRepresentation`</SwmToken>.

```c#
        public virtual async Task<ValueTuple<PatientLinkConfirmationRepresentation, string, ErrorRepresentation>>
```

---

</SwmSnippet>

## Link Confirmation Representation Endpoints

The <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatient.cs" pos="168:3:3" line-data="                        new LinkConfirmationRepresentation(">`LinkConfirmationRepresentation`</SwmToken> class is a model that encapsulates the details required for confirming a link between a patient's health information and a consent manager.

It contains properties such as <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatient.cs" pos="72:10:10" line-data="                    .Select(context =&gt; context.ReferenceNumber)">`ReferenceNumber`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatient.cs" pos="121:2:2" line-data="                                    .Display)).ToList();">`Display`</SwmToken>, and <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatient.cs" pos="71:11:11" line-data="                var careContextReferenceNumbers = request.Patient.CareContexts">`CareContexts`</SwmToken>, which store the reference number of the link, a display string, and a collection of care contexts respectively. This class is used in various parts of the codebase to ensure that the necessary information for link confirmation is passed and stored in a structured manner.

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
