# Command Design Pattern

## What is Command Pattern?
The **Command** is a behavioral pattern that packages a request as an object.

## How and When to Use
Deposit and withdrawal commands contain execution and undo behavior. Use it for queues, audit logs, macros, and undoable operations.

| Pros | Cons |
| :--- | :--- |
| Decouples the invoker from the receiver and supports history. | Each action generally needs another class. |

## Testing Project Flow
The terminal executes two account commands, stores them, and reverses the latest withdrawal.
