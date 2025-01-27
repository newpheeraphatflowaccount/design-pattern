namespace LiskovSubstitution
{
	public class Program
	{
		static public int Area(Rectangle r) => r.Width * r.Height;
		public static void Main(string[] args)
		{
			Rectangle rc = new Rectangle();
			Console.WriteLine($"{rc} has area {Area(rc)}");

			Square sq = new Square();
			sq.Width = 4;
			Console.WriteLine($"{sq} has area {Area(sq)}");
		}
	}
}