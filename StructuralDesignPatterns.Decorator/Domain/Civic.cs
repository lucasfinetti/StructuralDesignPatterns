using StructuralDesignPatterns.Decorator.Domain.Interface;

namespace StructuralDesignPatterns.Decorator.Domain
{
    public sealed class Civic : ICar
    {
        public string Name
        {
            get { return "Civic"; }
        }

        public float Price
        {
            get { return 32999.00f; }
        }
    }
}
