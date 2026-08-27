# Proxy Design Pattern

## What is Proxy?

The **Proxy** is a structural design pattern that lets you provide a substitute or placeholder for another object. 

A proxy controls access to the original object, allowing you to perform checks, logging, caching, or lazy initialization either before or after the request reaches the original object.

---

## How and When to Use

### How to Implement
A typical Proxy implementation consists of:
1. **Service Interface**: An interface (`IBankAccount`) declaring common operations shared by both the real service and the proxy.
2. **Real Service**: A class (`BankAccount`) that implements the Service Interface and contains the core business logic.
3. **Proxy Class**: A class (`BankAccountProxy`) that implements the Service Interface and holds a reference to a Real Service object. It intercept calls, performs specific tasks (e.g., authorization), and forwards valid requests to the Real Service.

### When to Use
* **Access Control (Protection Proxy)**: When you want to restrict access to a resource only to authorized clients (e.g., verifying an OTP before allowing bank transactions).
* **Lazy Initialization (Virtual Proxy)**: When you want to delay the instantiation of a resource-heavy service object until it is actually needed.
* **Logging and Auditing**: When you want to log details about clients' requests to the service object before executing them.
* **Caching**: When you want to store results of expensive service calls to reuse them for subsequent requests.

### Pros and Cons
| Pros | Cons |
| :--- | :--- |
| **Controlled Access**: You can control the lifecycle and accessibility of the real service object without modifying its core code. | **Code Complexity**: Introduces new interfaces and classes, which might complicate the architecture. |
| **Separation of Concerns**: Allows authorization or logging code to be separated from business logic. | **Performance Overhead**: Adds an extra layer of indirection, which could introduce a minor response delay. |
| **OCP Support**: New proxies can be added to wrap services without modifying client code or the services themselves. | |

---

## Testing Project Flow

This console application demonstrates the **Protection Proxy** pattern, securing a bank account by checking an OTP authentication token before letting any deposit or withdrawal transactions execute.

### 1. `IBankAccount.cs` (Service Interface)
Defines the interface with `Deposit(decimal amount)` and `Withdraw(decimal amount)` contracts.

### 2. `BankAccount.cs` (Real Service)
The concrete implementation representing the bank account. It stores the mobile number, password, and account balance, performing actual deposit and withdrawal modifications.

### 3. `BankAccountProxy.cs` (Proxy)
* Implements `IBankAccount` and accepts a `BankAccount` reference and an OTP string in its constructor.
* Intercepts `Deposit` and `Withdraw` calls.
* Verifies if the passed OTP matches `"123456"`.
  - If the OTP matches, it delegates the transaction to the underlying `BankAccount`.
  - If the OTP fails, it denies the operation and logs an authentication failure message.

### 4. `Program.cs` (Testing Flow)
The client application runs the following sequence:
1. **Creates a bank account**: Initializes `BankAccount` with a balance of `1000.00 MMK`.
2. **Wraps it in a proxy**: Instantiates a `BankAccountProxy` passing the account and a valid OTP (`"123456"`).
3. **Executes transactions**: Calls `Deposit(500)` and `Withdraw(200)` through the proxy.
4. **Validates output**: Prints the final balance by querying the core bank account, showing that the proxy successfully allowed the operations.
