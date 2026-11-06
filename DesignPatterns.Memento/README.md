# Memento Design Pattern

## What is Memento Pattern?
The **Memento** is a behavioral pattern that captures object state so it can be restored without exposing internal fields.

## How and When to Use
`TransferDraft` creates an immutable snapshot and `DraftHistory` stores it. Use it for undo, drafts, checkpoints, and rollback.

| Pros | Cons |
| :--- | :--- |
| Preserves encapsulation during state restoration. | Many snapshots can consume substantial memory. |

## Testing Project Flow
The sample saves a valid draft, makes an accidental edit, and restores the saved values.
