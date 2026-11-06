# Abstract Factory Design Pattern

## What is Abstract Factory Pattern?
The **Abstract Factory** is a creational pattern that creates families of related objects without exposing their concrete classes.

## How and When to Use
`IBankingUiFactory` creates matching login and transfer views for mobile or web. Use it when products must be used as a compatible family and the client should be platform-independent.

| Pros | Cons |
| :--- | :--- |
| Keeps product families consistent and client code decoupled. | Adding a new product type changes every factory. |

## Testing Project Flow
`Program.cs` builds the same banking application with mobile and web factories and renders each related view family.
