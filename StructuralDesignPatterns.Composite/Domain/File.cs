using StructuralDesignPatterns.Composite.Domain.Interface;
using System;

namespace StructuralDesignPatterns.Composite.Domain
{
    public class File : IObject
    {
        public string Name { get; set; }
        public int Nivel { get; set; }

        public File(string name)
        {
            Name = name;
        }

        public void Add(IObject obj)
        {
            Console.Write("Not allow");
        }

        public override string ToString()
        {
            return $"{new String(' ', Nivel)}{Name}\n";
        }
    }
}
