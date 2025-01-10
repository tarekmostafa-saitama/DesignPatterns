// The observer pattern is a behavioral design pattern that
// defines a one-to-many dependency between objects so that when one object changes state,
// all its dependents are notified and updated automatically.

// The observer pattern is mainly used to implement distributed event handling systems.


using ObserverPattern.Observers;
using ObserverPattern.Subjects;

var subject = new BotSubject();
var user1 = new User { Name = "User 1" };
var user2 = new User { Name = "User 2" };
var user3 = new User { Name = "User 3" };

subject.Attach(user1);
subject.Attach(user2);
subject.Attach(user3);

subject.Notify("Hello World!");

subject.Detach(user2);

subject.Notify("Hello World Again!");