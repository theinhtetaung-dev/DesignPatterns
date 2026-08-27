# Composite Design Pattern

## What is Composite?

The **Composite** is a structural design pattern that lets you compose objects into tree structures to represent part-whole hierarchies. 

Composite allows clients to treat individual objects (leaves) and compositions of objects (composites) uniformly.

---

## How and When to Use

### How to Implement
A typical Composite implementation consists of:
1. **Component Interface**: An interface (`IBankAccount`) declaring operations common to both simple and complex elements of the tree structure.
2. **Leaf Class**: A class representing the basic, end-elements of the tree that do not have children (e.g., `SavingAccount`, `CheckingAccount`). It implements the Component interface.
3. **Composite Class**: A class representing containers or complex elements that can have children (e.g., `AccountPortfolio`). It implements the Component interface and adds methods to manage child components, delegating work to them.

### When to Use
* **Hierarchical Tree Structures**: When you need to represent objects that contain other objects of similar types (e.g., file systems, organization charts, nested menus).
* **Uniform Client Interaction**: When client code should ignore the difference between individual objects and collections of objects, treating them all through a single interface.

### Pros and Cons
| Pros | Cons |
| :--- | :--- |
| **Polymorphism**: Simplifies client code by allowing it to operate on a tree structure uniformly. | **Over-generalization**: It can be difficult to define a clean interface that fits every leaf and composite type. |
| **OCP Support**: You can add new leaf or composite types to the tree without altering existing client code. | **Interface Restrictions**: Certain actions might make sense for leaves but not for composites (or vice versa), requiring runtime checks or placeholder implementations. |

---

## Testing Project Flow

This console application demonstrates the Composite pattern by structuring bank accounts into a nested portfolio hierarchy.

### 1. `IBankAccount.cs` (Component)
The base interface defining common account methods: `GetBalance()`, `Deposit()`, and `Withdraw()`.

### 2. `IAccountPortfolio.cs` (Composite Interface)
Extends `IBankAccount` and adds child management methods: `Add()`, `Remove()`, and `GetChildren()`.

### 3. Leaf Accounts (`SavingAccount.cs` & `CheckingAccount.cs`)
Concrete classes representing individual bank accounts. They implement the standard transactions directly modifying their own balance.

### 4. `AccountPortfolio.cs` (Composite)
* Implements `IAccountPortfolio`.
* Aggregates a collection of child `IBankAccount` objects (which can be either leaf accounts or other portfolios).
* Implements `GetBalance()` by dynamically summing the balances of all its children.
* Rejects direct `Deposit` and `Withdraw` actions since financial transactions must occur at the individual account level.

### 5. `Program.cs` (Testing Flow)
The application executes the following operations:
1. **Creates Leaf Accounts**: Sets up saving and checking accounts with initial deposits.
2. **Builds the Hierarchy**:
   - Adds `saving1` and `checking1` to a "Personal Portfolio".
   - Adds `saving2` to a "Business Portfolio".
   - Embeds both portfolios inside a "Main Portfolio".
3. **Executes Uniform Queries**: Calls `GetBalance()` on the "Main Portfolio" to show it correctly sums up the entire hierarchy recursively.
4. **Validates Separation**: Demonstrates that direct transaction attempts on portfolios are rejected, while updates to nested leaf accounts instantly propagate to parent portfolios.
