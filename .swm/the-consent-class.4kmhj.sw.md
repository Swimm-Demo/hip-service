---
title: The Consent class
---
This document will cover the class <SwmToken path="src/In.ProjectEKA.HipService/Consent/Model/Consent.cs" pos="9:3:3" line-data="        public Consent(string consentArtefactId,">`Consent`</SwmToken> in the <SwmPath>[src/In.ProjectEKA.HipService/Consent/Model/Consent.cs](src/In.ProjectEKA.HipService/Consent/Model/Consent.cs)</SwmPath> file. We will cover:

1. What is Consent
2. Variables and functions

# Variables and functions

# What is Consent

The <SwmToken path="src/In.ProjectEKA.HipService/Consent/Model/Consent.cs" pos="9:3:3" line-data="        public Consent(string consentArtefactId,">`Consent`</SwmToken> class in <SwmPath>[src/In.ProjectEKA.HipService/Consent/Model/Consent.cs](src/In.ProjectEKA.HipService/Consent/Model/Consent.cs)</SwmPath> represents a consent artifact in the HIP service. It is used to manage and store information about a patient's consent for accessing and sharing their health information. This class is essential for handling consent-related operations within the application.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Consent/Model/Consent.cs" line="9">

---

The <SwmToken path="src/In.ProjectEKA.HipService/Consent/Model/Consent.cs" pos="9:3:3" line-data="        public Consent(string consentArtefactId,">`Consent`</SwmToken> constructor initializes a new instance of the <SwmToken path="src/In.ProjectEKA.HipService/Consent/Model/Consent.cs" pos="9:3:3" line-data="        public Consent(string consentArtefactId,">`Consent`</SwmToken> class with the provided parameters: <SwmToken path="src/In.ProjectEKA.HipService/Consent/Model/Consent.cs" pos="9:7:7" line-data="        public Consent(string consentArtefactId,">`consentArtefactId`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/Consent/Model/Consent.cs" pos="10:3:3" line-data="            ConsentArtefact consentArtefact,">`consentArtefact`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/Consent/Model/Consent.cs" pos="11:3:3" line-data="            string signature,">`signature`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/Consent/Model/Consent.cs" pos="12:3:3" line-data="            ConsentStatus status,">`status`</SwmToken>, and <SwmToken path="src/In.ProjectEKA.HipService/Consent/Model/Consent.cs" pos="13:3:3" line-data="            string consentManagerId)">`consentManagerId`</SwmToken>.

```c#
        public Consent(string consentArtefactId,
            ConsentArtefact consentArtefact,
            string signature,
            ConsentStatus status,
            string consentManagerId)
        {
            ConsentArtefactId = consentArtefactId;
            ConsentArtefact = consentArtefact;
            Signature = signature;
            Status = status;
            ConsentManagerId = consentManagerId;
        }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Consent/Model/Consent.cs" line="22">

---

The variable <SwmToken path="src/In.ProjectEKA.HipService/Consent/Model/Consent.cs" pos="24:5:5" line-data="        public int Id { get; set; }">`Id`</SwmToken> is an integer that serves as the primary key for the <SwmToken path="src/In.ProjectEKA.HipService/Consent/Model/Consent.cs" pos="9:3:3" line-data="        public Consent(string consentArtefactId,">`Consent`</SwmToken> entity. It is decorated with the <SwmToken path="src/In.ProjectEKA.HipService/Consent/Model/Consent.cs" pos="22:1:8" line-data="        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]">`[DatabaseGenerated(DatabaseGeneratedOption.Identity)]`</SwmToken> and <SwmToken path="src/In.ProjectEKA.HipService/Consent/Model/Consent.cs" pos="23:1:3" line-data="        [Key]">`[Key]`</SwmToken> attributes to indicate that it is an identity column and the primary key.

```c#
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Consent/Model/Consent.cs" line="26">

---

The variable <SwmToken path="src/In.ProjectEKA.HipService/Consent/Model/Consent.cs" pos="26:5:5" line-data="        public string ConsentArtefactId { get; set; }">`ConsentArtefactId`</SwmToken> is a string that stores the unique identifier of the consent artifact.

```c#
        public string ConsentArtefactId { get; set; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Consent/Model/Consent.cs" line="28">

---

The variable <SwmToken path="src/In.ProjectEKA.HipService/Consent/Model/Consent.cs" pos="28:3:3" line-data="        public ConsentArtefact ConsentArtefact { get; set; }">`ConsentArtefact`</SwmToken> is an instance of the <SwmToken path="src/In.ProjectEKA.HipService/Consent/Model/Consent.cs" pos="28:3:3" line-data="        public ConsentArtefact ConsentArtefact { get; set; }">`ConsentArtefact`</SwmToken> class that represents the consent artifact associated with this consent.

```c#
        public ConsentArtefact ConsentArtefact { get; set; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Consent/Model/Consent.cs" line="30">

---

The variable <SwmToken path="src/In.ProjectEKA.HipService/Consent/Model/Consent.cs" pos="30:5:5" line-data="        public string Signature { get; set; }">`Signature`</SwmToken> is a string that stores the digital signature of the consent artifact.

```c#
        public string Signature { get; set; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Consent/Model/Consent.cs" line="32">

---

The variable <SwmToken path="src/In.ProjectEKA.HipService/Consent/Model/Consent.cs" pos="32:5:5" line-data="        public ConsentStatus Status { get; set; }">`Status`</SwmToken> is an instance of the <SwmToken path="src/In.ProjectEKA.HipService/Consent/Model/Consent.cs" pos="32:3:3" line-data="        public ConsentStatus Status { get; set; }">`ConsentStatus`</SwmToken> enum that indicates the current status of the consent.

```c#
        public ConsentStatus Status { get; set; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Consent/Model/Consent.cs" line="34">

---

The variable <SwmToken path="src/In.ProjectEKA.HipService/Consent/Model/Consent.cs" pos="34:5:5" line-data="        public string ConsentManagerId { get; set; }">`ConsentManagerId`</SwmToken> is a string that stores the identifier of the consent manager responsible for managing this consent.

```c#
        public string ConsentManagerId { get; set; }
```

---

</SwmSnippet>

# Usage

<SwmSnippet path="/src/In.ProjectEKA.HipService/Consent/ConsentArtefactRequest.cs" line="1">

---

## <SwmToken path="src/In.ProjectEKA.HipService/Consent/ConsentArtefactRequest.cs" pos="5:5:5" line-data="    public class ConsentArtefactRequest">`ConsentArtefactRequest`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipService/Consent/ConsentArtefactRequest.cs" pos="1:8:8" line-data="namespace In.ProjectEKA.HipService.Consent">`Consent`</SwmToken> class is used in the <SwmToken path="src/In.ProjectEKA.HipService/Consent/ConsentArtefactRequest.cs" pos="5:5:5" line-data="    public class ConsentArtefactRequest">`ConsentArtefactRequest`</SwmToken> file, which is likely responsible for handling requests related to consent artefacts.

```c#
namespace In.ProjectEKA.HipService.Consent
{
    using Common.Model;
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Consent/ConsentArtefactRepresentation.cs" line="1">

---

## <SwmToken path="src/In.ProjectEKA.HipService/Consent/ConsentArtefactRepresentation.cs" pos="6:5:5" line-data="    public class ConsentArtefactRepresentation">`ConsentArtefactRepresentation`</SwmToken>

In the <SwmToken path="src/In.ProjectEKA.HipService/Consent/ConsentArtefactRepresentation.cs" pos="6:5:5" line-data="    public class ConsentArtefactRepresentation">`ConsentArtefactRepresentation`</SwmToken> file, the <SwmToken path="src/In.ProjectEKA.HipService/Consent/ConsentArtefactRepresentation.cs" pos="1:8:8" line-data="namespace In.ProjectEKA.HipService.Consent">`Consent`</SwmToken> class is utilized, indicating its role in representing consent artefacts.

```c#
namespace In.ProjectEKA.HipService.Consent
{
    using System;
    using Model;
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Consent/Database/Migrations/20200403080416_addConsentManagerIdenitifier.cs" line="1">

---

## Database Migrations

The <SwmToken path="src/In.ProjectEKA.HipService/Consent/Database/Migrations/20200403080416_addConsentManagerIdenitifier.cs" pos="1:9:9" line-data="﻿namespace In.ProjectEKA.HipService.Consent.Database.Migrations">`Consent`</SwmToken> class is also used in various database migration files, such as `20200403080416_addConsentManagerIdenitifier` and `20200212205522_AddConsentArtefactTable`. These migrations likely involve creating or modifying database tables related to consent artefacts.

```c#
﻿namespace In.ProjectEKA.HipService.Consent.Database.Migrations
{
    using Microsoft.EntityFrameworkCore.Migrations;
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Consent/Database/ConsentContext.cs" line="16">

---

## <SwmToken path="src/In.ProjectEKA.HipService/Consent/Database/ConsentContext.cs" pos="10:5:5" line-data="    public class ConsentContext : DbContext">`ConsentContext`</SwmToken>

In the <SwmToken path="src/In.ProjectEKA.HipService/Consent/Database/ConsentContext.cs" pos="10:5:5" line-data="    public class ConsentContext : DbContext">`ConsentContext`</SwmToken> file, the <SwmToken path="src/In.ProjectEKA.HipService/Consent/Database/ConsentContext.cs" pos="16:5:5" line-data="        public DbSet&lt;Consent&gt; ConsentArtefact { get; set; }">`Consent`</SwmToken> class is used to define the <SwmToken path="src/In.ProjectEKA.HipService/Consent/Database/ConsentContext.cs" pos="16:8:8" line-data="        public DbSet&lt;Consent&gt; ConsentArtefact { get; set; }">`ConsentArtefact`</SwmToken> <SwmToken path="src/In.ProjectEKA.HipService/Consent/Database/ConsentContext.cs" pos="16:3:3" line-data="        public DbSet&lt;Consent&gt; ConsentArtefact { get; set; }">`DbSet`</SwmToken> and configure its properties and relationships within the database context.

```c#
        public DbSet<Consent> ConsentArtefact { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Consent>().HasIndex(p => p.ConsentArtefactId).IsUnique();
            modelBuilder.Entity<Consent>().Property(p => p.Status)
                .HasConversion(status => status.ToString(),
                    x => (ConsentStatus) Enum.Parse(typeof(ConsentStatus), x));
            modelBuilder.ApplyConfiguration(new ConsentArtefactConfiguration());
        }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Consent/IConsentRepository.cs" line="7">

---

## <SwmToken path="src/In.ProjectEKA.HipService/Consent/IConsentRepository.cs" pos="7:5:5" line-data="    public interface IConsentRepository">`IConsentRepository`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipService/Consent/IConsentRepository.cs" pos="7:5:5" line-data="    public interface IConsentRepository">`IConsentRepository`</SwmToken> interface defines methods for adding, updating, retrieving, and deleting consent artefacts, utilizing the <SwmToken path="src/In.ProjectEKA.HipService/Consent/IConsentRepository.cs" pos="9:7:7" line-data="        public Task AddAsync(Consent consent);">`Consent`</SwmToken> class.

```c#
    public interface IConsentRepository
    {
        public Task AddAsync(Consent consent);

        public Task UpdateAsync(string consentArtefactId, ConsentStatus status);

        public Task<Consent> GetFor(string consentArtefactId);
        Task DeleteConsentArtefact(string healthId);
    }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Consent/ConsentRepository.cs" line="20">

---

## <SwmToken path="src/In.ProjectEKA.HipService/Consent/ConsentRepository.cs" pos="11:5:5" line-data="    public class ConsentRepository : IConsentRepository">`ConsentRepository`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipService/Consent/ConsentRepository.cs" pos="11:5:5" line-data="    public class ConsentRepository : IConsentRepository">`ConsentRepository`</SwmToken> class implements the <SwmToken path="src/In.ProjectEKA.HipService/Consent/IConsentRepository.cs" pos="7:5:5" line-data="    public interface IConsentRepository">`IConsentRepository`</SwmToken> interface, providing concrete implementations for managing <SwmToken path="src/In.ProjectEKA.HipService/Consent/ConsentRepository.cs" pos="20:9:9" line-data="        public async Task AddAsync(Consent consent)">`Consent`</SwmToken> artefacts in the database.

```c#
        public async Task AddAsync(Consent consent)
        {
            await consentContext.ConsentArtefact.AddAsync(consent);
            await consentContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(string consentArtefactId, ConsentStatus status)
        {
            var consentArtefact = await consentContext.ConsentArtefact
                .FirstOrDefaultAsync(c => c.ConsentArtefactId == consentArtefactId);
            consentArtefact.Status = status;
            await consentContext.SaveChangesAsync();
        }

        public async Task<Consent> GetFor(string consentArtefactId)
        {
            return await consentContext.ConsentArtefact
                .FirstOrDefaultAsync(x => x.ConsentArtefactId == consentArtefactId);
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Consent/ConsentNotificationController.cs" line="49">

---

## <SwmToken path="src/In.ProjectEKA.HipService/Consent/ConsentNotificationController.cs" pos="19:5:5" line-data="    public class ConsentNotificationController : ControllerBase">`ConsentNotificationController`</SwmToken>

In the <SwmToken path="src/In.ProjectEKA.HipService/Consent/ConsentNotificationController.cs" pos="19:5:5" line-data="    public class ConsentNotificationController : ControllerBase">`ConsentNotificationController`</SwmToken> file, the <SwmToken path="src/In.ProjectEKA.HipService/Consent/ConsentNotificationController.cs" pos="51:9:9" line-data="                var consent = new Consent(notification.ConsentDetail.ConsentId,">`Consent`</SwmToken> class is used to handle notifications related to consent status changes.

```c#
            if (notification.Status == ConsentStatus.GRANTED)
            {
                var consent = new Consent(notification.ConsentDetail.ConsentId,
                    notification.ConsentDetail,
                    notification.Signature,
                    notification.Status,
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
