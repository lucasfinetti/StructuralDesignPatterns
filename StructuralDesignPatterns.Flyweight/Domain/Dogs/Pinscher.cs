using StructuralDesignPatterns.Flyweight.Domain.Base;
using StructuralDesignPatterns.Flyweight.Domain.ValueObj;

namespace StructuralDesignPatterns.Flyweight.Domain.Dogs
{
    public sealed class Pinscher : DogBase
    {
        public Pinscher() : base(DogBreed.Pinscher)
        {

        }
    }
}