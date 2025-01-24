using FactoryMethod.Products;

namespace FactoryMethod.Creators;

public abstract class Creator
{
	// Factory Method
	public abstract IProduct FactoryMethod();

	public string SomeOperation()
	{
		// Call the factory method to create a Product object.
		var product = FactoryMethod();
		// Now, use the product.
		return "Creator: The same creator's code has just worked with " + product.Operation();
	}
}