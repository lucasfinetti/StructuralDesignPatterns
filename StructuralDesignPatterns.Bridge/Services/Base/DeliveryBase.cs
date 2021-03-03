using StructuralDesignPatterns.Bridge.Services.Interface;
using System;

namespace StructuralDesignPatterns.Bridge.Services.Base
{
    public abstract class DeliveryBase : IDelivery
    {
        protected string Vehicle;

        protected int MaxWeight;

        protected DeliveryBase(string vehicle, int maxWeight)
        {
            Vehicle = vehicle;
            MaxWeight = maxWeight;
        }

        public void Send(string addres, string name, bool showMaxWeight)
        {
            var msg = $"Sending {name} to {addres} by {Vehicle}";

            if (showMaxWeight)
                msg += $" - Max weight: {MaxWeight} kilograms";

            Console.WriteLine(msg);
        }
    }
}
