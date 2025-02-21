namespace InterfaceSegregation
{
	public class Photocopier : IPrinter, IScanner
	{
		public void Print(Document d)
		{
			// Print the document
		}
		public void Scan(Document d)
		{
			// Scan the document
		}
	}
}