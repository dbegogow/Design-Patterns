# Design Patterns Playground
Design patterns implemented in C# language \
Resources I learned from - https://github.com/anupavanm/csharp-design-patterns-for-humans

- Creational
  * Simple Factory - simply generates an instance for client without exposing any instantiation logic to the client
  * Factory Method - it provides a way to delegate the instantiation logic to child classes
  * Abstract Factory - a factory of factories; a factory that groups the individual but related factories together without specifying their concrete classes
  * Builder - allows you to create different flavors of an object while avoiding constructor pollution. Useful when there could be several flavors of an object. Or when there are a lot of steps involved in creation of an object
  * Prototype - create object based on an existing object through cloning
  * Singleton - ensures that only one object of a particular class is ever created
