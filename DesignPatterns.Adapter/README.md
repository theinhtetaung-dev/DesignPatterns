# Adapter Design Pattern

## What is Adapter?

The **Adapter** is a structural design pattern that allows objects with incompatible interfaces to collaborate.

It acts as a wrapper between two objects. It catches calls for one object and translates/converts them into a format and interface recognizable by the second object.

---

## How and When to Use

### How to Implement
A typical Adapter implementation consists of:
1. **Target Interface**: The interface (`IPayment`) that the client code expects and uses to interact with services.
2. **Adaptee Class**: The class (`ThirdPartyPayment`) containing the useful functionality but with a different, incompatible interface that cannot be directly used by the client.
3. **Adapter Class**: A class (`PaymemtAdapter`) that implements the Target interface and wraps the Adaptee instance. It translates the incoming client calls into the format required by the Adaptee.

### When to Use
* **Incompatible Libraries**: When you want to use an existing class or third-party service, but its interface does not match the rest of your application's code.
* **Legacy Code Integration**: When integrating legacy classes that cannot be modified directly but must be used under a newer interface.
* **Unified Interface**: When you want to create a reusable component that cooperates with multiple unrelated classes sharing different interfaces.

### Pros and Cons
| Pros | Cons |
| :--- | :--- |
| **SRP Support**: Separates the interface/data conversion logic from the main application flow. | **Code Complexity**: Increases overall code size and complexity by introducing new interfaces and classes. |
| **OCP Support**: Allows introducing new adapters into the program without breaking the existing client code. | **Direct Modification Alternative**: Sometimes it is cleaner to refactor the adaptee class directly, if its source code is accessible. |

---

## Testing Project Flow

This console application demonstrates the Adapter pattern by integrating a third-party payment service under a unified local payment interface.

### 1. `IPayment.cs` (Target Interface)
Declares the contract `Pay(string phoneNo, decimal amount)` that the internal payment system uses.

### 2. `SystemPayment.cs` (Concrete Implementation)
A standard implementation of `IPayment` that processes payments directly using the application's native structure.

### 3. `ThirdPartyPayment.cs` (Adaptee)
A third-party payment service with an incompatible signature: `Pay(string phoneNo, float amount, string crrency, string note)`. It requires parameters of different types (such as `float` for amount) and extra metadata strings.

### 4. `PaymemtAdapter.cs` (Adapter)
* Implements the `IPayment` interface.
* Wraps an instance of `ThirdPartyPayment`.
* Adapts the `Pay` call by casting the `decimal amount` to `float` and passing default values for currency (`"MMK"`) and note (`"Payment"`).

### 5. `Program.cs` (Testing Flow)
The application runs three scenarios:
1. **Direct native payment**: Calls `Pay` on `SystemPayment`.
2. **Direct third-party payment**: Calls `Pay` directly on `ThirdPartyPayment`, requiring the developer to pass explicit arguments and handle different types manually.
3. **Adapted third-party payment**: Uses the `PaymemtAdapter` as an `IPayment` instance, demonstrating that the client can now treat the third-party system identically to the native one.
