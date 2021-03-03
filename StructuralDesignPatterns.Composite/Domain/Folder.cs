using StructuralDesignPatterns.Composite.Domain.Interface;
using System;
using System.Collections.Generic;

namespace StructuralDesignPatterns.Composite.Domain
{
    public class Folder : IObject
    {
        public string Name { get; set; }
        public int Nivel { get; set; }
        public List<IObject> Content { get; set; }

        public Folder(string name)
        {
            Name = name;
            Content = new List<IObject>();
        }

        public void Add(IObject obj)
        {
            obj.Nivel = this.Nivel + 3;
            Content.Add(obj);
        }

        public override string ToString()
        {
            var ret = $"{new String(' ', Nivel)}{Name}\n";

            foreach (var item in Content)
            {
                ret += item;
            }

            return ret;
        }
    }
}
