---
title: Exploring Consent Database
---
# Overview of Consent Database

The Consent module in the hip-service repository manages its database through the <SwmToken path="src/In.ProjectEKA.HipService/Consent/Database/ConsentContext.cs" pos="10:5:5" line-data="    public class ConsentContext : DbContext">`ConsentContext`</SwmToken> class. This class inherits from <SwmToken path="src/In.ProjectEKA.HipService/Consent/Database/ConsentContext.cs" pos="10:9:9" line-data="    public class ConsentContext : DbContext">`DbContext`</SwmToken> and is responsible for configuring the database context and defining the <SwmToken path="src/In.ProjectEKA.HipService/Consent/Database/ConsentContext.cs" pos="16:3:3" line-data="        public DbSet&lt;Consent&gt; ConsentArtefact { get; set; }">`DbSet`</SwmToken> properties that represent the tables in the database.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Consent/Database/ConsentContext.cs" line="1">

---

The <SwmToken path="src/In.ProjectEKA.HipService/Consent/Database/ConsentContext.cs" pos="10:5:5" line-data="    public class ConsentContext : DbContext">`ConsentContext`</SwmToken> class includes a <SwmToken path="src/In.ProjectEKA.HipService/Consent/Database/ConsentContext.cs" pos="16:3:3" line-data="        public DbSet&lt;Consent&gt; ConsentArtefact { get; set; }">`DbSet`</SwmToken> property named <SwmToken path="src/In.ProjectEKA.HipService/Consent/Database/ConsentContext.cs" pos="16:8:8" line-data="        public DbSet&lt;Consent&gt; ConsentArtefact { get; set; }">`ConsentArtefact`</SwmToken>, which represents the table that stores consent artefacts.

```c#
namespace In.ProjectEKA.HipService.Consent.Database
```

---

</SwmSnippet>

# Database Migrations

The <SwmToken path="src/In.ProjectEKA.HipService/Consent/Database/ConsentContext.cs" pos="18:7:7" line-data="        protected override void OnModelCreating(ModelBuilder modelBuilder)">`OnModelCreating`</SwmToken> method in the <SwmToken path="src/In.ProjectEKA.HipService/Consent/Database/ConsentContext.cs" pos="10:5:5" line-data="    public class ConsentContext : DbContext">`ConsentContext`</SwmToken> class configures the model by setting up unique indexes and property conversions. For example, it ensures that the <SwmToken path="src/In.ProjectEKA.HipService/Consent/Database/ConsentContext.cs" pos="20:18:18" line-data="            modelBuilder.Entity&lt;Consent&gt;().HasIndex(p =&gt; p.ConsentArtefactId).IsUnique();">`ConsentArtefactId`</SwmToken> property is unique and converts the <SwmToken path="src/In.ProjectEKA.HipService/Consent/Database/ConsentContext.cs" pos="21:18:18" line-data="            modelBuilder.Entity&lt;Consent&gt;().Property(p =&gt; p.Status)">`Status`</SwmToken> property to and from a string representation.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/Database/Migrations/20200419184602_IntiatedLinkRequest.cs" line="1">

---

Migrations are used to manage changes to the database schema over time. The <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/Migrations/20200419184602_IntiatedLinkRequest.cs" pos="1:13:13" line-data="﻿namespace In.ProjectEKA.HipService.Link.Database.Migrations">`Migrations`</SwmToken> folder contains classes that represent these migrations, such as <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/Migrations/20200419184602_IntiatedLinkRequest.cs" pos="5:7:7" line-data="    public partial class IntiatedLinkRequest : Migration">`IntiatedLinkRequest`</SwmToken> and `LinkRequestMigrations`. These classes define the operations to be performed on the database schema, such as creating or altering tables.

```c#
﻿namespace In.ProjectEKA.HipService.Link.Database.Migrations
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/appsettings.json" line="30">

---

# Database Connection String

The database connection string is defined in the <SwmPath>[src/In.ProjectEKA.HipService/appsettings.json](src/In.ProjectEKA.HipService/appsettings.json)</SwmPath> file under the <SwmToken path="src/In.ProjectEKA.HipService/appsettings.json" pos="30:2:2" line-data="  &quot;ConnectionStrings&quot;: {">`ConnectionStrings`</SwmToken> section. This connection string is used to establish a connection to the database.

```json
  "ConnectionStrings": {
    "DefaultConnection": "$CONNECTION_STRING;"
  },
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/appsettings.Development.json" line="26">

---

Similarly, the <SwmPath>[src/In.ProjectEKA.HipService/appsettings.Development.json](src/In.ProjectEKA.HipService/appsettings.Development.json)</SwmPath> and <SwmPath>[src/In.ProjectEKA.HipService/appsettings.local.json](src/In.ProjectEKA.HipService/appsettings.local.json)</SwmPath> files also contain the <SwmToken path="src/In.ProjectEKA.HipService/appsettings.Development.json" pos="26:2:2" line-data="  &quot;ConnectionStrings&quot;: {">`ConnectionStrings`</SwmToken> section, which specifies the connection string for the development and local environments respectively.

```json
  "ConnectionStrings": {
    "DefaultConnection": "$CONNECTION_STRING"
  },
```

---

</SwmSnippet>

The <SwmToken path="src/In.ProjectEKA.HipService/Consent/Database/ConsentContext.cs" pos="10:5:5" line-data="    public class ConsentContext : DbContext">`ConsentContext`</SwmToken> class in the Consent module uses this connection string to configure the database context and define the <SwmToken path="src/In.ProjectEKA.HipService/Consent/Database/ConsentContext.cs" pos="16:3:3" line-data="        public DbSet&lt;Consent&gt; ConsentArtefact { get; set; }">`DbSet`</SwmToken> properties that represent the tables in the database.

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
