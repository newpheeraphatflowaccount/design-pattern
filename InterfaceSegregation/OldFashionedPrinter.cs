namespace InterfaceSegregation
{
	public class OldFashionedPrinter : IMachine
	{
		public void Print(Document d)
		{
			// Print the document
		}
		public void Fax(Document d)
		{
			// This printer cannot fax
		}
		public void Scan(Document d)
		{
			// This printer cannot scan
		}
	}
}