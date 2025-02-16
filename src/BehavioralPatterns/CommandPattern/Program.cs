// Command pattern is a behavioral design pattern that turns a request into a stand-alone object that contains
// all information about the request. This transformation lets you parameterize methods with different requests,
// delay or queue a request's execution, and support undoable operations. The pattern consists of four main components:
// Command, Receiver, Invoker, and Client.
// The Command declares an interface for executing an operation.
// The ConcreteCommand defines a binding between the action and the Receiver.
// The Receiver knows how to perform the operation.
// The Invoker asks the command to carry out the request.
// The Client creates a ConcreteCommand object and sets its receiver.
// The Invoker decides when to execute the command.
// The Client decides which commands to execute at which points.

// The Command pattern is useful when you want to parameterize objects with operations,
// queue operations, undo operations, and support callbacks.
// It's also useful when you want to support undoable operations and support logging changes.
// The pattern is widely used in GUI buttons, menu items, and macro recording tools.

using CommandPattern.Commands;
using CommandPattern.Invokers;
using CommandPattern.Receivers;

namespace CommandPattern;

// Client
public class Program
{
	public static void Main(string[] args)
	{
		var light = new Light();
		var lightOnCommand = new LightOnCommand(light);
		var lightOffCommand = new LightOffCommand(light);

		var remoteControl = new RemoteControl();

		remoteControl.ExecuteCommand(lightOnCommand);
		remoteControl.ExecuteCommand(lightOffCommand);
		remoteControl.UndoCommand();
		remoteControl.UndoCommand();
	}
}