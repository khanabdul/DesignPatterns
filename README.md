# DesignPatterns
All Design Patterns POCs under single repo

```
Every Pattern is a individual project(.sln)
which can run individually without any dependecy 
Using Visual Studio.
```




# •	Creational Patterns 
o	Factory Method - Define an interface for creating a single object, but let subclasses decide which class to instantiate. Factory Method lets a class defer instantiation to subclasses  (dependency injection) 
o	Builder -  Separate the construction of a complex object from its representation, allowing the same construction process to create various representations. 
o	Lazy initialization -  Tactic of delaying the creation of an object, the calculation of a value, or some other expensive process until the first time it is needed.  
o	Singleton -  Ensure a class has only one instance, and provide a global point of access to it. 
# •	Structural Patterns 
o	Translator or Wrapper - Convert the interface of a class into another interface clients expect. An adapter lets classes work together that could not otherwise because of incompatible interfaces. The enterprise integration pattern equivalent is the translator. 
o	Proxy - Provide a surrogate or placeholder for another object to control access to it. 
# •	Behavioral patterns 
1.	Mediator - Define an object that encapsulates how a set of objects interact. Mediator promotes loose coupling by keeping objects from referring to each other explicitly, and it lets you vary their interaction independently. 
2.	Manager -  The Manager Design Pattern controls multiple entities 
1.	http://www.eventhelix.com/RealtimeMantra/ManagerDesignPattern.htm 
3.	Chain of Responsibility - Avoid coupling the sender of a request to its receiver by giving more than one object a chance to handle the request. Chain the receiving objects and pass the request along the chain until an object handles it 
4.	Observer or Publish/Subscribe - Define a one-to-many dependency between objects where a state change in one object results in all its dependents being notified and updated automatically. 












# Creational Patterns
  ## Abstract Factory
Creates an instance of several families of classes
  ## Factory Method
Creates an instance of several derived classes
  ## Singleton
A class of which only a single instance can exist

# Structural Patterns
  ## Adapter
Match interfaces of different classes
  ## Composite
A tree structure of simple and composite objects
  ## Facade
A single class that represents an entire subsystem
 ## Decorator	
 Decorators provide a flexible alternative to sub classing for extending functionality


# Behavioral Patterns
 ## Observer
A way of notifying change to a number of classes
  ## Strategy
Encapsulates an algorithm inside a class

  ## Chain of Resp.       
A way of passing a request between a chain of objects


# Details ========>

# *Singleton: 
```
•	Singletons can be hard to test.
•	Memory allocated to a Singleton can't be freed.
•	Behave like Global variables. Any part of code can change the value.
•	Static Vs Singleton: 
The big difference between a singleton and a bunch of static methods is that singletons can implement interfaces (or derive from useful base classes, although that's less common IME), so you can pass around the singleton as if it were "just another" implementation.
A singleton allows access to a single created instance - that instance (or rather, a reference to that instance) can be passed as a parameter to other methods, and treated as a normal object.
A static class allows only static methods.
Static classes
•	A class having all static methods.
•	better performance (static methods are bonded on compile time)
Singleton
•	an object that can only be instantiated once.
•	methods can be overridden
•	easier to mock then static methods
•	better at maintaining state
•	can be lazy loaded when need (static classes are always loaded)

 
```
### Example: Load balancer instance, Logger.

# *Factory:
```
•	Object creation logic is separated out and is job of factory
•	Pass the type of instance needed and factory returns specific type using if/else or switch case.
•	Decreases coupling between code that needs to create objects from object creation code
•	Separate object creation from which objects to create(avoid huge if else/Switch case for objects)
o	Add New Classes without breaking OCP
o	Factory products 
o	Or factory themselves(abstract)
o	Store object creation in Db.Cofig file
o	Encapsulate object Creation
o	Late decisions for Instantiation
 ```

# *Abstract Factory:
```
An abstract factory is used to provide an interface for creating families of related objects, without specifying concrete classes and can be used to hide platform specific classes


 ```
### Example: Dabur patanjili: honey/ chawanprash factory
### Difference B/W factory & Abstarct Factory 
```
Factory
Imagine you are constructing a house and you approach a carpenter for a door. You give the measurement for the door and your requirements, and he will construct a door for you. In this case, the carpenter is a factory of doors. Your specifications are inputs for the factory, and the door is the output or product from the factory.
Abstract Factory
Now, consider the same example of the door. You can go to a carpenter, or you can go to a plastic door shop or a PVC shop. All of them are door factories. Based on the situation, you decide what kind of factory you need to approach. This is like an Abstract Factory.
```


# *Façade : 
```
Unified interface to a set of interfaces in a subsystem. Façade defines a higher-level interface that makes the subsystem easier to use.

Example : Different set of validations for plan & product & FACADE
Question: So the way to tell the difference between the Adapter pattern and the Facade pattern is that the Adapter wraps one class and the Facade may represent many classes? 
Answer: No! Remember, the Adapter pattern changes the interface of one or more classes into one interface that a client is expecting. While most textbook examples show the adapter adapting one class, you may need to adapt many classes to provide the interface a client is coded to. Likewise, a Facade may provide a simplified interface to a single class with a very complex interface. The difference between the two is not in terms of how many classes they "wrap", it is in their intent.
 
```

# *Adapter :
```
Adapter lets classes work together that couldn't otherwise because of incompatible interfaces.

•	Convert the interface of a class into another interface clients expect. 
•	Adapter makes things work after they're designed.
•	Adapter is meant to change the interface of an existing object.

``` 
### Example: Bluetooth manager logger to use our loggers

# *Observer 
```
•	Publisher/Subscriber type pattern ->subject/observer
•	One-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically.
•	Observer defines a very decoupled interface that allows for multiple receivers to be configured at run-time

```
 ### Example: Bid , Global, Canada  India strategy broadcast


# *Strategy
```
“Strategy pattern defines a family of algorithms, encapsulates each one of them and makes them interchangeable.”
 
•	Family of Algorithms- The definition says that the pattern defines the family of algorithms-it means we have functionality (in these algorithms) which will do the same common thing for our object, but in different ways.

•	Encapsulate each one of them- The pattern would force you to place your          algorithms in different classes (encapsulate them). Doing so would help us in selecting the appropriate algorithm for our object.

•	Make them interchangeable- The beauty with strategy pattern is we can select at run time which algorithm we should apply to our object and can replace them with one another


 ```
 ### Example: Sorting, 
 
 
# *Chain of Responsibility ( Set_Succsessor() )
```
•	A way of passing a request between a chain of objects
•	Avoid coupling the sender of a request to its receiver by giving more than one object a chance to handle the request. 
•	Chain the receiving objects and pass the request along the chain until an object handles it.


```
 ### Example: service request handler, husband-father in law responsibility, Management Approval


# *Decorator (extended functionality)
```
Add new functionality to an existing object without altering its structure.

This pattern creates a decorator class which wraps the original class and provides additional functionality keeping class methods signature intact.


```
 ### Example : Duster car example +Additional Offers Functionality.


# *Composite 
```
Composite pattern is used where we need to treat a group of objects in similar way as a single object. Composite pattern composes objects in term of a tree structure to represent part as well as whole hierarchy 	 	 
•	Recursive composition


```
  ### Example: Employee subordinates. List<employee>

Directories contain entries, each of which could be a directory












