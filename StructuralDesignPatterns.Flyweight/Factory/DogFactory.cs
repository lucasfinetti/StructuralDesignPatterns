using StructuralDesignPatterns.Flyweight.Domain.Base;
using StructuralDesignPatterns.Flyweight.Domain.Dogs;
using StructuralDesignPatterns.Flyweight.Domain.ValueObj;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StructuralDesignPatterns.Flyweight.Factory
{
    public static class DogFactory
    {
        private static Dictionary<DogBreed, DogBase> dogBreedDict = new Dictionary<DogBreed, DogBase>();
 
        public static DogBase GedDog(DogBreed dogBreed)
        {
            DogBase dog = null;

            if (dogBreedDict.ContainsKey(dogBreed))
            {
                dog = dogBreedDict.First(db => db.Key == dogBreed).Value;
            }
            else
            {
                switch (dogBreed)
                {
                    case DogBreed.Dalmatian:
                        dog = new Dalmatian();
                        break;
                    case DogBreed.GoldenRetriever:
                        dog = new GoldenRetriever();
                        break;
                    case DogBreed.Labrador:
                        dog = new Labrador();
                        break;
                    case DogBreed.Pinscher:
                        dog = new Pinscher();
                        break;
                    case DogBreed.Poodle:
                        dog = new Poodle();
                        break;
                }

                Console.WriteLine($"{dogBreed} Created");

                dogBreedDict.Add(dogBreed, dog);
            }

            return dog;
        }
    }
}
