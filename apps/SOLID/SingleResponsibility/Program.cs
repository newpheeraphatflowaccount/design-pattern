using System.Diagnostics;

namespace SingleResponsibility
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Journal journal = new Journal();
			journal.AddEntry("I cried today.");
			journal.AddEntry("I ate a bug.");
			Console.WriteLine(journal);

			Persistence persistence = new Persistence();
			string fileName = @"C:\temp\journal.txt";
			persistence.SaveToFile(journal, fileName, true);
			Process.Start(fileName);
		}
	}
}