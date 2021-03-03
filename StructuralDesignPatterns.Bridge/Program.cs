using StructuralDesignPatterns.Bridge.Domain;
using StructuralDesignPatterns.Bridge.Domain.Base;
using StructuralDesignPatterns.Bridge.Services;
using StructuralDesignPatterns.Bridge.Services.Interface;
using System;

namespace StructuralDesignPatterns.Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            IDelivery bike = new BikeDelivery();
            IDelivery car = new CarDelivery();
            IDelivery motocycle = new MotocycleDelivery();

            DeliveryItemBase food = new FoodDelivery();
            food.ItemName = "Japonese Food";
            food.Address = "SP, Brazil";

            food.DeliverySender = bike;
            food.Send();

            food.DeliverySender = car;
            food.Send();

            food.DeliverySender = motocycle;
            food.Send();

            DeliveryItemBase market = new MarketDelivey();
            market.ItemName = "Market Items";
            market.Address = "RJ, Brazil";

            market.DeliverySender = bike;
            market.Send();

            market.DeliverySender = car;
            market.Send();

            market.DeliverySender = motocycle;
            market.Send();

            Console.ReadKey();
        }
    }
}
