namespace StructuralDesignPatterns.Composite.Domain.Interface
{
    public interface IObject
    {
        string Name { get; set; }
        int Nivel { get; set; }

        void Add(IObject obj);
    }
}
