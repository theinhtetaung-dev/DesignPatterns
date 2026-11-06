# Iterator Design Pattern

## What is Iterator Pattern?
The **Iterator** is a behavioral pattern that traverses a collection without exposing its internal representation.

## How and When to Use
`TransactionHistory` implements `IEnumerable<Transaction>` and yields newest entries first. Use it to provide a stable custom traversal over a collection.

| Pros | Cons |
| :--- | :--- |
| Hides storage details and supports custom traversal. | Simple collections may not need a custom iterator. |

## Testing Project Flow
`Program.cs` adds two transactions and consumes the history with a normal `foreach` loop.
