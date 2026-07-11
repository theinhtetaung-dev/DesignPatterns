# Builder Design Pattern

## What is Builder Pattern?

The **Builder** is a creational design pattern that allows you to construct complex objects step by step. 

It solves the "Telescoping Constructor" problem (constructors with a long list of parameters, many of which are optional or default) by breaking down the object construction into a series of clean, readable method calls. 

---

## How and When to Use

### How to Implement
A typical Builder implementation consists of:
1. **Product Class**: The class representing the complex object being built (e.g., `Transaction`).
2. **Builder Class**: A class (e.g., `TransactionBuilder`) containing:
   - A private reference to the product being built.
   - Step-by-step methods to configure each property. These methods return `this` (the builder instance) to enable a **fluent interface** (method chaining).
   - A `Build()` method that returns the fully configured product.

### When to Use
* **Complex Constructors**: When a class has a large number of fields or optional configuration parameters.
* **Fluent Interfaces**: When you want to make object instantiation highly readable and descriptive.
* **Different Configurations**: When the same construction process must support different configurations of the product (e.g., domestic vs. international transactions).

### Pros and Cons
| Pros | Cons |
| :--- | :--- |
| **Readability**: Promotes clean, self-documenting code using method chaining. | **Boilerplate**: Requires creating and maintaining a separate builder class for every product. |
| **Immutability Support**: Allows building objects step-by-step and keeping the final product read-only once constructed. | **Class Duplication**: Code size increases due to the builder companion class. |
| **Controlled Construction**: You can defer steps or run steps conditionally. | |

---

## Testing Project Flow

This repository contains a C# console application that uses the Builder pattern to configure and execute financial transactions.

### 1. `Transaction.cs` (Product)
Represents a transaction record with properties like `TransactionId`, `FromAccount`, `ToAccount`, `Amount`, `Currency`, `Note`, `TransferFee`, and `ScheduledDate`. It has an `Execute()` method that prints the transaction's state to the console.

### 2. `TransactionBuilder.cs` (Builder)
* Instantiates a private `Transaction` object inside its constructor.
* Assigns sensible default values during construction (e.g., generating a new `Guid` for `TransactionId`, defaulting `Currency` to `"MMK"`, and setting `TransferFee` to `0`).
* Offers fluent chaining methods like `FromAccount()`, `ToAccount()`, `Amount()`, `Currency()`, `Note()`, and `TransferFee()`.
* Implements `Build()` to retrieve the configured `Transaction` instance.

### 3. `Program.cs` (Testing Flow)
The console app runs two different transaction test cases:
1. **Local MMK Transaction**:
   - Chaining is used to define only `FromAccount`, `ToAccount`, `Amount`, and a `Note`.
   - The currency and transfer fee automatically default to `"MMK"` and `0` respectively.
2. **International USD Transaction**:
   - Overrides default values by explicitly setting `.Currency("USD")` and `.TransferFee(2.5m)`.
   - Demonstrates the flexibility of configuring only the fields needed for an international transfer.
