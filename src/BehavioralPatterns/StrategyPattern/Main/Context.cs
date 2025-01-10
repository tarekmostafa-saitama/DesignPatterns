﻿using StrategyPattern.Strategies;

namespace StrategyPattern.Main;

// Context class
public class Context
{
	private IStrategy _strategy;

	public void SetStrategy(IStrategy strategy)
	{
		_strategy = strategy;
	}

	public void ExecuteStrategy()
	{
		_strategy.Execute();
	}
}