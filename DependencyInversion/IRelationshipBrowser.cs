namespace DependencyInversion
{
	public interface IRelationshipBrowser
	{
		IEnumerable<Person> FindAllChildrenOf(string name);
	}
}