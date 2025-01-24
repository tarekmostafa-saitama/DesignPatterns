using AbstractFactoryPattern.Creators;
using AbstractFactoryPattern.Products;

public class Client
{
	private readonly IProductA _productA;
	private readonly IProductB _productB;

	public Client(IAbstractFactory factory)
	{
		_productA = factory.CreateProductA();
		_productB = factory.CreateProductB();
	}

	public void Run()
	{
		Console.WriteLine(_productA.GetName());
		Console.WriteLine(_productB.GetName());
	}
}