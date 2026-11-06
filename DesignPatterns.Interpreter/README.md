# Interpreter Design Pattern

## What is Interpreter Pattern?
The **Interpreter** is a behavioral pattern that represents grammar rules as objects and evaluates expressions in a context.

## How and When to Use
Customer type and minimum amount expressions combine into a fee-waiver rule. Use it for small, stable rule languages; use a parser for complex grammars.

| Pros | Cons |
| :--- | :--- |
| Rules are composable and easy to extend. | Large grammars create many classes and can be slow. |

## Testing Project Flow
The sample interprets `VIP AND amount >= 100000` against one transaction context.
