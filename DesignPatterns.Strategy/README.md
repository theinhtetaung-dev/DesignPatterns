# Strategy Design Pattern

## What is Strategy Pattern?
The **Strategy** is a behavioral pattern that places interchangeable algorithms behind one interface.

## How and When to Use
`TransferFeeCalculator` switches between local and international fee algorithms at runtime. Use it when behavior varies independently from its client.

| Pros | Cons |
| :--- | :--- |
| Removes algorithm conditionals and supports runtime selection. | Clients must understand available strategies. |

## Testing Project Flow
The same calculator evaluates an amount using two fee strategies.
