namespace StrategyPattern.Strategies;

// Concrete strategy A
public class ConcreteStrategyA : IStrategy
{
	public void Execute()
	{
		Console.WriteLine("Executing strategy A");
	}
}

