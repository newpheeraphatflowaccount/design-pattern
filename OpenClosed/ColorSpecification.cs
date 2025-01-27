namespace OpenClosed
{
	public class ColorSpecification : ISpecification<Product>
	{
		private Color color;
		public ColorSpecification(Color color)
		{
			this.color = color;
		}
		public bool IsSatisfied(Product p)
		{
			return p.Color == color;
		}
	}
}