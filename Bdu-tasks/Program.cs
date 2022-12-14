namespace Bdu_tasks
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
			Console.Write("a:");
			int a = int.Parse(Console.ReadLine());
			for (int i=1; i <= a; i++)
			{
				Console.WriteLine($"{i}-ci eded:{i}");
			}
		}
	}
}