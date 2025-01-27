﻿namespace LiskovSubstitution
{
	public class Rectangle
	{
		public virtual int Width { get; set; }
		public virtual int Height { get; set; }

		public Rectangle()
		{
		}

		public Rectangle(int width, int height)
		{
			Width = width;
			Height = height;
		}

		public override string ToString()
		{
			return $"{nameof(Width)}: {Width}, {nameof(Height)}: {Height}";
		}
	}

	public class Square : Rectangle
	{
		public override int Width
		{
			set { base.Width = base.Height = value; }
		}

		public override int Height
		{
			set { base.Width = base.Height = value; }
		}
	}


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