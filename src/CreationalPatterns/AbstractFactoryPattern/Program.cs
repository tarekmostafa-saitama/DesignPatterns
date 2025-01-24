// Abstract Factory is a creational design pattern that lets you produce families of related objects without
// specifying their concrete classes.

using AbstractFactoryPattern.Creators;


IAbstractFactory factory1 = new ConcreteFactory1();
Client client1 = new Client(factory1);
client1.Run();

IAbstractFactory factory2 = new ConcreteFactory2();
Client client2 = new Client(factory2);
client2.Run();


