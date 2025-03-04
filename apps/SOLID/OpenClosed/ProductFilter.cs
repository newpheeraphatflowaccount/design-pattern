﻿namespace OpenClosed
{
	public class ProductFilter
	{
		public IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Color color)
		{
			foreach (var p in products)
			{
				if (p.Color == color)
				{
					yield return p;
				}
			}
		}

		public IEnumerable<Product> FilterBySizeAndColor(IEnumerable<Product> products, Size size, Color color)
		{
			foreach (var p in products)
			{
				if (p.Size == size && p.Color == color)
				{
					yield return p;
				}
			}
		}
	}
}