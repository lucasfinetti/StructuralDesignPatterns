using StructuralDesignPatterns.Bridge.Services.Base;

namespace StructuralDesignPatterns.Bridge.Services
{
    public class BikeDelivery : DeliveryBase
    {
        public BikeDelivery() : base("Bike", 10)
        {
                
        }
    }
}
