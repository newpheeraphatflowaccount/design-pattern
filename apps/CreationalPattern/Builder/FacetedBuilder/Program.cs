﻿namespace FacetedBuilder
{
	public class Person
	{
		// address
		public string StreetAddress, Postcode, City;

		// employment
		public string CompanyName, Position;
		public int AnnualIncome;

		public override string ToString()
		{
			return $"" +
				   $"Address: {StreetAddress}, {Postcode}, {City}\n" +
				   $"Employed at {CompanyName} as a {Position} earning {AnnualIncome}";
		}
	}

	public class PersonBuilder // facade
	{
		protected Person person = new Person(); // reference!

		public PersonJobBuilder Works => new PersonJobBuilder(person);
		public PersonAddressBuilder Lives => new PersonAddressBuilder(person);

		public static implicit operator Person(PersonBuilder pb)
		{
			return pb.person;
		}
	}

	public class PersonAddressBuilder : PersonBuilder
	{
		public PersonAddressBuilder(Person person)
		{
			this.person = person;
		}

		public PersonAddressBuilder At(string streetAddress)
		{
			person.StreetAddress = streetAddress;
			return this;
		}

		public PersonAddressBuilder WithPostcode(string postcode)
		{
			person.Postcode = postcode;
			return this;
		}

		public PersonAddressBuilder In(string city)
		{
			person.City = city;
			return this;
		}
	}

	public class PersonJobBuilder : PersonBuilder
	{
		public PersonJobBuilder(Person person)
		{
			this.person = person;
		}

		public PersonJobBuilder WorksAt(string companyName)
		{
			person.CompanyName = companyName;
			return this;
		}
		public PersonJobBuilder AsA(string position)
		{
			person.Position = position;
			return this;
		}
		public PersonJobBuilder Earning(int amount)
		{
			person.AnnualIncome = amount;
			return this;
		}
	}

	internal class Program
	{
		public static void Main(string[] args)
		{
			var pb = new PersonBuilder();
			Person person = pb
				.Works
					.WorksAt("Fabrikam")
					.AsA("Engineer")
					.Earning(123000)
				.Lives
					.At("123 London Road")
					.WithPostcode("12345")
					.In("London");
			System.Console.WriteLine(person);
		}
	}
}