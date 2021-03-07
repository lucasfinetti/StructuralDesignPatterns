using StructuralDesignPatterns.Flyweight.Domain.Base;
using StructuralDesignPatterns.Flyweight.Domain.ValueObj;
using StructuralDesignPatterns.Flyweight.Factory;
using System;

namespace StructuralDesignPatterns.Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                DogBase dogFactory = DogFactory.GedDog(GetRandDogBreed());

                Console.WriteLine(dogFactory.GetDogBreed());
            }
        }

        public static DogBreed GetRandDogBreed()
        {
            Array values = Enum.GetValues(typeof(DogBreed));
            Random random = new Random();
            DogBreed randomDogBreed = (DogBreed)values.GetValue(random.Next(values.Length));
            return randomDogBreed;
        }
    }
}
