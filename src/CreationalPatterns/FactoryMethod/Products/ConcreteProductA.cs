namespace FactoryMethod.Products;

public class ConcreteProductA : IProduct
{
	public string Operation()
	{
		return "{Result of ConcreteProductA}";
	}
}