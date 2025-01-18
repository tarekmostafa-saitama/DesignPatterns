using DecoratorPattern.Components;

namespace DecoratorPattern.Decorators;

public class ConcreteDecoratorA : Decorator
{
	public ConcreteDecoratorA(IComponent component) : base(component) { }

	public override string Operation()
	{
		return $"ConcreteDecoratorA({base.Operation()})";
	}
}