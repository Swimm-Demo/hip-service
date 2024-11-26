---
title: The LinkPatientContext class
---
This document will cover the class <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/LinkPatientContext.cs" pos="10:3:3" line-data="        public LinkPatientContext(DbContextOptions&lt;LinkPatientContext&gt; options) : base(options)">`LinkPatientContext`</SwmToken> in detail. We will cover:

1. What is <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/LinkPatientContext.cs" pos="10:3:3" line-data="        public LinkPatientContext(DbContextOptions&lt;LinkPatientContext&gt; options) : base(options)">`LinkPatientContext`</SwmToken>
2. Variables and functions in <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/LinkPatientContext.cs" pos="10:3:3" line-data="        public LinkPatientContext(DbContextOptions&lt;LinkPatientContext&gt; options) : base(options)">`LinkPatientContext`</SwmToken>

# Variables and functions

# What is <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/LinkPatientContext.cs" pos="10:3:3" line-data="        public LinkPatientContext(DbContextOptions&lt;LinkPatientContext&gt; options) : base(options)">`LinkPatientContext`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/LinkPatientContext.cs" pos="10:3:3" line-data="        public LinkPatientContext(DbContextOptions&lt;LinkPatientContext&gt; options) : base(options)">`LinkPatientContext`</SwmToken> class is a part of the <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/LinkPatientContext.cs" pos="6:2:10" line-data="namespace In.ProjectEKA.HipService.Link.Database">`In.ProjectEKA.HipService.Link.Database`</SwmToken> namespace. It inherits from <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/Migrations/20200122093241_LinkRequestMigrations.Designer.cs" pos="10:2:2" line-data="    [DbContext(typeof(LinkPatientContext))]">`DbContext`</SwmToken> and is used to configure the database context for the Link module. This class defines the <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/LinkPatientContext.cs" pos="14:3:3" line-data="        public DbSet&lt;LinkEnquires&gt; LinkEnquires { get; set; }">`DbSet`</SwmToken> properties that represent the tables in the database.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/Database/LinkPatientContext.cs" line="10">

---

The constructor <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/LinkPatientContext.cs" pos="10:3:3" line-data="        public LinkPatientContext(DbContextOptions&lt;LinkPatientContext&gt; options) : base(options)">`LinkPatientContext`</SwmToken> initializes the database context with the provided options.

```c#
        public LinkPatientContext(DbContextOptions<LinkPatientContext> options) : base(options)
        {
        }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/Database/LinkPatientContext.cs" line="22">

---

The function <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/LinkPatientContext.cs" pos="22:7:7" line-data="        protected override void OnModelCreating(ModelBuilder modelBuilder)">`OnModelCreating`</SwmToken> is used to configure the model by overriding the default behavior. It defines the relationships and properties for the entities in the database.

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

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/Database/LinkPatientContext.cs" line="14">

---

The variable <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/LinkPatientContext.cs" pos="14:5:5" line-data="        public DbSet&lt;LinkEnquires&gt; LinkEnquires { get; set; }">`LinkEnquires`</SwmToken> is a <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/LinkPatientContext.cs" pos="14:3:3" line-data="        public DbSet&lt;LinkEnquires&gt; LinkEnquires { get; set; }">`DbSet`</SwmToken> that represents the <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/LinkPatientContext.cs" pos="14:5:5" line-data="        public DbSet&lt;LinkEnquires&gt; LinkEnquires { get; set; }">`LinkEnquires`</SwmToken> table in the database.

```c#
        public DbSet<LinkEnquires> LinkEnquires { get; set; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/Database/LinkPatientContext.cs" line="16">

---

The variable <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/LinkPatientContext.cs" pos="16:5:5" line-data="        public DbSet&lt;LinkedAccounts&gt; LinkedAccounts { get; set; }">`LinkedAccounts`</SwmToken> is a <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/LinkPatientContext.cs" pos="16:3:3" line-data="        public DbSet&lt;LinkedAccounts&gt; LinkedAccounts { get; set; }">`DbSet`</SwmToken> that represents the <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/LinkPatientContext.cs" pos="16:5:5" line-data="        public DbSet&lt;LinkedAccounts&gt; LinkedAccounts { get; set; }">`LinkedAccounts`</SwmToken> table in the database.

```c#
        public DbSet<LinkedAccounts> LinkedAccounts { get; set; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/Database/LinkPatientContext.cs" line="18">

---

The variable <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/LinkPatientContext.cs" pos="18:5:5" line-data="        public DbSet&lt;CareContextMap&gt; CareContextMap { get; set; }">`CareContextMap`</SwmToken> is a <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/LinkPatientContext.cs" pos="18:3:3" line-data="        public DbSet&lt;CareContextMap&gt; CareContextMap { get; set; }">`DbSet`</SwmToken> that represents the <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/LinkPatientContext.cs" pos="18:5:5" line-data="        public DbSet&lt;CareContextMap&gt; CareContextMap { get; set; }">`CareContextMap`</SwmToken> table in the database.

```c#
        public DbSet<CareContextMap> CareContextMap { get; set; }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/Database/LinkPatientContext.cs" line="20">

---

The variable <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/LinkPatientContext.cs" pos="20:5:5" line-data="        public DbSet&lt;InitiatedLinkRequest&gt; InitiatedLinkRequest { get; set; }">`InitiatedLinkRequest`</SwmToken> is a <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/LinkPatientContext.cs" pos="20:3:3" line-data="        public DbSet&lt;InitiatedLinkRequest&gt; InitiatedLinkRequest { get; set; }">`DbSet`</SwmToken> that represents the <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/LinkPatientContext.cs" pos="20:5:5" line-data="        public DbSet&lt;InitiatedLinkRequest&gt; InitiatedLinkRequest { get; set; }">`InitiatedLinkRequest`</SwmToken> table in the database.

```c#
        public DbSet<InitiatedLinkRequest> InitiatedLinkRequest { get; set; }
```

---

</SwmSnippet>

# Usage

<SwmSnippet path="/test/In.ProjectEKA.HipServiceTest/Link/LinkPatientRepositoryTest.cs" line="18">

---

## <SwmToken path="test/In.ProjectEKA.HipServiceTest/Link/LinkPatientRepositoryTest.cs" pos="16:5:5" line-data="    public class LinkPatientRepositoryTest">`LinkPatientRepositoryTest`</SwmToken>

In <SwmToken path="test/In.ProjectEKA.HipServiceTest/Link/LinkPatientRepositoryTest.cs" pos="16:5:5" line-data="    public class LinkPatientRepositoryTest">`LinkPatientRepositoryTest`</SwmToken>, the <SwmToken path="test/In.ProjectEKA.HipServiceTest/Link/LinkPatientRepositoryTest.cs" pos="18:5:5" line-data="        private static LinkPatientContext PatientContext()">`LinkPatientContext`</SwmToken> is used to create an in-memory database for testing purposes. This is achieved by configuring the <SwmToken path="test/In.ProjectEKA.HipServiceTest/Link/LinkPatientRepositoryTest.cs" pos="20:9:9" line-data="            var optionsBuilder = new DbContextOptionsBuilder&lt;LinkPatientContext&gt;()">`DbContextOptionsBuilder`</SwmToken> to use an in-memory database and then passing these options to the <SwmToken path="test/In.ProjectEKA.HipServiceTest/Link/LinkPatientRepositoryTest.cs" pos="18:5:5" line-data="        private static LinkPatientContext PatientContext()">`LinkPatientContext`</SwmToken> constructor.

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

In the <SwmToken path="src/In.ProjectEKA.HipService/Startup.cs" pos="54:5:5" line-data="    public class Startup">`Startup`</SwmToken> class, <SwmToken path="src/In.ProjectEKA.HipService/Startup.cs" pos="83:4:4" line-data="                .AddDbContext&lt;LinkPatientContext&gt;(options =&gt;">`LinkPatientContext`</SwmToken> is configured as a service within the <SwmToken path="src/In.ProjectEKA.HipService/Startup.cs" pos="80:5:5" line-data="        public void ConfigureServices(IServiceCollection services)">`ConfigureServices`</SwmToken> method. It is added to the service collection with a <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/Migrations/20200122093241_LinkRequestMigrations.Designer.cs" pos="8:7:7" line-data="    using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;">`PostgreSQL`</SwmToken> database connection, ensuring that the context is available for dependency injection throughout the application.

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

Also in the <SwmToken path="src/In.ProjectEKA.HipService/Startup.cs" pos="54:5:5" line-data="    public class Startup">`Startup`</SwmToken> class, <SwmToken path="src/In.ProjectEKA.HipService/Startup.cs" pos="277:13:13" line-data="            var linkContext = serviceScope.ServiceProvider.GetService&lt;LinkPatientContext&gt;();">`LinkPatientContext`</SwmToken> is used to apply database migrations at runtime. This ensures that the database schema is up-to-date with the latest migrations whenever the application starts.

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

In the <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatientRepository.cs" pos="20:3:3" line-data="        public LinkPatientRepository(LinkPatientContext linkPatientContext)">`LinkPatientRepository`</SwmToken> class, <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkPatientRepository.cs" pos="18:5:5" line-data="        private readonly LinkPatientContext linkPatientContext;">`LinkPatientContext`</SwmToken> is injected via the constructor and assigned to a private readonly field. This allows the repository to interact with the database using the context.

```c#
        private readonly LinkPatientContext linkPatientContext;

        public LinkPatientRepository(LinkPatientContext linkPatientContext)
        {
            this.linkPatientContext = linkPatientContext;
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/Database/Migrations/20200122093241_LinkRequestMigrations.Designer.cs" line="10">

---

## Database Migrations

In various migration classes, <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/Migrations/20200122093241_LinkRequestMigrations.Designer.cs" pos="10:6:6" line-data="    [DbContext(typeof(LinkPatientContext))]">`LinkPatientContext`</SwmToken> is specified as the <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/Migrations/20200122093241_LinkRequestMigrations.Designer.cs" pos="10:2:2" line-data="    [DbContext(typeof(LinkPatientContext))]">`DbContext`</SwmToken> for which the migrations are being generated. This ensures that the migrations are correctly applied to the database schema managed by <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/Migrations/20200122093241_LinkRequestMigrations.Designer.cs" pos="10:6:6" line-data="    [DbContext(typeof(LinkPatientContext))]">`LinkPatientContext`</SwmToken>.

```c#
    [DbContext(typeof(LinkPatientContext))]
    [Migration("20200122093241_LinkRequestMigrations")]
    partial class LinkRequestMigrations
```

---

</SwmSnippet>

&nbsp;

*This is an* <SwmToken path="src/In.ProjectEKA.HipService/Link/Database/Migrations/20200122093241_LinkRequestMigrations.Designer.cs" pos="1:4:6" line-data="﻿// &lt;auto-generated /&gt;">`auto-generated`</SwmToken> *document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
