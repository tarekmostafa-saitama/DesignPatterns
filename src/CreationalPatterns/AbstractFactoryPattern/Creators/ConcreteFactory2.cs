using AbstractFactoryPattern.Products;

namespace AbstractFactoryPattern.Creators;

public class ConcreteFactory2 : IAbstractFactory
{
	public IProductA CreateProductA() => new ProductA2();
	public IProductB CreateProductB() => new ProductB2();
}