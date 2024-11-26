---
title: The Log class
---
This document will provide an overview of the <SwmToken path="src/In.ProjectEKA.HipService/Logger/Log.cs" pos="9:3:3" line-data="            Serilog.Log.Information(format, arg);">`Log`</SwmToken> class. We will cover:

1. What the <SwmToken path="src/In.ProjectEKA.HipService/Logger/Log.cs" pos="9:3:3" line-data="            Serilog.Log.Information(format, arg);">`Log`</SwmToken> class is and what it is used for.
2. The variables and functions defined in the <SwmToken path="src/In.ProjectEKA.HipService/Logger/Log.cs" pos="9:3:3" line-data="            Serilog.Log.Information(format, arg);">`Log`</SwmToken> class.

# Variables and functions

# What is Log

The <SwmToken path="src/In.ProjectEKA.HipService/Logger/Log.cs" pos="9:3:3" line-data="            Serilog.Log.Information(format, arg);">`Log`</SwmToken> class in <SwmPath>[src/In.ProjectEKA.HipService/Logger/Log.cs](src/In.ProjectEKA.HipService/Logger/Log.cs)</SwmPath> is a static class used for logging information, errors, and fatal exceptions in the application. It leverages the Serilog library to log messages in a structured and efficient manner.

<SwmSnippet path="/src/In.ProjectEKA.HipService/Logger/Log.cs" line="7">

---

The function <SwmToken path="src/In.ProjectEKA.HipService/Logger/Log.cs" pos="7:7:7" line-data="        public static void Information(string format, params object[] arg)">`Information`</SwmToken> is used to log informational messages. It takes a format string and an array of objects as arguments and logs the message using Serilog.

```c#
        public static void Information(string format, params object[] arg)
        {
            Serilog.Log.Information(format, arg);
        }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Logger/Log.cs" line="12">

---

The function <SwmToken path="src/In.ProjectEKA.HipService/Logger/Log.cs" pos="12:7:7" line-data="        public static void Error(string format, params object[] arg)">`Error`</SwmToken> is used to log error messages. It takes a format string and an array of objects as arguments and logs the message using Serilog.

```c#
        public static void Error(string format, params object[] arg)
        {
            Serilog.Log.Error(format, arg);
        }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Logger/Log.cs" line="17">

---

The function <SwmToken path="src/In.ProjectEKA.HipService/Logger/Log.cs" pos="17:7:7" line-data="        public static void Fatal(Exception exception, string format, params object[] arg)">`Fatal`</SwmToken> is used to log fatal exceptions. It takes an exception, a format string, and an array of objects as arguments and logs the message using Serilog.

```c#
        public static void Fatal(Exception exception, string format, params object[] arg)
        {
            Serilog.Log.Error(exception, format, arg);
        }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Logger/Log.cs" line="22">

---

The function <SwmToken path="src/In.ProjectEKA.HipService/Logger/Log.cs" pos="22:7:7" line-data="        public static void Error(params object[] arg)">`Error`</SwmToken> is an overloaded method used to log error messages with a predefined template. It takes an array of objects as arguments and logs the message using Serilog.

```c#
        public static void Error(params object[] arg)
        {
            Serilog.Log.Error(LogTemplate.ErrorTemplate, arg);
        }
```

---

</SwmSnippet>

<SwmSnippet path="/src/In.ProjectEKA.HipService/Logger/Log.cs" line="27">

---

The function <SwmToken path="src/In.ProjectEKA.HipService/Logger/Log.cs" pos="27:7:7" line-data="        public static void Fatal(Exception exception, params object[] arg)">`Fatal`</SwmToken> is an overloaded method used to log fatal exceptions with a predefined template. It takes an exception and an array of objects as arguments and logs the message using Serilog.

```c#
        public static void Fatal(Exception exception, params object[] arg)
        {
            Serilog.Log.Error(exception, LogTemplate.ExceptionTemplate, arg);
        }
```

---

</SwmSnippet>

# Usage

<SwmSnippet path="/src/In.ProjectEKA.HipService/Program.cs" line="20">

---

## <SwmPath>[src/In.ProjectEKA.HipService/Program.cs](src/In.ProjectEKA.HipService/Program.cs)</SwmPath>

In <SwmPath>[src/In.ProjectEKA.HipService/Program.cs](src/In.ProjectEKA.HipService/Program.cs)</SwmPath>, the <SwmToken path="src/In.ProjectEKA.HipService/Program.cs" pos="23:1:1" line-data="            Log.Logger = CreateLogger(host);">`Log`</SwmToken> class is used to create and configure the logger for the application. It logs the start of the application, handles any exceptions that occur during the application's execution, and ensures that the logger is properly closed and flushed when the application terminates.

```c#
            if (host is null)
                throw new ArgumentNullException(nameof(host));

            Log.Logger = CreateLogger(host);
            try
            {
                Log.Information("Started application");
                host.Run();
            }
#pragma warning disable CA1031 // Do not catch general exception types
            catch (Exception exception)
#pragma warning restore CA1031 // Do not catch general exception types
            {
                Log.Fatal(exception, "Application terminated unexpectedly");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
