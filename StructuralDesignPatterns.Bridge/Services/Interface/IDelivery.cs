namespace StructuralDesignPatterns.Bridge.Services.Interface
{
    public interface IDelivery
    {
        void Send(string addres, string message, bool showMaxWeight);
    }
}
