namespace Adapter;

internal class Program
{
    static void Main()
    {
        var wildDog = new WildDog();
        var wildDogAdapter = new WildDogAdapter(wildDog);

        var hunter = new Hunter();
        hunter.Hunt(wildDogAdapter);
    }
}