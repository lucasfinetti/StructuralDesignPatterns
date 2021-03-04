using StructuralDesignPatterns.Decorator.Domain.Interface;

namespace StructuralDesignPatterns.Decorator.Domain.Decorator
{
    public class InsulfilmDecorator : CarDecorator
    {
        public InsulfilmDecorator(ICar car)
            : base(car) { }

        public float InsulfilmPrice { get; set; }

        public string InsulfilmName { get; set; }

        public new float Price
        {
            get
            {
                var price = base.Price;
                return price + InsulfilmPrice;
            }
        }
    }
}