using StructuralDesignPatterns.Bridge.Domain.Base;

namespace StructuralDesignPatterns.Bridge.Domain
{
    public sealed class FoodDelivery : DeliveryItemBase
    {
        public override void Send()
        {
            DeliverySender.Send(Address, ItemName, false);
        }
    }
}
