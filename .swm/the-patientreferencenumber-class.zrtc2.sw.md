---
title: The PatientReferenceNumber class
---
This document will cover the class <SwmToken path="src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200328140139_patient-reference-number.Designer.cs" pos="36:9:9" line-data="                    b.Property&lt;string&gt;(&quot;PatientReferenceNumber&quot;)">`PatientReferenceNumber`</SwmToken> in detail. We will cover:

1. What is <SwmToken path="src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200328140139_patient-reference-number.Designer.cs" pos="36:9:9" line-data="                    b.Property&lt;string&gt;(&quot;PatientReferenceNumber&quot;)">`PatientReferenceNumber`</SwmToken>
2. Variables and functions in <SwmToken path="src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200328140139_patient-reference-number.Designer.cs" pos="36:9:9" line-data="                    b.Property&lt;string&gt;(&quot;PatientReferenceNumber&quot;)">`PatientReferenceNumber`</SwmToken>

## Variables and functions

## What is <SwmToken path="src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200328140139_patient-reference-number.Designer.cs" pos="36:9:9" line-data="                    b.Property&lt;string&gt;(&quot;PatientReferenceNumber&quot;)">`PatientReferenceNumber`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200328140139_patient-reference-number.Designer.cs" pos="36:9:9" line-data="                    b.Property&lt;string&gt;(&quot;PatientReferenceNumber&quot;)">`PatientReferenceNumber`</SwmToken> class is a partial class defined in the file <SwmPath>[src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200328140139_patient-reference-number.Designer.cs](src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200328140139_patient-reference-number.Designer.cs)</SwmPath>. It is used as part of the Entity Framework Core migration process to define the schema of the <SwmToken path="src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200328140139_patient-reference-number.Designer.cs" pos="24:16:16" line-data="            modelBuilder.Entity(&quot;In.ProjectEKA.HipService.Discovery.Model.DiscoveryRequest&quot;, b =&gt;">`DiscoveryRequest`</SwmToken> entity in the database. This class is responsible for configuring the database model to include a <SwmToken path="src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200328140139_patient-reference-number.Designer.cs" pos="36:9:9" line-data="                    b.Property&lt;string&gt;(&quot;PatientReferenceNumber&quot;)">`PatientReferenceNumber`</SwmToken> property in the <SwmToken path="src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200328140139_patient-reference-number.Designer.cs" pos="24:16:16" line-data="            modelBuilder.Entity(&quot;In.ProjectEKA.HipService.Discovery.Model.DiscoveryRequest&quot;, b =&gt;">`DiscoveryRequest`</SwmToken> table.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200328140139_patient-reference-number.Designer.cs" line="16">

---

The function <SwmToken path="src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200328140139_patient-reference-number.Designer.cs" pos="16:7:7" line-data="        protected override void BuildTargetModel(ModelBuilder modelBuilder)">`BuildTargetModel`</SwmToken> is used to build the model for the <SwmToken path="src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200328140139_patient-reference-number.Designer.cs" pos="24:16:16" line-data="            modelBuilder.Entity(&quot;In.ProjectEKA.HipService.Discovery.Model.DiscoveryRequest&quot;, b =&gt;">`DiscoveryRequest`</SwmToken> entity. It configures the properties and annotations for the entity, including the <SwmToken path="src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200328140139_patient-reference-number.Designer.cs" pos="36:9:9" line-data="                    b.Property&lt;string&gt;(&quot;PatientReferenceNumber&quot;)">`PatientReferenceNumber`</SwmToken> property.

```c#
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("In.ProjectEKA.HipService.Discovery.Model.DiscoveryRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ConsentManagerUserId")
                        .IsRequired()
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.Property<string>("PatientReferenceNumber")
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200328140139_patient-reference-number.Designer.cs" line="36">

---

The variable <SwmToken path="src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200328140139_patient-reference-number.Designer.cs" pos="36:9:9" line-data="                    b.Property&lt;string&gt;(&quot;PatientReferenceNumber&quot;)">`PatientReferenceNumber`</SwmToken> is a property of the <SwmToken path="src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200328140139_patient-reference-number.Designer.cs" pos="24:16:16" line-data="            modelBuilder.Entity(&quot;In.ProjectEKA.HipService.Discovery.Model.DiscoveryRequest&quot;, b =&gt;">`DiscoveryRequest`</SwmToken> entity. It is a required string with a maximum length of 50 characters.

```c#
                    b.Property<string>("PatientReferenceNumber")
                        .IsRequired()
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);
```

---

</SwmSnippet>

# Usage

<SwmSnippet path="/src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200408103411_UniqueTransactionId.Designer.cs" line="36">

---

## <SwmToken path="src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200408103411_UniqueTransactionId.Designer.cs" pos="14:5:5" line-data="    partial class UniqueTransactionId">`UniqueTransactionId`</SwmToken> Migration

In the <SwmToken path="src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200408103411_UniqueTransactionId.Designer.cs" pos="14:5:5" line-data="    partial class UniqueTransactionId">`UniqueTransactionId`</SwmToken> migration, the <SwmToken path="src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200408103411_UniqueTransactionId.Designer.cs" pos="36:9:9" line-data="                    b.Property&lt;string&gt;(&quot;PatientReferenceNumber&quot;)">`PatientReferenceNumber`</SwmToken> is defined as a required property with a maximum length of 50 characters.

```c#
                    b.Property<string>("PatientReferenceNumber")
                        .IsRequired()
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Discovery/Database/Migrations/DiscoveryContextModelSnapshot.cs" line="34">

---

## <SwmToken path="src/In.ProjectEKA.HipService/Discovery/Database/Migrations/DiscoveryContextModelSnapshot.cs" pos="12:5:5" line-data="    partial class DiscoveryContextModelSnapshot : ModelSnapshot">`DiscoveryContextModelSnapshot`</SwmToken>

In the <SwmToken path="src/In.ProjectEKA.HipService/Discovery/Database/Migrations/DiscoveryContextModelSnapshot.cs" pos="12:5:5" line-data="    partial class DiscoveryContextModelSnapshot : ModelSnapshot">`DiscoveryContextModelSnapshot`</SwmToken>, the <SwmToken path="src/In.ProjectEKA.HipService/Discovery/Database/Migrations/DiscoveryContextModelSnapshot.cs" pos="34:9:9" line-data="                    b.Property&lt;string&gt;(&quot;PatientReferenceNumber&quot;)">`PatientReferenceNumber`</SwmToken> is similarly defined as a required property with a maximum length of 50 characters.

```c#
                    b.Property<string>("PatientReferenceNumber")
                        .IsRequired()
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200526172717_RenamingRequestID.Designer.cs" line="36">

---

## <SwmToken path="src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200526172717_RenamingRequestID.Designer.cs" pos="14:5:5" line-data="    partial class RenamingRequestID">`RenamingRequestID`</SwmToken> Migration

In the <SwmToken path="src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200526172717_RenamingRequestID.Designer.cs" pos="14:5:5" line-data="    partial class RenamingRequestID">`RenamingRequestID`</SwmToken> migration, the <SwmToken path="src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200526172717_RenamingRequestID.Designer.cs" pos="36:9:9" line-data="                    b.Property&lt;string&gt;(&quot;PatientReferenceNumber&quot;)">`PatientReferenceNumber`</SwmToken> is also defined as a required property with a maximum length of 50 characters.

```c#
                    b.Property<string>("PatientReferenceNumber")
                        .IsRequired()
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200417080025_RenamingTranscationID.Designer.cs" line="36">

---

## <SwmToken path="src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200417080025_RenamingTranscationID.Designer.cs" pos="14:5:5" line-data="    partial class RenamingTranscationID">`RenamingTranscationID`</SwmToken> Migration

In the <SwmToken path="src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200417080025_RenamingTranscationID.Designer.cs" pos="14:5:5" line-data="    partial class RenamingTranscationID">`RenamingTranscationID`</SwmToken> migration, the <SwmToken path="src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200417080025_RenamingTranscationID.Designer.cs" pos="36:9:9" line-data="                    b.Property&lt;string&gt;(&quot;PatientReferenceNumber&quot;)">`PatientReferenceNumber`</SwmToken> is defined as a required property with a maximum length of 50 characters.

```c#
                    b.Property<string>("PatientReferenceNumber")
                        .IsRequired()
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);
```

---

</SwmSnippet>

&nbsp;

*This is an* <SwmToken path="src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200328140139_patient-reference-number.Designer.cs" pos="1:4:6" line-data="﻿// &lt;auto-generated /&gt;">`auto-generated`</SwmToken> *document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
