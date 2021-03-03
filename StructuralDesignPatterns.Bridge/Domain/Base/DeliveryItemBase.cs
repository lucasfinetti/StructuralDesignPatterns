using StructuralDesignPatterns.Bridge.Services.Interface;

namespace StructuralDesignPatterns.Bridge.Domain.Base
{
    public abstract class DeliveryItemBase
    {
        public IDelivery DeliverySender { get; set; }

        public string ItemName { get; set; }

        public string Address { get; set; }

        public abstract void Send();
    }
}
