# SOLID Principles in C#

This repository demonstrates the **SOLID principles** of object-oriented programming using simple examples in **C#**.

## What is SOLID?

**SOLID** is an acronym that represents five design principles intended to make software designs more understandable, flexible, and maintainable:

1. S – Single Responsibility Principle (SRP)
   A class should have only one reason to change, Each class should do only one job or represent one responsibility. This makes code easier to maintain, test, and understand.

2. O – Open/Closed Principle (OCP)
   Software entities should be open for extension but closed for modification, You should be able to add new behavior without changing existing code. This is often done using interfaces or abstract classes.

3. L – Liskov Substitution Principle (LSP)  
   Subtypes must be substitutable for their base types, Objects of a subclass should be usable wherever the parent class is expected, without breaking the functionality.

4. I – Interface Segregation Principle (ISP)  
   Clients should not be forced to depend on interfaces they do not use, Split large interfaces into smaller, more specific ones so that classes only implement what they actually need.

5. D – Dependency Inversion Principle (DIP)  
   High-level modules should not depend on low-level modules; both should depend on abstractions, High-level modules should not depend on low-level modules; both should depend on abstractions (e.g., interfaces).

## Structure

Each principle is implemented in a separate folder with:
- Clean and simple C# code examples
- Before and after versions
