# Prototype Design Pattern

## What is Prototype Pattern?
The **Prototype** is a creational pattern that creates new objects by copying an existing configured object.

## How and When to Use
`TransferTemplate.Clone()` copies scalar values and creates a new tags list. Use it when setup is expensive or many objects begin from the same configuration.

| Pros | Cons |
| :--- | :--- |
| Avoids repeated initialization. | Deep and shallow copy rules require care. |

## Testing Project Flow
`Program.cs` clones a salary template, customizes the copy, and shows that its mutable tags do not change the original.
