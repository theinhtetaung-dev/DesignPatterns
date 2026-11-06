# Bridge Design Pattern

## What is Bridge Pattern?
The **Bridge** is a structural pattern that separates an abstraction from its implementation so both can vary independently.

## How and When to Use
`Notification` is the abstraction and `IMessageSender` is its implementation bridge. Use it to avoid a class for every notification-type and delivery-channel combination.

| Pros | Cons |
| :--- | :--- |
| Both dimensions can grow independently. | Introduces an extra abstraction layer. |

## Testing Project Flow
The sample sends a transaction alert through SMS and a security alert through email.
