---
title: The LinkPatientContext class
---
This document will cover the class <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/LinkPatientContext.cs" pos="10:3:3" line-data="        public LinkPatientContext(DbContextOptions&lt;LinkPatientContext&gt; options) : base(options)">`LinkPatientContext`</SwmToken> in detail. We will cover:

1. What is <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/LinkPatientContext.cs" pos="10:3:3" line-data="        public LinkPatientContext(DbContextOptions&lt;LinkPatientContext&gt; options) : base(options)">`LinkPatientContext`</SwmToken>
2. Variables and functions in <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/LinkPatientContext.cs" pos="10:3:3" line-data="        public LinkPatientContext(DbContextOptions&lt;LinkPatientContext&gt; options) : base(options)">`LinkPatientContext`</SwmToken>

# Variables and functions

# What is <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/LinkPatientContext.cs" pos="10:3:3" line-data="        public LinkPatientContext(DbContextOptions&lt;LinkPatientContext&gt; options) : base(options)">`LinkPatientContext`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/LinkPatientContext.cs" pos="10:3:3" line-data="        public LinkPatientContext(DbContextOptions&lt;LinkPatientContext&gt; options) : base(options)">`LinkPatientContext`</SwmToken> class is a part of the <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/LinkPatientContext.cs" pos="6:2:10" line-data="namespace In.ProjectEKA.HipService.Link.Database">`In.ProjectEKA.HipService.Link.Database`</SwmToken> namespace. It is used to interact with the database for operations related to linking patient data. This class inherits from <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/Migrations/20200419184602_IntiatedLinkRequest.Designer.cs" pos="11:2:2" line-data="    [DbContext(typeof(LinkPatientContext))]">`DbContext`</SwmToken>, which is a part of the Entity Framework Core and provides the necessary methods and properties to interact with the database.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/Database/LinkPatientContext.cs" line="10">

---

The constructor <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/LinkPatientContext.cs" pos="10:3:3" line-data="        public LinkPatientContext(DbContextOptions&lt;LinkPatientContext&gt; options) : base(options)">`LinkPatientContext`</SwmToken> initializes the context with the provided options.

```c#
        public LinkPatientContext(DbContextOptions<LinkPatientContext> options) : base(options)
        {
        }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/Database/LinkPatientContext.cs" line="14">

---

The <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/LinkPatientContext.cs" pos="14:5:5" line-data="        public DbSet&lt;LinkEnquires&gt; LinkEnquires { get; set; }">`LinkEnquires`</SwmToken> property is a <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/LinkPatientContext.cs" pos="14:3:3" line-data="        public DbSet&lt;LinkEnquires&gt; LinkEnquires { get; set; }">`DbSet`</SwmToken> that represents the collection of <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/LinkPatientContext.cs" pos="14:5:5" line-data="        public DbSet&lt;LinkEnquires&gt; LinkEnquires { get; set; }">`LinkEnquires`</SwmToken> entities in the context.

```c#
        public DbSet<LinkEnquires> LinkEnquires { get; set; }
```

---

</SwmSnippet>

<SwmSnippet path="src/In.ProjectEKA.HipService/Link/Database/LinkPatientContext.cs" line="14">

---

The <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/LinkPatientContext.cs" pos="34:5:5" line-data="            modelBuilder.Entity&lt;LinkedAccounts&gt;(builder =&gt;">`LinkedAccounts`</SwmToken> property is a <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/LinkPatientContext.cs" pos="14:3:3" line-data="        public DbSet&lt;LinkEnquires&gt; LinkEnquires { get; set; }">`DbSet`</SwmToken> that represents the collection of <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/LinkPatientContext.cs" pos="34:5:5" line-data="            modelBuilder.Entity&lt;LinkedAccounts&gt;(builder =&gt;">`LinkedAccounts`</SwmToken> entities in the context.

```
        public DbSet<LinkEnquires> LinkEnquires { get; set; }
```

---

</SwmSnippet>

<SwmSnippet path="src/In.ProjectEKA.HipService/Link/Database/LinkPatientContext.cs" line="18">

---

The <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/LinkPatientContext.cs" pos="40:5:5" line-data="            modelBuilder.Entity&lt;CareContextMap&gt;(builder =&gt;">`CareContextMap`</SwmToken> property is a <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/LinkPatientContext.cs" pos="14:3:3" line-data="        public DbSet&lt;LinkEnquires&gt; LinkEnquires { get; set; }">`DbSet`</SwmToken> that represents the collection of <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/LinkPatientContext.cs" pos="40:5:5" line-data="            modelBuilder.Entity&lt;CareContextMap&gt;(builder =&gt;">`CareContextMap`</SwmToken> entities in the context.

```
        public DbSet<CareContextMap> CareContextMap { get; set; }
```

---

</SwmSnippet>

<SwmSnippet path="src/In.ProjectEKA.HipService/Link/Database/LinkPatientContext.cs" line="20">

---

The <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/LinkPatientContext.cs" pos="20:5:5" line-data="        public DbSet&lt;InitiatedLinkRequest&gt; InitiatedLinkRequest { get; set; }">`InitiatedLinkRequest`</SwmToken> property is a <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/LinkPatientContext.cs" pos="14:3:3" line-data="        public DbSet&lt;LinkEnquires&gt; LinkEnquires { get; set; }">`DbSet`</SwmToken> that represents the collection of <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/LinkPatientContext.cs" pos="20:5:5" line-data="        public DbSet&lt;InitiatedLinkRequest&gt; InitiatedLinkRequest { get; set; }">`InitiatedLinkRequest`</SwmToken> entities in the context.

```
        public DbSet<InitiatedLinkRequest> InitiatedLinkRequest { get; set; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/Database/LinkPatientContext.cs" line="22">

---

The <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/LinkPatientContext.cs" pos="22:7:7" line-data="        protected override void OnModelCreating(ModelBuilder modelBuilder)">`OnModelCreating`</SwmToken> method is overridden to configure the schema needed for the context. It defines the relationships and properties for the entities.

```c#
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CareContext>()
                .HasKey("CareContextName", "LinkReferenceNumber")
                .HasName("Id");

            modelBuilder.Entity<LinkEnquires>()
                .HasMany(l => l.CareContexts)
                .WithOne(c => c.LinkEnquires)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<LinkedAccounts>(builder =>
            {
                builder.Property(p => p.DateTimeStamp)
                    .HasDefaultValueSql("now()");
            });

            modelBuilder.Entity<CareContextMap>(builder =>
            {
                builder.HasKey(p=>p.CareContextName);
```

---

</SwmSnippet>

# Usage

<SwmSnippet path="/test/In.ProjectEKA.HipServiceTest/Link/LinkPatientRepositoryTest.cs" line="18">

---

## <SwmToken path="test/In.ProjectEKA.HipServiceTest/Link/LinkPatientRepositoryTest.cs" pos="16:5:5" line-data="    public class LinkPatientRepositoryTest">`LinkPatientRepositoryTest`</SwmToken>

In the <SwmToken path="test/In.ProjectEKA.HipServiceTest/Link/LinkPatientRepositoryTest.cs" pos="16:5:5" line-data="    public class LinkPatientRepositoryTest">`LinkPatientRepositoryTest`</SwmToken> class, <SwmToken path="test/In.ProjectEKA.HipServiceTest/Link/LinkPatientRepositoryTest.cs" pos="18:5:5" line-data="        private static LinkPatientContext PatientContext()">`LinkPatientContext`</SwmToken> is used to create an in-memory database for testing purposes. This is done by configuring the <SwmToken path="test/In.ProjectEKA.HipServiceTest/Link/LinkPatientRepositoryTest.cs" pos="20:9:9" line-data="            var optionsBuilder = new DbContextOptionsBuilder&lt;LinkPatientContext&gt;()">`DbContextOptionsBuilder`</SwmToken> to use an in-memory database and then passing these options to the <SwmToken path="test/In.ProjectEKA.HipServiceTest/Link/LinkPatientRepositoryTest.cs" pos="18:5:5" line-data="        private static LinkPatientContext PatientContext()">`LinkPatientContext`</SwmToken> constructor.

```c#
        private static LinkPatientContext PatientContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<LinkPatientContext>()
                .UseInMemoryDatabase(TestBuilders.Faker().Random.String())
                .Options;
            return new LinkPatientContext(optionsBuilder);
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Startup.cs" line="80">

---

## Startup Configuration

In the <SwmToken path="src/In.ProjectEKA.HipService/Startup.cs" pos="54:5:5" line-data="    public class Startup">`Startup`</SwmToken> class, <SwmToken path="src/In.ProjectEKA.HipService/Startup.cs" pos="83:4:4" line-data="                .AddDbContext&lt;LinkPatientContext&gt;(options =&gt;">`LinkPatientContext`</SwmToken> is registered with the dependency injection container. This is done by adding it to the service collection and configuring it to use a <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/Migrations/20200419184602_IntiatedLinkRequest.Designer.cs" pos="7:6:6" line-data="using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;">`PostgreSQL`</SwmToken> database with a connection string from the configuration.

```c#
        public void ConfigureServices(IServiceCollection services)
        {
            services
                .AddDbContext<LinkPatientContext>(options =>
                    options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"),
                        x => x.MigrationsAssembly("In.ProjectEKA.HipService")))
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Startup.cs" line="276">

---

## Database Migration

Also in the <SwmToken path="src/In.ProjectEKA.HipService/Startup.cs" pos="54:5:5" line-data="    public class Startup">`Startup`</SwmToken> class, <SwmToken path="src/In.ProjectEKA.HipService/Startup.cs" pos="277:13:13" line-data="            var linkContext = serviceScope.ServiceProvider.GetService&lt;LinkPatientContext&gt;();">`LinkPatientContext`</SwmToken> is used to apply any pending migrations to the database when the application starts. This ensures that the database schema is up to date.

```c#
            using var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope();
            var linkContext = serviceScope.ServiceProvider.GetService<LinkPatientContext>();
            linkContext.Database.Migrate();
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/LinkPatientRepository.cs" line="18">

---

## <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatientRepository.cs" pos="20:3:3" line-data="        public LinkPatientRepository(LinkPatientContext linkPatientContext)">`LinkPatientRepository`</SwmToken>

In the <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatientRepository.cs" pos="20:3:3" line-data="        public LinkPatientRepository(LinkPatientContext linkPatientContext)">`LinkPatientRepository`</SwmToken> class, <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatientRepository.cs" pos="18:5:5" line-data="        private readonly LinkPatientContext linkPatientContext;">`LinkPatientContext`</SwmToken> is injected via the constructor and stored in a private readonly field. This allows the repository to interact with the database using the context.

```c#
        private readonly LinkPatientContext linkPatientContext;

        public LinkPatientRepository(LinkPatientContext linkPatientContext)
        {
            this.linkPatientContext = linkPatientContext;
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/Database/Migrations/20200419184602_IntiatedLinkRequest.Designer.cs" line="11">

---

## Database Migrations

In various migration classes, <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/Migrations/20200419184602_IntiatedLinkRequest.Designer.cs" pos="11:6:6" line-data="    [DbContext(typeof(LinkPatientContext))]">`LinkPatientContext`</SwmToken> is used as the <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/Migrations/20200419184602_IntiatedLinkRequest.Designer.cs" pos="11:2:2" line-data="    [DbContext(typeof(LinkPatientContext))]">`DbContext`</SwmToken> for generating and applying database migrations. This includes classes like <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/Migrations/20200419184602_IntiatedLinkRequest.Designer.cs" pos="13:5:5" line-data="    partial class IntiatedLinkRequest">`IntiatedLinkRequest`</SwmToken>, `CareContextColumnNameChange`, `LinkedRequestMigrationsv1`, `CareContextMigration`, <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/LinkPatientContext.cs" pos="40:5:5" line-data="            modelBuilder.Entity&lt;CareContextMap&gt;(builder =&gt;">`CareContextMap`</SwmToken>, `LinkRequestMigrations`, and `LinkedAccountsMigration`.

```c#
    [DbContext(typeof(LinkPatientContext))]
    [Migration("20200419184602_IntiatedLinkRequest")]
```

---

</SwmSnippet>

&nbsp;

*This is an* <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/Migrations/20200419184602_IntiatedLinkRequest.Designer.cs" pos="1:4:6" line-data="﻿// &lt;auto-generated /&gt;">`auto-generated`</SwmToken> *document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](https://app.swimm.io/)</sup></SwmMeta>
