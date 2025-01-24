using FactoryMethod.Products;

namespace FactoryMethod.Creators;

public class ConcreteCreatorA : Creator
{
	public override IProduct FactoryMethod()
	{
		return new ConcreteProductA();
	}
}