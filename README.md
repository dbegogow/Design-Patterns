# Design Patterns Playground
Design patterns implemented in C# language \
Resources I learned from - https://github.com/anupavanm/csharp-design-patterns-for-humans

- ___Creational___ - Creational patterns are focused towards how to instantiate an object or group of related objects
  * __Simple Factory__ - simply generates an instance for client without exposing any instantiation logic to the client
  * __Factory Method__ - it provides a way to delegate the instantiation logic to child classes
  * __Abstract Factory__ - a factory of factories; a factory that groups the individual but related factories together without specifying their concrete classes
  * __Builder__ - allows you to create different flavors of an object while avoiding constructor pollution. Useful when there could be several flavors of an object. Or when there are a lot of steps involved in creation of an object
  * __Prototype__ - create object based on an existing object through cloning
  * __Singleton__ - ensures that only one object of a particular class is ever created
- ___Structural___ - Structural patterns are mostly concerned with object composition or in other words how the entities can use each other. Or yet another explanation would be, they help in answering "How to build a software component?"
  * __Adapter__ - Adapter pattern lets you wrap an otherwise incompatible object in an adapter to make it compatible with another class
  * __Bridge__ - Bridge pattern is about preferring composition over inheritance. Implementation details are pushed from a hierarchy to another object with a separate hierarchy
  * __Composite__ - Composite pattern lets clients treat the individual objects in a uniform manner
  * __Decorator__ - Decorator pattern lets you dynamically change the behavior of an object at run time by wrapping them in an object of a decorator class
  * __Facade__ - Facade pattern provides a simplified interface to a complex subsystem
  * __Flyweight__ - It is used to minimize memory usage or computational expenses by sharing as much as possible with similar objects
  * __Proxy__ - Using the proxy pattern, a class represents the functionality of another class
- ___Behavioral___ - It is concerned with assignment of responsibilities between the objects. What makes them different from structural patterns is they don't just specify the structure but also outline the patterns for message passing/communication between them. Or in other words, they assist in answering "How to run a behavior in software component?"
  * __Chain of Responsibility__ - It helps building a chain of objects. Request enters from one end and keeps going from object to object till it finds the suitable handler
  * __Command__ - Allows you to encapsulate actions in objects. The key idea behind this pattern is to provide the means to decouple client from receiver
  * __Iterator__ - It presents a way to access the elements of an object without exposing the underlying presentation
  * __Mediator__ - Mediator pattern adds a third party object (called mediator) to control the interaction between two objects (called colleagues). It helps reduce the coupling between the classes communicating with each other. Because now they don't need to have the knowledge of each other's implementation
  * __Memento__ - Memento pattern is about capturing and storing the current state of an object in a manner that it can be restored later on in a smooth manner
  * __Observer__ - Defines a dependency between objects so that whenever an object changes its state, all its dependents are notified
  * __Visitor__ - Visitor pattern lets you add further operations to objects without having to modify them
  * __Strategy__ - Strategy pattern allows you to switch the algorithm or strategy based upon the situation
  * __State__ - It lets you change the behavior of a class when the state changes
  * __Template Method__ - Template method defines the skeleton of how a certain algorithm could be performed, but defers the implementation of those steps to the children classes

