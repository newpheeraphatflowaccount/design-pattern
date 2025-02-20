namespace FluentBuilder
{
	public class Person
	{
		public string Name;
		public string Position;

		public class Builder : PersonJobBuilder<Builder>
		{
		}

		public static Builder New => new Builder();

		public override string ToString()
		{
			return $"{nameof(Name)}: {Name}, {nameof(Position)}: {Position}";
		}
	}

	public abstract class PersonBuilder
	{
		protected Person person = new Person();
		public Person Build()
		{
			return person;
		}
	}

	// class Foo : Bar<Foo>
	public class PeronInfoBuilder<SELF>
		: PersonBuilder
		where SELF : PeronInfoBuilder<SELF>
	{
		public SELF Called(string name)
		{
			person.Name = name;
			return (SELF) this;
		}
	}

	public class PersonJobBuilder<SELF>
		: PeronInfoBuilder<PersonJobBuilder<SELF>>
		where SELF : PersonJobBuilder<SELF>
	{
		public SELF WorksAsA(string position)
		{
			person.Position = position;
			return (SELF) this;
		}
	}

	public class Program
	{
		public static void Main(string[] args)
		{
			var me = Person.New
				.Called("Dmitri")
				.WorksAsA("Quant")
				.Build();
			System.Console.WriteLine(me);
		}
	}
}