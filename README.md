# Match3-Unity-Game

# Positives of the design:

Clear division of classes with defined roles
Straightforward code flow with GameManager.cs as the entry point
Simple code suitable for rapid prototyping

# Concerns with the design:

Violates several design principles (Single Responsibility, Inversion of Control, Dependency Inversion, Open-Close)
Overlapping dependencies between concrete classes, could be improved with more interfaces/abstractions and dependency injection
GameManager has too many responsibilities, could use State Pattern to delegate tasks to smaller state classes
BonusItem and NormalItem classes have too many responsibilities, could be improved with abstract classes and configuration-based approaches
Overall, this is a prototyping-focused design that may cause maintainability issues in the long run.

#Suggested Improvements:

- Use more interfaces and abstract classes:
  Introduce interfaces and abstract classes to reduce the overlapping dependencies between concrete classes.
  This will make the code more extensible and maintainable in the long run.

- Refactor GameManager using the State Pattern:
  Implement the State Pattern to separate the different game states into smaller, more focused classes.
  This will remove many responsibilities from the GameManager class and improve the code's overall structure.
- Improve the BonusItem and NormalItem classes:
  Refactor the BonusItem class to use an abstract base class with an abstract ExplodeView() method.
  Derive specific BonusItem classes from the abstract base class and implement the ExplodeView() method accordingly.
  Remove the eNormalType enum from the NormalItem class and use a configuration-based approach to associate the item types with their prefabs.
