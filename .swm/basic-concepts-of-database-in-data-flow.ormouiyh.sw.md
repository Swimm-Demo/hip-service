---
title: Basic Concepts of Database in Data Flow
---
# <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/Database/DataFlowContext.cs" pos="13:3:3" line-data="        public DbSet&lt;DataFlowRequest&gt; DataFlowRequest { get; set; }">`DbSet`</SwmToken> Properties

# Database Management

The database is managed through the <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/Database/DataFlowContext.cs" pos="7:5:5" line-data="    public class DataFlowContext : DbContext">`DataFlowContext`</SwmToken> class, which inherits from <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/Database/DataFlowContext.cs" pos="7:9:9" line-data="    public class DataFlowContext : DbContext">`DbContext`</SwmToken>. This class is responsible for configuring the database context and defining the entities that will be stored in the database.

# Configuring the Model

The <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/Database/DataFlowContext.cs" pos="7:5:5" line-data="    public class DataFlowContext : DbContext">`DataFlowContext`</SwmToken> class includes two <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/Database/DataFlowContext.cs" pos="13:3:3" line-data="        public DbSet&lt;DataFlowRequest&gt; DataFlowRequest { get; set; }">`DbSet`</SwmToken> properties: <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/Database/DataFlowContext.cs" pos="13:5:5" line-data="        public DbSet&lt;DataFlowRequest&gt; DataFlowRequest { get; set; }">`DataFlowRequest`</SwmToken> and <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/Database/DataFlowContext.cs" pos="14:5:5" line-data="        public DbSet&lt;HealthInformation&gt; HealthInformation { get; set; }">`HealthInformation`</SwmToken>. These properties represent the tables in the database where data flow requests and health information are stored, respectively.

# Usage in Application

The <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/Database/DataFlowContext.cs" pos="16:7:7" line-data="        protected override void OnModelCreating(ModelBuilder modelBuilder)">`OnModelCreating`</SwmToken> method in <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/Database/DataFlowContext.cs" pos="7:5:5" line-data="    public class DataFlowContext : DbContext">`DataFlowContext`</SwmToken> is used to configure the model and its relationships. For example, it sets the primary key for the <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/Database/DataFlowContext.cs" pos="13:5:5" line-data="        public DbSet&lt;DataFlowRequest&gt; DataFlowRequest { get; set; }">`DataFlowRequest`</SwmToken> entity and configures the conversion of complex types to and from JSON for both <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/Database/DataFlowContext.cs" pos="13:5:5" line-data="        public DbSet&lt;DataFlowRequest&gt; DataFlowRequest { get; set; }">`DataFlowRequest`</SwmToken> and <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/Database/DataFlowContext.cs" pos="14:5:5" line-data="        public DbSet&lt;HealthInformation&gt; HealthInformation { get; set; }">`HealthInformation`</SwmToken> entities.

# Startup Configuration

The <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/Database/DataFlowContext.cs" pos="7:5:5" line-data="    public class DataFlowContext : DbContext">`DataFlowContext`</SwmToken> is utilized in various parts of the application, such as repositories and the startup configuration. It is injected into repositories like `DataFlowRepository` and `HealthInformationRepository` to perform database operations.

<SwmSnippet path="/src/In.ProjectEKA.HipService/DataFlow/Database/DataFlowContext.cs" line="1">

---

During the application startup, the <SwmToken path="src/In.ProjectEKA.HipService/DataFlow/Database/DataFlowContext.cs" pos="7:5:5" line-data="    public class DataFlowContext : DbContext">`DataFlowContext`</SwmToken> is configured with the database connection string and migrations are applied to ensure the database schema is up-to-date. This is done in the `Startup` class where the `AddDbContext` method is called with the necessary options.

```c#
namespace In.ProjectEKA.HipService.DataFlow.Database
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
