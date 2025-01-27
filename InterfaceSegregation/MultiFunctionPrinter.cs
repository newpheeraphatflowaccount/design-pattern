namespace InterfaceSegregation
{
	public class MultiFunctionPrinter : IMachine
	{
		public void Print(Document d)
		{
			// Print the document
		}
		public void Fax(Document d)
		{
			// Fax the document
		}
		public void Scan(Document d)
		{
			// Scan the document
		}
	}
}