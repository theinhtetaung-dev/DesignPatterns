# Decorator Design Pattern

## What is Decorator?

The **Decorator** is a structural design pattern that lets you attach new behaviors to objects dynamically by placing these objects inside special wrapper objects that contain the behaviors.

It provides a flexible alternative to subclassing for extending functionality, avoiding a combinational explosion of subclasses when combining optional features.

---

## How and When to Use

### How to Implement
A typical Decorator implementation consists of:
1. **Component Interface**: An interface (`IDataPlan`) that defines the common operations for both the basic object and its wrappers.
2. **Concrete Component**: A class (`DataPlan`) that represents the base object whose behavior can be decorated.
3. **Base Decorator**: An abstract class (`DataPlanDecorator`) that implements the Component interface and holds a reference to a wrapped Component. It forwards all calls to the wrapped object.
4. **Concrete Decorators**: Classes (`FaceBookPlan`, `TikTokPlan`, `AWaThonePlan`) that extend the base decorator to add extra features or modify values before/after delegating the calls.

### When to Use
* **Dynamic Behavior Addition**: When you want to add or remove responsibilities from individual objects at runtime without affecting other instances.
* **Avoid Inheritance Explosion**: When inheritance would result in an excessive number of subclasses to support every combination of features.
* **Component Composition**: When you want to compose complex object behaviors from simple, focused building blocks.

### Pros and Cons
| Pros | Cons |
| :--- | :--- |
| **High Flexibility**: Allows combining multiple behaviors by wrapping an object in several decorators. | **Wrapper Complexity**: It can be difficult to remove a specific decorator from the middle of a nested wrapper stack. |
| **SRP Support**: Splittable into single-purpose wrapper classes rather than having one class do everything. | **Ordering Dependencies**: The order of decoration might matter, which can make setup code sensitive. |
| **Runtime Control**: Behaviors can be added or stripped away dynamically as needed. | **Readability**: Debugging nested decorators can be confusing because stack traces flow through multiple wrapper layers. |

---

## Testing Project Flow

This console application demonstrates the Decorator pattern by dynamically wrapping a base mobile data plan with various social media packages and calculating their combined cost and description.

### 1. `IDataPlan.cs` (Component)
The interface defining the contract with `GetPlanName()` and `GetCost()`.

### 2. `DataPlan.cs` (Concrete Component)
The starting point representing a basic internet data package with a fixed plan name and base cost.

### 3. `DataPlanDecorator.cs` (Base Decorator)
An abstract class implementing `IDataPlan`. It wraps a reference to another `IDataPlan` object and redirects calls to it.

### 4. Concrete Decorators (`FaceBookPlan.cs`, `TikTokPlan.cs`, & `AWaThonePlan.cs`)
These classes extend `DataPlanDecorator` to override and append their respective features:
* **`FaceBookPlan`**: Appends `+ Unlimited Facebook (2 Days)` to the plan name and adds `1000.00 MMK` to the cost.
* **`TikTokPlan`**: Appends `+ Unlimited TikTok (2 Days)` to the plan name and adds `1500.00 MMK` to the cost.
* **`AWaThonePlan`**: Appends `+ A Wa Thone Pack` to the plan name and adds `500.00 MMK` to the cost.

### 5. `Program.cs` (Testing Flow)
The project demonstrates two customer flows:
1. **Incremental Decoration**:
   - Customer 1 starts with a standard "Basic Data Plan 1 GB".
   - It is decorated with `FaceBookPlan`.
   - It is further decorated with `TikTokPlan`, displaying the updated plan description and cumulative cost at each stage.
2. **Deep Nesting**:
   - Customer 2 instantiates a "Basic Data Plan 2 GB" wrapped simultaneously in multiple decorators: `new TikTokPlan(new FaceBookPlan(new AWaThonePlan(dataPlan1)))`.
   - Verifies the recursive accumulation of descriptions and total price.
