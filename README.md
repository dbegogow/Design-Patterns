# Design Patterns Playground
Design patterns implemented in C# language \
Resources I learned from - https://github.com/anupavanm/csharp-design-patterns-for-humans

- __Creational__ - Creational patterns are focused towards how to instantiate an object or group of related objects
- __Structural__ - Structural patterns are mostly concerned with object composition or in other words how the entities can use each other. Or yet another explanation would be, they help in answering "How to build a software component?"
- __Behavioral__ - It is concerned with assignment of responsibilities between the objects. What makes them different from structural patterns is they don't just specify the structure but also outline the patterns for message passing/communication between them. Or in other words, they assist in answering "How to run a behavior in software component?"

- ___Creational___
  * __Simple Factory__ - simply generates an instance for client without exposing any instantiation logic to the client
  * __Factory Method__ - it provides a way to delegate the instantiation logic to child classes
  * __Abstract Factory__ - a factory of factories; a factory that groups the individual but related factories together without specifying their concrete classes
  * __Builder__ - allows you to create different flavors of an object while avoiding constructor pollution. Useful when there could be several flavors of an object. Or when there are a lot of steps involved in creation of an object
  * __Prototype__ - create object based on an existing object through cloning
  * __Singleton__ - ensures that only one object of a particular class is ever created
- ___Structural___
  * __Adapter__ - Adapter pattern lets you wrap an otherwise incompatible object in an adapter to make it compatible with another class
  * __Bridge__ - Bridge pattern is about preferring composition over inheritance. Implementation details are pushed from a hierarchy to another object with a separate hierarchy
  * __Composite__ - Composite pattern lets clients treat the individual objects in a uniform manner
  * __Decorator__ - Decorator pattern lets you dynamically change the behavior of an object at run time by wrapping them in an object of a decorator class
  * __Facade__ - Facade pattern provides a simplified interface to a complex subsystem
  * __Flyweight__ - It is used to minimize memory usage or computational expenses by sharing as much as possible with similar objects
  * __Proxy__ - Using the proxy pattern, a class represents the functionality of another class
