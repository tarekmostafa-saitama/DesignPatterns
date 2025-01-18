﻿namespace DecoratorPattern.Components;

public class ConcreteComponent : IComponent
{
	public string Operation()
	{
		return "ConcreteComponent";
	}
}