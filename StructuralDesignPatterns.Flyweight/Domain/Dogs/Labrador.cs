using StructuralDesignPatterns.Flyweight.Domain.Base;
using StructuralDesignPatterns.Flyweight.Domain.ValueObj;

namespace StructuralDesignPatterns.Flyweight.Domain.Dogs
{
    public sealed class Labrador : DogBase
    {
        public Labrador() : base(DogBreed.Labrador)
        {

        }
    }
}