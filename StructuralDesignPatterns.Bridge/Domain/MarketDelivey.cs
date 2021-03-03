using StructuralDesignPatterns.Bridge.Domain.Base;

namespace StructuralDesignPatterns.Bridge.Domain
{
    public sealed class MarketDelivey : DeliveryItemBase
    {
        public override void Send()
        {
            DeliverySender.Send(Address, ItemName, true);
        }
    }
}
