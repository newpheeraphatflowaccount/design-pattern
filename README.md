# DesignPattern

## SOLID Priciple

### Summary

- **Single Responsibility Principle**
  - A class should only have one reason to change.
  - _Separation of concerns_ - different classes handling different, independent tasks/problems.
- **Open-Closed Principle**
  - Classes should be open for extension but closed for modification.
- **Liskov Substition Principle**
  - You should be able to substitute a base type for a subtype.
- **Interface Segregation Principle**
  - Don't put too much into an interface; split into separate interfaces.
  - _YAGNI_ - You Ain't Going to Need It.
- **Dependency Inversion Principle**
  - High-level modules should not depend upon low-level ones; use abstractions.

## Builder

### Summary

- A builder is a separate component for building an object.
- Can either give builder a constructor or return it via a static function.
- To make builder fluent, return this.
- Different facets of an object can be built with different builders working in tandem via a base class.
