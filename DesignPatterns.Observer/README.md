# Observer Design Pattern

## What is Observer Pattern?

The **Observer** is a behavioral pattern that defines a one-to-many subscription relationship. When the subject changes, every registered observer is notified without depending on concrete notification classes.

## How and When to Use

The sample contains a `BankAccount` subject, an `IAccountObserver` contract, and SMS and email observers. Use Observer for event notifications, UI updates, and cases where subscribers must be attached or removed at runtime.

| Pros | Cons |
| :--- | :--- |
| Publishers and subscribers remain loosely coupled. | Notification order and error handling require care. |
| Subscribers can be added without changing the publisher. | Forgotten subscriptions can cause memory leaks. |

## Testing Project Flow

`Program.cs` registers two observers. Deposit and withdrawal operations automatically send the same account event to both.
