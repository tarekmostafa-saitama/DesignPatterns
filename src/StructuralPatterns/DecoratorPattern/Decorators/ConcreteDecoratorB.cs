using DecoratorPattern.Components;

namespace DecoratorPattern.Decorators;

public class ConcreteDecoratorB : Decorator
{
	public ConcreteDecoratorB(IComponent component) : base(component) { }

	public override string Operation()
	{
		return $"ConcreteDecoratorB({base.Operation()})";
	}
}