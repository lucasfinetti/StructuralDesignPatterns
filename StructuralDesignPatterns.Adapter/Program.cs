using StructuralDesignPatterns.Adapter.Adapter;
using StructuralDesignPatterns.Adapter.Domain;
using System;

namespace StructuralDesignPatterns.Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var rectangleAdapter = new RectangleAdapter(new Rectangle());
            var lineAdapter = new LineAdapter(new Line());

            int x1 = 10, y1 = 20;
            int x2 = 30, y2 = 60;

            rectangleAdapter.draw(x1, y1, x2, y2);
            lineAdapter.draw(x1, y1, x2, y2);

            Console.ReadKey();
        }
    }
}
