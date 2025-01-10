// The Strategy Pattern defines a family of algorithms, encapsulates each one, and makes them interchangeable.
// This pattern allows the algorithm to vary independently from clients that use it.
// It is useful when you have multiple ways of performing a task and want to choose the algorithm at runtime.


using StrategyPattern.Main;
using StrategyPattern.Strategies;



Context context = new Context();

// Using strategy A
context.SetStrategy(new ConcreteStrategyA());
context.ExecuteStrategy();

// Using strategy B
context.SetStrategy(new ConcreteStrategyB());
context.ExecuteStrategy();


