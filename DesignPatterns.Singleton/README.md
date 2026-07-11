# Singleton Design Pattern

## What is Singleton?

The **Singleton** is a creational design pattern that lets you ensure that a class has only one instance, while providing a global access point to this instance.

It solves two key problems simultaneously:
1. **Ensure that a class has just a single instance**: Useful for sharing access to shared resources, such as a database, configuration files, or hardware peripherals.
2. **Provide a global access point to that instance**: Similar to a global variable, the Singleton pattern lets you access an object from anywhere in the program, but protects the instance from being overwritten by other code.

---

## How and When to Use

### How to Implement
A typical Singleton implementation consists of:
1. **Private Constructor**: A private parameterless constructor prevents other classes from using the `new` operator with the Singleton class.
2. **Private Static Field**: A private static field to hold the single instance of the class.
3. **Public Static Method**: A public static method (often named `GetInstance`) that serves as the entry point to get the instance. It lazily initializes the static field on the first call and returns the cached instance on subsequent calls.

### When to Use
* **Shared Configurations/Settings**: When you need a single configuration manager or settings class that needs to be accessed globally without passing it to every class.
* **Database Connection Pools**: When managing a pool of connections where creating multiple instances would be expensive and redundant.
* **Loggers**: When you want all parts of your application to log to the same destination via a single manager instance.

### Pros and Cons
| Pros | Cons |
| :--- | :--- |
| **Guaranteed Single Instance**: You can be sure that a class has only one instance. | **SRP Violation**: Violates the *Single Responsibility Principle* by solving two problems at once. |
| **Global Access**: Provides a controlled global access point to the instance. | **Multithreading Risk**: Requires careful lock handling (thread safety) in concurrent environments. |
| **Lazy Initialization**: The object is initialized only when requested for the first time. | **Testing Difficulties**: Hard to unit test because mock objects cannot easily override the private constructor or static instance. |

---

## Testing Project Flow

This project demonstrates the Singleton pattern with two class implementations tested in `Program.cs`.

### 1. `ConfigSetting.cs` (Basic Singleton)
* Contains a private constructor that sets a default `DbConnectionString`.
* Implements a standard, parameterless `GetInstance()` method.
* Demonstrates how modifying the connection string of one variable (`config1`) affects another (`config2`) because both point to the exact same instance in memory.

### 2. `ConfigSettingV2.cs` (Parameterized Singleton)
* Extends the pattern by allowing configuration values to be passed during initialization.
* The constructor accepts a `dbConnectionString` string parameter.
* The `GetInstance(string? dbConnectionString = null)` method checks if the instance is null:
  - If null, it instantiates the class using the passed string.
  - If already instantiated, it ignores any new parameters and returns the existing instance.

### 3. `Program.cs` (Execution Flow)
The application runs as follows:
1. **Demonstrates Reference Equality**:
   - Calls `ConfigSetting.GetInstance()` twice (`config1` and `config2`).
   - Modifies `config1.DbConnectionString`.
   - Prints `config2.DbConnectionString` to show it has also changed.
   - Validates that `config1.DbConnectionString == config2.DbConnectionString`.
2. **Demonstrates Parameter Initialization**:
   - Calls `ConfigSettingV2.GetInstance(...)` with a specific connection string to create `configV2_1`.
   - Calls `ConfigSettingV2.GetInstance()` without parameters to create `configV2_2`.
   - Verifies that `configV2_2` successfully retains the same connection string passed during `configV2_1`'s initialization.
