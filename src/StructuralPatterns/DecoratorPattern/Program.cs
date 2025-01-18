// The decorator pattern is a structural design pattern
// that lets you attach new behaviors to objects
// by placing these objects inside special wrapper objects
// that contain the new behaviors.


using DecoratorPattern.Components;
using DecoratorPattern.Decorators;

IComponent component = new ConcreteComponent();
Console.WriteLine("Client: I get a simple component:");
Console.WriteLine(component.Operation());

IComponent decorator1 = new ConcreteDecoratorA(component);
IComponent decorator2 = new ConcreteDecoratorB(decorator1);
Console.WriteLine("Client: Now I've got a decorated component:");
Console.WriteLine(decorator2.Operation());
