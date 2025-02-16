namespace CommandPattern.Commands;
// Command Interface
public interface ICommand
{
	void Execute();
	void Undo();
}