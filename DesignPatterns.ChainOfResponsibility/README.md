# Chain of Responsibility Design Pattern

## What is Chain of Responsibility Pattern?
The **Chain of Responsibility** is a behavioral pattern that passes a request through ordered handlers until one handles it.

## How and When to Use
Teller, manager, and director handlers approve increasing limits. Use it for approval flows, middleware, validation, and support escalation.

| Pros | Cons |
| :--- | :--- |
| Sender does not need to know the final handler. | A request may reach the end unhandled. |

## Testing Project Flow
`Program.cs` builds the approval chain and submits three withdrawal amounts that stop at different handlers.
