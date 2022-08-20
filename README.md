# Design Patterns Playground
Design patterns implemented in C# language \
Resources I learned from - https://github.com/anupavanm/csharp-design-patterns-for-humans

- ___Creational___
  * __Simple Factory__ - simply generates an instance for client without exposing any instantiation logic to the client
  * __Factory Method__ - it provides a way to delegate the instantiation logic to child classes
  * __Abstract Factory__ - a factory of factories; a factory that groups the individual but related factories together without specifying their concrete classes
  * __Builder__ - allows you to create different flavors of an object while avoiding constructor pollution. Useful when there could be several flavors of an object. Or when there are a lot of steps involved in creation of an object
  * __Prototype__ - create object based on an existing object through cloning
  * __Singleton__ - ensures that only one object of a particular class is ever created
- ___Structural___
  * __Adapter__ - Adapter pattern lets you wrap an otherwise incompatible object in an adapter to make it compatible with another class
