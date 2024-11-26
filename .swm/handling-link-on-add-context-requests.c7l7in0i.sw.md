---
title: Handling Link On-Add-Context Requests
---
In this document, we will explain the process of handling a link <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkController.cs" pos="158:8:12" line-data="            Log.Information(&quot;Link on-add-context received.&quot; +">`on-add-context`</SwmToken> request. The process involves logging the receipt of the request, checking for errors, and verifying and linking care contexts if the acknowledgment status is successful.

The flow starts by logging the receipt of a link <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkController.cs" pos="158:8:12" line-data="            Log.Information(&quot;Link on-add-context received.&quot; +">`on-add-context`</SwmToken> request. It then checks if there are any errors in the confirmation. If there are errors, it logs the error code and message. If the confirmation contains an acknowledgment with a success status, it proceeds to verify and link care contexts. Finally, it logs the acknowledgment status.

# Flow drill down

```mermaid
graph TD;
      subgraph srcInProjectEKAHipServiceLink["src/In.ProjectEKA.HipService/Link"]
8f89ac6d70760bf13e795cda7de5d09657a1a2c1a801dcc05915a52efa2705b3(HipLinkOnAddContexts) --> fd22a2c8c2dcf692f1a6c01c29abf0e959ba3a5e56ce2eb603c0dc34285a46c8(VerifyAndLinkCareContexts)
end

subgraph srcInProjectEKAHipServiceOpenMrs["src/In.ProjectEKA.HipService/OpenMrs"]
fd22a2c8c2dcf692f1a6c01c29abf0e959ba3a5e56ce2eb603c0dc34285a46c8(VerifyAndLinkCareContexts) --> dd70669797c818b313d9a11e817dc9ed83b93f37739339c86521cb905bd3dcae(PatientWithAsync)
end

subgraph srcInProjectEKAHipServiceOpenMrs["src/In.ProjectEKA.HipService/OpenMrs"]
dd70669797c818b313d9a11e817dc9ed83b93f37739339c86521cb905bd3dcae(PatientWithAsync) --> bc8341f884da0777a1cb7088037bd750965dfa48508b07c3fef1dafb683bb701(GetCareContexts)
end


      classDef mainFlowStyle color:#000000,fill:#7CB9F4
classDef rootsStyle color:#000000,fill:#00FFF4
classDef Style1 color:#000000,fill:#00FFAA
classDef Style2 color:#000000,fill:#FFFF00
classDef Style3 color:#000000,fill:#AA7CB9
```

<SwmSnippet path="/src/In.ProjectEKA.HipService/Link/LinkController.cs" line="155">

---

## <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkController.cs" pos="156:10:10" line-data="        public async Task&lt;AcceptedResult&gt; HipLinkOnAddContexts(HipLinkContextConfirmation confirmation)">`HipLinkOnAddContexts`</SwmToken>

First, the <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkController.cs" pos="156:10:10" line-data="        public async Task&lt;AcceptedResult&gt; HipLinkOnAddContexts(HipLinkContextConfirmation confirmation)">`HipLinkOnAddContexts`</SwmToken> method logs the receipt of a link <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkController.cs" pos="158:8:12" line-data="            Log.Information(&quot;Link on-add-context received.&quot; +">`on-add-context`</SwmToken> request and checks for any errors in the confirmation. If the confirmation contains an acknowledgment with a success status, it proceeds to verify and link care contexts using the <SwmToken path="src/In.ProjectEKA.HipService/Link/LinkController.cs" pos="169:5:5" line-data="                        await linkPatient.VerifyAndLinkCareContexts(confirmation.Resp.RequestId);">`VerifyAndLinkCareContexts`</SwmToken> method.

```c#
        [HttpPost(PATH_ON_ADD_CONTEXTS)]
        public async Task<AcceptedResult> HipLinkOnAddContexts(HipLinkContextConfirmation confirmation)
        {
            Log.Information("Link on-add-context received." +
                            $" RequestId:{confirmation.RequestId}, " +
                            $" Timestamp:{confirmation.Timestamp}");
            if (confirmation.Error != null)
                Log.Information($" Error Code:{confirmation.Error.Code}," +
                                $" Error Message:{confirmation.Error.Message}");
            else if (confirmation.Acknowledgement != null)
            {
                if (confirmation.Acknowledgement.Status.Equals(Status.SUCCESS.ToString()))
                {
                    var error =
                        await linkPatient.VerifyAndLinkCareContexts(confirmation.Resp.RequestId);
                    if (error != null)
                    {
                        Log.Error(error);
                    }
                }
                Log.Information($" Acknowledgment Status:{confirmation.Acknowledgement.Status}");
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
