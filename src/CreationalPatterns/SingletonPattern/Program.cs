// singleton pattern is a creational pattern that ensures a class has
// only one instance and provides a global point of access to it.


namespace SingletonPattern
{
	public sealed class Singleton
	{
		private static readonly Lock Padlock = new Lock();
		private static Singleton _instance = null;

		public static Singleton Instance
		{
			get
			{
				lock (Padlock)
				{
					return _instance ??= new Singleton();
				}
			}
		}

		private Singleton()
		{
			// Private constructor to prevent instantiation
		}

		public void DoSomething()
		{
			Console.WriteLine("Singleton instance is working.");
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Singleton singleton1 = Singleton.Instance;
			Singleton singleton2 = Singleton.Instance;

			if (singleton1 == singleton2)
			{
				Console.WriteLine("Both instances are the same.");
			}

			singleton1.DoSomething();
		}
	}
}
