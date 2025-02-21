public class Journal
{
	private readonly List<string> entries = new List<string>();
	private static int count = 0;

	public Journal() { }

	public void AddEntry(string text)
	{
		entries.Add($"{++count}: {text}");
	}

	public void RemoveEntry(int index)
	{
		entries.RemoveAt(index);
	}

	public override string ToString()
	{
		return string.Join(Environment.NewLine, entries.ToArray());
	}
}
