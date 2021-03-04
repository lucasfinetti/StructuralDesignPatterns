using StructuralDesignPatterns.Decorator.Domain.Interface;

namespace StructuralDesignPatterns.Decorator.Domain.Decorator
{
    public class AirfoilDecorator : CarDecorator
    {
        public AirfoilDecorator(ICar car)
            : base(car) { }

        public float AirfoilPrice { get; set; }

        public string AirfoilName { get; set; }

        public new float Price
        {
            get
            {
                var price = base.Price;
                return price + AirfoilPrice;
            }
        }
    }
}
