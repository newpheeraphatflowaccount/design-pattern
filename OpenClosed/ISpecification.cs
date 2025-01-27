namespace OpenClosed
{
	public interface ISpecification<T>
	{
		bool IsSatisfied(T t);
	}
}