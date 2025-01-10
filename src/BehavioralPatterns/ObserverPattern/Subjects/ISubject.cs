using ObserverPattern.Observers;

namespace ObserverPattern.Subjects;

public interface ISubject
{
	void Attach(IObserver observer);
	void Detach(IObserver observer);
	void Notify(string value);
}