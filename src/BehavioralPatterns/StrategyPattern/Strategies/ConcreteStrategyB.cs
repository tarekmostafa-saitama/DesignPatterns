namespace StrategyPattern.Strategies;

// Concrete strategy B
public class ConcreteStrategyB : IStrategy
{
	public void Execute()
	{
		Console.WriteLine("Executing strategy B");
	}
}