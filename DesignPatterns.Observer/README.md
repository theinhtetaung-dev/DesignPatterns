# Observer Design Pattern

## What is Observer?

The **Observer** is a behavioral design pattern that lets you define a subscription mechanism to notify multiple objects about any events that happen to the object they're observing.

It establishes a one-to-many dependency between a source object (the **Subject** or **Publisher**) and multiple dependent objects (the **Observers** or **Subscribers**). When the Subject's state changes, all its Observers are automatically notified and updated.

---

## How and When to Use

### How to Implement
A typical Observer implementation consists of:
1. **Subject (Publisher) Interface/Class**: Declares methods to attach, detach, and notify observers. It maintains a list of references to its observers.
2. **Observer (Subscriber) Interface**: Declares a notification method (e.g., `Update`) that the subject invokes to push changes.
3. **Concrete Subject**: Stores the state of interest to observers. It sends notifications to its subscribers when its state changes.
4. **Concrete Observers**: Implement the Observer interface and register themselves with the Subject to receive and process updates.

### When to Use
* **Event-Driven Communication**: When an event in one object requires updating other objects, and you don't know in advance how many objects need to change.
* **Loose Coupling**: When an object must notify others without knowing their concrete implementations.
* **Component Synchronization**: When a GUI component needs to update its view state based on changes to an underlying data model.

### Pros and Cons
| Pros | Cons |
| :--- | :--- |
| **OCP Support**: You can introduce new subscriber classes without having to change the publisher's code. | **Random Order**: Observers are notified in no specific order, which can cause synchronization issues if not managed. |
| **Dynamic Relationships**: Relationships between publishers and subscribers can be established or terminated dynamically at runtime. | **Memory Leaks**: Failing to unsubscribe observers can lead to memory leaks (dangling references) because the publisher keeps holding references to them. |

---

## Testing Project Flow

> [!NOTE]
> This project currently serves as a clean console template for demonstrating the Observer design pattern.

### 1. `Program.cs`
A standard C# console template entry point (`Console.WriteLine("Hello, World!")`) representing the starting point for implementing the observer-subject relationship.
