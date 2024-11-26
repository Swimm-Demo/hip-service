---
title: Filtering and Returning Patient Information
---
This document explains the process of filtering and returning a patient's information based on verified identifiers, gender, age, and name. The process involves several key steps to ensure accurate and relevant patient data is retrieved.

The flow starts with accessing demographic records, which contain patient information. These records are then processed to create expressions that match specific criteria such as verified identifiers, gender, age, and name. The expressions are combined using logical operations to refine the search. Finally, the refined search results are used to invoke the necessary functions to return the filtered patient information.

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
