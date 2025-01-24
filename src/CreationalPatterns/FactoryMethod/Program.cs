// Factory Method is a creational design pattern that provides an interface for creating objects in a superclass,
// but allows subclasses to alter the type of objects that will be created.

using FactoryMethod.Creators;


Console.WriteLine("App: Launched with the ConcreteCreatorA.");
ClientCode(new ConcreteCreatorA());

Console.WriteLine("App: Launched with the ConcreteCreatorB.");
ClientCode(new ConcreteCreatorB());


static void ClientCode(Creator creator)
{
	Console.WriteLine("Client: I'm not aware of the creator's class, but it still works.\n" + creator.SomeOperation());
}
