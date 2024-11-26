---
title: Overview of Consent Management
---
# What is Consent Management

Consent management refers to the process of managing patient permissions for accessing and sharing their health information.

# How Consent is Used

It involves creating, storing, and handling consent artifacts, which are digital records of the patient's consent.

Consent is managed through creating, storing, and handling consent artifacts. These artifacts are digital records that capture the patient's consent for accessing and sharing their health information.

Consent is used in various parts of the application, such as the <SwmToken path="src/In.ProjectEKA.HipService/Consent/ConsentRepository.cs" pos="11:5:5" line-data="    public class ConsentRepository : IConsentRepository">`ConsentRepository`</SwmToken>, `ConsentController`, and `ConsentNotificationController`.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Consent/ConsentRepository.cs" line="20">

---

The <SwmToken path="src/In.ProjectEKA.HipService/Consent/ConsentRepository.cs" pos="13:5:5" line-data="        private readonly ConsentContext consentContext;">`ConsentContext`</SwmToken> class is part of the database layer in the Consent module and is responsible for managing database operations related to consent artifacts.

```c#
        public async Task AddAsync(Consent consent)
        {
            await consentContext.ConsentArtefact.AddAsync(consent);
            await consentContext.SaveChangesAsync();
        }
```

---

</SwmSnippet>

# Consent APIs

# Example of Consent Usage

The <SwmToken path="src/In.ProjectEKA.HipService/Consent/ConsentRepository.cs" pos="13:5:5" line-data="        private readonly ConsentContext consentContext;">`ConsentContext`</SwmToken> class is used in the <SwmToken path="src/In.ProjectEKA.HipService/Consent/ConsentRepository.cs" pos="11:5:5" line-data="    public class ConsentRepository : IConsentRepository">`ConsentRepository`</SwmToken> class to perform database operations related to consent artifacts.

The Consent APIs provide endpoints for managing consent artifacts.

For example, the `getDocument` function is used to get a document by its ID.

Similarly, the `getPlaylist` function is used to get a playlist by its ID.

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
