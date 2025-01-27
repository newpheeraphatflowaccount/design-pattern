namespace InterfaceSegregation
{
	public class MultiFunctionDevice : IMultiFunctionDevice
	{
		private IPrinter printer;
		private IScanner scanner;

		public MultiFunctionDevice(IPrinter printer, IScanner scanner)
		{
			this.printer = printer;
			this.scanner = scanner;
		}

		public void Print(Document d)
		{
			this.printer.Print(d);
		}

		public void Scan(Document d)
		{
			this.scanner.Scan(d);
		}
	}
}