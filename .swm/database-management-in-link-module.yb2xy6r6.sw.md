---
title: Database Management in Link Module
---
# DbSet Properties

# Database Management

The database in the Link module is managed through the `LinkPatientContext` class, which extends the `DbContext` class from Entity Framework Core.

# Querying and Saving Data

This context class includes several `DbSet` properties that represent collections of different entities, such as `LinkEnquires`, `LinkedAccounts`, `CareContextMap`, and <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/Migrations/20200419184602_IntiatedLinkRequest.cs" pos="10:2:2" line-data="                &quot;InitiatedLinkRequest&quot;,">`InitiatedLinkRequest`</SwmToken>.

# Model Configuration

These `DbSet` properties allow for querying and saving instances of these entities to the database.

# Migrations

The `OnModelCreating` method in the `LinkPatientContext` class is overridden to configure the model using the `ModelBuilder`. This method sets up the relationships between the entities and configures various properties, such as default values and constraints.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/Database/Migrations/20200419184602_IntiatedLinkRequest.cs" line="1">

---

Migrations are used to manage changes to the database schema over time. For example, the <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/Migrations/20200419184602_IntiatedLinkRequest.cs" pos="5:7:7" line-data="    public partial class IntiatedLinkRequest : Migration">`IntiatedLinkRequest`</SwmToken> and `LinkRequestMigrations` classes represent different migration steps.

```c#
﻿namespace In.ProjectEKA.HipService.Link.Database.Migrations
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
