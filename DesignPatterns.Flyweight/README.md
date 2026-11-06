# Flyweight Design Pattern

## What is Flyweight Pattern?
The **Flyweight** is a structural pattern that saves memory by sharing immutable, repeating state across many objects.

## How and When to Use
The factory caches currency and symbol data while each call supplies its own amount and branch. Use it when an application holds a very large number of similar objects.

| Pros | Cons |
| :--- | :--- |
| Reduces duplicate memory usage. | Shared and unique state must be separated carefully. |

## Testing Project Flow
Three amounts use only two shared `CurrencyFormatter` instances, as shown by the final cache count.
