# Template Method Design Pattern

## What is Template Method Pattern?
The **Template Method** is a behavioral pattern that defines an algorithm skeleton while subclasses customize selected steps.

## How and When to Use
`TransferProcess.Execute()` fixes the workflow; local and international transfers override fee and sending steps. Use it for workflows with a stable order and variable details.

| Pros | Cons |
| :--- | :--- |
| Reuses the common algorithm and controls step order. | Inheritance couples subclasses to the template. |

## Testing Project Flow
The sample executes local and international workflows; the latter also adds a KYC validation step.
