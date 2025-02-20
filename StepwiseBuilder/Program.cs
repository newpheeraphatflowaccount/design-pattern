namespace StepwiseBuilder
{
	public enum CarType
	{
		Sedan,
		Crossover
	}

	public class Car
	{
		public CarType Type { get; set; }
		public int WheelSize;
	}

	public interface ISpecifyCarType
	{
		ISpecifyWheelSize OfType(CarType type);
	}

	public interface ISpecifyWheelSize
	{
		IBuildCar WithWheels(int size);
	}

	public interface IBuildCar
	{
		public Car Build();
	}

	public class CarBuilder 
	{
		private class Impl :
			ISpecifyCarType,
			ISpecifyWheelSize,
			IBuildCar
		{
			private Car car = new Car();

			public Car Build()
			{
				return car;
			}

			public ISpecifyWheelSize OfType(CarType type)
			{
				car.Type = type;
				return this;
			}

			public IBuildCar WithWheels(int size)
			{
				switch (car.Type)
				{
					case CarType.Sedan:
						if (size != 17 && size != 18)
							throw new ArgumentOutOfRangeException();
						break;
					case CarType.Crossover:
						if (size < 20)
							throw new ArgumentOutOfRangeException();
						break;
				}

				car.WheelSize = size;
				return this;
			}
		}

		public static ISpecifyCarType Create()
		{
			return new Impl();
		}
	}

	internal class Program
	{
		public static void Main(string[] args)
		{
			var car = CarBuilder
				.Create() // ISpecifyCarType
				.OfType(CarType.Crossover) // ISpecifyWheelSize
				.WithWheels(22) // IBuildCar
				.Build(); // Car
		}
	}
}