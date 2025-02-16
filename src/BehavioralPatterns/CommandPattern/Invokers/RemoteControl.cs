using CommandPattern.Commands;

namespace CommandPattern.Invokers;

// Invoker
public class RemoteControl
{
	private readonly Stack<ICommand> _commandHistory = new Stack<ICommand>();

	public void ExecuteCommand(ICommand command)
	{
		command.Execute();
		_commandHistory.Push(command);
	}

	public void UndoCommand()
	{
		if (_commandHistory.Count > 0)
		{
			var command = _commandHistory.Pop();
			command.Undo();
		}
	}
}