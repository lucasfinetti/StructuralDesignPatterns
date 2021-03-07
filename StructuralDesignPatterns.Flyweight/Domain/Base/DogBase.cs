using StructuralDesignPatterns.Flyweight.Domain.ValueObj;

namespace StructuralDesignPatterns.Flyweight.Domain.Base
{
    public abstract class DogBase
    {
        private DogBreed DogBreed { get; set; }

        protected DogBase(DogBreed dogBreed)
        {
            DogBreed = dogBreed;
        }

        public DogBreed GetDogBreed()
        {
            return DogBreed;
        }
    }
}
