---
title: System Downtime Notification Flow
---
In this document, we will explain the process of sending notifications when Bahmni or an external system is down. The process involves checking the system status, determining if a notification should be sent, and then sending the appropriate notification.

The flow involves three main steps: checking the status of Bahmni or an external system, deciding if a notification is necessary, and sending the notification if required.

Here is a high level diagram of the flow, showing only the most important functions:

```mermaid
graph TD;
      

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
