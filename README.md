# C# Boxing and Unboxing Examples

This repository provides examples of **boxing** and **unboxing** in C#, demonstrating how they can cause performance issues and ways to optimize code to avoid them.

## What are Boxing and Unboxing?

- **Boxing**: Converting a value type (e.g., `int`, `float`) to a reference type (`object` or an interface type). This requires additional memory and processing as the value is stored on the heap.
- **Unboxing**: Converting a boxed reference type back into a value type. This requires explicit casting.

Boxing and unboxing can lead to performance issues, especially in loops or large-scale operations. This repository illustrates these pitfalls with examples and solutions.
