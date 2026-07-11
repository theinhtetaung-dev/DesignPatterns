# Factory Design Pattern

## What is Factory Pattern?

The **Factory Pattern** (specifically, the Simple Factory idiom demonstrated here) is a creational design pattern that provides a centralized interface or class/method to handle object creation. 

It isolates the object creation logic from the client code, so that the client doesn't need to know the specific concrete class it is instantiating, but rather works through a common interface.

---

## How and When to Use

### How to Implement
A standard Simple Factory pattern comprises:
1. **Product Interface**: A common interface (e.g., `IDiscount`) defining the actions that all concrete products must implement.
2. **Concrete Products**: Different implementations of the product interface (e.g., `RegularDiscount`, `PremiumDiscount`, `VIPDiscount`).
3. **Factory Class**: A dedicated class (e.g., `DiscountFactory`) with a creation method (e.g., `GetDiscount`) that accepts an identifier (like an enum) and returns the corresponding concrete product cast to the product interface.

### When to Use
* **Varying Types of Same Object**: When you have multiple classes implementing the same interface and want to decide which one to instantiate dynamically at runtime.
* **Separation of Concerns**: When you want to decouple the instantiation process of an object from its usage.
* **Simplifying Client Code**: When creating an object involves complex setup, conditions, or configurations that shouldn't clutter the main application logic.

### Pros and Cons
| Pros | Cons |
| :--- | :--- |
| **Loose Coupling**: The client only depends on the interface, not concrete classes. | **Complexity**: Introduces additional classes and interfaces to the codebase. |
| **Centralized Creation Logic**: Easier to maintain, debug, and update instantiation logic in one place. | **OCP Violation**: Modifying the factory switch/if-else logic is often required to support new types (can be mitigated with reflection or registrations). |

---

## Testing Project Flow

This console application demonstrates the Factory pattern by calculating order discounts based on the selected customer type.

### 1. `CustomerType.cs` (Enum)
Defines the different customer tiers:
* `Regular`
* `Premium`
* `VIP`

### 2. `DiscountFactory.cs` (Factory and Products)
* **`IDiscount` Interface**: Declares `Calculate(decimal amount)` to return the discounted total.
* **Concrete Products**:
  - `RegularDiscount`: Deducts 10% (returns `amount * 0.9`).
  - `PremiumDiscount`: Deducts 20% (returns `amount * 0.8`).
  - `VIPDiscount`: Deducts 30% (returns `amount * 0.7`).
* **`DiscountFactory`**: The static helper class with the `GetDiscount(CustomerType customerType)` method. It returns the matching class using a switch expression on the customer type.

### 3. `Program.cs` (Testing Flow)
The application runs interactively using the console:
1. **Amount Input**: Prompts the user to enter the original price amount.
2. **Customer Type Selection**: Prompts the user to choose a tier (1 = Regular, 2 = Premium, 3 = VIP).
3. **Factory Resolution**: Resolves the correct discount strategy by passing the user's choice to `DiscountFactory.GetDiscount()`.
4. **Calculation & Output**: Invokes `Calculate()` on the returned strategy and displays the original amount, calculated discounted amount, and selected customer type.
