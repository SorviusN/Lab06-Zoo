# Zoo - An Object Oriented Principles Project

## Intro
This project is meant to showcase the different types of animals and their properties (How many legs, Name) as well as their methods (Swim, run, fly).
It utilizes a combination of classes and interfaces alongside polymorphism in order to model out the necessary actions and properties for an animal.

## Model Diagram - 
![UML](./UML.PNG)

### So... what are some OOP terms that you should know?

- Abstract: This is the basis for polymorphism in classes. You declare a class abstract when its definitions will be used and declared in child classes.
Addiitonally, you insert abstract into method definitions when you want them to be declared (and defined) inside of the child classes.

- Virtual: We use this to define our props and methods. We declare the values of these immediately and they MAY be overriden by the child classes or not. It's entirely up
to them.

- Override: This is used with both props and methods. When we override the original value (or declaration) with our own, we use this term. 

- Concrete: Classes that will not be abstract. They are generally at the bottom of the child list (A wolf is a land animal, which is a mammal. Wolf is concrete.) 

## Interfaces
- Interfaces are pre-built layouts of code that you are able to assign to any heirarchy within your classes. They are flexible and nice to implement when you want to assign some characteristics to a class that span across your hierarchy.