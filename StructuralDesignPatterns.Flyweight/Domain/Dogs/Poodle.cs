using StructuralDesignPatterns.Flyweight.Domain.Base;
using StructuralDesignPatterns.Flyweight.Domain.ValueObj;

namespace StructuralDesignPatterns.Flyweight.Domain.Dogs
{
    public sealed class Poodle : DogBase
    {
        public Poodle() : base(DogBreed.Poodle)
        {

        }
    }
}