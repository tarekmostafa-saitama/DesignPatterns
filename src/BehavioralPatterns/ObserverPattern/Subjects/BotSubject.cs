using ObserverPattern.Observers;

namespace ObserverPattern.Subjects;

public class BotSubject: ISubject
{
	public List<IObserver> Observers { get; private set; } = new();
	public void Attach(IObserver observer)
	{
		Observers.Add(observer);
	}

	public void Detach(IObserver observer)
	{
		Observers.Remove(observer);
	}

	public void Notify(string value)
	{
		foreach (var observer in Observers)
		{
			observer.Update(value);
		}
	}
}