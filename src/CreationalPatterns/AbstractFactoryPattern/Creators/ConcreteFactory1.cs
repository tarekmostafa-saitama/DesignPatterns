using AbstractFactoryPattern.Products;

namespace AbstractFactoryPattern.Creators;

public class ConcreteFactory1 : IAbstractFactory
{
	public IProductA CreateProductA() => new ProductA1();
	public IProductB CreateProductB() => new ProductB1();
}