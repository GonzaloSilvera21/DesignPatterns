namespace Prototype.Person
{
    public interface IPrototype<T>
    {
        T Clone();
    }
}
