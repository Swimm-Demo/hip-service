---
title: Filtering and Returning a Patient Regardless of Name Casing
---
In this document, we will explain the process of filtering and returning a patient regardless of the casing of their name. The process involves several steps to ensure that the patient's name is matched correctly, even if the casing differs.

The flow involves checking the patient's name in a case-insensitive manner. This means that whether the name is in uppercase, lowercase, or a mix of both, the system will still be able to find and return the correct patient. This is important for ensuring that patient records are accurately retrieved without being affected by variations in name casing.

Here is a high level diagram of the flow, showing only the most important functions:

```mermaid
graph TD;
      subgraph srcInProjectEKAHipServiceDiscovery["src/In.ProjectEKA.HipService/Discovery"]
e37bd2319e70a3cc4983c64c5b1ae6c5f8548d69222487ceffab4be1c069d09a(DemographicRecords) --> e4e40037e20b250fbf5bc0601a222a04b6036f186e2660080f842e277eb01536(ExpressionFor)
end

subgraph srcInProjectEKAHipLibraryMatcherExpressionBuildercs["src/In.ProjectEKA.HipLibrary/Matcher/ExpressionBuilder.cs"]
e4e40037e20b250fbf5bc0601a222a04b6036f186e2660080f842e277eb01536(ExpressionFor) --> afa2a18b483eb7787b2c9a6f0a2d5e83ed3061f2f840d3956448249ed93096c5(And)
end

subgraph srcInProjectEKAHipServiceOpenMrsHealthCheckHealthCheckMiddlewarecs["src/In.ProjectEKA.HipService/OpenMrs/HealthCheck/HealthCheckMiddleware.cs"]
afa2a18b483eb7787b2c9a6f0a2d5e83ed3061f2f840d3956448249ed93096c5(And) --> 2262675033cc03afc2f7209990ec5d2c6c18c252ba2214f54a5af855a6fe8381(Invoke)
end


      classDef mainFlowStyle color:#000000,fill:#7CB9F4
classDef rootsStyle color:#000000,fill:#00FFF4
classDef Style1 color:#000000,fill:#00FFAA
classDef Style2 color:#000000,fill:#FFFF00
classDef Style3 color:#000000,fill:#AA7CB9
```

# Flow drill down

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>