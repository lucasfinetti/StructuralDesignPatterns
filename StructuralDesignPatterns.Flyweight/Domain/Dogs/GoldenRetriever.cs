using StructuralDesignPatterns.Flyweight.Domain.Base;
using StructuralDesignPatterns.Flyweight.Domain.ValueObj;

namespace StructuralDesignPatterns.Flyweight.Domain.Dogs
{
    public sealed class GoldenRetriever : DogBase
    {
        public GoldenRetriever() : base(DogBreed.GoldenRetriever)
        {

        }
    }
}
