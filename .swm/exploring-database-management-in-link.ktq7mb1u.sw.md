---
title: Exploring Database Management in Link
---
# Overview of Link Database

The database in the Link module is managed through the <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/LinkPatientContext.cs" pos="8:5:5" line-data="    public class LinkPatientContext : DbContext">`LinkPatientContext`</SwmToken> class, which inherits from <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/LinkPatientContext.cs" pos="8:9:9" line-data="    public class LinkPatientContext : DbContext">`DbContext`</SwmToken>. This class is responsible for configuring the database context and defining the <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/LinkPatientContext.cs" pos="14:3:3" line-data="        public DbSet&lt;LinkEnquires&gt; LinkEnquires { get; set; }">`DbSet`</SwmToken> properties that represent the tables in the database.

# <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/LinkPatientContext.cs" pos="14:3:3" line-data="        public DbSet&lt;LinkEnquires&gt; LinkEnquires { get; set; }">`DbSet`</SwmToken> Properties

The <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/LinkPatientContext.cs" pos="8:5:5" line-data="    public class LinkPatientContext : DbContext">`LinkPatientContext`</SwmToken> class includes <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/LinkPatientContext.cs" pos="14:3:3" line-data="        public DbSet&lt;LinkEnquires&gt; LinkEnquires { get; set; }">`DbSet`</SwmToken> properties such as <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/LinkPatientContext.cs" pos="14:5:5" line-data="        public DbSet&lt;LinkEnquires&gt; LinkEnquires { get; set; }">`LinkEnquires`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/LinkPatientContext.cs" pos="16:5:5" line-data="        public DbSet&lt;LinkedAccounts&gt; LinkedAccounts { get; set; }">`LinkedAccounts`</SwmToken>, <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/LinkPatientContext.cs" pos="18:5:5" line-data="        public DbSet&lt;CareContextMap&gt; CareContextMap { get; set; }">`CareContextMap`</SwmToken>, and <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/LinkPatientContext.cs" pos="20:5:5" line-data="        public DbSet&lt;InitiatedLinkRequest&gt; InitiatedLinkRequest { get; set; }">`InitiatedLinkRequest`</SwmToken>. These properties map to the respective tables in the database and allow for querying and saving instances of these entities.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/Database/LinkPatientContext.cs" line="6">

---

The <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/LinkPatientContext.cs" pos="8:5:5" line-data="    public class LinkPatientContext : DbContext">`LinkPatientContext`</SwmToken> class is defined in this file and is responsible for configuring the database context and defining the <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/LinkPatientContext.cs" pos="14:3:3" line-data="        public DbSet&lt;LinkEnquires&gt; LinkEnquires { get; set; }">`DbSet`</SwmToken> properties.

```c#
namespace In.ProjectEKA.HipService.Link.Database
```

---

</SwmSnippet>

# Configuring the Model

The <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/LinkPatientContext.cs" pos="22:7:7" line-data="        protected override void OnModelCreating(ModelBuilder modelBuilder)">`OnModelCreating`</SwmToken> method in the <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/LinkPatientContext.cs" pos="8:5:5" line-data="    public class LinkPatientContext : DbContext">`LinkPatientContext`</SwmToken> class is used to configure the model and relationships between the entities. This method is overridden to customize the mapping of the entities to the database schema.

# Database Migrations

Migrations are used to manage changes to the database schema over time. The <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/Migrations/20200419184602_IntiatedLinkRequest.cs" pos="1:13:13" line-data="﻿namespace In.ProjectEKA.HipService.Link.Database.Migrations">`Migrations`</SwmToken> folder contains classes that represent these migrations, such as <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/Migrations/20200419184602_IntiatedLinkRequest.cs" pos="5:7:7" line-data="    public partial class IntiatedLinkRequest : Migration">`IntiatedLinkRequest`</SwmToken> and <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/Migrations/20200122093241_LinkRequestMigrations.Designer.cs" pos="12:5:5" line-data="    partial class LinkRequestMigrations">`LinkRequestMigrations`</SwmToken>. These classes define the operations to be performed on the database schema, such as creating or altering tables.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/Database/Migrations/20200419184602_IntiatedLinkRequest.cs" line="1">

---

The <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/Migrations/20200419184602_IntiatedLinkRequest.cs" pos="5:7:7" line-data="    public partial class IntiatedLinkRequest : Migration">`IntiatedLinkRequest`</SwmToken> class represents a migration that defines the operations to be performed on the database schema, such as creating or altering tables.

```c#
﻿namespace In.ProjectEKA.HipService.Link.Database.Migrations
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/Database/Migrations/20200122093241_LinkRequestMigrations.Designer.cs" line="3">

---

The <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/Migrations/20200122093241_LinkRequestMigrations.Designer.cs" pos="12:5:5" line-data="    partial class LinkRequestMigrations">`LinkRequestMigrations`</SwmToken> class represents a migration that defines the operations to be performed on the database schema, such as creating or altering tables.

```c#
namespace In.ProjectEKA.HipService.Link.Database.Migrations
```

---

</SwmSnippet>

# Synchronizing Database Schema

The <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/LinkPatientContext.cs" pos="8:5:5" line-data="    public class LinkPatientContext : DbContext">`LinkPatientContext`</SwmToken> class and the migration classes work together to ensure that the database schema is kept in sync with the application's data model. This allows for seamless updates to the database as the application evolves.

&nbsp;

*This is an* <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/Migrations/20200122093241_LinkRequestMigrations.Designer.cs" pos="1:4:6" line-data="﻿// &lt;auto-generated /&gt;">`auto-generated`</SwmToken> *document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
