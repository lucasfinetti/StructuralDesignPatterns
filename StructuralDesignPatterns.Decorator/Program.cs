using StructuralDesignPatterns.Decorator.Domain;
using StructuralDesignPatterns.Decorator.Domain.Decorator;
using System;

namespace StructuralDesignPatterns.Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var civic = new Civic();

            Console.WriteLine($"{civic.Name}, price: ${civic.Price}");

            var civiWithAirfoil = new AirfoilDecorator(civic);
            civiWithAirfoil.AirfoilName = "Airfoil Sport";
            civiWithAirfoil.AirfoilPrice = 1499.00f;

            var civiWithAirfoilAndInsufilm = new InsulfilmDecorator(civiWithAirfoil);
            civiWithAirfoilAndInsufilm.InsulfilmName = "G5";
            civiWithAirfoilAndInsufilm.InsulfilmPrice = 499.00f;

            Console.Write($"{civiWithAirfoilAndInsufilm.Name} with Airfoil ({civiWithAirfoil.AirfoilName}) " +
                $"and Insufilme ({civiWithAirfoilAndInsufilm.InsulfilmName}), price: ${ civiWithAirfoilAndInsufilm.Price}");

            Console.ReadKey();
        }
    }
}
