namespace FactoryMethodPattern;

public class Tiger : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("Tiger says: Halum.");
    }

    public void Action()
    {
        Console.WriteLine("Tiger hunts.");
    }
}