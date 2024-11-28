---
title: The PatientReferenceNumber class
---
This document will cover the class <SwmToken path="src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200328140139_patient-reference-number.Designer.cs" pos="36:9:9" line-data="                    b.Property&lt;string&gt;(&quot;PatientReferenceNumber&quot;)">`PatientReferenceNumber`</SwmToken> in the file <SwmPath>[src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200328140139_patient-reference-number.Designer.cs](src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200328140139_patient-reference-number.Designer.cs)</SwmPath>. We will discuss:

1. What is <SwmToken path="src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200328140139_patient-reference-number.Designer.cs" pos="36:9:9" line-data="                    b.Property&lt;string&gt;(&quot;PatientReferenceNumber&quot;)">`PatientReferenceNumber`</SwmToken>
2. Variables and functions in <SwmToken path="src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200328140139_patient-reference-number.Designer.cs" pos="36:9:9" line-data="                    b.Property&lt;string&gt;(&quot;PatientReferenceNumber&quot;)">`PatientReferenceNumber`</SwmToken>

# Variables and functions

# What is <SwmToken path="src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200328140139_patient-reference-number.Designer.cs" pos="36:9:9" line-data="                    b.Property&lt;string&gt;(&quot;PatientReferenceNumber&quot;)">`PatientReferenceNumber`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200328140139_patient-reference-number.Designer.cs" pos="36:9:9" line-data="                    b.Property&lt;string&gt;(&quot;PatientReferenceNumber&quot;)">`PatientReferenceNumber`</SwmToken> class is a partial class defined in the <SwmPath>[src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200328140139_patient-reference-number.Designer.cs](src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200328140139_patient-reference-number.Designer.cs)</SwmPath> file. It is used as part of the Entity Framework Core migration process to define the schema for the <SwmToken path="src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200328140139_patient-reference-number.Designer.cs" pos="24:16:16" line-data="            modelBuilder.Entity(&quot;In.ProjectEKA.HipService.Discovery.Model.DiscoveryRequest&quot;, b =&gt;">`DiscoveryRequest`</SwmToken> entity. This class helps in managing the database schema changes related to the <SwmToken path="src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200328140139_patient-reference-number.Designer.cs" pos="36:9:9" line-data="                    b.Property&lt;string&gt;(&quot;PatientReferenceNumber&quot;)">`PatientReferenceNumber`</SwmToken> field in the <SwmToken path="src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200328140139_patient-reference-number.Designer.cs" pos="24:16:16" line-data="            modelBuilder.Entity(&quot;In.ProjectEKA.HipService.Discovery.Model.DiscoveryRequest&quot;, b =&gt;">`DiscoveryRequest`</SwmToken> table.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200328140139_patient-reference-number.Designer.cs" line="16">

---

The function <SwmToken path="src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200328140139_patient-reference-number.Designer.cs" pos="16:7:7" line-data="        protected override void BuildTargetModel(ModelBuilder modelBuilder)">`BuildTargetModel`</SwmToken> is used to build the model for the <SwmToken path="src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200328140139_patient-reference-number.Designer.cs" pos="24:16:16" line-data="            modelBuilder.Entity(&quot;In.ProjectEKA.HipService.Discovery.Model.DiscoveryRequest&quot;, b =&gt;">`DiscoveryRequest`</SwmToken> entity. It defines the schema and properties of the <SwmToken path="src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200328140139_patient-reference-number.Designer.cs" pos="24:16:16" line-data="            modelBuilder.Entity(&quot;In.ProjectEKA.HipService.Discovery.Model.DiscoveryRequest&quot;, b =&gt;">`DiscoveryRequest`</SwmToken> table, including the <SwmToken path="src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200328140139_patient-reference-number.Designer.cs" pos="36:9:9" line-data="                    b.Property&lt;string&gt;(&quot;PatientReferenceNumber&quot;)">`PatientReferenceNumber`</SwmToken> field.

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

<SwmSnippet path="/src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200328140139_patient-reference-number.Designer.cs" line="26">

---

The variable <SwmToken path="src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200328140139_patient-reference-number.Designer.cs" pos="26:9:9" line-data="                    b.Property&lt;int&gt;(&quot;Id&quot;)">`Id`</SwmToken> is used to store the unique identifier for each <SwmToken path="src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200328140139_patient-reference-number.Designer.cs" pos="24:16:16" line-data="            modelBuilder.Entity(&quot;In.ProjectEKA.HipService.Discovery.Model.DiscoveryRequest&quot;, b =&gt;">`DiscoveryRequest`</SwmToken>. It is an integer that is generated automatically.

```c#
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200328140139_patient-reference-number.Designer.cs" line="31">

---

The variable <SwmToken path="src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200328140139_patient-reference-number.Designer.cs" pos="31:9:9" line-data="                    b.Property&lt;string&gt;(&quot;ConsentManagerUserId&quot;)">`ConsentManagerUserId`</SwmToken> is used to store the user ID of the consent manager. It is a required string with a maximum length of 50 characters.

```c#
                    b.Property<string>("ConsentManagerUserId")
                        .IsRequired()
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200328140139_patient-reference-number.Designer.cs" line="36">

---

The variable <SwmToken path="src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200328140139_patient-reference-number.Designer.cs" pos="36:9:9" line-data="                    b.Property&lt;string&gt;(&quot;PatientReferenceNumber&quot;)">`PatientReferenceNumber`</SwmToken> is used to store the reference number of the patient. It is a required string with a maximum length of 50 characters.

```c#
                    b.Property<string>("PatientReferenceNumber")
                        .IsRequired()
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200328140139_patient-reference-number.Designer.cs" line="41">

---

The variable <SwmToken path="src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200328140139_patient-reference-number.Designer.cs" pos="41:9:9" line-data="                    b.Property&lt;DateTime&gt;(&quot;Timestamp&quot;)">`Timestamp`</SwmToken> is used to store the timestamp of the <SwmToken path="src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200328140139_patient-reference-number.Designer.cs" pos="24:16:16" line-data="            modelBuilder.Entity(&quot;In.ProjectEKA.HipService.Discovery.Model.DiscoveryRequest&quot;, b =&gt;">`DiscoveryRequest`</SwmToken>. It is a <SwmToken path="src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200328140139_patient-reference-number.Designer.cs" pos="41:5:5" line-data="                    b.Property&lt;DateTime&gt;(&quot;Timestamp&quot;)">`DateTime`</SwmToken> value that is generated automatically with a default value of the current time.

```c#
                    b.Property<DateTime>("Timestamp")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("now()");
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200328140139_patient-reference-number.Designer.cs" line="46">

---

The variable <SwmToken path="src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200328140139_patient-reference-number.Designer.cs" pos="46:9:9" line-data="                    b.Property&lt;string&gt;(&quot;TransactionId&quot;)">`TransactionId`</SwmToken> is used to store the transaction ID of the <SwmToken path="src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200328140139_patient-reference-number.Designer.cs" pos="24:16:16" line-data="            modelBuilder.Entity(&quot;In.ProjectEKA.HipService.Discovery.Model.DiscoveryRequest&quot;, b =&gt;">`DiscoveryRequest`</SwmToken>. It is a required string with a maximum length of 50 characters.

```c#
                    b.Property<string>("TransactionId")
                        .IsRequired()
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200328140139_patient-reference-number.Designer.cs" line="51">

---

The <SwmToken path="src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200328140139_patient-reference-number.Designer.cs" pos="51:3:3" line-data="                    b.HasKey(&quot;Id&quot;);">`HasKey`</SwmToken> method is used to define the primary key for the <SwmToken path="src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200328140139_patient-reference-number.Designer.cs" pos="24:16:16" line-data="            modelBuilder.Entity(&quot;In.ProjectEKA.HipService.Discovery.Model.DiscoveryRequest&quot;, b =&gt;">`DiscoveryRequest`</SwmToken> table, which is the <SwmToken path="src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200328140139_patient-reference-number.Designer.cs" pos="51:6:6" line-data="                    b.HasKey(&quot;Id&quot;);">`Id`</SwmToken> field.

```c#
                    b.HasKey("Id");
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200328140139_patient-reference-number.Designer.cs" line="53">

---

The <SwmToken path="src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200328140139_patient-reference-number.Designer.cs" pos="53:3:3" line-data="                    b.ToTable(&quot;DiscoveryRequest&quot;);">`ToTable`</SwmToken> method is used to specify the name of the table in the database, which is <SwmToken path="src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200328140139_patient-reference-number.Designer.cs" pos="53:6:6" line-data="                    b.ToTable(&quot;DiscoveryRequest&quot;);">`DiscoveryRequest`</SwmToken>.

```c#
                    b.ToTable("DiscoveryRequest");
```

---

</SwmSnippet>

# Usage

<SwmSnippet path="/src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200408103411_UniqueTransactionId.Designer.cs" line="36">

---

## <SwmToken path="src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200408103411_UniqueTransactionId.Designer.cs" pos="14:5:5" line-data="    partial class UniqueTransactionId">`UniqueTransactionId`</SwmToken> Migration

In the <SwmToken path="src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200408103411_UniqueTransactionId.Designer.cs" pos="14:5:5" line-data="    partial class UniqueTransactionId">`UniqueTransactionId`</SwmToken> migration, the <SwmToken path="src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200408103411_UniqueTransactionId.Designer.cs" pos="36:9:9" line-data="                    b.Property&lt;string&gt;(&quot;PatientReferenceNumber&quot;)">`PatientReferenceNumber`</SwmToken> property is defined with a maximum length of 50 characters and is marked as required.

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

Similarly, in the <SwmToken path="src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200417080025_RenamingTranscationID.Designer.cs" pos="14:5:5" line-data="    partial class RenamingTranscationID">`RenamingTranscationID`</SwmToken> migration, the <SwmToken path="src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200417080025_RenamingTranscationID.Designer.cs" pos="36:9:9" line-data="                    b.Property&lt;string&gt;(&quot;PatientReferenceNumber&quot;)">`PatientReferenceNumber`</SwmToken> property is also defined with a maximum length of 50 characters and is marked as required.

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

In the <SwmToken path="src/In.ProjectEKA.HipService/Discovery/Database/Migrations/DiscoveryContextModelSnapshot.cs" pos="12:5:5" line-data="    partial class DiscoveryContextModelSnapshot : ModelSnapshot">`DiscoveryContextModelSnapshot`</SwmToken>, the <SwmToken path="src/In.ProjectEKA.HipService/Discovery/Database/Migrations/DiscoveryContextModelSnapshot.cs" pos="34:9:9" line-data="                    b.Property&lt;string&gt;(&quot;PatientReferenceNumber&quot;)">`PatientReferenceNumber`</SwmToken> property is consistently defined with a maximum length of 50 characters and is marked as required.

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

Lastly, in the <SwmToken path="src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200526172717_RenamingRequestID.Designer.cs" pos="14:5:5" line-data="    partial class RenamingRequestID">`RenamingRequestID`</SwmToken> migration, the <SwmToken path="src/In.ProjectEKA.HipService/Discovery/Database/Migrations/20200526172717_RenamingRequestID.Designer.cs" pos="36:9:9" line-data="                    b.Property&lt;string&gt;(&quot;PatientReferenceNumber&quot;)">`PatientReferenceNumber`</SwmToken> property maintains the same definition with a maximum length of 50 characters and is marked as required.

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
