using StructuralDesignPatterns.Flyweight.Domain.Base;
using StructuralDesignPatterns.Flyweight.Domain.ValueObj;

namespace StructuralDesignPatterns.Flyweight.Domain.Dogs
{
    public sealed class Dalmatian : DogBase
    {
        public Dalmatian() : base(DogBreed.Dalmatian)
        {

        }
    }
}