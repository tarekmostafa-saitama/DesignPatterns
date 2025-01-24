using AbstractFactoryPattern.Products;

namespace AbstractFactoryPattern.Creators;

public interface IAbstractFactory
{
	IProductA CreateProductA();
	IProductB CreateProductB();
}