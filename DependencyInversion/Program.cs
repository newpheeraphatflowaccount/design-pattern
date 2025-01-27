using System.Linq;

namespace DependencyInversion
{

	public class Research
	{
		//public Research(Relationships relationships)
		//{
		//	var relations = relationships.Relations;
		//	foreach (var r in relations.Where(
		//		x => x.Item1.Name == "John" &&
		//		x.Item2 == Relationship.Parent
		//		))
		//	{
		//		Console.WriteLine($"John has a child called {r.Item3.Name}");
		//	}
		//}

		public Research(IRelationshipBrowser relationshipBrowser)
		{
			foreach (var p in relationshipBrowser.FindAllChildrenOf("John"))
			{
				Console.WriteLine($"John has a child called {p.Name}");
			}
		}

		static void Main(string[] args)
		{
			var parent = new Person { Name = "John" };
			var child1 = new Person { Name = "Chris" };
			var child2 = new Person { Name = "Matt" };

			var relationships = new Relationships();
			relationships.AddParentAndChild(parent, child1);
			relationships.AddParentAndChild(parent, child2);

			new Research(relationships);
		}
	}
}