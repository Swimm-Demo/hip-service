---
title: DateRange Model Overview
---
## What is <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DateRange.cs" pos="3:5:5" line-data="    public class DateRange">`DateRange`</SwmToken>

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DateRange.cs" pos="3:5:5" line-data="    public class DateRange">`DateRange`</SwmToken> class is a model that represents a range of dates with a start date and an end date. It has two properties, `From` and <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DateRange.cs" pos="8:1:1" line-data="            To = to;">`To`</SwmToken>, which store the start and end dates of the range respectively. The constructor of the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DateRange.cs" pos="3:5:5" line-data="    public class DateRange">`DateRange`</SwmToken> class initializes these properties with the provided start and end dates.

## How to use <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DateRange.cs" pos="3:5:5" line-data="    public class DateRange">`DateRange`</SwmToken>

To use the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DateRange.cs" pos="3:5:5" line-data="    public class DateRange">`DateRange`</SwmToken> class, you need to create an instance of it by providing the start and end dates as parameters to its constructor. For example, `var dateRange = new DateRange("2021-01-01", "2021-12-31");` will create a <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DateRange.cs" pos="3:5:5" line-data="    public class DateRange">`DateRange`</SwmToken> object representing the entire year of 2021.

## Example Usage

This code snippet shows the definition of the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DateRange.cs" pos="3:5:5" line-data="    public class DateRange">`DateRange`</SwmToken> class and its constructor, which initializes the `From` and <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DateRange.cs" pos="8:1:1" line-data="            To = to;">`To`</SwmToken> properties with the provided start and end dates.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/DateRange.cs" line="3">

---

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DateRange.cs" pos="3:5:5" line-data="    public class DateRange">`DateRange`</SwmToken> class definition and its constructor.

```c#
    public class DateRange
    {
        public DateRange(string from, string to)
        {
            From = from;
            To = to;
        }
```

---

</SwmSnippet>

## Main Functions

There are several main functions in this class. Some of them are the constructor, From, and To. We will dive a little into each of them.

### Constructor

The constructor of the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DateRange.cs" pos="3:5:5" line-data="    public class DateRange">`DateRange`</SwmToken> class initializes the `From` and <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DateRange.cs" pos="8:1:1" line-data="            To = to;">`To`</SwmToken> properties with the provided start and end dates.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/DateRange.cs" line="5">

---

The constructor of the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DateRange.cs" pos="5:3:3" line-data="        public DateRange(string from, string to)">`DateRange`</SwmToken> class.

```c#
        public DateRange(string from, string to)
        {
            From = from;
            To = to;
        }
```

---

</SwmSnippet>

### From

The `From` property stores the start date of the date range.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/DateRange.cs" line="11">

---

The `From` property of the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DateRange.cs" pos="3:5:5" line-data="    public class DateRange">`DateRange`</SwmToken> class.

```c#
        public string From { get; }
```

---

</SwmSnippet>

### To

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DateRange.cs" pos="8:1:1" line-data="            To = to;">`To`</SwmToken> property stores the end date of the date range.

<SwmSnippet path="/src/In.ProjectEKA.HipLibrary/Patient/Model/DateRange.cs" line="13">

---

The <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DateRange.cs" pos="13:5:5" line-data="        public string To { get; }">`To`</SwmToken> property of the <SwmToken path="src/In.ProjectEKA.HipLibrary/Patient/Model/DateRange.cs" pos="3:5:5" line-data="    public class DateRange">`DateRange`</SwmToken> class.

```c#
        public string To { get; }
```

---

</SwmSnippet>

&nbsp;

*This is an auto-generated document by Swimm 🌊 and has not yet been verified by a human*

<SwmMeta version="3.0.0" repo-id="Z2l0aHViJTNBJTNBaGlwLXNlcnZpY2UlM0ElM0FTd2ltbS1EZW1v" repo-name="hip-service"><sup>Powered by [Swimm](/)</sup></SwmMeta>
