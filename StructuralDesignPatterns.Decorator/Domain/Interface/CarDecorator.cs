namespace StructuralDesignPatterns.Decorator.Domain.Interface
{
    public abstract class CarDecorator : ICar
    {
        private ICar _car;

        public CarDecorator(ICar car)
        {
            _car = car;
        }

        public string Name
        {
            get { return _car.Name; }
        }

        public float Price
        {
            get { return _car.Price; }
        }
    }
}
