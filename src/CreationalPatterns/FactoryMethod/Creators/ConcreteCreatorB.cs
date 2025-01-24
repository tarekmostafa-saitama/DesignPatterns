using FactoryMethod.Products;

namespace FactoryMethod.Creators;

public class ConcreteCreatorB : Creator
{
	public override IProduct FactoryMethod()
	{
		return new ConcreteProductB();
	}
}