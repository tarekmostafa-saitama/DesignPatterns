namespace ObserverPattern.Observers;

public class User: IObserver
{
	public string Name { get; set; }
	public void Update(string value)
	{
		Console.WriteLine($"{Name} received a message: {value}");
	}
}