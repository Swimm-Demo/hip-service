---
title: Database Management in Consent Module
---
# Database Management in Consent Module

The database in the Consent module is managed through the `ConsentContext` class, which extends `DbContext`.

# Configuring the Database Schema

This class is responsible for configuring the database schema and managing the <SwmToken path="src/In.ProjectEKA.HipService/Consent/Database/Migrations/20200212205522_AddConsentArtefactTable.cs" pos="1:9:9" line-data="﻿namespace In.ProjectEKA.HipService.Consent.Database.Migrations">`Consent`</SwmToken> entities.

The `ConsentContext` class includes a `DbSet<`<SwmToken path="src/In.ProjectEKA.HipService/Consent/Database/Migrations/20200212205522_AddConsentArtefactTable.cs" pos="1:9:9" line-data="﻿namespace In.ProjectEKA.HipService.Consent.Database.Migrations">`Consent`</SwmToken>`>` property named <SwmToken path="src/In.ProjectEKA.HipService/Consent/Database/Migrations/20200212205522_AddConsentArtefactTable.cs" pos="11:2:2" line-data="                &quot;ConsentArtefact&quot;,">`ConsentArtefact`</SwmToken>, which represents the collection of <SwmToken path="src/In.ProjectEKA.HipService/Consent/Database/Migrations/20200212205522_AddConsentArtefactTable.cs" pos="1:9:9" line-data="﻿namespace In.ProjectEKA.HipService.Consent.Database.Migrations">`Consent`</SwmToken> entities in the database.

# Managing Database Changes

The `OnModelCreating` method in `ConsentContext` configures the entity properties and relationships, such as setting up a unique index on the <SwmToken path="src/In.ProjectEKA.HipService/Consent/Database/Migrations/20200212205522_AddConsentArtefactTable.cs" pos="17:1:1" line-data="                    ConsentArtefactId = table.Column&lt;string&gt;(nullable: true),">`ConsentArtefactId`</SwmToken> property and converting the <SwmToken path="src/In.ProjectEKA.HipService/Consent/Database/Migrations/20200212205522_AddConsentArtefactTable.cs" pos="20:1:1" line-data="                    Status = table.Column&lt;string&gt;()">`Status`</SwmToken> property to and from a string representation.

Migrations are used to manage changes to the database schema over time. Classes like <SwmToken path="src/In.ProjectEKA.HipService/Consent/Database/Migrations/20200212205522_AddConsentArtefactTable.cs" pos="6:7:7" line-data="    public partial class AddConsentArtefactTable : Migration">`AddConsentArtefactTable`</SwmToken> and `addConsentManagerIdenitifier` define specific schema changes, ensuring that the database structure evolves as needed.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Consent/Database/Migrations/20200212205522_AddConsentArtefactTable.cs" line="1">

---

For example, the migration class <SwmToken path="src/In.ProjectEKA.HipService/Consent/Database/Migrations/20200212205522_AddConsentArtefactTable.cs" pos="6:7:7" line-data="    public partial class AddConsentArtefactTable : Migration">`AddConsentArtefactTable`</SwmToken> is used to add a new table for consent artefacts.

```c#
﻿namespace In.ProjectEKA.HipService.Consent.Database.Migrations
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
