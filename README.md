# 🧮 RPN Calculator - Starting Point

This repository serves as the starting point for an exercise designed for students studying the module **UG409765 - Software Construction**.

## ℹ️ **Overview**
In this exercise, students will build a fully functional Reverse Polish Notation (RPN) Calculator application using C#. The project emphasises:
- Implementing abstract data types (ADTs) such as stacks.
- Leveraging interfaces and generics.
- Applying concepts in a graphical application with a Windows Forms interface.
- Demonstrating proper use of version control and clean coding practices.

## 🔧 **Repository Structure**

- `IStack<T>`: An interface provided to define the contract for stack implementations.
- `PolishNotationCalculator`: A partially implemented class where the RPN evaluation logic will be added.
- `ArrayStack<T>`: This file will be created by students to implement a stack using an array.
- `WindowsFormsApp`: A pre-built graphical interface for the RPN Calculator.

## ✅ **Your Tasks**
1. **Implement `ArrayStack<T>`**:
   - Create a fixed-capacity array-based implementation of the `IStack<T>` interface.
   - Ensure the stack supports operations like `Push`, `Pop`, `Peek`, and `IsEmpty`.

2. **Complete the `PolishNotationCalculator` Class**:
   - Add logic to the `Evaluate` method to parse and compute RPN expressions using your stack implementation.

3. **Integrate with Windows Forms**:
   - Hook up the calculator to the provided interface.
   - Handle user input, process expressions, and display results or errors.

4. **Follow Version Control Best Practices**:
   - Use Git for tracking changes.
   - Commit frequently with meaningful messages.

## 💪 **Optional Extensions**
- **Linked List Stack**:
  - Create a new `LinkedListStack<T>` class implementing `IStack<T>`.
  - Replace the `ArrayStack<T>` in the calculator and test the functionality.

- **Exception Handling**:
  - Add proper exception handling for edge cases such as stack underflow/overflow (array-based), invalid inputs, and division by zero.