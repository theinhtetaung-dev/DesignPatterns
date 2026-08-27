# Facade Design Pattern

## What is Facade?

The **Facade** is a structural design pattern that provides a simplified interface to a complex system, library, framework, or set of classes.

It hides the complexities of the underlying subsystems and provides a clean, unified entry point, reducing direct dependencies and coupling between the client code and the internal system details.

---

## How and When to Use

### How to Implement
A typical Facade implementation consists of:
1. **Facade Class**: A class (`OrderFacade`) that orchestrates the execution flow of multiple subsystems. It exposes simple, high-level methods to the client and delegates the actual work to subsystem instances.
2. **Subsystems**: A set of classes (`InventoryService`, `PaymentService`, `DeliveryService`) that implement specialized features. They are independent of each other and of the facade.

### When to Use
* **Complex Subsystem APIs**: When you want to provide a simple, unified interface for a complex library or ecosystem of classes.
* **Layering**: When you want to structure your subsystems into layers, using facades to act as entry points for each level.
* **Decoupling**: When you want to minimize dependencies between the client code and inner workings of services, allowing them to evolve independently.

### Pros and Cons
| Pros | Cons |
| :--- | :--- |
| **System Decoupling**: Clients are isolated from the internal components of subsystems. | **God Object Risk**: A facade can easily become a "god object" closely coupled to every class in the application if not scoped correctly. |
| **Simplified Usage**: Clients need to call only a single method instead of managing multiple subsystem steps and dependencies. | **Customization Limits**: Clients that need to perform customized or rare subsystem flows might still have to bypass the facade. |

---

## Testing Project Flow

This console application demonstrates the Facade pattern by wrapping an e-commerce order workflow (checking inventory, updating stock, verifying payments, and scheduling deliveries) under a single facade class.

### 1. Subsystem Services
* **`Inventory/InventoryService.cs`**: Handles checking and updating stock levels for products.
* **`Payment/PaymentService.cs`**: Simulates verifying client balance and processing transactions.
* **`Delivery/DeliveryService.cs`**: Manages scheduling shipments to physical addresses.

### 2. `OrderFacade.cs` (Facade)
* Accepts instances of `InventoryService`, `PaymentService`, and `DeliveryService` via its constructor.
* Implements `PlaceOrder(string productName, int quantity, string mobileNo, decimal amount, string address)`.
* Employs `TransactionScope` to ensure atomic, transactional operations:
  1. Checks stock availability.
  2. Updates inventory numbers.
  3. Processes the payment. If the payment fails, it aborts the process and rolls back.
  4. Triggers delivery routing.
  5. Completes the transaction scope.

### 3. `Program.cs` (Testing Flow)
The application starts by initializing the individual subsystem dependencies. It then builds the `OrderFacade` and executes a single call to `PlaceOrder()`, verifying that all subsystem actions occur sequentially and safely.
