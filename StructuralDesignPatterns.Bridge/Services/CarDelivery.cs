using StructuralDesignPatterns.Bridge.Services.Base;

namespace StructuralDesignPatterns.Bridge.Services
{
    public class CarDelivery : DeliveryBase
    {
        public CarDelivery() : base("Car", 100)
        {

        }
    }
}