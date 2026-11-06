# Visitor Design Pattern

## What is Visitor Pattern?
The **Visitor** is a behavioral pattern that adds operations to an object structure without changing its element classes.

## How and When to Use
Account types accept a monthly-fee visitor with type-specific calculations. Use it when element types are stable but new cross-cutting operations are frequent.

| Pros | Cons |
| :--- | :--- |
| New operations can be added without modifying elements. | Adding a new element type changes every visitor. |

## Testing Project Flow
One visitor calculates different fees for saving and business accounts through double dispatch.
