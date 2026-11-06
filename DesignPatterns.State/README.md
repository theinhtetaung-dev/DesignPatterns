# State Design Pattern

## What is State Pattern?
The **State** is a behavioral pattern that lets an object change behavior when its internal state changes.

## How and When to Use
A transfer delegates processing to pending, processing, and completed state objects. Use it when large conditionals depend on lifecycle state.

| Pros | Cons |
| :--- | :--- |
| Localizes state behavior and transitions. | Small workflows may gain unnecessary classes. |

## Testing Project Flow
Three `Process()` calls advance the transfer and demonstrate completed-state behavior.
