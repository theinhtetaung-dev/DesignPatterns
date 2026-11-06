# Mediator Design Pattern

## What is Mediator Pattern?
The **Mediator** is a behavioral pattern that centralizes communication between objects so they do not reference each other directly.

## How and When to Use
Accounts route transfers through `TransferMediator`. Use it when many components otherwise develop complex many-to-many dependencies.

| Pros | Cons |
| :--- | :--- |
| Reduces coupling between colleagues. | The mediator can become overly large. |

## Testing Project Flow
The sender asks the mediator to find and notify the receiver for a transfer.
